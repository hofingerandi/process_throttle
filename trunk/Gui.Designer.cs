namespace slowdown
{
    partial class Gui
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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.txtThreadCount = new System.Windows.Forms.TextBox();
            this.txtCpu = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.txtWorkerName = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabSuspendProcess = new System.Windows.Forms.TabPage();
            this.txtSuspendedProcess = new System.Windows.Forms.TextBox();
            this.lblPercentage = new System.Windows.Forms.Label();
            this.tabBlockCpu = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabSuspendProcess.SuspendLayout();
            this.tabBlockCpu.SuspendLayout();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(81, 6);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(45, 20);
            this.numericUpDown1.TabIndex = 0;
            this.numericUpDown1.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(276, 8);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(120, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnStop.Location = new System.Drawing.Point(274, 37);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(120, 23);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // txtThreadCount
            // 
            this.txtThreadCount.Location = new System.Drawing.Point(81, 35);
            this.txtThreadCount.Name = "txtThreadCount";
            this.txtThreadCount.ReadOnly = true;
            this.txtThreadCount.Size = new System.Drawing.Size(45, 20);
            this.txtThreadCount.TabIndex = 3;
            // 
            // txtCpu
            // 
            this.txtCpu.Location = new System.Drawing.Point(81, 66);
            this.txtCpu.Name = "txtCpu";
            this.txtCpu.ReadOnly = true;
            this.txtCpu.Size = new System.Drawing.Size(45, 20);
            this.txtCpu.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(274, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(274, 35);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Stop";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(6, 80);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(388, 45);
            this.trackBar1.TabIndex = 9;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(138, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "normal -> slow";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtWorkerName
            // 
            this.txtWorkerName.Location = new System.Drawing.Point(6, 9);
            this.txtWorkerName.Name = "txtWorkerName";
            this.txtWorkerName.Size = new System.Drawing.Size(120, 20);
            this.txtWorkerName.TabIndex = 11;
            this.txtWorkerName.Text = "processName";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabSuspendProcess);
            this.tabControl1.Controls.Add(this.tabBlockCpu);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(410, 163);
            this.tabControl1.TabIndex = 12;
            // 
            // tabSuspendProcess
            // 
            this.tabSuspendProcess.BackColor = System.Drawing.SystemColors.Control;
            this.tabSuspendProcess.Controls.Add(this.txtSuspendedProcess);
            this.tabSuspendProcess.Controls.Add(this.lblPercentage);
            this.tabSuspendProcess.Controls.Add(this.button1);
            this.tabSuspendProcess.Controls.Add(this.txtWorkerName);
            this.tabSuspendProcess.Controls.Add(this.button2);
            this.tabSuspendProcess.Controls.Add(this.label1);
            this.tabSuspendProcess.Controls.Add(this.trackBar1);
            this.tabSuspendProcess.Location = new System.Drawing.Point(4, 22);
            this.tabSuspendProcess.Name = "tabSuspendProcess";
            this.tabSuspendProcess.Padding = new System.Windows.Forms.Padding(3);
            this.tabSuspendProcess.Size = new System.Drawing.Size(402, 137);
            this.tabSuspendProcess.TabIndex = 0;
            this.tabSuspendProcess.Text = "Suspend Process";
            // 
            // txtSuspendedProcess
            // 
            this.txtSuspendedProcess.Location = new System.Drawing.Point(8, 35);
            this.txtSuspendedProcess.Name = "txtSuspendedProcess";
            this.txtSuspendedProcess.ReadOnly = true;
            this.txtSuspendedProcess.Size = new System.Drawing.Size(120, 20);
            this.txtSuspendedProcess.TabIndex = 14;
            // 
            // lblPercentage
            // 
            this.lblPercentage.Location = new System.Drawing.Point(338, 103);
            this.lblPercentage.Name = "lblPercentage";
            this.lblPercentage.Size = new System.Drawing.Size(47, 22);
            this.lblPercentage.TabIndex = 13;
            this.lblPercentage.Text = "0";
            this.lblPercentage.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // tabBlockCpu
            // 
            this.tabBlockCpu.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabBlockCpu.Controls.Add(this.label4);
            this.tabBlockCpu.Controls.Add(this.label3);
            this.tabBlockCpu.Controls.Add(this.label2);
            this.tabBlockCpu.Controls.Add(this.btnStart);
            this.tabBlockCpu.Controls.Add(this.txtCpu);
            this.tabBlockCpu.Controls.Add(this.numericUpDown1);
            this.tabBlockCpu.Controls.Add(this.txtThreadCount);
            this.tabBlockCpu.Controls.Add(this.btnStop);
            this.tabBlockCpu.Location = new System.Drawing.Point(4, 22);
            this.tabBlockCpu.Name = "tabBlockCpu";
            this.tabBlockCpu.Padding = new System.Windows.Forms.Padding(3);
            this.tabBlockCpu.Size = new System.Drawing.Size(402, 137);
            this.tabBlockCpu.TabIndex = 1;
            this.tabBlockCpu.Text = "Block Cpu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cpu %";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Threads";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Running";
            // 
            // Gui
            // 
            this.AcceptButton = this.btnStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnStop;
            this.ClientSize = new System.Drawing.Size(410, 163);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Gui";
            this.Text = "Process Throttle";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabSuspendProcess.ResumeLayout(false);
            this.tabSuspendProcess.PerformLayout();
            this.tabBlockCpu.ResumeLayout(false);
            this.tabBlockCpu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.TextBox txtThreadCount;
        private System.Windows.Forms.TextBox txtCpu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtWorkerName;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabSuspendProcess;
        private System.Windows.Forms.TabPage tabBlockCpu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPercentage;
        private System.Windows.Forms.TextBox txtSuspendedProcess;
    }
}

