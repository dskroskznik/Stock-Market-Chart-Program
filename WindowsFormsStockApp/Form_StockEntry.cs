using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.DirectoryServices;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Net.WebRequestMethods;

namespace WindowsFormsStockApp
{
    public partial class Form_StockEntry : Form
    {
        public Form_StockEntry()
        {
            InitializeComponent();
            comboBox_StockFill();
        }
            
        private Form_StockChartDisplay stockChartDisplay;
        //filenames directory path
        string dirPath = "../../../Stock Data";

        private void LoadDataCSV(string filename, List<aCandleStick> candleStickData)
        {
            try
            {
                dataGridView_StockData.DataSource = null;
                dataGridView_StockData.Refresh();
                dataGridView_StockData.Rows.Clear();
                dataGridView_StockData.Columns.Clear();
                dataGridView_StockData.AutoGenerateColumns = true;

                
                var candleStickProperties = typeof(aCandleStick).GetProperties();
                foreach(var prop in candleStickProperties)
                {
                    dataGridView_StockData.Columns.Add(prop.Name, prop.Name);
                }
               
                foreach(var data in candleStickData)    
                {
                    int rowIndex = dataGridView_StockData.Rows.Add();
                    dataGridView_StockData.Rows[rowIndex].Cells["DateTime"].Value = data.datetime;
                    dataGridView_StockData.Rows[rowIndex].Cells["Open"].Value = data.open;
                    dataGridView_StockData.Rows[rowIndex].Cells["High"].Value = data.high;
                    dataGridView_StockData.Rows[rowIndex].Cells["Low"].Value = data.low;
                    dataGridView_StockData.Rows[rowIndex].Cells["Close"].Value = data.close;
                    dataGridView_StockData.Rows[rowIndex].Cells["Volume"].Value = data.volume;
                }
                dataGridView_StockData.Refresh();

            }
            catch 
            {
                MessageBox.Show("There was an ERROR successfuly loading CSV Data Source.","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void LoadCandlestickChartCSV(string fileName, List<aCandleStick> candleStickList)
        {
            try
            {
                /* All chart settings implemented in code here */
                /* But manually entered in the designer and reverse engineered to candleStickList */
                /* Check Line: 96 */
                /*
                chart_StockData.DataSource = null;
                chart_StockData.Series.Clear();
                chart_StockData.ChartAreas.Clear();
                chart_StockData.ChartAreas.Add("ChartArea_Stock");
                chart_StockData.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
                chart_StockData.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;

                string ticker = Path.GetFileNameWithoutExtension(openFileDialog_OpenStock.FileName);
                
                decimal highestCandleStick = candleStickList.Max(maxCandleStick => maxCandleStick.high);
                chart_StockData.ChartAreas[0].AxisY.Maximum = ((double)highestCandleStick) + 1;
                decimal lowestCandleStick = candleStickList.Min(minCandleStick => minCandleStick.low);
                chart_StockData.ChartAreas[0].AxisY.Minimum = ((double)lowestCandleStick) - 1;
                chart_StockData.ChartAreas[0].AxisY.LabelStyle.Format = "0";
                chart_StockData.ChartAreas[0].BorderDashStyle = ChartDashStyle.Solid;

                chart_StockData.Series.Add("Ticker");
                chart_StockData.Series["Ticker"].ChartType = SeriesChartType.Candlestick;
                chart_StockData.Series["Ticker"].XValueMember = "DateTime";
                chart_StockData.Series["Ticker"].XValueType = ChartValueType.DateTime;
                chart_StockData.Series["Ticker"].YValueMembers = "Low, High, Open, Close";
                chart_StockData.Series["Ticker"]["ShowOpenClose"] = "Both";
                chart_StockData.Series["Ticker"]["PointWidth"] = "1.0";
                chart_StockData.DataManipulator.IsStartFromFirst = true;
                */
                candleStickList.Reverse();
                chart_StockData.DataSource = candleStickList;
                chart_StockData.DataBind();

                for(int value=0; value<candleStickList.Count;value++)
                {
                    decimal priceOpen = candleStickList[value].open;
                    decimal priceClose = candleStickList[value].close;
                    
                    if(priceOpen > priceClose) {
                        chart_StockData.Series["Ticker"].Points[value]["PriceDownColor"] = "Red";
                        chart_StockData.Series["Ticker"].Points[value]["PriceUpColor"] = "Red";

                    }
                    else {
                        chart_StockData.Series["Ticker"].Points[value]["PriceUpColor"] = "Green";
                        chart_StockData.Series["Ticker"].Points[value]["PriceDownColor"] = "Green";
                    }
                }
               
            }
            catch (Exception ex) 
            {
                MessageBox.Show("There was an ERROR successfuly loading Chart Data Source.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_Help_Click(object sender, EventArgs e)
        {
            string helpText = " -- How To Use -- \n\n Stock And Time:\n\tSelect the stock ticker of your choosing ";
            MessageBox.Show(helpText, "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button_WebLink_Click(object sender, EventArgs e)
        {
            if((MessageBox.Show("This link will transport you off the app. \n Would Like To Proceed?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes))
            {
                string webLink = "https://finance.yahoo.com/trending-tickers";
                Process.Start(webLink);
            }
            else { }           
        }
        private void toolTip_WebLink_Popup(object sender, PopupEventArgs e)
        {
            toolTip_WebLink.SetToolTip(button_WebLink, "");
        }

        private void toolTip_HelpBox_Popup(object sender, PopupEventArgs e)
        {
            toolTip_HelpBox.SetToolTip(button_Help, "");
        }
        private void comboBox_StockFill()
        { 
            if(Directory.Exists(dirPath))
            {
                string[] filePath = Directory.GetFiles(dirPath);
                foreach (string files in filePath)
                {
                    string fileNames = Path.GetFileNameWithoutExtension(files);
                    string[] fileNameParts = fileNames.Split('-');
                    if(fileNameParts[0].Length >= 3)
                    {
                        string stockTickers = fileNameParts[0];
                        if (!comboBox_Stock.Items.Contains(stockTickers))
                        {
                               comboBox_Stock.Items.Add(stockTickers);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Error Occurred: Directory does not exist", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void comboBox_Stock_SelectedIndexChanged(object sender, EventArgs e)
        {
            dateTimePicker_StartDate.Value = DateTime.Now;
            dateTimePicker_EndDate.Value = DateTime.Now;
            comboBox_TimeInt.Text = "Daily";
            string timeInterval = comboBox_TimeInt.Text;
            string stockName = comboBox_Stock.Text;
            string filePathName;
            if(textBox_StockSelected.Enabled == true)
            {
                filePathName = LocateFileCSV(stockName, timeInterval);
                CSVread csvHelp = new CSVread();
                List<aCandleStick> candleStickList = new List<aCandleStick>();
                csvHelp.RecordCSVList(filePathName, candleStickList);
                for (int i = 0; i < candleStickList.Count; i++)
                {
                    dateTimePicker_StartDate.Value = candleStickList[i].datetime;
                }
            }
        }
        private void comboBox_TimeInt_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedTime = comboBox_TimeInt.Text.ToLower();

            if(Directory.Exists(dirPath))
            {
                string[] filePath = Directory.GetFiles(dirPath);

                foreach(string files in filePath)
                {
                    /**/
                    string fileNames = Path.GetFileNameWithoutExtension(files);
                    string[] fileNameParts = fileNames.Split('-');
                    string timeInterval = fileNameParts[1];

                    if(selectedTime == "daily" && timeInterval == "Day")
                    {
                        string stockTickers = fileNameParts[0];
                        if (!comboBox_Stock.Items.Contains(stockTickers))
                        {
                            comboBox_Stock.Items.Add(stockTickers);
                        }
                    }
                    else if(selectedTime == "weekly" && timeInterval == "Week")
                    {
                        string stockTickers = fileNameParts[0];
                        if (!comboBox_Stock.Items.Contains(stockTickers))
                        {
                            comboBox_Stock.Items.Add(stockTickers);
                        }
                    }
                    else if(selectedTime == "monthly" && timeInterval == "Month")
                    {
                        string stockTickers = fileNameParts[0];
                        if (!comboBox_Stock.Items.Contains(stockTickers))
                        {
                            comboBox_Stock.Items.Add(stockTickers);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Error Occurred: Directory does not exist", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button_OpenFile_Click(object sender, EventArgs e)
        {
            textBox_StockSelected.Enabled = false;
            comboBox_Stock.Enabled = false;
            comboBox_TimeInt.Enabled = false;
            comboBox_Stock.Text = null;
            comboBox_TimeInt.Text = null;
            DialogResult fileDialog = openFileDialog_OpenStock.ShowDialog();
            if(fileDialog == DialogResult.OK)
            {
                //String refString = "\"Ticker\",\"Period\",\"Date\",\"Open\",\"High\",\"Low\"\"Close\"";
                string selFile = Path.GetFileName(openFileDialog_OpenStock.FileName);
                textBox_StockSelected.Text = selFile;
                textBox_StockSelected.Text.Normalize();
                CSVread csvHelp = new CSVread();
                List<aCandleStick> candleStickList = new List<aCandleStick>();
                string fileName = openFileDialog_OpenStock.FileName;
                csvHelp.RecordCSVList(fileName, candleStickList);
                for (int i = 0; i < candleStickList.Count; i++)
                {
                    dateTimePicker_StartDate.Value = candleStickList[i].datetime;
                }

            }
            else
            {
                MessageBox.Show("Error Occurred: File does not exist", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private string LocateFileCSV(string stockTickerName, string stockTimeInterval)
        {
            string filePath = "";
            if(Directory.Exists(dirPath))
            {
                if((comboBox_TimeInt.Enabled == true) || (comboBox_TimeInt.Enabled == true))
                {
                    string[] files = Directory.GetFiles(dirPath, stockTickerName + "-*", SearchOption.TopDirectoryOnly);

                    foreach (string file in files)
                    {
                        string fileNames = Path.GetFileNameWithoutExtension(file);
                        string[] fileNameParts = fileNames.Split('-');
                        string timeInterval = fileNameParts[1];

                        if (stockTimeInterval.ToLower() == "daily" && timeInterval == "Day") 
                        {
                            filePath = Path.GetFullPath(file);
                        }
                        else if(stockTimeInterval.ToLower() == "weekly" && timeInterval == "Week")
                        {
                            filePath = Path.GetFullPath(file);
                        }
                        else if(stockTimeInterval.ToLower() == "monthly" && timeInterval == "Month")
                        {
                            filePath = Path.GetFullPath(file);
                        }
                    }
                }
                else 
                { 
                    MessageBox.Show("Error Occurred: Fill in all options", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Error Occurred: File does not exist", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return filePath;
        }
        private void button_SubmitStock_Click(object sender, EventArgs e)
        {
            CSVread csvHelp = new CSVread();
            List<aCandleStick> candleSticks = new List<aCandleStick>();
            DateTime startDate = dateTimePicker_StartDate.Value;
            DateTime endDate = dateTimePicker_EndDate.Value;
            string fileDialogName = openFileDialog_OpenStock.FileName;
            string stockName = comboBox_Stock.Text;
            string timeInterval = comboBox_TimeInt.Text;
            string filePathName;

            if(textBox_StockSelected.Enabled == true)
            {
                filePathName = LocateFileCSV(stockName, timeInterval);
                csvHelp.RecordCSVList(filePathName, candleSticks);
                List<aCandleStick> filteredCandleStickData = csvHelp.FilterCSVList(candleSticks, startDate.AddDays(-1), endDate.AddDays(-1));
                LoadDataCSV(filePathName, filteredCandleStickData);
                if ((checkBox_Volume.Checked))
                {
                    if (stockChartDisplay == null || stockChartDisplay.IsDisposed)
                    {
                        stockChartDisplay = new Form_StockChartDisplay();
                        LoadCandlestickChartCSV(filePathName, filteredCandleStickData);
                        stockChartDisplay.LoadDisplayChartCSV(filePathName, filteredCandleStickData);
                        stockChartDisplay.Show();
                    }
                    else if (stockChartDisplay != null)
                    {
                        stockChartDisplay = new Form_StockChartDisplay();
                        LoadCandlestickChartCSV(filePathName, filteredCandleStickData);
                        stockChartDisplay.LoadDisplayChartCSV(filePathName, filteredCandleStickData);
                        stockChartDisplay.Show();
                    }
                }
                else
                {
                    stockChartDisplay?.Dispose();
                    LoadCandlestickChartCSV(filePathName, filteredCandleStickData);
                }
            }
            else
            {
                csvHelp.RecordCSVList(fileDialogName, candleSticks);
                List<aCandleStick> filteredCandleStickData = csvHelp.FilterCSVList(candleSticks, startDate.AddDays(-1), endDate.AddDays(-1));
                LoadDataCSV(fileDialogName, filteredCandleStickData);
                if ((checkBox_Volume.Checked))
                {
                    if (stockChartDisplay == null || stockChartDisplay.IsDisposed)
                    {
                        stockChartDisplay = new Form_StockChartDisplay();
                        LoadCandlestickChartCSV(fileDialogName, filteredCandleStickData);
                        stockChartDisplay.LoadDisplayChartCSV(fileDialogName, filteredCandleStickData);
                        stockChartDisplay.Show();
                    }
                    else if (stockChartDisplay != null)
                    {
                        stockChartDisplay = new Form_StockChartDisplay();
                        LoadCandlestickChartCSV(fileDialogName, filteredCandleStickData);
                        stockChartDisplay.LoadDisplayChartCSV(fileDialogName, filteredCandleStickData);
                        stockChartDisplay.Show();
                    }
                }
                else
                {
                    stockChartDisplay?.Dispose();
                    LoadCandlestickChartCSV(fileDialogName, filteredCandleStickData);
                }
            }
            
            //String message = "This is the CSV file you selected: \n" + Path.GetFileName(fileName);
            //MessageBox.Show(message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void linkLabel_Name_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if((MessageBox.Show("This link will transport you off the app. \n Would Like To Proceed?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes))
            { 
                string webLink = "https://www.github.com/dskroskznik";
                Process.Start(webLink);
            }
            else { }
        }
        private void chart_StockData_MouseMove(object sender, MouseEventArgs e)
        {
            HitTestResult result = chart_StockData.HitTest(e.X, e.Y);

            if (result.ChartElementType == ChartElementType.DataPoint)
            {
                string tooltipText = $"Open: {chart_StockData.Series[0].Points[result.PointIndex].YValues[2]:F2}" +
                    $"\nHigh: {chart_StockData.Series[0].Points[result.PointIndex].YValues[1]:F2}" +
                    $"\nLow: {chart_StockData.Series[0].Points[result.PointIndex].YValues[0]:F2}" +
                    $"\nClose: {chart_StockData.Series[0].Points[result.PointIndex].YValues[3]:F2}" +
                    $"\nDate: {chart_StockData.Series[0].Points[result.PointIndex].XValue:F2}";

                chart_StockData.Series[0].ToolTip = tooltipText;
            }
            else
            {
                chart_StockData.Series[0].ToolTip = string.Empty;
            }
        }
        private void button_ClearFile_Click(object sender, EventArgs e)
        {
            dateTimePicker_StartDate.Value = DateTime.Now;
            dateTimePicker_EndDate.Value = DateTime.Now;
            comboBox_Stock.Text = string.Empty;
            comboBox_TimeInt.Text = string.Empty;
            comboBox_Stock.Enabled = true;
            comboBox_TimeInt.Enabled = true;
            textBox_StockSelected.Enabled = true;
            textBox_StockSelected.Clear();
            openFileDialog_OpenStock.FileName = string.Empty;
            dataGridView_StockData.Rows.Clear();
            stockChartDisplay?.Dispose();
            comboBox_StockFill();

        }
    }
}


