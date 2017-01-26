using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeSystem.Model;

namespace TimeSystem
{
    public class TimeManager
    {
        private TimeReader timeReader;

        private TimeModel timeModel;

        private ObservableCollection<TimeModel> timeModelList;

        public System.Action<double> TimeChanged;

        public TimeManager(TimeReader timeReader)
        {
            timeModelList = new ObservableCollection<TimeModel>();

            this.timeReader = timeReader;

            this.timeReader.TimeChanged += OnTimeChanged;
            this.timeReader.StopWatchChanged += OnStopWatchChanged;
            this.timeReader.Started += OnStarted;
        }

        public void OnStarted()
        {
            timeModel = new TimeModel();
            timeModel.AddTimePoint(new TimePoint(0.0, false));
            timeModelList.Add(timeModel);
        }

        public void OnTimeChanged(TimeObject timeObject)
        {
            if (TimeChanged != null)
                TimeChanged(timeObject.time);
        }

        public void OnStopWatchChanged(StopWatchObject stopWatchObject)
        {
            timeModel.AddTimePoint(new TimePoint(stopWatchObject.time, stopWatchObject.photoCell));
        }

        public void Stop()
        {
            timeReader.Stop();
        }

        public void ReadyToStart()
        {
            timeReader.ReadyToStart = true;
        }

        public void Start()
        {
            timeReader.Start();
        }
    }
}
