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

    public class Result
    {
        private double time;

        public double Time
        {
            get { return time; }
            set { time = value; }
        }

        private int rank;

        public int Rank
        {
            get { return rank; }
            set { rank = value; }
        }

        public Result(double time, int rank)
        {
            Time = time;
            Rank = rank;
        }
    }

    public class TimeModel
    {
        private List<TimePoint> timePoints;
        private List<Result> timeResults;
        
        public List<Result> Results
        {
            get { return timeResults; }
        }

        public TimeModel()
        {
            timePoints = new List<TimePoint>();
            timeResults = new List<Result>();
        }

        public void AddTimePoint(TimePoint timePoint)
        {
            timePoints.Add(timePoint);
        }

        public void AddResult(Result timeResult)
        {
            timeResults.Add(timeResult);
        }

        public void AddResult(double time)
        {
            if (timeResults.Count > 0)
                AddResult(new Result(time, timeResults[timeResults.Count - 1].Rank + 1));
            else
                AddResult(new Result(time, 1));
        }

        public void RemoveResult(double timeResult)
        {
            for (int i = timeResults.Count() - 1; i >= 0; i--)
            {
                if (timeResults[i].Time == timeResult)
                    timeResults.RemoveAt(i);
            }
        }

        public void UpdateResults(List<Result> resultList)
        {
            timeResults.Clear();
            timeResults.AddRange(resultList);
        }
    }
}
