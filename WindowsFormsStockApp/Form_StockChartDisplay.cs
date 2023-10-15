using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsStockApp
{
    public partial class Form_StockChartDisplay : Form
    {
        public Form_StockChartDisplay()
        {
            InitializeComponent();
        }

        public void LoadDisplayChartCSV(string fileName, List<aCandleStick> candleStickList)
        {
            try
            {
                /* All chart settings implemented in code here */
                /* Some options manually entered in the designer and reverse engineered to candleStickList */
                /* Check Line: 78 */
                /*
                chart_StockDataAndVolume.DataSource = null;
                chart_StockDataAndVolume.Series.Clear();
                chart_StockDataAndVolume.ChartAreas.Clear();
                chart_StockDataAndVolume.ChartAreas.Add("ChartArea_Stock");
                chart_StockDataAndVolume.ChartAreas["ChartArea_Stock"].AxisX.MajorGrid.LineWidth = 0;
                chart_StockDataAndVolume.ChartAreas["ChartArea_Stock"].AxisY.MajorGrid.LineWidth = 0;

                decimal highestCandleStick = candleStickList.Max(maxCandleStick => maxCandleStick.high);
                chart_StockDataAndVolume.ChartAreas["ChartArea_Stock"].AxisY.Maximum = ((double)highestCandleStick) + 1;
                decimal lowestCandleStick = candleStickList.Min(minCandleStick => minCandleStick.low);
                chart_StockDataAndVolume.ChartAreas["ChartArea_Stock"].AxisY.Minimum = ((double)lowestCandleStick) - 1;
                chart_StockDataAndVolume.ChartAreas["ChartArea_Stock"].AxisY.LabelStyle.Format = "0";
                chart_StockDataAndVolume.ChartAreas["ChartArea_Stock"].BorderDashStyle = ChartDashStyle.Solid;

                chart_StockDataAndVolume.Series.Add("Ticker");
                chart_StockDataAndVolume.Series["Ticker"].ChartType = SeriesChartType.Candlestick;
                chart_StockDataAndVolume.Series["Ticker"].XValueMember = "DateTime";
                chart_StockDataAndVolume.Series["Ticker"].XValueType = ChartValueType.DateTime;
                chart_StockDataAndVolume.Series["Ticker"].YValueMembers = "Low, High, Open, Close";
                chart_StockDataAndVolume.Series["Ticker"]["ShowOpenClose"] = "Both";
                chart_StockDataAndVolume.Series["Ticker"]["PointWidth"] = "0.9";
                chart_StockDataAndVolume.DataManipulator.IsStartFromFirst = true;
                
                chart_StockDataAndVolume.ChartAreas.Add("ChartArea_Volume");
                chart_StockDataAndVolume.ChartAreas["ChartArea_Volume"].AxisX.MajorGrid.LineWidth = 0;
                chart_StockDataAndVolume.ChartAreas["ChartArea_Volume"].AxisY.MajorGrid.LineWidth = 0;
                chart_StockDataAndVolume.ChartAreas["ChartArea_Volume"].AxisY.MajorGrid.LineWidth = 0;
                chart_StockDataAndVolume.ChartAreas["ChartArea_Volume"].AxisY.MajorGrid.LineWidth = 0;

                long peakVolume = candleStickList.Max(peak => peak.volume);
                chart_StockDataAndVolume.ChartAreas["ChartArea_Volume"].AxisY.Maximum = (peakVolume) + 1;
                long floorVolume = candleStickList.Min(floor => floor.volume);
                chart_StockDataAndVolume.ChartAreas["ChartArea_Volume"].AxisY.Minimum = (floorVolume) - 1;
                chart_StockDataAndVolume.ChartAreas["ChartArea_Volume"].AxisY.LabelStyle.Format = "0";
                chart_StockDataAndVolume.ChartAreas["ChartArea_Volume"].BorderDashStyle = ChartDashStyle.Solid;

                chart_StockDataAndVolume.Series.Add("Volume");
                chart_StockDataAndVolume.Series["Volume"].ChartType = SeriesChartType.Column;
                chart_StockDataAndVolume.Series["Volume"].XValueMember = "DateTime";
                chart_StockDataAndVolume.Series["Volume"].XValueType = ChartValueType.DateTime;
                chart_StockDataAndVolume.Series["Volume"].YValueMembers = "Volume";
                chart_StockDataAndVolume.DataManipulator.IsStartFromFirst = true;
                */
                candleStickList.Reverse();
                candleStickList.Reverse();
                chart_StockDataAndVolume.DataSource = candleStickList;
                chart_StockDataAndVolume.DataBind();
                for (int value = 0; value < candleStickList.Count; value++)
                {
                    decimal priceOpen = candleStickList[value].open;
                    decimal priceClose = candleStickList[value].close;

                    if (priceOpen > priceClose)
                    {
                        chart_StockDataAndVolume.Series["Ticker"].Points[value]["PriceDownColor"] = "Red";
                        chart_StockDataAndVolume.Series["Ticker"].Points[value]["PriceUpColor"] = "Red";
                    }
                    else
                    {
                        chart_StockDataAndVolume.Series["Ticker"].Points[value]["PriceUpColor"] = "Green";
                        chart_StockDataAndVolume.Series["Ticker"].Points[value]["PriceDownColor"] = "Green";
                    }
                } 
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an ERROR successfully loading Chart Data Source.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chart_StockDataAndVolume_MouseMove(object sender, MouseEventArgs e)
        {
            HitTestResult result1 = chart_StockDataAndVolume.HitTest(e.X, e.Y);

            if (result1.ChartElementType == ChartElementType.DataPoint)
            {
                string tooltipTextStock = $"Open: {chart_StockDataAndVolume.Series[0].Points[result1.PointIndex].YValues[2]:F2}" +
                    $"\nHigh: {chart_StockDataAndVolume.Series[0].Points[result1.PointIndex].YValues[1]:F2}" +
                    $"\nLow: {chart_StockDataAndVolume.Series[0].Points[result1.PointIndex].YValues[0]:F2}" +
                    $"\nClose: {chart_StockDataAndVolume.Series[0].Points[result1.PointIndex].YValues[3]:F2}" +
                    $"\nDate: {chart_StockDataAndVolume.Series[0].Points[result1.PointIndex].XValue:F2}";

                chart_StockDataAndVolume.Series[0].ToolTip = tooltipTextStock;

            }
            HitTestResult result2 = chart_StockDataAndVolume.HitTest(e.X, e.Y);

            if (result2.ChartElementType == ChartElementType.DataPoint)
            {
                string tooltipTextVolume = $"Volume: {chart_StockDataAndVolume.Series[1].Points[result2.PointIndex].YValues[0]:F2}";

                chart_StockDataAndVolume.Series[1].ToolTip = tooltipTextVolume;
            }
            else
            {
                chart_StockDataAndVolume.Series[0].ToolTip = string.Empty;
            }
        }
    }
}
