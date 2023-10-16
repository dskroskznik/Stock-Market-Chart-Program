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

/*  COP4365 Software System Development - Project 1 */
/*  Stock Entry App by Dylan Skroskznik */
namespace WindowsFormsStockApp
{
    public partial class Form_StockChartDisplay : Form
    {
        public Form_StockChartDisplay()
        {
            /*  Initialize form components and launch form   */
            InitializeComponent();
        }

        /*  Load in Stock Date CSV file from Stock Data folder into the Stock Chart */
        public void LoadDisplayChartCSV(string fileName, List<aCandleStick> candleStickList)
        {
            try
            {
                /* All chart settings implemented in code here */
                /* Some options manually entered in the designer and engineered to candleStickList */
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
                /*  Reverses candlestick list in proper ascending order for charts   */
                candleStickList.Reverse();
                candleStickList.Reverse();
                /*  Grabs datasource from candlestick list object parameter passed in and binds  */
                chart_StockDataAndVolume.DataSource = candleStickList;
                chart_StockDataAndVolume.DataBind();
                /*  Logic function to assigned colors in accordance to stock opening and closing data   */
                for (int value = 0; value < candleStickList.Count; value++)
                {
                    decimal priceOpen = candleStickList[value].open;
                    decimal priceClose = candleStickList[value].close;

                    /*  stock opening price is greater than close, it down trends and is red*/
                    if (priceOpen > priceClose)
                    {
                        chart_StockDataAndVolume.Series["Ticker"].Points[value]["PriceDownColor"] = "Red";
                        chart_StockDataAndVolume.Series["Ticker"].Points[value]["PriceUpColor"] = "Red";
                    }
                    /*  otherwise it will be up trending and be green   */
                    else
                    {
                        chart_StockDataAndVolume.Series["Ticker"].Points[value]["PriceUpColor"] = "Green";
                        chart_StockDataAndVolume.Series["Ticker"].Points[value]["PriceDownColor"] = "Green";
                    }
                } 
                
            }
            catch
            {
                MessageBox.Show("There was an ERROR successfully loading Chart Data Source.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*  Displays specific candlestick and volume data when mouse is over the object  */
        private void chart_StockDataAndVolume_MouseMove(object sender, MouseEventArgs e)
        {
            /*  mouse hitting movement handler if its over correct position */
            HitTestResult result1 = chart_StockDataAndVolume.HitTest(e.X, e.Y);

            /* performs if mouse over specific chart elements   */
            if (result1.ChartElementType == ChartElementType.DataPoint)
            {
                /* Convert X Axis value from double to DateTime */
                double xValue = chart_StockDataAndVolume.Series[0].Points[result1.PointIndex].XValue;
                DateTime xDateTime = DateTime.FromOADate(xValue);
                string tooltipTextStock = $"Open: {chart_StockDataAndVolume.Series[0].Points[result1.PointIndex].YValues[2]:F2}" +
                    $"\nHigh: {chart_StockDataAndVolume.Series[0].Points[result1.PointIndex].YValues[1]:F2}" +
                    $"\nLow: {chart_StockDataAndVolume.Series[0].Points[result1.PointIndex].YValues[0]:F2}" +
                    $"\nClose: {chart_StockDataAndVolume.Series[0].Points[result1.PointIndex].YValues[3]:F2}" +
                    $"\nDate: {xDateTime:yyyy-MM-dd}";

                /*  assigned tooltip from string    */
                chart_StockDataAndVolume.Series[0].ToolTip = tooltipTextStock;

            }
            /*  mouse hitting movement handler if its over correct position */
            HitTestResult result2 = chart_StockDataAndVolume.HitTest(e.X, e.Y);

            /* performs if mouse over specific chart elements   */
            if (result2.ChartElementType == ChartElementType.DataPoint)
            {
                /* Convert X Axis value from double to DateTime */
                double xValue = chart_StockDataAndVolume.Series[0].Points[result1.PointIndex].XValue;
                DateTime xDateTime = DateTime.FromOADate(xValue);
                string tooltipTextVolume = $"Volume: {chart_StockDataAndVolume.Series[1].Points[result2.PointIndex].YValues[0]:F2}" +
                    $"\nDate: {xDateTime:yyyy-MM-dd}";

                /*  assigned tooltip from string    */
                chart_StockDataAndVolume.Series[1].ToolTip = tooltipTextVolume;
            }
            else
            {
                /*  tooltip is set to empty otherwise   */
                chart_StockDataAndVolume.Series[0].ToolTip = string.Empty;
                chart_StockDataAndVolume.Series[1].ToolTip = string.Empty;
            }
        }
    }
}
