using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using MFORMATSLib;
using System.Diagnostics;

namespace SampleFileWriting
{
    public partial class Form1 : Form
    {
        private MFPreviewClass m_objPreview;
        private MFLiveClass m_objLive;
        private MFLiveClass m_audioLive;
        private MCCDisplayClass m_objCCDisplay;

        private Thread m_threadWorker;	//Working thread
        private Thread m_NDIcheckThread;
        private bool m_bWork;
        private MFWriterClass m_objWriter;
        private MFReaderClass m_objReader;
              
        private M_AV_PROPS m_avProps;

        private bool rec = false;
        public Form1()
        {
            InitializeComponent();
        }

        private CancellationTokenSource cancelSource;
        private void Form1_Load(object sender, EventArgs e)
        {
            m_objPreview = new MFPreviewClass();
            m_objWriter = new MFWriterClass();
            m_objReader = new MFReaderClass();

            try
            {
                m_objLive = new MFLiveClass();
                m_audioLive = new MFLiveClass();
                FillCombo(eMFDeviceType.eMFDT_Video,video, true);

            }
            catch (Exception ex)
            {
                MessageBox.Show("MLive device not found\n\n" + ex.ToString());
            }

            try
            {
                m_objCCDisplay = new MCCDisplayClass();
            }
            catch
            {
                MessageBox.Show("MCCDisplay module was not found.");
            }

            //Configure preview
            m_objPreview.PreviewWindowSet("", panelPreview.Handle.ToInt32());
            m_objPreview.PreviewEnable("", Convert.ToInt32(checkBoxAPrev.Checked), Convert.ToInt32(checkBoxVPrev.Checked));

            // Fill Senders
            FillSenders();

            FillVideoFormats();

            //Fill live devices
            FillMLiveDevices();

            //Fill formats
            FillMWriterFormats();

            // Create & config background worker

            cancelSource = new CancellationTokenSource();
            m_threadWorker = new Thread(() => thread_DoWork(cancelSource.Token));
            m_threadWorker.Name = "thread_DoWork";
            m_threadWorker.Start();

            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;   //Need for use renderersCombobox in multithreading 
        }

        private void FillSenders()
        {
            comboBoxExtSources.Items.Clear();

            comboBoxExtSources.Items.Add("<Live Source>");
            int nCount = 0;

            m_objReader.SendersGetCount(out nCount);
            for (int i = 0; i < nCount; i++)
            {
                string strName;
                M_VID_PROPS vidProps;
                M_AUD_PROPS audProps;
                m_objReader.SendersGetByIndex(i, out strName, out vidProps, out audProps);

                comboBoxExtSources.Items.Add(strName);
            }

            comboBoxExtSources.SelectedIndex = 0;
        }

