namespace slowdown
{
    partial class LicenseInfo
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
            this.linkLabelAhaSoft = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // linkLabelAhaSoft
            // 
            this.linkLabelAhaSoft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.linkLabelAhaSoft.Location = new System.Drawing.Point(0, 0);
            this.linkLabelAhaSoft.Name = "linkLabelAhaSoft";
            this.linkLabelAhaSoft.Size = new System.Drawing.Size(409, 52);
            this.linkLabelAhaSoft.TabIndex = 0;
            this.linkLabelAhaSoft.TabStop = true;
            this.linkLabelAhaSoft.Text = "aha-soft-link";
            this.linkLabelAhaSoft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabelAhaSoft.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelAhaSoft_LinkClicked);
            // 
            // LicenseInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 52);
            this.Controls.Add(this.linkLabelAhaSoft);
            this.Name = "LicenseInfo";
            this.Text = "LicenseInfo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabelAhaSoft;
    }
}