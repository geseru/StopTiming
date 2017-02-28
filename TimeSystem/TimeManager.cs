using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeSystem.Model;

namespace TimeSystem
{
    /// <summary>
    /// Time manager
    /// </summary>
    public class TimeManager
    {
        #region Fields
        private TimeReader timeReader;

        private TimeModel timeModel;
        #endregion

        #region Events        
        /// <summary>
        /// The time changed event
        /// </summary>
        public System.Action<double> TimeChanged;

        /// <summary>
        /// The stop watch changed
        /// </summary>
        public System.Action<double, bool> StopWatchChanged;
        #endregion

        public TimeManager(TimeReader timeReader)
        {
            this.timeReader = timeReader;

            this.timeReader.TimeChanged += OnTimeChanged;
            this.timeReader.StopWatchChanged += OnStopWatchChanged;
            this.timeReader.Started += OnStarted;
            timeModel = new TimeModel();
        }

        /// <summary>
        /// Called when [started].
        /// </summary>
        public void OnStarted()
        {
            timeModel = new TimeModel();
            timeModel.AddTimePoint(new TimePoint(0.0, false));
        }

        /// <summary>
        /// Called when [time changed].
        /// </summary>
        /// <param name="timeObject">The time object.</param>
        public void OnTimeChanged(TimeObject timeObject)
        {
            if (TimeChanged != null)
                TimeChanged(timeObject.time);
        }

        /// <summary>
        /// Called when [stop watch changed].
        /// </summary>
        /// <param name="stopWatchObject">The stop watch object.</param>
        public void OnStopWatchChanged(StopWatchObject stopWatchObject)
        {
            timeModel.AddTimePoint(new TimePoint(stopWatchObject.time, stopWatchObject.photoCell));
            if (stopWatchObject.photoCell)
                timeModel.AddResult(stopWatchObject.time);
            if (StopWatchChanged != null)
                StopWatchChanged(stopWatchObject.time, stopWatchObject.photoCell);
        }

        /// <summary>
        /// Stops the stopwatch.
        /// </summary>
        public void Stop()
        {
            timeReader.Stop();
        }

        /// <summary>
        /// Ready to start.
        /// </summary>
        public void ReadyToStart()
        {
            timeReader.ReadyToStart = true;
        }

        /// <summary>
        /// Start the stopwatch
        /// </summary>
        public void Start()
        {
            timeReader.Start();
        }

        /// <summary>
        /// Updates the results.
        /// </summary>
        /// <param name="results">The results.</param>
        public void UpdateResults(List<Result> results)
        {
            timeModel.UpdateResults(results);
        }

        /// <summary>
        /// Gets the results.
        /// </summary>
        /// <returns></returns>
        public List<Result> GetResults()
        {
            return timeModel.Results;
        }

        /// <summary>
        /// Adds the result.
        /// </summary>
        /// <param name="time">The time.</param>
        public void AddResult(double time)
        {
            timeModel.AddResult(time);
        }

        /// <summary>
        /// Removes the result.
        /// </summary>
        /// <param name="time">The time.</param>
        public void RemoveResult(double time)
        {
            timeModel.RemoveResult(time);
        }
    }
}
