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
    class PlotModel: OxyPlot.PlotModel  
    {
        StairStepSeries serie;

        public PlotModel()
        {
            Background = OxyColors.Black;
            PlotAreaBorderColor = OxyColors.White;
            PlotAreaBorderThickness = new OxyThickness(1.0, 0.0, 0.0, 1.0);
            Axes.Add(new LinearAxis
                        {
                            Position = AxisPosition.Bottom,
                            Minimum = 0, TextColor = OxyColors.White,
                            AxislineColor = OxyColors.White,
                            MajorGridlineColor =  OxyColors.White,
                            TicklineColor = OxyColors.White,
                            FontWeight = 800.0
                             
            });
            Axes.Add(new LinearAxis
                        {
                            Position = AxisPosition.Left,
                            Minimum = -0.5, Maximum = 1.2,
                            IsZoomEnabled = false
            });
            // Add a line series
            serie = new StairStepSeries();
            serie.Color = OxyColors.SkyBlue;
            serie.MarkerStroke = OxyColors.White;
            serie.MarkerFill = OxyColors.SkyBlue;
            serie.MarkerStrokeThickness = 2;
         
            Series.Add(serie);

            AddPoint(0.0, 0);
            AddPoint(10.2, 1);
            AddPoint(10.5, 0);
     
            AddPoint(10.75, 1);
            AddPoint(11.2, 0);
            AddPoint(12.4, 1);
            AddPoint(13.0, 0);
            AddPoint(15.0, 0);

            AddRulersToPulses();
        }

        public void AddRulersToPulses()
        {
            foreach (DataPoint dp in serie.Points)
            {
                if (dp.Y == 1.0)
                    AddRuler(dp.X);
            }
        }

        public void AddPoint(double x, double y)
        {
            serie.Points.Add(new DataPoint(x, y));
        }

        public List<double> GetAllRulerPositions()
        {
            List<double> rulerPositions = new List<double>();

            foreach (LineAnnotation la in Annotations)
                rulerPositions.Add(la.X);

            rulerPositions.Sort();
            return rulerPositions;
        }

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

        private void RemoveRuler(LineAnnotation lineAnnotation)
        {
            int pos = Annotations.IndexOf(lineAnnotation);
            lineAnnotation.MouseDown -= La_MouseDown;
            lineAnnotation.MouseMove -= La_MouseMove;
            lineAnnotation.MouseUp -= La_MouseUp;
            Annotations.Remove(lineAnnotation);
        }

        private void La_MouseUp(object sender, OxyMouseEventArgs e)
        {
            ((LineAnnotation)sender).StrokeThickness /= 3;
            InvalidatePlot(false);
            e.Handled = true;
        }

        private void La_MouseMove(object sender, OxyMouseEventArgs e)
        {
            ((LineAnnotation)sender).X = ((LineAnnotation)sender).InverseTransform(e.Position).X;
            InvalidatePlot(false);
            e.Handled = true;
        }

        private void La_MouseDown(object sender, OxyMouseDownEventArgs e)
        {
            LineAnnotation lineAnnotation = ((LineAnnotation)sender);
            if (e.ChangedButton != OxyMouseButton.Left)
            {
                return;
            }
                 
            lineAnnotation.StrokeThickness *= 3;
            
            InvalidatePlot(false);
            e.Handled = true;
        } 
    }
}
