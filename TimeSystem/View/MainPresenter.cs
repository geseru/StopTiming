using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeSystem.Model;

namespace TimeSystem.View
{
    /// <summary>
    /// Presenter of the main form
    /// </summary>
    class MainPresenter
    {
        #region Fields
        private TimeManager timeManager;
        private IMainForm mainForm;
        #endregion

        #region Constructor        
        /// <summary>
        /// Initializes a new instance of the <see cref="MainPresenter"/> class.
        /// </summary>
        /// <param name="timeManager">The time manager.</param>
        /// <param name="mainForm">The main form.</param>
        public MainPresenter(TimeManager timeManager, IMainForm mainForm)
        {
            this.timeManager = timeManager;
            this.mainForm = mainForm;

            this.timeManager.TimeChanged += OnTimeChanged;
            this.timeManager.StopWatchChanged += OnStopWatchChanged;
            this.mainForm.StartClicked += OnStartClicked;
            this.mainForm.StopClicked += OnStopClicked;
            this.mainForm.ReadyClicked += OnReadyClicked;
            this.mainForm.RulerMoved += OnRulerMoved;
            this.mainForm.ResultChanged += OnResultChanged;
            this.mainForm.RankChanged += OnRankChanged;
            this.mainForm.RulerAdded += OnRulerAdded;
            this.mainForm.RulerRemoved += OnRulerRemoved;
            this.mainForm.CopyPressed += OnCopyPressed;
        }



        /// <summary>
        /// Finalizes an instance of the <see cref="MainPresenter"/> class.
        /// </summary>
        ~MainPresenter()
        {
            this.timeManager.Stop();
            this.timeManager.TimeChanged -= OnTimeChanged;
            this.timeManager.StopWatchChanged -= OnStopWatchChanged;
            this.mainForm.StartClicked -= OnStartClicked;
            this.mainForm.StopClicked -= OnStopClicked;
            this.mainForm.ReadyClicked -= OnReadyClicked;
            this.mainForm.RulerMoved -= OnRulerMoved;
            this.mainForm.ResultChanged -= OnResultChanged;
            this.mainForm.RankChanged -= OnRankChanged;
            this.mainForm.RulerAdded -= OnRulerAdded;
            this.mainForm.RulerRemoved -= OnRulerRemoved;
            this.mainForm.CopyPressed -= OnCopyPressed;

        }
        #endregion

        #region Methods        
        /// <summary>
        /// Called when [ready clicked].
        /// </summary>
        private void OnReadyClicked()
        {
            mainForm.CleanAll();
            timeManager.ReadyToStart();
        }

        /// <summary>
        /// Called when [start clicked].
        /// </summary>
        private void OnStartClicked()
        {
            timeManager.Start();
        }

        /// <summary>
        /// Called when [stop clicked].
        /// </summary>
        private void OnStopClicked()
        {
            timeManager.Stop();
            mainForm.AddRulers();
            List<Result> results = timeManager.GetResults();
            for (int i = 0; i < results.Count; i++)
            {
                mainForm.UpdateResult(i, results[i].Time.ToString("N2"));
                mainForm.UpdateRank(i, results[i].Rank.ToString());
            }

            if (results.Count > 0)
                mainForm.SetTimeMinimum(results[0].Time - 0.5);
        }

        /// <summary>
        /// Called when [time changed].
        /// </summary>
        /// <param name="time">The time.</param>
        private void OnTimeChanged(double time)
        {
            mainForm.RunningTime = time.ToString("N1");
        }

        /// <summary>
        /// Called when [stop watch changed].
        /// </summary>
        /// <param name="time">The time.</param>
        /// <param name="signal">if set to <c>true</c> [signal].</param>
        private void OnStopWatchChanged(double time, bool signal)
        {
            mainForm.AddPoint(time, signal);
        }

        /// <summary>
        /// Called when [ruler moved].
        /// </summary>
        private void OnRulerMoved()
        {
            List<double> rulerPositions = mainForm.GetRulerPositions();
            List<string> ranks = mainForm.GetRanks();
            List<Result> results = new List<Result>();

            for (int i = 0; i < rulerPositions.Count; i++)
            {
                results.Add(new Result(rulerPositions[i], Convert.ToInt32(ranks[i])));
                mainForm.UpdateResult(i, rulerPositions[i].ToString("N2"));
            }

            timeManager.UpdateResults(results);
        }

        /// <summary>
        /// Called when [ruler added].
        /// </summary>
        /// <param name="x">The x.</param>
        private void OnRulerAdded(double x)
        {
            timeManager.AddResult(x);
            List<Result> results = timeManager.GetResults();

            mainForm.CleanResults();
            for (int i = 0; i < results.Count; i++)
            {
                mainForm.UpdateResult(i, results[i].Time.ToString("N2"));
                mainForm.UpdateRank(i, results[i].Rank.ToString());
            }
        }

        /// <summary>
        /// Called when [ruler removed].
        /// </summary>
        /// <param name="x">The x.</param>
        private void OnRulerRemoved(double x)
        {
            timeManager.RemoveResult(x);
            List<Result> results = timeManager.GetResults();

            mainForm.CleanResults();
            for (int i = 0; i < results.Count; i++)
            {
                mainForm.UpdateResult(i, results[i].Time.ToString("N2"));
                mainForm.UpdateRank(i, results[i].Rank.ToString());
            }
        }

        /// <summary>
        /// Called when [result changed].
        /// </summary>
        private void OnResultChanged()
        {
            List<double> resultValues = ConvertResults(mainForm.GetResults());
            List<string> ranks = mainForm.GetRanks();
            List<Result> results = new List<Result>();

            for (int i = 0; i < resultValues.Count; i++)
            {
                results.Add(new Result(resultValues[i], Convert.ToInt32(ranks[i])));
            }

            timeManager.UpdateResults(results);
        }

        /// <summary>
        /// Called when [rank changed].
        /// </summary>
        private void OnRankChanged()
        {
            OnResultChanged();
        }

        /// <summary>
        /// Converts the results from string to double.
        /// </summary>
        /// <param name="resultTexts">The result texts.</param>
        /// <returns>Return a list of results as double values</returns>
        private List<double> ConvertResults(List<string> resultTexts)
        {
            double doubleValue;
            List<double> resultValues = new List<double>();

            for (int i = 0; i < resultTexts.Count; i++)
                if (double.TryParse(resultTexts[i], out doubleValue))
                    resultValues.Add(doubleValue);

            return resultValues;
        }

        /// <summary>
        /// Called when [copy pressed].
        /// </summary>
        private void OnCopyPressed()
        {
            timeManager.CopyResultToClipboard();
        }
        #endregion
    }
}
