using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TimeSystem.View
{
    /// <summary>
    /// Main form
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    /// <seealso cref="TimeSystem.View.IMainForm" />
    public partial class Main : Form, IMainForm
    {
        #region Fields
        private PlotModel plotModel;

        private List<TextBox> results;
        private List<ComboBox> ranks;

        private bool changeGuard = false;
        #endregion

        #region Events        
        /// <summary>
        /// Occurs when [start clicked].
        /// </summary>
        public event System.Action StartClicked;

        /// <summary>
        /// Occurs when [stop clicked].
        /// </summary>
        public event System.Action StopClicked;

        /// <summary>
        /// Occurs when [ready clicked].
        /// </summary>
        public event System.Action ReadyClicked;

        /// <summary>
        /// Ruler moved event
        /// </summary>
        public event System.Action RulerMoved;

        /// <summary>
        /// Occurs when [ruler added].
        /// </summary>
        public event System.Action<double> RulerAdded;

        /// <summary>
        /// Occurs when [ruler removed].
        /// </summary>
        public event System.Action<double> RulerRemoved;
        
        /// <summary>
        /// Occurs when [result changed].
        /// </summary>
        public event System.Action ResultChanged;

        /// <summary>
        /// Occurs when [position changed].
        /// </summary>
        public event System.Action RankChanged;

        /// <summary>
        /// Occurs when [copy pressed].
        /// </summary>
        public event System.Action CopyPressed;
        #endregion

        #region Properties
        /// <summary>
        /// Sets the running time.
        /// </summary>
        /// <value>
        /// The running time.
        /// </value>
        public string RunningTime
        {
            set
            {
                // Don't do anything if the form's handle hasn't been created 
                // or the form has been disposed.
                if (!this.IsHandleCreated || this.IsDisposed || !runningTime.IsHandleCreated || runningTime.IsDisposed) return;

                // Invoke an anonymous method on the thread of the form.
                this.Invoke((MethodInvoker)delegate
                {
                    // Show the current time in the form's title bar.
                    runningTime.Text = value;
                });
                
            }
        }
        #endregion

        #region Construtor        
        /// <summary>
        /// Initializes a new instance of the <see cref="Main"/> class.
        /// </summary>
        public Main()
        {
            InitializeComponent();
            results = new List<TextBox>();
            results.Add(result1);
            results.Add(result2);    
            results.Add(result3);
            results.Add(result4);
            results.Add(result5);
            results.Add(result6);
            results.Add(result7);
            results.Add(result8);
            results.Add(result9);
            results.Add(result10);
            results.Add(new TextBox());
            results.Add(new TextBox());
            results.Add(new TextBox());
            results.Add(new TextBox());
            results.Add(new TextBox());
            results.Add(new TextBox());
            results.Add(new TextBox());
            results.Add(new TextBox());
            results.Add(new TextBox());
            results.Add(new TextBox());

            ranks = new List<ComboBox>();
            ranks.Add(rank1);
            ranks.Add(rank2);
            ranks.Add(rank3);
            ranks.Add(rank4);
            ranks.Add(rank5);
            ranks.Add(rank6);
            ranks.Add(rank7);
            ranks.Add(rank8);
            ranks.Add(rank9);
            ranks.Add(rank10);
            ranks.Add(new ComboBox());
            ranks.Add(new ComboBox());
            ranks.Add(new ComboBox());
            ranks.Add(new ComboBox());
            ranks.Add(new ComboBox());
            ranks.Add(new ComboBox());
            ranks.Add(new ComboBox());
            ranks.Add(new ComboBox());
            ranks.Add(new ComboBox());
            ranks.Add(new ComboBox());
        }
        #endregion

        #region Methods                
        /// <summary>
        /// Handles the Load event of the Main control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Main_Load(object sender, EventArgs e)
        {
            plotModel = new PlotModel();
            plotModel.RulerMoved += OnRulerMoved;
            plotModel.MouseDoubleClicked += PlotModel_MouseDoubleClicked;
            plotModel.RulerDoubleClicked += PlotModel_RulerDoubleClicked;

            this.plot.Model = plotModel;
            this.plot.Controller = null;
        }

        /// <summary>
        /// Plots the model ruler double clicked.
        /// </summary>
        /// <param name="time">The time.</param>
        /// <exception cref="NotImplementedException"></exception>
        private void PlotModel_RulerDoubleClicked(double time)
        {
            if (RulerRemoved != null)
                RulerRemoved(time);
        }

        /// <summary>
        /// Plots the model mouse double clicked.
        /// </summary>
        /// <param name="time">The time.</param>
        private void PlotModel_MouseDoubleClicked(double time)
        {
            if (RulerAdded != null)
                RulerAdded(time);
        }

        /// <summary>
        /// Called when [ruler moved].
        /// </summary>
        private void OnRulerMoved()
        {
            if (RulerMoved != null)
                RulerMoved();
        }

        /// <summary>
        /// Handles the Click event of the buttonStart control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (StartClicked != null)
                StartClicked();
        }

        /// <summary>
        /// Handles the Click event of the buttonReady control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void buttonReady_Click(object sender, EventArgs e)
        {
            if (ReadyClicked != null)
                ReadyClicked();
            plotModel.ZoomData();
        }

        /// <summary>
        /// Handles the Click event of the buttonStopp control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void buttonStopp_Click(object sender, EventArgs e)
        {
            if (StopClicked != null)
                StopClicked();
            plotModel.ZoomData();
        }

        /// <summary>
        /// Adds the point.
        /// </summary>
        /// <param name="time">The time.</param>
        /// <param name="signal">if set to <c>true</c> [signal].</param>
        public void AddPoint(double time, bool signal)
        {
            plotModel.AddPoint(time,  Convert.ToDouble(signal));
        }

        /// <summary>
        /// Gets the ruler positions.
        /// </summary>
        /// <returns>Return a list with all ruler positions</returns>
        public List<double> GetRulerPositions()
        {
            return plotModel.GetAllRulerPositions();
        }

        /// <summary>
        /// Adds the rulers.
        /// </summary>
        public void AddRulers()
        {
            plotModel.AddRulersToPulses();
        }

        /// <summary>
        /// Updates the result.
        /// </summary>
        /// <param name="resultList">The result list.</param>
        public void UpdateResults(List<string> resultList)
        {
             for (int i =0; i<resultList.Count; i++)
                UpdateResult(i, resultList[i]);
        }

        /// <summary>
        /// Gets the result.
        /// </summary>
        /// <returns>
        /// Return the result as string
        /// </returns>
        public List<string> GetResults()
        {
            List<string> resultList = new List<string>();
            for (int i = 0; i < results.Count; i++)
                resultList.Add(results[i].Text);

            return resultList;
        }

        /// <summary>
        /// Gets the ranks.
        /// </summary>
        /// <returns>Return a list of all positions</returns>
        public List<string> GetRanks()
        {
            List<string> rankList = new List<string>();
            for (int i = 0; i < ranks.Count; i++)
                if (!string.IsNullOrEmpty(ranks[i].Text))
                    rankList.Add(ranks[i].Text);

            return rankList;
        }

        /// <summary>
        /// Updates the ranks.
        /// </summary>
        /// <param name="rankList">The rank list.</param>
        public void UpdateRanks(List<string> rankList)
        {
             for (int i = 0; i < rankList.Count; i++)
                UpdateRank(i, rankList[i]);
        }

        /// <summary>
        /// Handles the TextChanged event of the result control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void result_TextChanged(object sender, EventArgs e)
        {
            if (!changeGuard && ResultChanged != null)
                ResultChanged();
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the rank control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void rank_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!changeGuard && RankChanged != null)
                RankChanged();
        }

        /// <summary>
        /// Updates the result.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <param name="result">The result.</param>
        public void UpdateResult(int index, string result)
        {
            if (index >= results.Count)
                return;
            changeGuard = true;
            results[index].Text = result;
            changeGuard = false;
        }

        /// <summary>
        /// Cleans the results.
        /// </summary>
        public void CleanResults()
        {
            changeGuard = true;
            foreach (TextBox tb in results)
                tb.Text = string.Empty;

            foreach (ComboBox cb in ranks)
                cb.Text = string.Empty;
            changeGuard = false;
        }

        /// <summary>
        /// Cleans all.
        /// </summary>
        public void CleanAll()
        {
            CleanResults();
            plotModel.ClearAll();
        }

        /// <summary>
        /// Updates the rank.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <param name="rank">The rank.</param>
        public void UpdateRank(int index, string rank)
        {
            if (index >= ranks.Count)
                return;
            changeGuard = true;
            ranks[index].Text = rank;
            changeGuard = false;

        }

        /// <summary>
        /// Handles the Click event of the buttonCopy control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void buttonCopy_Click(object sender, EventArgs e)
        {
            if (CopyPressed != null)
                CopyPressed();
        }

        /// <summary>
        /// Sets the time minimum.
        /// </summary>
        /// <param name="timeMin">The time minimum.</param>
        public void SetTimeMinimum(double timeMin)
        {
            plotModel.SetTimeMinimum(timeMin);
        }
        #endregion
    }
}