        private void FillVideoFormats()
        {
            comboBoxVideoFormat.Items.Clear();

            comboBoxVideoFormat.Items.Add(eMVideoFormat.eMVF_Custom);

            comboBoxVideoFormat.Items.Add(eMVideoFormat.eMVF_NTSC);
            comboBoxVideoFormat.Items.Add(eMVideoFormat.eMVF_NTSC_2398);
            comboBoxVideoFormat.Items.Add(eMVideoFormat.eMVF_NTSC_16x9);
            comboBoxVideoFormat.Items.Add(eMVideoFormat.eMVF_PAL);
            comboBoxVideoFormat.Items.Add(eMVideoFormat.eMVF_PAL_16x9);

            comboBoxVideoFormat.Items.Add(eMVideoFormat.eMVF_HD720_50p);
            comboBoxVideoFormat.Items.Add(eMVideoFormat.eMVF_HD720_5994p);
            comboBoxVideoFormat.Items.Add(eMVideoFormat.eMVF_HD720_60p);

            comboBoxVideoFormat.Items.Add(eMVideoFormat.eMVF_HD1080_2398p);
            comboBoxVideoFormat.Items.Add(eMVideoFormat.eMVF_HD1080_24p);
            comboBoxVideoFormat.Items.Add(eMVideoFormat.eMVF_HD1080_25p);
            comboBoxVideoFormat.Items.Add(eMVideoFormat.eMVF_HD1080_2997p);
            comboBoxVideoFormat.Items.Add(eMVideoFormat.eMVF_HD1080_30p);

            comboBoxVideoFormat.Items.Add(eMVideoFormat.eMVF_HD1080_50i);
            comboBoxVideoFormat.Items.Add(eMVideoFormat.eMVF_HD1080_5994i);
            comboBoxVideoFormat.Items.Add(eMVideoFormat.eMVF_HD1080_60i);

            comboBoxVideoFormat.Items.Add(eMVideoFormat.eMVF_HD1080_50p);
            comboBoxVideoFormat.Items.Add(eMVideoFormat.eMVF_HD1080_5994p);
            comboBoxVideoFormat.Items.Add(eMVideoFormat.eMVF_HD1080_60p);

            comboBoxVideoFormat.Items.Add(eMVideoFormat.eMVF_2K_DCI_2398p);
            comboBoxVideoFormat.Items.Add(eMVideoFormat.eMVF_2K_DCI_24p);
            comboBoxVideoFormat.Items.Add(eMVideoFormat.eMVF_2K_DCI_25p);
            comboBoxVideoFormat.Items.Add(eMVideoFormat.eMVF_2K_DCI_50p);
            comboBoxVideoFormat.Items.Add(eMVideoFormat.eMVF_2K_DCI_5994p);
            comboBoxVideoFormat.Items.Add(eMVideoFormat.eMVF_2K_DCI_60p);

            comboBoxVideoFormat.Items.Add(eMVideoFormat.eMVF_2K_2398p);
            comboBoxVideoFormat.Items.Add(eMVideoFormat.eMVF_2K_24p);
            comboBoxVideoFormat.Items.Add(eMVideoFormat.eMVF_2K_25p);

            comboBoxVideoFormat.Items.Add(eMVideoFormat.eMVF_4K_DCI_2398p);
            comboBoxVideoFormat.Items.Add(eMVideoFormat.eMVF_4K_DCI_24p);
            comboBoxVideoFormat.Items.Add(eMVideoFormat.eMVF_4K_DCI_25p);

            comboBoxVideoFormat.Items.Add(eMVideoFormat.eMVF_4K_UHD_50i);
            comboBoxVideoFormat.Items.Add(eMVideoFormat.eMVF_4K_UHD_5994i);
            comboBoxVideoFormat.Items.Add(eMVideoFormat.eMVF_4K_UHD_60i);

            comboBoxVideoFormat.Items.Add(eMVideoFormat.eMVF_4K_UHD_50p);
            comboBoxVideoFormat.Items.Add(eMVideoFormat.eMVF_4K_UHD_5994p);
            comboBoxVideoFormat.Items.Add(eMVideoFormat.eMVF_4K_UHD_60p);
            comboBoxVideoFormat.SelectedIndex = 0;

            m_avProps = new M_AV_PROPS();
            m_avProps.vidProps.eVideoFormat = (eMVideoFormat)comboBoxVideoFormat.SelectedItem;
        }
        private void CopyAudio(MFFrame from , ref MFFrame to)
        {
            if (from != null)
            from.MFAudioCopyTo("ch1", to);
        }
        private void thread_DoWork(CancellationToken token)
        {
            while (!token.IsCancellationRequested)
            {
                if (m_bWork)
                {
                    MFFrame pFrame = null;
                    MFFrame pAudio = null;
                    try
                    {
                        if (comboBoxExtSources.SelectedIndex > 0)
                        {
                            m_objReader.SourceFrameConvertedGet(ref m_avProps, -1, out pFrame, "");
                        }
                        else
                        {
                            m_objLive.SourceFrameConvertedGet(ref m_avProps, -1, out pFrame, "");
                            m_audioLive.SourceFrameGet(-1, out pAudio, "");
                        }
                    }
                    catch
                    {
                    }

                    if (pFrame != null)
                    {
                        // Show CC
                        if (checkBoxCC.Checked)
                        {
                            if (m_objCCDisplay != null)
                                ShowPluggin(m_objCCDisplay, ref pFrame);
                        }
                        CopyAudio(pAudio, ref pFrame);
                        if (rec)
                        {
                            buttonStartRec.Enabled = false;
                            buttonStartRec.Text = "Recording";

                            try
                            {
                                // Encode frame
                                m_objWriter.ReceiverFramePut(pFrame, 0, "");

                                UpdateStatistic();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error capture " + ex.ToString());

                                rec = false;
                            }
                        }
                        else
                        {
                            buttonStartRec.Enabled = true;
                            buttonStartRec.Text = "Start record";
                            labelStatistic.BackColor = Color.FromArgb(222, 232, 254);
                        }

                        //Send frame to the preview
                        m_objPreview.ReceiverFramePut(pFrame, -1, "");

                        //Release frame - DO NOT FORGOT TO DO THIS !!!
                        Marshal.ReleaseComObject(pFrame);

                    }
                }
                else
                {
                    Thread.Sleep(1);
                }
            }
        }

