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
            this.buttonStopp = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.plot = new OxyPlot.WindowsForms.PlotView();
            this.runningTime = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.buttonReady = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.labelResult = new System.Windows.Forms.Label();
            this.labelLine1 = new System.Windows.Forms.Label();
            this.labelLine2 = new System.Windows.Forms.Label();
            this.labelLine3 = new System.Windows.Forms.Label();
            this.labelLine4 = new System.Windows.Forms.Label();
            this.labelLine5 = new System.Windows.Forms.Label();
            this.labelLine7 = new System.Windows.Forms.Label();
            this.labelLine6 = new System.Windows.Forms.Label();
            this.labelLine8 = new System.Windows.Forms.Label();
            this.labelLine9 = new System.Windows.Forms.Label();
            this.labelLine10 = new System.Windows.Forms.Label();
            this.result1 = new System.Windows.Forms.TextBox();
            this.result2 = new System.Windows.Forms.TextBox();
            this.result3 = new System.Windows.Forms.TextBox();
            this.result4 = new System.Windows.Forms.TextBox();
            this.result5 = new System.Windows.Forms.TextBox();
            this.result6 = new System.Windows.Forms.TextBox();
            this.result7 = new System.Windows.Forms.TextBox();
            this.result8 = new System.Windows.Forms.TextBox();
            this.result9 = new System.Windows.Forms.TextBox();
            this.result10 = new System.Windows.Forms.TextBox();
            this.rank1 = new System.Windows.Forms.ComboBox();
            this.rank2 = new System.Windows.Forms.ComboBox();
            this.rank3 = new System.Windows.Forms.ComboBox();
            this.rank4 = new System.Windows.Forms.ComboBox();
            this.rank5 = new System.Windows.Forms.ComboBox();
            this.rank6 = new System.Windows.Forms.ComboBox();
            this.rank7 = new System.Windows.Forms.ComboBox();
            this.rank8 = new System.Windows.Forms.ComboBox();
            this.rank9 = new System.Windows.Forms.ComboBox();
            this.rank10 = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(787, 144);
            this.tableLayoutPanel1.TabIndex = 0;
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
            // panel1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 5);
            this.panel1.Controls.Add(this.plot);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(781, 88);
            this.panel1.TabIndex = 0;
            // 
            // plot
            // 
            this.plot.BackColor = System.Drawing.Color.White;
            this.plot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plot.Location = new System.Drawing.Point(0, 0);
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
            this.plot.Size = new System.Drawing.Size(781, 88);
            this.plot.TabIndex = 1;
            this.plot.Text = "plot1";
            this.plot.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plot.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plot.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
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
            this.runningTime.Size = new System.Drawing.Size(409, 50);
            this.runningTime.TabIndex = 2;
            this.runningTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 362F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(793, 520);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel3.Controls.Add(this.labelResult, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.labelLine1, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.labelLine2, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.labelLine3, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.labelLine4, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.labelLine5, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.labelLine7, 0, 7);
            this.tableLayoutPanel3.Controls.Add(this.labelLine6, 0, 6);
            this.tableLayoutPanel3.Controls.Add(this.labelLine8, 0, 8);
            this.tableLayoutPanel3.Controls.Add(this.labelLine9, 0, 9);
            this.tableLayoutPanel3.Controls.Add(this.labelLine10, 0, 10);
            this.tableLayoutPanel3.Controls.Add(this.result1, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.result2, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.result3, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.result4, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.result5, 1, 5);
            this.tableLayoutPanel3.Controls.Add(this.result6, 1, 6);
            this.tableLayoutPanel3.Controls.Add(this.result7, 1, 7);
            this.tableLayoutPanel3.Controls.Add(this.result8, 1, 8);
            this.tableLayoutPanel3.Controls.Add(this.result9, 1, 9);
            this.tableLayoutPanel3.Controls.Add(this.result10, 1, 10);
            this.tableLayoutPanel3.Controls.Add(this.rank1, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.rank2, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.rank3, 2, 3);
            this.tableLayoutPanel3.Controls.Add(this.rank4, 2, 4);
            this.tableLayoutPanel3.Controls.Add(this.rank5, 2, 5);
            this.tableLayoutPanel3.Controls.Add(this.rank6, 2, 6);
            this.tableLayoutPanel3.Controls.Add(this.rank7, 2, 7);
            this.tableLayoutPanel3.Controls.Add(this.rank8, 2, 8);
            this.tableLayoutPanel3.Controls.Add(this.rank9, 2, 9);
            this.tableLayoutPanel3.Controls.Add(this.rank10, 2, 10);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 153);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 11;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(228, 344);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.BackColor = System.Drawing.Color.Black;
            this.labelResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel3.SetColumnSpan(this.labelResult, 3);
            this.labelResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResult.ForeColor = System.Drawing.Color.White;
            this.labelResult.Location = new System.Drawing.Point(1, 1);
            this.labelResult.Margin = new System.Windows.Forms.Padding(0);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(229, 30);
            this.labelResult.TabIndex = 9;
            this.labelResult.Text = "Results";
            this.labelResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelLine1
            // 
            this.labelLine1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLine1.AutoSize = true;
            this.labelLine1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLine1.ForeColor = System.Drawing.Color.White;
            this.labelLine1.Location = new System.Drawing.Point(4, 32);
            this.labelLine1.Name = "labelLine1";
            this.labelLine1.Size = new System.Drawing.Size(56, 30);
            this.labelLine1.TabIndex = 0;
            this.labelLine1.Text = "Bahn 1";
            this.labelLine1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelLine2
            // 
            this.labelLine2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLine2.AutoSize = true;
            this.labelLine2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLine2.ForeColor = System.Drawing.Color.White;
            this.labelLine2.Location = new System.Drawing.Point(4, 63);
            this.labelLine2.Name = "labelLine2";
            this.labelLine2.Size = new System.Drawing.Size(56, 30);
            this.labelLine2.TabIndex = 1;
            this.labelLine2.Text = "Bahn 2";
            this.labelLine2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelLine3
            // 
            this.labelLine3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLine3.AutoSize = true;
            this.labelLine3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLine3.ForeColor = System.Drawing.Color.White;
            this.labelLine3.Location = new System.Drawing.Point(4, 94);
            this.labelLine3.Name = "labelLine3";
            this.labelLine3.Size = new System.Drawing.Size(56, 30);
            this.labelLine3.TabIndex = 2;
            this.labelLine3.Text = "Bahn 3";
            this.labelLine3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelLine4
            // 
            this.labelLine4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLine4.AutoSize = true;
            this.labelLine4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLine4.ForeColor = System.Drawing.Color.White;
            this.labelLine4.Location = new System.Drawing.Point(4, 125);
            this.labelLine4.Name = "labelLine4";
            this.labelLine4.Size = new System.Drawing.Size(56, 30);
            this.labelLine4.TabIndex = 3;
            this.labelLine4.Text = "Bahn 4";
            this.labelLine4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelLine5
            // 
            this.labelLine5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLine5.AutoSize = true;
            this.labelLine5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLine5.ForeColor = System.Drawing.Color.White;
            this.labelLine5.Location = new System.Drawing.Point(4, 156);
            this.labelLine5.Name = "labelLine5";
            this.labelLine5.Size = new System.Drawing.Size(56, 30);
            this.labelLine5.TabIndex = 4;
            this.labelLine5.Text = "Bahn 5";
            this.labelLine5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelLine7
            // 
            this.labelLine7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLine7.AutoSize = true;
            this.labelLine7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLine7.ForeColor = System.Drawing.Color.White;
            this.labelLine7.Location = new System.Drawing.Point(4, 218);
            this.labelLine7.Name = "labelLine7";
            this.labelLine7.Size = new System.Drawing.Size(56, 30);
            this.labelLine7.TabIndex = 2;
            this.labelLine7.Text = "Bahn 7";
            this.labelLine7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelLine6
            // 
            this.labelLine6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLine6.AutoSize = true;
            this.labelLine6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLine6.ForeColor = System.Drawing.Color.White;
            this.labelLine6.Location = new System.Drawing.Point(4, 187);
            this.labelLine6.Name = "labelLine6";
            this.labelLine6.Size = new System.Drawing.Size(56, 30);
            this.labelLine6.TabIndex = 5;
            this.labelLine6.Text = "Bahn 6";
            this.labelLine6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelLine8
            // 
            this.labelLine8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLine8.AutoSize = true;
            this.labelLine8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLine8.ForeColor = System.Drawing.Color.White;
            this.labelLine8.Location = new System.Drawing.Point(4, 249);
            this.labelLine8.Name = "labelLine8";
            this.labelLine8.Size = new System.Drawing.Size(56, 30);
            this.labelLine8.TabIndex = 6;
            this.labelLine8.Text = "Bahn 8";
            this.labelLine8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelLine9
            // 
            this.labelLine9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLine9.AutoSize = true;
            this.labelLine9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLine9.ForeColor = System.Drawing.Color.White;
            this.labelLine9.Location = new System.Drawing.Point(4, 280);
            this.labelLine9.Name = "labelLine9";
            this.labelLine9.Size = new System.Drawing.Size(56, 30);
            this.labelLine9.TabIndex = 7;
            this.labelLine9.Text = "Bahn 9";
            this.labelLine9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelLine10
            // 
            this.labelLine10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLine10.AutoSize = true;
            this.labelLine10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLine10.ForeColor = System.Drawing.Color.White;
            this.labelLine10.Location = new System.Drawing.Point(4, 311);
            this.labelLine10.Name = "labelLine10";
            this.labelLine10.Size = new System.Drawing.Size(56, 32);
            this.labelLine10.TabIndex = 8;
            this.labelLine10.Text = "Bahn 10";
            this.labelLine10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // result1
            // 
            this.result1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.result1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result1.Location = new System.Drawing.Point(67, 35);
            this.result1.Name = "result1";
            this.result1.Size = new System.Drawing.Size(74, 22);
            this.result1.TabIndex = 0;
            this.result1.TextChanged += new System.EventHandler(this.result_TextChanged);
            // 
            // result2
            // 
            this.result2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.result2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result2.Location = new System.Drawing.Point(67, 66);
            this.result2.Name = "result2";
            this.result2.Size = new System.Drawing.Size(74, 22);
            this.result2.TabIndex = 11;
            this.result2.TextChanged += new System.EventHandler(this.result_TextChanged);
            // 
            // result3
            // 
            this.result3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.result3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result3.Location = new System.Drawing.Point(67, 97);
            this.result3.Name = "result3";
            this.result3.Size = new System.Drawing.Size(74, 22);
            this.result3.TabIndex = 12;
            this.result3.TextChanged += new System.EventHandler(this.result_TextChanged);
            // 
            // result4
            // 
            this.result4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.result4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result4.Location = new System.Drawing.Point(67, 128);
            this.result4.Name = "result4";
            this.result4.Size = new System.Drawing.Size(74, 22);
            this.result4.TabIndex = 13;
            this.result4.TextChanged += new System.EventHandler(this.result_TextChanged);
            // 
            // result5
            // 
            this.result5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.result5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result5.Location = new System.Drawing.Point(67, 159);
            this.result5.Name = "result5";
            this.result5.Size = new System.Drawing.Size(74, 22);
            this.result5.TabIndex = 14;
            this.result5.TextChanged += new System.EventHandler(this.result_TextChanged);
            // 
            // result6
            // 
            this.result6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.result6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result6.Location = new System.Drawing.Point(67, 190);
            this.result6.Name = "result6";
            this.result6.Size = new System.Drawing.Size(74, 22);
            this.result6.TabIndex = 15;
            this.result6.TextChanged += new System.EventHandler(this.result_TextChanged);
            // 
            // result7
            // 
            this.result7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.result7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result7.Location = new System.Drawing.Point(67, 221);
            this.result7.Name = "result7";
            this.result7.Size = new System.Drawing.Size(74, 22);
            this.result7.TabIndex = 16;
            this.result7.TextChanged += new System.EventHandler(this.result_TextChanged);
            // 
            // result8
            // 
            this.result8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.result8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result8.Location = new System.Drawing.Point(67, 252);
            this.result8.Name = "result8";
            this.result8.Size = new System.Drawing.Size(74, 22);
            this.result8.TabIndex = 17;
            this.result8.TextChanged += new System.EventHandler(this.result_TextChanged);
            // 
            // result9
            // 
            this.result9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.result9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result9.Location = new System.Drawing.Point(67, 283);
            this.result9.Name = "result9";
            this.result9.Size = new System.Drawing.Size(74, 22);
            this.result9.TabIndex = 18;
            this.result9.TextChanged += new System.EventHandler(this.result_TextChanged);
            // 
            // result10
            // 
            this.result10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.result10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result10.Location = new System.Drawing.Point(67, 314);
            this.result10.Name = "result10";
            this.result10.Size = new System.Drawing.Size(74, 22);
            this.result10.TabIndex = 19;
            this.result10.TextChanged += new System.EventHandler(this.result_TextChanged);
            // 
            // rank1
            // 
            this.rank1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rank1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rank1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rank1.FormattingEnabled = true;
            this.rank1.Items.AddRange(new object[] {
            "Leer",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.rank1.Location = new System.Drawing.Point(148, 35);
            this.rank1.Name = "rank1";
            this.rank1.Size = new System.Drawing.Size(79, 24);
            this.rank1.TabIndex = 20;
            this.rank1.SelectedIndexChanged += new System.EventHandler(this.rank_SelectedIndexChanged);
            // 
            // rank2
            // 
            this.rank2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rank2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rank2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rank2.FormattingEnabled = true;
            this.rank2.Items.AddRange(new object[] {
            "Leer",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.rank2.Location = new System.Drawing.Point(148, 66);
            this.rank2.Name = "rank2";
            this.rank2.Size = new System.Drawing.Size(79, 24);
            this.rank2.TabIndex = 21;
            this.rank2.SelectedIndexChanged += new System.EventHandler(this.rank_SelectedIndexChanged);
            // 
            // rank3
            // 
            this.rank3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rank3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rank3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rank3.FormattingEnabled = true;
            this.rank3.Items.AddRange(new object[] {
            "Leer",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.rank3.Location = new System.Drawing.Point(148, 97);
            this.rank3.Name = "rank3";
            this.rank3.Size = new System.Drawing.Size(79, 24);
            this.rank3.TabIndex = 22;
            this.rank3.SelectedIndexChanged += new System.EventHandler(this.rank_SelectedIndexChanged);
            // 
            // rank4
            // 
            this.rank4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rank4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rank4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rank4.FormattingEnabled = true;
            this.rank4.Items.AddRange(new object[] {
            "Leer",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.rank4.Location = new System.Drawing.Point(148, 128);
            this.rank4.Name = "rank4";
            this.rank4.Size = new System.Drawing.Size(79, 24);
            this.rank4.TabIndex = 23;
            this.rank4.SelectedIndexChanged += new System.EventHandler(this.rank_SelectedIndexChanged);
            // 
            // rank5
            // 
            this.rank5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rank5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rank5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rank5.FormattingEnabled = true;
            this.rank5.Items.AddRange(new object[] {
            "Leer",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.rank5.Location = new System.Drawing.Point(148, 159);
            this.rank5.Name = "rank5";
            this.rank5.Size = new System.Drawing.Size(79, 24);
            this.rank5.TabIndex = 24;
            this.rank5.SelectedIndexChanged += new System.EventHandler(this.rank_SelectedIndexChanged);
            // 
            // rank6
            // 
            this.rank6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rank6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rank6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rank6.FormattingEnabled = true;
            this.rank6.Items.AddRange(new object[] {
            "Leer",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.rank6.Location = new System.Drawing.Point(148, 190);
            this.rank6.Name = "rank6";
            this.rank6.Size = new System.Drawing.Size(79, 24);
            this.rank6.TabIndex = 25;
            this.rank6.SelectedIndexChanged += new System.EventHandler(this.rank_SelectedIndexChanged);
            // 
            // rank7
            // 
            this.rank7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rank7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rank7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rank7.FormattingEnabled = true;
            this.rank7.Items.AddRange(new object[] {
            "Leer",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.rank7.Location = new System.Drawing.Point(148, 221);
            this.rank7.Name = "rank7";
            this.rank7.Size = new System.Drawing.Size(79, 24);
            this.rank7.TabIndex = 26;
            this.rank7.SelectedIndexChanged += new System.EventHandler(this.rank_SelectedIndexChanged);
            // 
            // rank8
            // 
            this.rank8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rank8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rank8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rank8.FormattingEnabled = true;
            this.rank8.Items.AddRange(new object[] {
            "Leer",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.rank8.Location = new System.Drawing.Point(148, 252);
            this.rank8.Name = "rank8";
            this.rank8.Size = new System.Drawing.Size(79, 24);
            this.rank8.TabIndex = 27;
            this.rank8.SelectedIndexChanged += new System.EventHandler(this.rank_SelectedIndexChanged);
            // 
            // rank9
            // 
            this.rank9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rank9.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rank9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rank9.FormattingEnabled = true;
            this.rank9.Items.AddRange(new object[] {
            "Leer",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.rank9.Location = new System.Drawing.Point(148, 283);
            this.rank9.Name = "rank9";
            this.rank9.Size = new System.Drawing.Size(79, 24);
            this.rank9.TabIndex = 28;
            this.rank9.SelectedIndexChanged += new System.EventHandler(this.rank_SelectedIndexChanged);
            // 
            // rank10
            // 
            this.rank10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rank10.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rank10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rank10.FormattingEnabled = true;
            this.rank10.Items.AddRange(new object[] {
            "Leer",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.rank10.Location = new System.Drawing.Point(148, 314);
            this.rank10.Name = "rank10";
            this.rank10.Size = new System.Drawing.Size(79, 24);
            this.rank10.TabIndex = 29;
            this.rank10.SelectedIndexChanged += new System.EventHandler(this.rank_SelectedIndexChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(793, 520);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label labelLine1;
        private System.Windows.Forms.Label labelLine2;
        private System.Windows.Forms.Label labelLine3;
        private System.Windows.Forms.Label labelLine4;
        private System.Windows.Forms.Label labelLine5;
        private System.Windows.Forms.Label labelLine7;
        private System.Windows.Forms.Label labelLine6;
        private System.Windows.Forms.Label labelLine8;
        private System.Windows.Forms.Label labelLine9;
        private System.Windows.Forms.Label labelLine10;
        private System.Windows.Forms.TextBox result1;
        private System.Windows.Forms.TextBox result2;
        private System.Windows.Forms.TextBox result3;
        private System.Windows.Forms.TextBox result4;
        private System.Windows.Forms.TextBox result5;
        private System.Windows.Forms.TextBox result6;
        private System.Windows.Forms.TextBox result7;
        private System.Windows.Forms.TextBox result8;
        private System.Windows.Forms.TextBox result9;
        private System.Windows.Forms.TextBox result10;
        private System.Windows.Forms.ComboBox rank1;
        private System.Windows.Forms.ComboBox rank2;
        private System.Windows.Forms.ComboBox rank3;
        private System.Windows.Forms.ComboBox rank4;
        private System.Windows.Forms.ComboBox rank5;
        private System.Windows.Forms.ComboBox rank6;
        private System.Windows.Forms.ComboBox rank7;
        private System.Windows.Forms.ComboBox rank8;
        private System.Windows.Forms.ComboBox rank9;
        private System.Windows.Forms.ComboBox rank10;
    }
}

