using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace slowdown
{
    public partial class Gui : Form
    {
        SynchronizationContext theContext;
        public Gui()
        {
            InitializeComponent();
            theContext = SynchronizationContext.Current;
            Thread.CurrentThread.Priority = ThreadPriority.Highest; // keep ui responsive

            StartCpuTimer(); // monitor cpu%
            StartTextboxTimer(); // refresh display

            SuspendWorker = new SuspendWorker("processName");
            UpdateWorker(0);

            Blocker = new CpuBlocker();
            Blocker.PropertyChanged += BlockerChanged;
            UpdateBlocker();
        }


        #region About... context menu entry

        private int SYSMENU_ABOUT_ID = 0x01;

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);

            // Get a handle to a copy of this form's system (window) menu
            IntPtr hSysMenu = NativeMethods.GetSystemMenu(this.Handle, false);

            // Add a separator
            NativeMethods.AppendMenu(hSysMenu, NativeMethods.MF_SEPARATOR, 0, string.Empty);

            // Add the About menu item
            NativeMethods.AppendMenu(hSysMenu, NativeMethods.MF_STRING, SYSMENU_ABOUT_ID, "&About…");
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            // Test if the About item was selected from the system menu
            if ((m.Msg == NativeMethods.WM_SYSCOMMAND) && ((int)m.WParam == SYSMENU_ABOUT_ID))
            {
                using (var dlg = new LicenseInfo())
                {
                    dlg.ShowDialog();
                }
            }
        }

        #endregion

        CpuBlocker Blocker;

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            if (!e.Cancel && SuspendWorker != null)
                SuspendWorker.Stop();
        }

        #region Measure Cpu %

        System.Threading.Timer CpuTimer;
        private void StartCpuTimer()
        {
            if (CpuTimer != null)
                CpuTimer.Dispose();
            CpuTimer = new System.Threading.Timer(ComputeCpu, null, 200, Timeout.Infinite);
        }

        double Cpu = 0;
        DateTime lastTime;
        double lastProcessorTime;
        bool firstTime = true;
        private void ComputeCpu(object o)
        {
            var currentProcTime = Process.GetCurrentProcess().TotalProcessorTime.TotalMilliseconds;
            var currentTime = DateTime.Now;
            var percentage = (currentProcTime - lastProcessorTime) / (double)((currentTime - lastTime).TotalMilliseconds);
            percentage /= Environment.ProcessorCount;
            lastProcessorTime = currentProcTime;
            lastTime = currentTime;

            if (firstTime)
            {
                firstTime = false;
            }
            else
            {
                lock (this)
                {
                    Cpu = percentage;
                }
            }
            StartCpuTimer();
        }

        #endregion

        #region Update Textboxes

        System.Threading.Timer TextboxTimer;
        private void StartTextboxTimer()
        {
            if (TextboxTimer != null)
                TextboxTimer.Dispose();
            TextboxTimer = new System.Threading.Timer(UpdateTextBox, null, 50, Timeout.Infinite);
        }

        private void UpdateTextBox(object o)
        {
            theContext.Post(
                new SendOrPostCallback((ob) => UpdateText()), null);
        }

        public void UpdateText()
        {

            lock (this)
            {
                txtCpu.Text = String.Format("{0:F2}%", Cpu * 100);
            }
            var value = Interlocked.Read(ref Blocker.RunningThreadsCount);
            txtThreadCount.Text = value.ToString();
            if (SuspendWorker != null)
                txtSuspendedProcess.Text = SuspendWorker.SuspenedProcess;

            StartTextboxTimer();
        }

        #endregion

        void BlockerChanged(object sender, PropertyChangedEventArgs e)
        {
            bool isRunning = Blocker.IsRunning;
            numericUpDown1.Invoke(new Action(() => { numericUpDown1.Enabled = !isRunning; }));
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Blocker.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Blocker.Stop();
        }

        SuspendWorker SuspendWorker;

        private void button1_Click(object sender, EventArgs e)
        {
            if (SuspendWorker != null)
                SuspendWorker.Stop();

            if (txtWorkerName.Text.Length > 0)
                SuspendWorker = new SuspendWorker(txtWorkerName.Text);
            else
                SuspendWorker = new SuspendWorker("perfexp");

            SuspendWorker.Start();
            UpdateWorker(trackBar1.Value);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (SuspendWorker != null)
                SuspendWorker.Stop();
        }

        private void UpdateWorker(int value)
        {
            value = Math.Max(0, Math.Min(100, value));
            if (SuspendWorker != null)
                SuspendWorker.Update(value, 100 - value);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            lblPercentage.Text = trackBar1.Value.ToString();
            UpdateWorker(trackBar1.Value);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            UpdateBlocker();
        }

        private void UpdateBlocker()
        {
            Blocker.ThreadCount = (int)numericUpDown1.Value;
        }
    }
}