        private void ShowPluggin(object _obj, ref MFFrame pFrame)
        {
            int nFramesRes;
            MFFrame pFrameOut = null;
            ((MFORMATSLib.IMFProcess)_obj).ProcessFrame(pFrame, out pFrameOut, out nFramesRes, "");
            if (pFrameOut != null)
            {
                releaseComObj(pFrame);
                pFrame = pFrameOut;
            }
        }

        private void releaseComObj(object comObj)
        {
            if (comObj != null)
                Marshal.ReleaseComObject(comObj);
        }

        private void UpdateStatistic()
        {
            labelStatistic.BackColor = Color.OrangeRed;

            string srtOrPath, opttionsList;
            string fIn, bIn, fDrops, buff;

            m_objWriter.WriterGet(out srtOrPath, out opttionsList);

            int propsCount;
            m_objWriter.PropsGetCount("stat", out propsCount);
            StringBuilder propsBuilder = new StringBuilder();
            for (int propsIndex = 0; propsIndex < propsCount; propsIndex++)
            {
                string propsName;
                string propsValue;
                int propsIsNode;
                m_objWriter.PropsGetByIndex("stat", propsIndex, out propsName, out propsValue, out propsIsNode);
                propsBuilder.AppendLine(propsName + " : " + propsValue);
            }

            string propsStatList = propsBuilder.ToString();
            m_objWriter.PropsGet("stat::frames_in", out fIn);
            m_objWriter.PropsGet("stat::breaks_in", out bIn);

            m_objWriter.PropsGet("stat::buffers_overflow", out fDrops);
            m_objWriter.PropsGet("stat::buffered", out buff);


            labelStatistic.Text = "Capturing file: " + srtOrPath + "\n\n" +
                                   "Frames In: " + fIn + "; " +
                                   "Break In: " + bIn + "; " +
                                   "Frame drops: " + fDrops + ";\n" +
                                   "Buffer: " + buff;

            checkWriter();
        }

        private void FillCombo(eMFDeviceType strType, ComboBox cbxType, bool test = false)
        {
            if (test)   
            {
              MFLiveClass  m_objLive = m_audioLive;
            }

            cbxType.Items.Clear();
            int nCount = 0;
            //Get device count / input line count
            m_objLive.DeviceGetCount(strType, out nCount);
            cbxType.Enabled = nCount > 0;
            if (nCount > 0)
            {
                for (int i = 0; i < nCount; i++)
                {
                    string strName;
                    int pbBusy;
                    //Get deveice / input line
                    m_objLive.DeviceGetByIndex(strType, i, out strName, out pbBusy);
                    cbxType.Items.Add(strName);
                }
                string name = "";
                int nIndex = 0;
                try
                {
                    //Check if there is already selected device / input line
                    m_objLive.DeviceGet(strType, out nIndex, out name);
                    cbxType.SelectedIndex = nIndex >= 0 && nIndex < cbxType.Items.Count - 1 ? nIndex : 0;
                }
                catch
                {
                    if (strType == eMFDeviceType.eMFDT_Audio)
                    {
                        cbxType.SelectedIndex = cbxType.Items.Count > 1 ? cbxType.Items.Count - 2 : 0;
                    }
                    else
                    {
                        cbxType.SelectedIndex = 0;
                    }
                }
            }
        }

        private void FillMWriterFormats()
        {
            conboBoxFormat.Items.Clear();

            int nCount;
            m_objWriter.WriterOptionGetCount(eMFWriterOption.eMFWO_Format, out nCount);

            for (int i = 0; i < nCount; i++)
            {
                string myName, longName;
                m_objWriter.WriterOptionGetByIndex(eMFWriterOption.eMFWO_Format, i, out myName, out longName);
                conboBoxFormat.Items.Add(longName);
            }
            conboBoxFormat.SelectedIndex = 0;
        }

