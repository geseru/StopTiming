using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeSystem.Model
{

    public class TimePoint
    {
        private double timeValue;

        public double TimeValue
        {
            get { return timeValue; }
            set { timeValue = value; }
        }


        private bool signal;

        public bool Signal
        {
            get { return signal; }
            set { signal = value; }
        }
        
        public TimePoint(double timeValue, bool signal)
        {
            this.timeValue = timeValue;
            this.signal = signal;
        }

        public TimePoint()
        {

        }
    }

    public class TimeModel
    {
        private List<TimePoint> timePoints;
        private List<double> timeResults;

        public TimeModel()
        {
            timePoints = new List<TimePoint>();
            timeResults = new List<double>();
        }

        public void AddTimePoint(TimePoint timePoint)
        {
            timePoints.Add(timePoint);
        }

        public void AddResult(double timeResult)
        {
            timeResults.Add(timeResult);
        }

        public void RemoveResult(double timeResult)
        {
            for (int i = timeResults.Count() - 1; i >= 0; i--)
            {
                if (timeResults[i] == timeResult)
                    timeResults.RemoveAt(i);
            }
        }
    }
}
