namespace SampleFileWriting
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonCloseDev = new System.Windows.Forms.Button();
            this.panelPreview = new System.Windows.Forms.Panel();
            this.buttonInit = new System.Windows.Forms.Button();
            this.comboBoxVF = new System.Windows.Forms.ComboBox();
            this.comboBoxV = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonStartRec = new System.Windows.Forms.Button();
            this.buttonStopRec = new System.Windows.Forms.Button();
            this.textBoxConfig = new System.Windows.Forms.TextBox();
            this.conboBoxFormat = new System.Windows.Forms.ComboBox();
            this.ConboBoxVideoCodec = new System.Windows.Forms.ComboBox();
            this.comboBocAudioCodec = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonUpdateLineIn = new System.Windows.Forms.Button();
            this.comboBoxVideoLine = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxAudioEx = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxAudio = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxAF = new System.Windows.Forms.ComboBox();
            this.buttonRefreshSink = new System.Windows.Forms.Button();
            this.comboBoxExtSources = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.checkBoxCC = new System.Windows.Forms.CheckBox();
            this.comboBoxVideoFormat = new System.Windows.Forms.ComboBox();
            this.AudioCodecButton = new System.Windows.Forms.Button();
            this.VideoCodecButton = new System.Windows.Forms.Button();
            this.FormatPropsButton = new System.Windows.Forms.Button();
            this.textBoxURL = new System.Windows.Forms.TextBox();
            this.checkBoxVPrev = new System.Windows.Forms.CheckBox();
            this.checkBoxAPrev = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelStatistic = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBoxAudioEx2 = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.livePropsList = new SampleFileWriting.MFAttributesList();
            this.audio_channels = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCloseDev
            // 
            this.buttonCloseDev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCloseDev.Enabled = false;
            this.buttonCloseDev.Location = new System.Drawing.Point(212, 483);
            this.buttonCloseDev.Name = "buttonCloseDev";
            this.buttonCloseDev.Size = new System.Drawing.Size(110, 32);
            this.buttonCloseDev.TabIndex = 188;
            this.buttonCloseDev.Text = "Close Device";
            this.buttonCloseDev.UseVisualStyleBackColor = true;
            this.buttonCloseDev.Click += new System.EventHandler(this.buttonCloseDev_Click);
            // 
            // panelPreview
            // 
            this.panelPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPreview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(88)))), ((int)(((byte)(143)))));
            this.panelPreview.Location = new System.Drawing.Point(361, 100);
            this.panelPreview.Name = "panelPreview";
            this.panelPreview.Size = new System.Drawing.Size(530, 268);
            this.panelPreview.TabIndex = 189;
            this.panelPreview.SizeChanged += new System.EventHandler(this.panelPreview_SizeChanged);
            // 
            // buttonInit
            // 
            this.buttonInit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonInit.Enabled = false;
            this.buttonInit.Location = new System.Drawing.Point(52, 483);
            this.buttonInit.Name = "buttonInit";
            this.buttonInit.Size = new System.Drawing.Size(115, 32);
            this.buttonInit.TabIndex = 187;
            this.buttonInit.Text = "Init Device";
            this.buttonInit.UseVisualStyleBackColor = true;
            this.buttonInit.Click += new System.EventHandler(this.btnInit_Click);
            // 
            // comboBoxVF
            // 
            this.comboBoxVF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxVF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVF.FormattingEnabled = true;
            this.comboBoxVF.Location = new System.Drawing.Point(78, 257);
            this.comboBoxVF.Name = "comboBoxVF";
            this.comboBoxVF.Size = new System.Drawing.Size(244, 21);
            this.comboBoxVF.TabIndex = 186;
            this.comboBoxVF.SelectedIndexChanged += new System.EventHandler(this.comboBoxVF_SelectedIndexChanged);
            // 
            // comboBoxV
            // 
            this.comboBoxV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxV.FormattingEnabled = true;
            this.comboBoxV.Location = new System.Drawing.Point(78, 23);
            this.comboBoxV.Name = "comboBoxV";
            this.comboBoxV.Size = new System.Drawing.Size(244, 21);
            this.comboBoxV.TabIndex = 184;
            this.comboBoxV.SelectedIndexChanged += new System.EventHandler(this.comboBoxV_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 181;
            this.label4.Text = "Video:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 183;
            this.label6.Text = "Format:";
            // 
            // buttonStartRec
            // 
            this.buttonStartRec.Location = new System.Drawing.Point(10, 177);
            this.buttonStartRec.Name = "buttonStartRec";
            this.buttonStartRec.Size = new System.Drawing.Size(75, 23);
            this.buttonStartRec.TabIndex = 190;
            this.buttonStartRec.Text = "Start record";
            this.buttonStartRec.UseVisualStyleBackColor = true;
            this.buttonStartRec.Click += new System.EventHandler(this.buttonStartRec_Click);
            // 
            // buttonStopRec
            // 
            this.buttonStopRec.Location = new System.Drawing.Point(91, 177);
            this.buttonStopRec.Name = "buttonStopRec";
            this.buttonStopRec.Size = new System.Drawing.Size(75, 23);
            this.buttonStopRec.TabIndex = 191;
            this.buttonStopRec.Text = "Stop record";
            this.buttonStopRec.UseVisualStyleBackColor = true;
            this.buttonStopRec.Click += new System.EventHandler(this.buttonStopRec_Click);
            // 
            // textBoxConfig
            // 
            this.textBoxConfig.Location = new System.Drawing.Point(9, 125);
            this.textBoxConfig.Name = "textBoxConfig";
            this.textBoxConfig.Size = new System.Drawing.Size(330, 20);
            this.textBoxConfig.TabIndex = 192;
            // 
            // conboBoxFormat
            // 
            this.conboBoxFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.conboBoxFormat.DropDownWidth = 200;
            this.conboBoxFormat.FormattingEnabled = true;
            this.conboBoxFormat.Location = new System.Drawing.Point(78, 42);
            this.conboBoxFormat.Name = "conboBoxFormat";
            this.conboBoxFormat.Size = new System.Drawing.Size(175, 21);
            this.conboBoxFormat.TabIndex = 193;
            this.conboBoxFormat.SelectedIndexChanged += new System.EventHandler(this.formatcombo_SelectedIndexChanged);
            // 
            // ConboBoxVideoCodec
            // 
            this.ConboBoxVideoCodec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ConboBoxVideoCodec.DropDownWidth = 200;
            this.ConboBoxVideoCodec.FormattingEnabled = true;
            this.ConboBoxVideoCodec.Location = new System.Drawing.Point(78, 69);
            this.ConboBoxVideoCodec.Name = "ConboBoxVideoCodec";
            this.ConboBoxVideoCodec.Size = new System.Drawing.Size(175, 21);
            this.ConboBoxVideoCodec.TabIndex = 194;
            this.ConboBoxVideoCodec.SelectedIndexChanged += new System.EventHandler(this.videocodec_SelectedIndexChanged);
            // 
            // comboBocAudioCodec
            // 
            this.comboBocAudioCodec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBocAudioCodec.DropDownWidth = 200;
            this.comboBocAudioCodec.FormattingEnabled = true;
            this.comboBocAudioCodec.Location = new System.Drawing.Point(78, 97);
            this.comboBocAudioCodec.Name = "comboBocAudioCodec";
            this.comboBocAudioCodec.Size = new System.Drawing.Size(175, 21);
            this.comboBocAudioCodec.TabIndex = 195;
            this.comboBocAudioCodec.SelectedIndexChanged += new System.EventHandler(this.audiocodec_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 100);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 13);
            this.label11.TabIndex = 198;
            this.label11.Text = "Audio codec";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 13);
            this.label10.TabIndex = 197;
            this.label10.Text = "Video codec";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 196;
            this.label9.Text = "Format";
            // 
            // pictureLogo
            // 
            this.pictureLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureLogo.Image")));
            this.pictureLogo.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureLogo.InitialImage")));
            this.pictureLogo.Location = new System.Drawing.Point(22, 11);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(193, 50);
            this.pictureLogo.TabIndex = 199;
            this.pictureLogo.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(232)))), ((int)(((byte)(254)))));
            this.panel1.Controls.Add(this.comboBoxAudioEx2);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.buttonUpdateLineIn);
            this.panel1.Controls.Add(this.comboBoxVideoLine);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.comboBoxAudioEx);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.livePropsList);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.buttonCloseDev);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.comboBoxAudio);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.buttonInit);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.comboBoxV);
            this.panel1.Controls.Add(this.comboBoxAF);
            this.panel1.Controls.Add(this.comboBoxVF);
            this.panel1.Location = new System.Drawing.Point(12, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(343, 521);
            this.panel1.TabIndex = 200;
            // 
            // buttonUpdateLineIn
            // 
            this.buttonUpdateLineIn.Location = new System.Drawing.Point(298, 49);
            this.buttonUpdateLineIn.Name = "buttonUpdateLineIn";
            this.buttonUpdateLineIn.Size = new System.Drawing.Size(24, 23);
            this.buttonUpdateLineIn.TabIndex = 204;
            this.buttonUpdateLineIn.Text = "R";
            this.buttonUpdateLineIn.UseVisualStyleBackColor = true;
            this.buttonUpdateLineIn.Click += new System.EventHandler(this.buttonUpdateLineIn_Click);
            // 
            // comboBoxVideoLine
            // 
            this.comboBoxVideoLine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVideoLine.FormattingEnabled = true;
            this.comboBoxVideoLine.Location = new System.Drawing.Point(78, 50);
            this.comboBoxVideoLine.Name = "comboBoxVideoLine";
            this.comboBoxVideoLine.Size = new System.Drawing.Size(214, 21);
            this.comboBoxVideoLine.TabIndex = 203;
            this.comboBoxVideoLine.SelectedIndexChanged += new System.EventHandler(this.comboBoxVideoLine_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 202;
            this.label7.Text = "Line:";
            // 
            // comboBoxAudioEx
            // 
            this.comboBoxAudioEx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxAudioEx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAudioEx.FormattingEnabled = true;
            this.comboBoxAudioEx.Location = new System.Drawing.Point(79, 346);
            this.comboBoxAudioEx.Name = "comboBoxAudioEx";
            this.comboBoxAudioEx.Size = new System.Drawing.Size(244, 21);
            this.comboBoxAudioEx.TabIndex = 201;
            this.comboBoxAudioEx.SelectedIndexChanged += new System.EventHandler(this.comboBoxAudioEx_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 350);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 200;
            this.label5.Text = "External 1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 198;
            this.label3.Text = "Video device:";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 292);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 198;
            this.label8.Text = "Audio device";
            // 
            // comboBoxAudio
            // 
            this.comboBoxAudio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxAudio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAudio.FormattingEnabled = true;
            this.comboBoxAudio.Location = new System.Drawing.Point(79, 312);
            this.comboBoxAudio.Name = "comboBoxAudio";
            this.comboBoxAudio.Size = new System.Drawing.Size(244, 21);
            this.comboBoxAudio.TabIndex = 195;
            this.comboBoxAudio.SelectedIndexChanged += new System.EventHandler(this.comboBoxAudio_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(17, 418);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 13);
            this.label14.TabIndex = 183;
            this.label14.Text = "Format:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 194;
            this.label2.Text = "Internal:";
            // 
            // comboBoxAF
            // 
            this.comboBoxAF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxAF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAF.FormattingEnabled = true;
            this.comboBoxAF.Location = new System.Drawing.Point(78, 415);
            this.comboBoxAF.Name = "comboBoxAF";
            this.comboBoxAF.Size = new System.Drawing.Size(244, 21);
            this.comboBoxAF.TabIndex = 186;
            this.comboBoxAF.SelectedIndexChanged += new System.EventHandler(this.comboBoxAF_SelectedIndexChanged);
            // 
            // buttonRefreshSink
            // 
            this.buttonRefreshSink.Location = new System.Drawing.Point(298, 4);
            this.buttonRefreshSink.Name = "buttonRefreshSink";
            this.buttonRefreshSink.Size = new System.Drawing.Size(24, 23);
            this.buttonRefreshSink.TabIndex = 207;
            this.buttonRefreshSink.Text = "R";
            this.buttonRefreshSink.UseVisualStyleBackColor = true;
            this.buttonRefreshSink.Click += new System.EventHandler(this.buttonRefreshSink_Click);
            // 
            // comboBoxExtSources
            // 
            this.comboBoxExtSources.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxExtSources.FormattingEnabled = true;
            this.comboBoxExtSources.Location = new System.Drawing.Point(78, 5);
            this.comboBoxExtSources.Name = "comboBoxExtSources";
            this.comboBoxExtSources.Size = new System.Drawing.Size(214, 21);
            this.comboBoxExtSources.TabIndex = 206;
            this.comboBoxExtSources.SelectedIndexChanged += new System.EventHandler(this.comboBoxExtSources_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(17, 8);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 13);
            this.label13.TabIndex = 205;
            this.label13.Text = "Ext Source:";
            // 
            // labelInfo
            // 
            this.labelInfo.Location = new System.Drawing.Point(221, 9);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(504, 52);
            this.labelInfo.TabIndex = 201;
            this.labelInfo.Text = "Sample File Writing demonstrates capturing to a file from the video/audio devices" +
    ".";
            this.labelInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(232)))), ((int)(((byte)(254)))));
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.checkBoxCC);
            this.panel2.Controls.Add(this.comboBoxVideoFormat);
            this.panel2.Controls.Add(this.AudioCodecButton);
            this.panel2.Controls.Add(this.VideoCodecButton);
            this.panel2.Controls.Add(this.FormatPropsButton);
            this.panel2.Controls.Add(this.textBoxURL);
            this.panel2.Controls.Add(this.checkBoxVPrev);
            this.panel2.Controls.Add(this.checkBoxAPrev);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.conboBoxFormat);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.comboBocAudioCodec);
            this.panel2.Controls.Add(this.buttonStopRec);
            this.panel2.Controls.Add(this.textBoxConfig);
            this.panel2.Controls.Add(this.buttonStartRec);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.ConboBoxVideoCodec);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Location = new System.Drawing.Point(364, 377);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(527, 209);
            this.panel2.TabIndex = 202;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 13);
            this.label12.TabIndex = 207;
            this.label12.Text = "Video format:";
            // 
            // checkBoxCC
            // 
            this.checkBoxCC.AutoSize = true;
            this.checkBoxCC.Location = new System.Drawing.Point(179, 181);
            this.checkBoxCC.Name = "checkBoxCC";
            this.checkBoxCC.Size = new System.Drawing.Size(40, 17);
            this.checkBoxCC.TabIndex = 208;
            this.checkBoxCC.Text = "CC";
            this.checkBoxCC.UseVisualStyleBackColor = true;
            // 
            // comboBoxVideoFormat
            // 
            this.comboBoxVideoFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVideoFormat.FormattingEnabled = true;
            this.comboBoxVideoFormat.Location = new System.Drawing.Point(78, 12);
            this.comboBoxVideoFormat.Name = "comboBoxVideoFormat";
            this.comboBoxVideoFormat.Size = new System.Drawing.Size(175, 21);
            this.comboBoxVideoFormat.TabIndex = 206;
            this.comboBoxVideoFormat.SelectedIndexChanged += new System.EventHandler(this.comboBoxVideoFormat_SelectedIndexChanged);
            // 
            // AudioCodecButton
            // 
            this.AudioCodecButton.Location = new System.Drawing.Point(256, 96);
            this.AudioCodecButton.Margin = new System.Windows.Forms.Padding(2);
            this.AudioCodecButton.Name = "AudioCodecButton";
            this.AudioCodecButton.Size = new System.Drawing.Size(81, 22);
            this.AudioCodecButton.TabIndex = 207;
            this.AudioCodecButton.Text = "Show Props";
            this.AudioCodecButton.UseVisualStyleBackColor = true;
            this.AudioCodecButton.Click += new System.EventHandler(this.AudioCodecButton_Click);
            // 
            // VideoCodecButton
            // 
            this.VideoCodecButton.Location = new System.Drawing.Point(256, 69);
            this.VideoCodecButton.Margin = new System.Windows.Forms.Padding(2);
            this.VideoCodecButton.Name = "VideoCodecButton";
            this.VideoCodecButton.Size = new System.Drawing.Size(81, 21);
            this.VideoCodecButton.TabIndex = 206;
            this.VideoCodecButton.Text = "Show Props";
            this.VideoCodecButton.UseVisualStyleBackColor = true;
            this.VideoCodecButton.Click += new System.EventHandler(this.VideoCodecButton_Click);
            // 
            // FormatPropsButton
            // 
            this.FormatPropsButton.Location = new System.Drawing.Point(256, 42);
            this.FormatPropsButton.Margin = new System.Windows.Forms.Padding(2);
            this.FormatPropsButton.Name = "FormatPropsButton";
            this.FormatPropsButton.Size = new System.Drawing.Size(81, 21);
            this.FormatPropsButton.TabIndex = 205;
            this.FormatPropsButton.Text = "Show Props";
            this.FormatPropsButton.UseVisualStyleBackColor = true;
            this.FormatPropsButton.Click += new System.EventHandler(this.FormatPropsButton_Click);
            // 
            // textBoxURL
            // 
            this.textBoxURL.Location = new System.Drawing.Point(45, 152);
            this.textBoxURL.Name = "textBoxURL";
            this.textBoxURL.Size = new System.Drawing.Size(294, 20);
            this.textBoxURL.TabIndex = 200;
            // 
            // checkBoxVPrev
            // 
            this.checkBoxVPrev.AutoSize = true;
            this.checkBoxVPrev.Checked = true;
            this.checkBoxVPrev.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxVPrev.Location = new System.Drawing.Point(286, 181);
            this.checkBoxVPrev.Name = "checkBoxVPrev";
            this.checkBoxVPrev.Size = new System.Drawing.Size(53, 17);
            this.checkBoxVPrev.TabIndex = 204;
            this.checkBoxVPrev.Text = "Video";
            this.checkBoxVPrev.UseVisualStyleBackColor = true;
            this.checkBoxVPrev.CheckedChanged += new System.EventHandler(this.checkBoxVPrev_CheckedChanged);
            // 
            // checkBoxAPrev
            // 
            this.checkBoxAPrev.AutoSize = true;
            this.checkBoxAPrev.Location = new System.Drawing.Point(227, 181);
            this.checkBoxAPrev.Name = "checkBoxAPrev";
            this.checkBoxAPrev.Size = new System.Drawing.Size(53, 17);
            this.checkBoxAPrev.TabIndex = 203;
            this.checkBoxAPrev.Text = "Audio";
            this.checkBoxAPrev.UseVisualStyleBackColor = true;
            this.checkBoxAPrev.CheckedChanged += new System.EventHandler(this.checkBoxAPrev_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 199;
            this.label1.Text = "URL:";
            // 
            // labelStatistic
            // 
            this.labelStatistic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelStatistic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(232)))), ((int)(((byte)(254)))));
            this.labelStatistic.Location = new System.Drawing.Point(361, 589);
            this.labelStatistic.Name = "labelStatistic";
            this.labelStatistic.Size = new System.Drawing.Size(529, 64);
            this.labelStatistic.TabIndex = 205;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(232)))), ((int)(((byte)(254)))));
            this.panel3.Controls.Add(this.buttonRefreshSink);
            this.panel3.Controls.Add(this.comboBoxExtSources);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Location = new System.Drawing.Point(12, 64);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(343, 31);
            this.panel3.TabIndex = 0;
            // 
            // comboBoxAudioEx2
            // 
            this.comboBoxAudioEx2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxAudioEx2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAudioEx2.FormattingEnabled = true;
            this.comboBoxAudioEx2.Location = new System.Drawing.Point(78, 377);
            this.comboBoxAudioEx2.Name = "comboBoxAudioEx2";
            this.comboBoxAudioEx2.Size = new System.Drawing.Size(244, 21);
            this.comboBoxAudioEx2.TabIndex = 206;
            this.comboBoxAudioEx2.SelectedIndexChanged += new System.EventHandler(this.comboBoxAudioEx2_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(18, 381);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 13);
            this.label15.TabIndex = 205;
            this.label15.Text = "External 2:";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // livePropsList
            // 
            this.livePropsList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.livePropsList.FullRowSelect = true;
            this.livePropsList.GridLines = true;
            this.livePropsList.Location = new System.Drawing.Point(20, 106);
            this.livePropsList.Margin = new System.Windows.Forms.Padding(2);
            this.livePropsList.Name = "livePropsList";
            this.livePropsList.ShowItemToolTips = true;
            this.livePropsList.Size = new System.Drawing.Size(302, 123);
            this.livePropsList.TabIndex = 199;
            this.livePropsList.UseCompatibleStateImageBehavior = false;
            this.livePropsList.View = System.Windows.Forms.View.Details;
            // 
            // audio_channels
            // 
            this.audio_channels.AutoSize = true;
            this.audio_channels.Checked = true;
            this.audio_channels.CheckState = System.Windows.Forms.CheckState.Checked;
            this.audio_channels.Location = new System.Drawing.Point(364, 69);
            this.audio_channels.Name = "audio_channels";
            this.audio_channels.Size = new System.Drawing.Size(286, 17);
            this.audio_channels.TabIndex = 206;
            this.audio_channels.Text = "\"audio_channels\"=\"0+2+4+6,1+3+5+7,0,1,2,3,4,5,6,7\"";
            this.audio_channels.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(903, 665);
            this.Controls.Add(this.audio_channels);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.labelStatistic);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.pictureLogo);
            this.Controls.Add(this.panelPreview);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Sample File Writing";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCloseDev;
        private System.Windows.Forms.Panel panelPreview;
        private System.Windows.Forms.Button buttonInit;
        private System.Windows.Forms.ComboBox comboBoxVF;
        private System.Windows.Forms.ComboBox comboBoxV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonStartRec;
        private System.Windows.Forms.Button buttonStopRec;
        private System.Windows.Forms.TextBox textBoxConfig;
        private System.Windows.Forms.ComboBox conboBoxFormat;
        private System.Windows.Forms.ComboBox ConboBoxVideoCodec;
        private System.Windows.Forms.ComboBox comboBocAudioCodec;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureLogo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxAudio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxAPrev;
        private System.Windows.Forms.CheckBox checkBoxVPrev;
        private System.Windows.Forms.TextBox textBoxURL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelStatistic;
        private System.Windows.Forms.Button FormatPropsButton;
        private System.Windows.Forms.Button AudioCodecButton;
        private System.Windows.Forms.Button VideoCodecButton;
        private MFAttributesList livePropsList;
        private System.Windows.Forms.CheckBox checkBoxCC;
        private System.Windows.Forms.ComboBox comboBoxAudioEx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxVideoLine;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonUpdateLineIn;
        private System.Windows.Forms.ComboBox comboBoxVideoFormat;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button buttonRefreshSink;
        private System.Windows.Forms.ComboBox comboBoxExtSources;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox comboBoxAF;
        private System.Windows.Forms.ComboBox comboBoxAudioEx2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox audio_channels;
    }
}