        private void FillMLiveDevices()
        {
            comboBoxV.Items.Clear();
            //Feel video devices
            int vCount;
            try
            {
                m_objLive.DeviceGetCount(eMFDeviceType.eMFDT_Video, out vCount);

                if (vCount > 0)
                {
                    for (int i = 0; i < vCount; i++)
                    {
                        string strName;
                        int _pbBusy;
                        m_objLive.DeviceGetByIndex(eMFDeviceType.eMFDT_Video, i, out strName, out _pbBusy);
                        comboBoxV.Items.Add(strName);
                    }
                    comboBoxV.SelectedIndex = comboBoxV.Items.Count - 1;
                }

                buttonInit.Enabled = true;
                buttonCloseDev.Enabled = true;
                FillCombo(eMFDeviceType.eMFDT_Audio, comboBoxAudio);
                FillCombo(eMFDeviceType.eMFDT_ExtAudio, comboBoxAudioEx);
               
            }
            catch { }
        }

        private void comboBoxV_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {                
                comboBoxVF.Items.Clear();
                comboBoxVideoLine.Items.Clear();

                M_VID_PROPS vidProps;

                m_objLive.DeviceSet(eMFDeviceType.eMFDT_Video, comboBoxV.SelectedIndex, "");

                RefreshProps();

                buttonInit.Enabled = true;
                buttonCloseDev.Enabled = true;

                int nCount;
                string strName;

                // Fill video formats
                m_objLive.FormatVideoGetCount(eMFormatType.eMFT_Input, out nCount);
                if (nCount > 0)
                {
                    for (int i = 0; i < nCount; i++)
                    {
                        m_objLive.FormatVideoGetByIndex(eMFormatType.eMFT_Input, i, out vidProps, out strName);
                        comboBoxVF.Items.Add(strName);
                    }

                    // Get current format
                    int nCurrent = 0;
                    try
                    {
                        string strName_;
                        M_VID_PROPS _vidProps;
                        m_objLive.FormatVideoGet(eMFormatType.eMFT_Input, out _vidProps, out nCurrent, out strName_);
                    }
                    catch (System.Exception)
                    {
                    }

                    // Select current
                    comboBoxVF.SelectedIndex = nCurrent >= 0 ? nCurrent : 0;
                }

                // Fill audio formats
                comboBoxAF.Items.Clear();
                nCount = 0;
                m_objLive.FormatAudioGetCount(eMFormatType.eMFT_Input, out nCount);
                if (nCount > 0)
                {
                    M_AUD_PROPS audProps;
                    for (int i = 0; i < nCount; i++)
                    {
                        m_objLive.FormatAudioGetByIndex(eMFormatType.eMFT_Input, i, out audProps, out strName);
                        comboBoxAF.Items.Add(strName);
                    }

                    // Get current format
                    int nCurrent = 0;
                    try
                    {
                        string strName_;
                        M_AUD_PROPS _audProps;
                        m_objLive.FormatAudioGet(eMFormatType.eMFT_Input, out _audProps, out nCurrent, out strName_);
                    }
                    catch (System.Exception)
                    {
                    }

                    // Select current
                    comboBoxAF.SelectedIndex = nCurrent >= 0 ? nCurrent : 0;
                }


                CheckLineIn();

                FillCombo(eMFDeviceType.eMFDT_Audio, comboBoxAudio);
                FillCombo(eMFDeviceType.eMFDT_ExtAudio, comboBoxAudioEx);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        void CheckLineIn()
        {
            comboBoxVideoLine.Items.Clear();
            string strCurrent;
            string strOptions;
            string strHelp;
            int nSel = -1;
            int nCount;
            m_objLive.PropsGet("line-in", out strCurrent);

            m_objLive.PropsOptionGetCount("line-in", out nCount);
            if (nCount > 0)
            {
                for (int i = 0; i < nCount; i++)
                {
                    m_objLive.PropsOptionGetByIndex("line-in", i, out strOptions, out strHelp);
                    comboBoxVideoLine.Items.Add(strHelp);

                    if (strCurrent == strOptions)
                        nSel = i;
                }

                if (nSel >= 0)
                    comboBoxVideoLine.SelectedIndex = nSel;
                else
                    comboBoxVideoLine.SelectedIndex = 0;
            }
        }

        private void RefreshProps()
        {
            livePropsList.SetControlledObject(m_objLive as IMFProps);
        }

        private void comboBoxVL_SelectedIndexChanged(object sender, EventArgs e)
        {
            //m_objLive.PropsOptionSetByIndex("line-in", comboBoxVL.SelectedIndex);
        }

        private void comboBoxVF_SelectedIndexChanged(object sender, EventArgs e)
        {
            M_VID_PROPS vidProps;
            string strName;
            m_objLive.FormatVideoGetByIndex(eMFormatType.eMFT_Input, comboBoxVF.SelectedIndex, out vidProps, out strName);
            m_objLive.FormatVideoSet(eMFormatType.eMFT_Input, vidProps);
        }
        private void comboBoxAF_SelectedIndexChanged(object sender, EventArgs e)
        {
            M_AUD_PROPS audProps;
            string strName;
            m_objLive.FormatAudioGetByIndex(eMFormatType.eMFT_Input, comboBoxAF.SelectedIndex, out audProps, out strName);
            m_objLive.FormatAudioSet(eMFormatType.eMFT_Input, audProps);
        }

        private void btnInit_Click(object sender, EventArgs e)
        {
            try
            {
                m_objLive.DeviceSet(eMFDeviceType.eMFDT_Video, comboBoxV.SelectedIndex, "");

                try
                {
                    if (comboBoxAudio.Items.Count > 0)
                        m_objLive.DeviceSet(eMFDeviceType.eMFDT_ExtAudio, comboBoxAudioEx.SelectedIndex, "");
                }
                catch { }

                if (comboBoxVF.SelectedIndex >= 0)
                {
                    M_VID_PROPS vidProps;
                    string strName;

                    m_objLive.FormatVideoGetByIndex(eMFormatType.eMFT_Input, comboBoxVF.SelectedIndex, out vidProps, out strName);
                    m_objLive.FormatVideoSet(eMFormatType.eMFT_Input, vidProps);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not start a device.\n\n" + ex);
            }

            // Start worker if not started yet
            m_bWork = true;
        }

        private void buttonCloseDev_Click(object sender, EventArgs e)
        {
            // Clode MLive device
            m_bWork = false;
            m_objLive.DeviceClose();
        }

        private void buttonStartRec_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            try
            {
                string strFormat;
                IMFProps props;
                m_objWriter.WriterOptionGet(eMFWriterOption.eMFWO_Format, out strFormat, out props);

                string sProtocol;
                props.PropsGet("protocol", out sProtocol);
                if (sProtocol == null)
                    sProtocol = "";
                string bNetwork = "";
                props.PropsGet("network", out bNetwork);

                if ((bNetwork == "true" || sProtocol.Contains("udp") || sProtocol.Contains("rtmp") || sProtocol.Contains("rtsp")) && textBoxURL.Text.Length > 0)
                {
                    try
                    {
                        m_objWriter.WriterSet(textBoxURL.Text, 0, textBoxConfig.Text);
                        rec = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                else if (strFormat == "Auto Select")
                {
                    sfd.Filter = "MPEG files (*.mp4)|*.mp4|All Files (*.*)|*.*";

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        m_objWriter.WriterSet(sfd.FileName, 0, " format='mp4' video::codec='mpeg4' video::b='5M' audio::codec='aac'");
                        rec = true;
                    }
                }
                else
                {
                    //Choose file extension
                    string strExtensions;
                    props.PropsGet("extensions", out strExtensions);
                    Marshal.ReleaseComObject(props);

                    string[] arrExt = strExtensions.Split(',');
                    string strFilterExt = ""; // (*.yyy;*.xxx)
                    for (int i = 0; i < arrExt.Length; i++)
                    {
                        if (strFilterExt.Length > 0)
                            strFilterExt += ";*." + arrExt[i];
                        else
                            strFilterExt = "*." + arrExt[i];
                    }

                    sfd.Filter = strFormat + " Files (" + strFilterExt + ")|" + strFilterExt + "|All Files (*.*)|*.*";

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        m_objWriter.WriterSet(sfd.FileName, 0, textBoxConfig.Text);
                        rec = true;
                    }
                }
            }
            catch (Exception)
            { }
        }

        private void buttonStopRec_Click(object sender, EventArgs e)
        {
            rec = false;
            m_objWriter.WriterClose(1);
        }

        private void formatcombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            IMFProps props;
            m_objWriter.WriterOptionSetByIndex(eMFWriterOption.eMFWO_Format, conboBoxFormat.SelectedIndex, out props);

            string bNetwork = "";
            props.PropsGet("network", out bNetwork);
            Marshal.ReleaseComObject(props);

            if (bNetwork == "true")
                textBoxURL.Enabled = true;
            else
                textBoxURL.Enabled = false;

            string tPath, options;
            m_objWriter.WriterGet(out tPath, out options);
            textBoxConfig.Text = options;

            int nCount;
            m_objWriter.WriterOptionGetCount(eMFWriterOption.eMFWO_VideoCodec, out nCount);
            ConboBoxVideoCodec.Items.Clear();
            for (int i = 0; i < nCount; i++)
            {
                string myName, longName;
                m_objWriter.WriterOptionGetByIndex(eMFWriterOption.eMFWO_VideoCodec, i, out myName, out longName);

                ConboBoxVideoCodec.Items.Add(longName);
            }
            ConboBoxVideoCodec.SelectedIndex = 0;

            m_objWriter.WriterOptionGetCount(eMFWriterOption.eMFWO_AudioCodec, out nCount);
            comboBocAudioCodec.Items.Clear();
            for (int i = 0; i < nCount; i++)
            {
                string myName, longName;
                m_objWriter.WriterOptionGetByIndex(eMFWriterOption.eMFWO_AudioCodec, i, out myName, out longName);

                comboBocAudioCodec.Items.Add(longName);
            }
            comboBocAudioCodec.SelectedIndex = 0;
        }

