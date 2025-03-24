using System;
using System.Diagnostics;
using System.Linq;
using System.Threading;

namespace slowdown
{
    public class SuspendWorker
    {
        ManualResetEvent StopWorker = new ManualResetEvent(false);
        public string ProcessName { get; private set; }
        public SuspendWorker(string processName)
        {
            this.ProcessName = processName.ToLowerInvariant();
            SuspenedProcess = "stopped";
        }

        System.Threading.Thread WorkerThread;
        internal void Start()
        {
            StopWorker.Reset();
            WorkerThread = new System.Threading.Thread(KeepApplicationBusy);
            WorkerThread.Start();
        }

        public String SuspenedProcess { get; private set; }

        private void KeepApplicationBusy()
        {
            do
            {
                System.Threading.Thread.Sleep(Running);
                var list = Process.GetProcesses();
                var proc = list.FirstOrDefault((p) => p.ProcessName.ToLowerInvariant().Contains(ProcessName));
                if (proc != null)
                {
                    SuspenedProcess = proc.ProcessName;
                    proc.Suspend();
                    System.Threading.Thread.Sleep(Paused);
                    proc.Resume();
                }
                else
                {
                    SuspenedProcess = "not found";
                    System.Threading.Thread.Sleep(Paused);
                }

                if (StopWorker.WaitOne(0))
                    break;
            }
            while (true);

            SuspenedProcess = "stopped";
        }


        internal void Stop()
        {
            StopWorker.Set();
            if (WorkerThread != null)
                WorkerThread.Join();
        }

        int Paused = 10;
        int Running = 10;
        internal void Update(int paused, int running)
        {
            this.Paused = Math.Max(0, paused);
            this.Running = Math.Max(0, running);
        }
    }


}
