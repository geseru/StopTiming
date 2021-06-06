using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeSystem
{
    /// <summary>
    /// Object for a time event data
    /// </summary>
    public class TimeObject
    {
        public double time;

        public TimeObject(double time)
        {
            this.time = time;
        }
    }

    /// <summary>
    /// Object for a stop watch event data
    /// </summary>
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

    /// <summary>
    /// Class to read the times forme the device
    /// </summary>
    public class TimeReader
    {
        private BackgroundWorker worker;
        private Stopwatch watch;
        private IDevice device;

        public Action Connected;
        public Action Disconnected;
        public Action Started;
        public Action<TimeObject> TimeChanged;
        public Action<StopWatchObject> StopWatchChanged;

        private bool readyToStart;
        private bool startCommandLast;
        private bool photoCellLast;
 
        /// <summary>
        /// Gets or sets a value indicating whether [ready to start].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [ready to start]; otherwise, <c>false</c>.
        /// </value>
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

        /// <summary>
        /// Initializes a new instance of the <see cref="TimeReader"/> class.
        /// </summary>
        /// <param name="device">The device.</param>
        public TimeReader(IDevice device)
        {
            readyToStart = false;
            startCommandLast = false;
            worker = new BackgroundWorker();
            worker.WorkerReportsProgress = true;
            worker.WorkerSupportsCancellation = true;
            worker.DoWork += Worker_DoWork;
            worker.ProgressChanged += Worker_ProgressChanged;

            watch = new Stopwatch();

            this.device = device;

            worker.RunWorkerAsync();
        }

        /// <summary>
        /// Connects to the io board
        /// </summary>
        public void Connect()
        {
            if (device.Connect())
            {
                if (Connected != null)
                    Connected();
            }
        }

        /// <summary>
        /// Disconnects the io board
        /// </summary>
        public void Disconnect()
        {
            device.Disconnect();
            if (Disconnected != null)
                Disconnected();
        }

        /// <summary>
        /// Stops the stopwatch
        /// </summary>
        public void Stop()
        {
            watch.Reset();
            startCommandLast = false;
            photoCellLast = true;
        }

        /// <summary>
        /// Starts the stopwatch
        /// </summary>
        public void Start()
        {
            Stop();
            watch.Start();

            if (Started != null)
                Started();
        }

        /// <summary>
        /// Handles the ProgressChanged event of the Worker control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="ProgressChangedEventArgs"/> instance containing the event data.</param>
        private void Worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.UserState is TimeObject)
            {
                // Send time object to show the running time
                TimeObject timeObject = (TimeObject)e.UserState;
                if (TimeChanged != null)
                    TimeChanged(timeObject);
            }
            else if (e.UserState is StopWatchObject)
            {
                StopWatchObject stopWatchObject = (StopWatchObject)e.UserState;
                if (stopWatchObject.time == 0.0)
                {
                    readyToStart = false;
                    // Send started event
                    if (Started != null)
                        Started();
                }
                // Send stop watch event
                if (StopWatchChanged != null)
                    StopWatchChanged(stopWatchObject);
            }
        }

        /// <summary>
        /// Handles the DoWork event of the Worker control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DoWorkEventArgs"/> instance containing the event data.</param>
        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            int reads = 0;
            int counter =0;
            BackgroundWorker worker = sender as BackgroundWorker;
            
            bool startCommand;
            bool photoCell;

            do
            {
                if (!watch.IsRunning && readyToStart)
                {
                    startCommand = device.ReadStartCommand();
                    if (startCommandLast == false && startCommand == true)
                    {
                        watch.Start();
                        counter = 0;
                        worker.ReportProgress(0, new StopWatchObject(0.0, false));
                        photoCellLast = true;
                    }
                    startCommandLast = startCommand;
 
                }
                else if (watch.IsRunning)
                {
                    photoCell = device.ReadPhotoCell();

                    double elapsedInSec = (double)(watch.ElapsedMilliseconds / 1000.0);
#if DEBUG
                    reads++;
                    if (reads % 100 == 0)
                        Debug.WriteLine("Anzahl Lesebefehle: " + reads + "   R/s = " + reads / elapsedInSec);
#endif
                    // Photo cell sensor value changed
                    if (photoCellLast != photoCell && elapsedInSec > 0)
                        worker.ReportProgress(1, new StopWatchObject(elapsedInSec, photoCell));

                    // Time message to show the running clock (100ms)
                    if (counter >= 6)
                    {
                        counter = 0;
                        worker.ReportProgress(2, new TimeObject(elapsedInSec));
                    }

                    photoCellLast = photoCell;
                }
                else
                {
                    System.Threading.Thread.Sleep(1);
                }
                
                if (worker.CancellationPending == true)
                {
                    e.Cancel = true;
                    break;
                }

                counter++;
            } while (e.Cancel == false);
        }
    }
}
