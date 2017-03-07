using OxyPlot;
using OxyPlot.Annotations;
using OxyPlot.Axes;
using OxyPlot.Series;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeSystem.View
{
    /// <summary>
    /// Model of oxyplot data
    /// </summary>
    /// <seealso cref="OxyPlot.PlotModel" />
    class PlotModel : OxyPlot.PlotModel  
    {
        #region Fields        
        /// <summary>
        /// The serie
        /// </summary>
        private StairStepSeries serie;

        /// <summary>
        /// The left axis
        /// </summary>
        private Axis leftAxis;

        /// <summary>
        /// The bottom axis
        /// </summary>
        private Axis bottomAxis;
        #endregion

        #region Events        
        /// <summary>
        /// Ruler moved event
        /// </summary>
        public event System.Action RulerMoved;

        /// <summary>
        /// Occurs when [mouse double clicked].
        /// </summary>
        public event System.Action<double> MouseDoubleClicked;

        /// <summary>
        /// Occurs when [ruler double clicked].
        /// </summary>
        public event System.Action<double> RulerDoubleClicked;
        #endregion

        public PlotModel()
        {
            Background = OxyColors.Black;
            PlotAreaBorderColor = OxyColors.White;
            PlotAreaBorderThickness = new OxyThickness(1.0, 0.0, 0.0, 1.0);
            bottomAxis = new LinearAxis
            {
                Position = AxisPosition.Bottom,
                Minimum = 0,
                TextColor = OxyColors.White,
                AxislineColor = OxyColors.White,
                MajorGridlineColor = OxyColors.White,
                TicklineColor = OxyColors.White,
                FontWeight = 800.0

            };
            Axes.Add(bottomAxis);
            leftAxis = new LinearAxis
            {
                Position = AxisPosition.Left,
                Minimum = -0.5,
                AbsoluteMinimum = -0.5,
                Maximum = 1.2,
                AbsoluteMaximum = 1.2,
                IsZoomEnabled = false,
            };
            Axes.Add(leftAxis);
            // Add a line series
            serie = new StairStepSeries();
            serie.Color = OxyColors.SkyBlue;
            serie.MarkerStroke = OxyColors.White;
            serie.MarkerFill = OxyColors.SkyBlue;
            serie.MarkerStrokeThickness = 2;
         
            Series.Add(serie);

            MouseDown += PlotModel_MouseDown;
        }

        /// <summary>
        /// Handles the MouseDown event of the PlotModel control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="OxyMouseDownEventArgs"/> instance containing the event data.</param>
        private void PlotModel_MouseDown(object sender, OxyMouseDownEventArgs e)
        {
            if (e.ClickCount == 2)
            {
                DataPoint p = OxyPlot.Axes.Axis.InverseTransform(e.Position, bottomAxis, leftAxis);

                AddRuler(p.X);
                InvalidatePlot(false);
                if (MouseDoubleClicked != null)
                    MouseDoubleClicked(p.X);
            }
        }

        /// <summary>
        /// Adds the rulers to pulses.
        /// </summary>
        public void AddRulersToPulses()
        {
            foreach (DataPoint dp in serie.Points)
            {
                if (dp.Y == 1.0)
                    AddRuler(dp.X);
            }
            InvalidatePlot(true);
        }

        /// <summary>
        /// Adds the point.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        public void AddPoint(double x, double y)
        {
            serie.Points.Add(new DataPoint(x, y));
            InvalidatePlot(true);
        }

        /// <summary>
        /// Gets all ruler positions.
        /// </summary>
        /// <returns>Return list of all ruler positions</returns>
        public List<double> GetAllRulerPositions()
        {
            List<double> rulerPositions = new List<double>();

            foreach (LineAnnotation la in Annotations)
                rulerPositions.Add(la.X);

            rulerPositions.Sort();
            return rulerPositions;
        }

        /// <summary>
        /// Clears all.
        /// </summary>
        public void ClearAll()
        {
            serie.Points.Clear();
            foreach (LineAnnotation lineAnnotation in Annotations)
            {
                lineAnnotation.MouseDown -= La_MouseDown;
                lineAnnotation.MouseMove -= La_MouseMove;
                lineAnnotation.MouseUp -= La_MouseUp;
            }
            Annotations.Clear();
            InvalidatePlot(false);
        }

        /// <summary>
        /// Adds the ruler.
        /// </summary>
        /// <param name="x">The x.</param>
        private void AddRuler(double x)
        {
            LineAnnotation lineAnnotation = new LineAnnotation();
            lineAnnotation.Type = LineAnnotationType.Vertical;
            lineAnnotation.Color = OxyColors.Yellow;
            lineAnnotation.LineStyle = LineStyle.Solid;
            
            lineAnnotation.X = x;

            lineAnnotation.MouseDown += La_MouseDown;
            lineAnnotation.MouseMove += La_MouseMove;
            lineAnnotation.MouseUp += La_MouseUp;
            
            Annotations.Add(lineAnnotation);
        }

        /// <summary>
        /// Removes the ruler.
        /// </summary>
        /// <param name="lineAnnotation">The line annotation.</param>
        private void RemoveRuler(LineAnnotation lineAnnotation)
        {
            int pos = Annotations.IndexOf(lineAnnotation);
            lineAnnotation.MouseDown -= La_MouseDown;
            lineAnnotation.MouseMove -= La_MouseMove;
            lineAnnotation.MouseUp -= La_MouseUp;
            Annotations.Remove(lineAnnotation);
        }

        /// <summary>
        /// Handles the MouseUp event of the La control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="OxyMouseEventArgs"/> instance containing the event data.</param>
        private void La_MouseUp(object sender, OxyMouseEventArgs e)
        {
            ((LineAnnotation)sender).StrokeThickness /= 3;
            InvalidatePlot(false);
            e.Handled = true;
        }

        /// <summary>
        /// Handles the MouseMove event of the La control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="OxyMouseEventArgs"/> instance containing the event data.</param>
        private void La_MouseMove(object sender, OxyMouseEventArgs e)
        {
            ((LineAnnotation)sender).X = ((LineAnnotation)sender).InverseTransform(e.Position).X;
            InvalidatePlot(false);
            e.Handled = true;

            if (RulerMoved != null)
                RulerMoved();
        }

        /// <summary>
        /// Handles the MouseDown event of the La control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="OxyMouseDownEventArgs"/> instance containing the event data.</param>
        private void La_MouseDown(object sender, OxyMouseDownEventArgs e)
        {
            LineAnnotation lineAnnotation = ((LineAnnotation)sender);
            if (e.ClickCount == 2)
            {
                if (RulerDoubleClicked != null)
                    RulerDoubleClicked(lineAnnotation.X);

                Annotations.Remove(lineAnnotation);
            }
            else
            {
                if (e.ChangedButton != OxyMouseButton.Left)
                {
                    return;
                }

                lineAnnotation.StrokeThickness *= 3;

            }
            InvalidatePlot(false);
            e.Handled = true;
        }

        /// <summary>
        /// Sets the time minimum.
        /// </summary>
        /// <param name="timeMin">The time minimum.</param>
        public void SetTimeMinimum(double timeMin)
        {
            bottomAxis.Minimum = timeMin;
            InvalidatePlot(false);
        }
    }
}
