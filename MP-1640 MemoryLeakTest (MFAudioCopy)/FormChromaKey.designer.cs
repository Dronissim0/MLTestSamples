namespace MControls
{
	partial class FormChromaKey
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.mChromaKey1 = new MControls.MChromaKeyControl();
            this.persist = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(219, 652);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Save CK XML ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(328, 652);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Load CK XML";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // mChromaKey1
            // 
            this.mChromaKey1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mChromaKey1.Location = new System.Drawing.Point(0, 0);
            this.mChromaKey1.Margin = new System.Windows.Forms.Padding(0);
            this.mChromaKey1.Name = "mChromaKey1";
            this.mChromaKey1.Size = new System.Drawing.Size(1184, 688);
            this.mChromaKey1.TabIndex = 0;
            // 
            // persist
            // 
            this.persist.AutoSize = true;
            this.persist.Checked = true;
            this.persist.CheckState = System.Windows.Forms.CheckState.Checked;
            this.persist.Location = new System.Drawing.Point(443, 657);
            this.persist.Name = "persist";
            this.persist.Size = new System.Drawing.Size(69, 17);
            this.persist.TabIndex = 3;
            this.persist.Text = "IMPersist";
            this.persist.UseVisualStyleBackColor = true;
            this.persist.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // FormChromaKey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 688);
            this.Controls.Add(this.persist);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mChromaKey1);
            this.Name = "FormChromaKey";
            this.Text = "FormChromaKey";
            this.Load += new System.EventHandler(this.FormChromaKey_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		public MChromaKeyControl mChromaKey1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox persist;
    }
}