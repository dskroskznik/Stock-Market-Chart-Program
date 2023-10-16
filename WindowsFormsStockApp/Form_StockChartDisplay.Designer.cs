namespace WindowsFormsStockApp
{
    partial class Form_StockChartDisplay
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_StockChartDisplay));
            this.chart_StockDataAndVolume = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.aCandleStickBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chart_StockDataAndVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCandleStickBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // chart_StockDataAndVolume
            // 
            this.chart_StockDataAndVolume.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.AlignWithChartArea = "ChartArea_Volume";
            chartArea1.AxisX.Title = "Dates";
            chartArea1.AxisY.LabelStyle.Format = "0";
            chartArea1.AxisY.Title = "Price(s)";
            chartArea1.Name = "ChartArea_Stock";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 45.5F;
            chartArea1.Position.Width = 79.61171F;
            chartArea1.Position.X = 3F;
            chartArea1.Position.Y = 3F;
            chartArea2.AlignWithChartArea = "ChartArea_Stock";
            chartArea2.AxisX.Title = "Dates";
            chartArea2.AxisY.Title = "Volume";
            chartArea2.Name = "ChartArea_Volume";
            chartArea2.Position.Auto = false;
            chartArea2.Position.Height = 45.5F;
            chartArea2.Position.Width = 79.61171F;
            chartArea2.Position.X = 8F;
            chartArea2.Position.Y = 51.5F;
            this.chart_StockDataAndVolume.ChartAreas.Add(chartArea1);
            this.chart_StockDataAndVolume.ChartAreas.Add(chartArea2);
            this.chart_StockDataAndVolume.DataSource = this.aCandleStickBindingSource;
            this.chart_StockDataAndVolume.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart_StockDataAndVolume.Legends.Add(legend1);
            this.chart_StockDataAndVolume.Location = new System.Drawing.Point(0, 0);
            this.chart_StockDataAndVolume.Name = "chart_StockDataAndVolume";
            this.chart_StockDataAndVolume.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chart_StockDataAndVolume.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            series1.ChartArea = "ChartArea_Stock";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Candlestick;
            series1.CustomProperties = "PriceDownColor=Red, PriceUpColor=Green";
            series1.IsXValueIndexed = true;
            series1.LabelToolTip = "Open: #VALY3\\nHigh: #VALY2\\nLow: #VALY1\\nClose: #VALY4\\nDate: #AXISLABEL";
            series1.Legend = "Legend1";
            series1.Name = "Ticker";
            series1.XValueMember = "DateTime";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series1.YValueMembers = "Low, High, Open, Close";
            series1.YValuesPerPoint = 4;
            series2.ChartArea = "ChartArea_Volume";
            series2.IsXValueIndexed = true;
            series2.LabelToolTip = "Volume: #VALY\\n Date: #VALX";
            series2.Legend = "Legend1";
            series2.Name = "Volume";
            series2.XValueMember = "DateTime";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series2.YValueMembers = "Volume";
            this.chart_StockDataAndVolume.Series.Add(series1);
            this.chart_StockDataAndVolume.Series.Add(series2);
            this.chart_StockDataAndVolume.Size = new System.Drawing.Size(947, 577);
            this.chart_StockDataAndVolume.TabIndex = 20;
            this.chart_StockDataAndVolume.Text = "Stock Data";
            this.chart_StockDataAndVolume.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chart_StockDataAndVolume_MouseMove);
            // 
            // aCandleStickBindingSource
            // 
            this.aCandleStickBindingSource.DataSource = typeof(WindowsFormsStockApp.aCandleStick);
            // 
            // Form_StockChartDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 577);
            this.Controls.Add(this.chart_StockDataAndVolume);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_StockChartDisplay";
            this.Text = "Stock Chart Display";
            ((System.ComponentModel.ISupportInitialize)(this.chart_StockDataAndVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCandleStickBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart_StockDataAndVolume;
        private System.Windows.Forms.BindingSource aCandleStickBindingSource;
    }
}