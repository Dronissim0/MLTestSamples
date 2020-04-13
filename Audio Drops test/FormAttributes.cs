using System;
using System.Windows.Forms;
using MFORMATSLib;

namespace SampleFileWriting
{
    public partial class FormAttributes : Form
    {
        public IMFProps WriterProps { get; set; }

        public FormAttributes()
        {
            InitializeComponent();
        }
        
        private void FormAttributes_Load(object sender, EventArgs e)
        {
            if (Owner != null)
            {
                Left = Owner.Left + 35;
                Top = Owner.Top + 35;
            }
            mAttributesList1.SetControlledObject(WriterProps);
        }

        private void mAttributesList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mAttributesList1.SelectedIndices.Count > 0)
            {
                string strName = mAttributesList1.SelectedItems[0].SubItems[0].Text;
                string strHelp;
                WriterProps.PropsInfoGet(strName, eMInfoType.eMIT_Help, out strHelp);
                textBoxHelp.Text = strHelp;
            }
        }
    }
}