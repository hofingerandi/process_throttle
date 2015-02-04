using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace slowdown
{
    class CpuBlocker
    {
        public void Start()
        {
            IsRunning = true;

            // perform starting in separate thread, to keep ui responsive
            var starter = new Thread(StartThreads);
            starter.Start();
        }

        public void Stop()
        {
            StopThreads();
            IsRunning = false;
        }


       public long RunningThreadsCount = 0;
        List<Thread> Threads = new List<Thread>();
        ManualResetEvent StopThreadEvent = new ManualResetEvent(false);

        public int ThreadCount { get; set; }
        private void StartThreads()
        {
            StopThreads();
            Threads.Clear();

            StopThreadEvent.Reset();
            for (int i = 0; i < ThreadCount; i++)
            {
                var th = new Thread(ThreadFunc);
                th.Priority = ThreadPriority.Normal;

                Threads.Add(th);

            }

            foreach (var item in Threads)
            {
                item.Start();
            }
        }

        private void WaitForThreads()
        {
            long activeThreads = 0;
            do
            {
                activeThreads = Interlocked.Read(ref RunningThreadsCount);
                System.Threading.Thread.Sleep(10);
            }
            while (activeThreads > 0);
        }

        private void StopThreads()
        {
            StopThreadEvent.Set();
            WaitForThreads();
        }

        public void ThreadFunc()
        {
            Interlocked.Increment(ref RunningThreadsCount);
            bool result = false;
            do
            {
                for (long i = 0; i < 10000000; ++i)
                {
                    double x = Math.Sqrt(4712.4712 + i);
                    double y = Math.Pow(x, 2);
                    double eps = 4712 + i - y;
                    result = result & eps > 0;
                }
                if (StopThreadEvent.WaitOne(0))
                    break;
            }
            while (true);
            Interlocked.Decrement(ref RunningThreadsCount);
        }

        private bool isRunning = false;
        public bool IsRunning
        {
            get { return isRunning; }
            set
            {
                var valueChanged = isRunning != value;
                isRunning = value;
                if (valueChanged)
                    RaisePropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged()
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(""));
        }

    }
}