        private void videocodec_SelectedIndexChanged(object sender, EventArgs e)
        {
            IMFProps props;
            m_objWriter.WriterOptionSetByIndex(eMFWriterOption.eMFWO_VideoCodec, ConboBoxVideoCodec.SelectedIndex, out props);
            Marshal.ReleaseComObject(props);

            string tPath, options;
            m_objWriter.WriterGet(out tPath, out options);
            textBoxConfig.Text = options;
        }

        private void audiocodec_SelectedIndexChanged(object sender, EventArgs e)
        {
            IMFProps props;
            m_objWriter.WriterOptionSetByIndex(eMFWriterOption.eMFWO_AudioCodec, comboBocAudioCodec.SelectedIndex, out props);
            Marshal.ReleaseComObject(props);

            string tPath, options;
            m_objWriter.WriterGet(out tPath, out options);
            textBoxConfig.Text = options;
        }

        private void comboBoxAudio_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                m_objLive.DeviceSet(eMFDeviceType.eMFDT_Audio, comboBoxAudio.SelectedIndex, "");
            }
            catch { }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            m_bWork = false;
            cancelSource.Cancel();
            m_threadWorker.Join(1000);

            if (m_objLive != null)
                m_objLive.DeviceClose();
            if (m_objWriter != null)
                m_objWriter.WriterClose(1);
        }

        private void checkBoxAPrev_CheckedChanged(object sender, EventArgs e)
        {
            if (m_objPreview != null)
                m_objPreview.PreviewEnable("", Convert.ToInt32(checkBoxAPrev.Checked), Convert.ToInt32(checkBoxVPrev.Checked));
        }

        private void checkBoxVPrev_CheckedChanged(object sender, EventArgs e)
        {
            if (m_objPreview != null)
                m_objPreview.PreviewEnable("", Convert.ToInt32(checkBoxAPrev.Checked), Convert.ToInt32(checkBoxVPrev.Checked));
        }

        private void panelPreview_SizeChanged(object sender, EventArgs e)
        {
            if (m_objPreview != null)
                m_objPreview.PreviewWindowSet("", panelPreview.Handle.ToInt32());
        }

        private void ShowWriterProperties(eMFWriterOption optionType)
        {
            IMFProps props;
            string writerName;
            m_objWriter.WriterOptionGet(optionType, out writerName, out props);
            FormAttributes attributes = new FormAttributes();
            attributes.Owner = this;
            attributes.Text = writerName;
            attributes.WriterProps = props;
            attributes.ShowDialog();
            string tPath, options;
            m_objWriter.WriterGet(out tPath, out options);
            textBoxConfig.Text = options;
        }

        private void FormatPropsButton_Click(object sender, EventArgs e)
        {
            ShowWriterProperties(eMFWriterOption.eMFWO_Format);
        }

        private void VideoCodecButton_Click(object sender, EventArgs e)
        {
            ShowWriterProperties(eMFWriterOption.eMFWO_VideoCodec);
        }

        private void AudioCodecButton_Click(object sender, EventArgs e)
        {
            ShowWriterProperties(eMFWriterOption.eMFWO_AudioCodec);
        }

        private void comboBoxAudioEx_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                m_objLive.DeviceSet(eMFDeviceType.eMFDT_ExtAudio, comboBoxAudioEx.SelectedIndex, "");
            }
            catch { }
        }

        private void comboBoxVideoLine_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_objLive.PropsOptionSetByIndex("line-in", comboBoxVideoLine.SelectedIndex);
        }

        private void buttonUpdateLineIn_Click(object sender, EventArgs e)
        {
            CheckLineIn();
        }

        private void comboBoxVideoFormat_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_avProps.vidProps.eVideoFormat = (eMVideoFormat)comboBoxVideoFormat.SelectedItem;
        }

        private void comboBoxExtSources_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxExtSources.SelectedIndex > 0)
            {
                comboBoxV.Enabled = false;
                comboBoxVideoLine.Enabled = false;
                comboBoxVF.Enabled = false;
                comboBoxAudio.Enabled = false;
                comboBoxAudioEx.Enabled = false;
                buttonUpdateLineIn.Enabled = false;
                buttonInit.Enabled = false;
                buttonCloseDev.Enabled = false;
                livePropsList.Enabled = false;

                try
                {
                    m_objReader.ReaderOpen("mp://" + comboBoxExtSources.SelectedItem, "");
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Failed load a source.\n\n" + ex);
                    return;
                }
                                
                m_bWork = true;
            }
            else
            {
                m_bWork = false;
                m_objReader.ReaderClose();

                comboBoxV.Enabled = true;
                comboBoxVideoLine.Enabled = true;
                comboBoxVF.Enabled = true;
                comboBoxAudio.Enabled = true;
                comboBoxAudioEx.Enabled = true;
                buttonUpdateLineIn.Enabled = true;
                buttonInit.Enabled = true;
                buttonCloseDev.Enabled = true;
                livePropsList.Enabled = true;
            }
        }

        private void buttonRefreshSink_Click(object sender, EventArgs e)
        {
            FillSenders();
        }

        private void checkWriter()
        {
            if (m_objWriter != null)
            {
                string pid;
                m_objWriter.PropsGet("mserver_pid", out pid);
                if (pid!=null)
                label15.Text = getProcessRAMUsage(Int32.Parse(pid));
            }

        }
        private string getProcessRAMUsage(int pid)
        {
            Process toMonitor = Process.GetProcessById(pid);
            long memoryUsed = toMonitor.WorkingSet64 / 1024;
            return String.Format("MServer.exe RAM: {0} Kb", memoryUsed);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (m_objLive != null)
            {
                //setting the audio channels 
                m_audioLive.PropsSet("audio_channels", "0+2+4+6+8+10,1+3+5+7+9+11,0,1,2,3,4,5,6,7,8,9,10,11");

                if (m_objWriter == null)
                    m_objWriter = new MFWriterClass();

                SaveFileDialog save = new SaveFileDialog();
                save.ShowDialog();
                string file_path = save.FileName;
                m_objWriter.WriterSet(file_path, 1, "format='mp4' split_channels='2' video::codec='mpeg4' video::b='2500K' audio::codec='aac' audio::b='128K' metadata::comment = 'StereoChannels'");
                m_bWork = true;
                rec = true;

            } else
            {
                MessageBox.Show("Please init Live with audio only device");
            }
        }

        private void testAudio_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int device_count;
                m_audioLive.DeviceSet(eMFDeviceType.eMFDT_ExtAudio, testAudio.SelectedIndex, "");
                
            }
            catch { }
        }

        private void video_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_audioLive.DeviceSet(eMFDeviceType.eMFDT_Video, video.SelectedIndex, "");
            FillCombo(eMFDeviceType.eMFDT_Audio, audio, true);
            FillCombo(eMFDeviceType.eMFDT_ExtAudio, testAudio, true);
        }

        private void audio_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_audioLive.DeviceSet(eMFDeviceType.eMFDT_Audio, audio.SelectedIndex, "");
        }
    }
}