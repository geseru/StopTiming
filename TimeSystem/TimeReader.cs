using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeSystem
{
    public class TimeObject
    {
        public double time;

        public TimeObject(double time)
        {
            this.time = time;
        }
    }

    public class StopWatchObject
    {
        public double time;
        public bool photoCell;

        public StopWatchObject(double time, bool photoCell)
        {
            this.time = time;
            this.photoCell = photoCell;
        }
    }

    public class TimeReader
    {
        private BackgroundWorker worker;
        private Stopwatch watch;
        private Device device;

        public Action Connected;
        public Action Disconnected;
        public Action Started;
        public Action<TimeObject> TimeChanged;
        public Action<StopWatchObject> StopWatchChanged;

        private bool readyToStart;

        public bool ReadyToStart
        {
            get { return readyToStart; }
            set
            {
                readyToStart = value;
                Stop();
                TimeObject timeObject = new TimeObject(0.0);
                if (TimeChanged != null)
                    TimeChanged(timeObject);
            }
        }

        public TimeReader(Device device)
        {
            worker = new BackgroundWorker();
            worker.WorkerReportsProgress = true;
            worker.WorkerSupportsCancellation = true;
            worker.DoWork += Worker_DoWork;
            worker.ProgressChanged += Worker_ProgressChanged;

            watch = new Stopwatch();

            this.device = device;

            worker.RunWorkerAsync();
        }

        public void Connect()
        {
            if (device.Connect())
            {
                if (Connected != null)
                    Connected();
            }
        }

        public void Disconnect()
        {
            device.Disconnect();
            if (Disconnected != null)
                Disconnected();
        }

        public void Stop()
        {
            watch.Reset();
        }

        public void Start()
        {
            Stop();
            watch.Start();

            if (Started != null)
                Started();
        }

        private void Worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.UserState is TimeObject)
            {
                TimeObject timeObject = (TimeObject)e.UserState;
                if (TimeChanged != null)
                    TimeChanged(timeObject);
            }
            else if (e.UserState is StopWatchObject)
            {
                StopWatchObject stopWatchObject = (StopWatchObject)e.UserState;
                if (stopWatchObject.time == 0.0)
                {
                    if (Started != null)
                        Started();
                }
                else
                {
                    if (StopWatchChanged != null)
                        StopWatchChanged(stopWatchObject);
                }
            }
        }

        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            int counter =0;
            BackgroundWorker worker = sender as BackgroundWorker;

            bool startCommandLast = false;
            bool startCommand;

            bool photoCellLast = false;
            bool photoCell;
            do
            {
                startCommand = device.ReadStartCommand();
                if (!watch.IsRunning && (startCommandLast == false && startCommand == true))
                {
                    watch.Start();
                    counter = 0;
                }
                startCommandLast = startCommand;

                photoCell = device.ReadPhotoCell();

                // Photo cell sensor value changed
                if (watch.IsRunning && photoCellLast != photoCell)
                    worker.ReportProgress(0, new StopWatchObject((double)(watch.ElapsedMilliseconds / 1000.0), photoCell));

                // Time message to show the running clock (100ms)
                if (watch.IsRunning && counter >= 10)
                {
                    counter = 0;
                    worker.ReportProgress(0, new TimeObject((double)(watch.ElapsedMilliseconds / 1000.0)));
                }

                photoCellLast = photoCell;
                
                if (worker.CancellationPending == true)
                {
                    e.Cancel = true;
                    break;
                }
                // Perform a time consuming operation and report progress.
                System.Threading.Thread.Sleep(10);
                counter++;
            } while (e.Cancel == false);
        }
    }
}
