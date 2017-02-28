using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeSystem.View
{
    interface IMainForm
    {
        #region Events
        /// <summary>
        /// Occurs when [start clicked].
        /// </summary>
        event System.Action StartClicked;
        /// <summary>
        /// Occurs when [stop clicked].
        /// </summary>
        event System.Action StopClicked;
        /// <summary>
        /// Occurs when [ready clicked].
        /// </summary>
        event System.Action ReadyClicked;
        /// <summary>
        /// Ruler moved event
        /// </summary>
        event System.Action RulerMoved;
        /// <summary>
        /// Occurs when [ruler removed].
        /// </summary>
        event System.Action<double> RulerRemoved;
        /// <summary>
        /// Occurs when [ruler added].
        /// </summary>
        event System.Action<double> RulerAdded;
        /// <summary>
        /// Occurs when [result changed].
        /// </summary>
        event System.Action ResultChanged;
        /// <summary>
        /// Occurs when [position changed].
        /// </summary>
        event System.Action RankChanged;
        #endregion

        /// <summary>
        /// Sets the running time.
        /// </summary>
        /// <value>
        /// The running time.
        /// </value>
        string RunningTime { set; }

        /// <summary>
        /// Adds the point.
        /// </summary>
        /// <param name="time">The time.</param>
        /// <param name="signal">if set to <c>true</c> [signal].</param>
        void AddPoint(double time, bool signal);

        /// <summary>
        /// Gets the ruler positions.
        /// </summary>
        /// <returns>Return a list with all ruler positions</returns>
        List<double> GetRulerPositions();

        /// <summary>
        /// Adds the rulers.
        /// </summary>
        void AddRulers();

        /// <summary>
        /// Updates the result.
        /// </summary>
        /// <param name="resultList">The result list.</param>
        void UpdateResults(List<string> resultList);

        /// <summary>
        /// Updates the result.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <param name="result">The result.</param>
        void UpdateResult(int index, string result);

        /// <summary>
        /// Cleans the results.
        /// </summary>
        void CleanResults();

        /// <summary>
        /// Gets the result.
        /// </summary>
        /// <returns>
        /// Return the result as string
        /// </returns>
        List<string> GetResults();

        /// <summary>
        /// Gets the positions.
        /// </summary>
        /// <returns>Return a list of all positions</returns>
        List<string> GetRanks();

        /// <summary>
        /// Updates the ranks.
        /// </summary>
        /// <param name="rankList">The rank list.</param>
        void UpdateRanks(List<string> rankList);

        /// <summary>
        /// Updates the rank.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <param name="rank">The rank.</param>
        void UpdateRank(int index, string rank);
    }
}
