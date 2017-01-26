namespace TimeSystem.View
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            OxyPlot.PlotModel plotModel1 = new OxyPlot.PlotModel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.plot = new OxyPlot.WindowsForms.PlotView();
            this.labelTime = new System.Windows.Forms.Label();
            this.runningTime = new System.Windows.Forms.Label();
            this.buttonReady = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStopp = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.buttonStopp, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonStart, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.runningTime, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelTime, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonReady, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(793, 445);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 5);
            this.panel1.Controls.Add(this.plot);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 50);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(793, 107);
            this.panel1.TabIndex = 0;
            // 
            // plot
            // 
            this.plot.BackColor = System.Drawing.Color.White;
            this.plot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plot.Location = new System.Drawing.Point(0, 0);
            this.plot.Margin = new System.Windows.Forms.Padding(0);
            plotModel1.AxisTierDistance = 4D;
            plotModel1.Culture = null;
            plotModel1.DefaultColors = null;
            plotModel1.DefaultFont = "Segoe UI";
            plotModel1.DefaultFontSize = 12D;
            plotModel1.IsLegendVisible = true;
            plotModel1.LegendBorderThickness = 1D;
            plotModel1.LegendColumnSpacing = 0D;
            plotModel1.LegendFont = null;
            plotModel1.LegendFontSize = 12D;
            plotModel1.LegendFontWeight = 400D;
            plotModel1.LegendItemAlignment = OxyPlot.HorizontalAlignment.Left;
            plotModel1.LegendItemOrder = OxyPlot.LegendItemOrder.Normal;
            plotModel1.LegendItemSpacing = 24D;
            plotModel1.LegendLineSpacing = 0D;
            plotModel1.LegendMargin = 8D;
            plotModel1.LegendMaxHeight = double.NaN;
            plotModel1.LegendMaxWidth = double.NaN;
            plotModel1.LegendOrientation = OxyPlot.LegendOrientation.Vertical;
            plotModel1.LegendPadding = 8D;
            plotModel1.LegendPlacement = OxyPlot.LegendPlacement.Inside;
            plotModel1.LegendPosition = OxyPlot.LegendPosition.RightTop;
            plotModel1.LegendSymbolLength = 16D;
            plotModel1.LegendSymbolMargin = 4D;
            plotModel1.LegendSymbolPlacement = OxyPlot.LegendSymbolPlacement.Left;
            plotModel1.LegendTitle = null;
            plotModel1.LegendTitleFont = null;
            plotModel1.LegendTitleFontSize = 12D;
            plotModel1.LegendTitleFontWeight = 700D;
            plotModel1.PlotType = OxyPlot.PlotType.XY;
            plotModel1.RenderingDecorator = null;
            plotModel1.Subtitle = null;
            plotModel1.SubtitleFont = null;
            plotModel1.SubtitleFontSize = 14D;
            plotModel1.SubtitleFontWeight = 400D;
            plotModel1.Title = null;
            plotModel1.TitleFont = null;
            plotModel1.TitleFontSize = 18D;
            plotModel1.TitleFontWeight = 700D;
            plotModel1.TitleHorizontalAlignment = OxyPlot.TitleHorizontalAlignment.CenteredWithinPlotArea;
            plotModel1.TitlePadding = 6D;
            plotModel1.TitleToolTip = null;
            this.plot.Model = plotModel1;
            this.plot.Name = "plot";
            this.plot.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plot.Size = new System.Drawing.Size(793, 107);
            this.plot.TabIndex = 1;
            this.plot.Text = "plot1";
            this.plot.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plot.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plot.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.BackColor = System.Drawing.Color.Black;
            this.labelTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.ForeColor = System.Drawing.Color.White;
            this.labelTime.Location = new System.Drawing.Point(318, 0);
            this.labelTime.Margin = new System.Windows.Forms.Padding(0);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(60, 50);
            this.labelTime.TabIndex = 1;
            this.labelTime.Text = "Zeit";
            this.labelTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // runningTime
            // 
            this.runningTime.AutoSize = true;
            this.runningTime.BackColor = System.Drawing.Color.Black;
            this.runningTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.runningTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runningTime.ForeColor = System.Drawing.Color.White;
            this.runningTime.Location = new System.Drawing.Point(378, 0);
            this.runningTime.Margin = new System.Windows.Forms.Padding(0);
            this.runningTime.Name = "runningTime";
            this.runningTime.Size = new System.Drawing.Size(415, 50);
            this.runningTime.TabIndex = 2;
            this.runningTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonReady
            // 
            this.buttonReady.AutoSize = true;
            this.buttonReady.BackColor = System.Drawing.Color.White;
            this.buttonReady.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonReady.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.buttonReady.FlatAppearance.BorderSize = 2;
            this.buttonReady.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReady.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReady.Location = new System.Drawing.Point(215, 3);
            this.buttonReady.MinimumSize = new System.Drawing.Size(100, 0);
            this.buttonReady.Name = "buttonReady";
            this.buttonReady.Size = new System.Drawing.Size(100, 44);
            this.buttonReady.TabIndex = 3;
            this.buttonReady.Text = "Ready";
            this.buttonReady.UseVisualStyleBackColor = false;
            this.buttonReady.Click += new System.EventHandler(this.buttonReady_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.AutoSize = true;
            this.buttonStart.BackColor = System.Drawing.Color.White;
            this.buttonStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonStart.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.buttonStart.FlatAppearance.BorderSize = 2;
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.Location = new System.Drawing.Point(3, 3);
            this.buttonStart.MinimumSize = new System.Drawing.Size(100, 0);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(100, 44);
            this.buttonStart.TabIndex = 4;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonStopp
            // 
            this.buttonStopp.AutoSize = true;
            this.buttonStopp.BackColor = System.Drawing.Color.White;
            this.buttonStopp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonStopp.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.buttonStopp.FlatAppearance.BorderSize = 2;
            this.buttonStopp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStopp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStopp.Location = new System.Drawing.Point(109, 3);
            this.buttonStopp.MinimumSize = new System.Drawing.Size(100, 0);
            this.buttonStopp.Name = "buttonStopp";
            this.buttonStopp.Size = new System.Drawing.Size(100, 44);
            this.buttonStopp.TabIndex = 5;
            this.buttonStopp.Text = "Stop";
            this.buttonStopp.UseVisualStyleBackColor = false;
            this.buttonStopp.Click += new System.EventHandler(this.buttonStopp_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(793, 445);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private OxyPlot.WindowsForms.PlotView plot;
        private System.Windows.Forms.Label runningTime;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonReady;
        private System.Windows.Forms.Button buttonStopp;
    }
}

