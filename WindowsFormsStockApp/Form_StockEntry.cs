using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsStockApp
{
    public partial class Form_StockEntry : Form
    {
        public Form_StockEntry()
        {
            InitializeComponent();
        }
        /*private void Form_StockEntry_Load(object sender, EventArgs e)
        {
            this.aCandleStickTableAdapter.Fill();
        }
        */

        public void LoadDataCSV(string filename, List<aCandleStick> candleStickData)
        {
            try
            {
                dataGridView_StockData.DataSource = null;
                dataGridView_StockData.Refresh();
                dataGridView_StockData.Rows.Clear();
                dataGridView_StockData.Columns.Clear();
                aCandleStickBindingSource.EndEdit();
                dataGridView_StockData.AutoGenerateColumns = true;
                

                var candleStickProperties = typeof(aCandleStick).GetProperties();
                foreach (var prop in candleStickProperties)
                {
                    dataGridView_StockData.Columns.Add(prop.Name, prop.Name);
                }
               
                foreach(var data in candleStickData)    
                {
                    int rowIndex = dataGridView_StockData.Rows.Add();
                    dataGridView_StockData.Rows[rowIndex].Cells["Ticker"].Value = data.ticker;
                    dataGridView_StockData.Rows[rowIndex].Cells["Period"].Value = data.period;
                    dataGridView_StockData.Rows[rowIndex].Cells["DateTime"].Value = data.datetime;
                    dataGridView_StockData.Rows[rowIndex].Cells["Open"].Value = data.open;
                    dataGridView_StockData.Rows[rowIndex].Cells["High"].Value = data.high;
                    dataGridView_StockData.Rows[rowIndex].Cells["Low"].Value = data.low;
                    dataGridView_StockData.Rows[rowIndex].Cells["Close"].Value = data.close;
                    dataGridView_StockData.Rows[rowIndex].Cells["Volume"].Value = data.volume;
                }                                
            }
            catch 
            {
                MessageBox.Show("There was an ERROR successfuly loading CSV Data Source.","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void LoadChartCSV(string fileName, List<aCandleStick> candleStickChart)
        {
            try
            {
                chart_StockData.DataSource = null;
                chart_StockData.ChartAreas["ChartArea_Stock"].AxisX.MajorGrid.LineWidth = 0;
                chart_StockData.ChartAreas["ChartArea_Stock"].AxisY.MajorGrid.LineWidth = 0;
                chart_StockData.Series.Clear();
                string ticker = Path.GetFileNameWithoutExtension(openFileDialog_OpenStock.FileName);
                var series = chart_StockData.Series.Add(ticker);
                
                series.XValueMember = "DateTime";
                series.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
                foreach(var candle in candleStickChart)
                {
                    var data = new DataPoint
                    {
                        XValue = candle.datetime.ToOADate(),
                        YValues = new[]
                        {
                            (double)candle.open, (double)candle.high, (double)candle.low, (double)candle.close
                        }
                    };

                    series.Points.Add(data);
                }

                series.CustomProperties = "PriceDownColor=Red, PriceUpColor=Green";
                series["ShowOpenClose"] = "Both";
                //series["OpenCloseStyle"] = "Triangle";
                
                //chart_StockData.DataManipulator.IsStartFromFirst = true;
                chart_StockData.DataSource = candleStickChart;
                chart_StockData.DataBind();
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
            string webLink = "https://finance.yahoo.com/trending-tickers";
            Process.Start(webLink);
        }
        private void toolTip_WebLink_Popup(object sender, PopupEventArgs e)
        {
            toolTip_WebLink.SetToolTip(button_WebLink, "");
        }

        private void toolTip_HelpBox_Popup(object sender, PopupEventArgs e)
        {
            toolTip_HelpBox.SetToolTip(button_Help, "");
        }
        private void comboBox_Stock_DropDown(object sender, EventArgs e)
        {   //filenames directory path
            string dirPath = "../../../Stock Data";
            //string test = Path.GetFullPath("../../../Stock Data");
            string selectedTime = comboBox_TimeInt.Text.ToLower();

            if (Directory.Exists(dirPath))
            {
                string[] filePath = Directory.GetFiles(dirPath, "*.csv");

                foreach (string names in filePath)
                {
                    string stockNames = Path.GetFileNameWithoutExtension(names);
                    string[] stockNameParts = stockNames.Split('-');
                    string stockTimeInt = stockNameParts.Last().ToLower();

                    if (!comboBox_Stock.Items.Contains(stockNames))
                    {
                        comboBox_Stock.Items.Add(stockNames);
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
            DialogResult fileDialog = openFileDialog_OpenStock.ShowDialog();
            if (fileDialog == DialogResult.OK)
            {
                //String refString = "\"Ticker\",\"Period\",\"Date\",\"Open\",\"High\",\"Low\"\"Close\"";
                string fileName = openFileDialog_OpenStock.FileName;
                string selFile = Path.GetFileName(openFileDialog_OpenStock.FileName);
                textBox_StockSelected.Text = selFile;

                CSVread csvHelp = new CSVread();
                List<aCandleStick> candleSticks = new List<aCandleStick>();
                csvHelp.RecordCSVList(fileName, candleSticks);

            }
        }
        private void button_SubmitStock_Click(object sender, EventArgs e)
        {
            string fileName = openFileDialog_OpenStock.FileName;
            CSVread csvHelp = new CSVread();
            List<aCandleStick> candleSticks = new List<aCandleStick>();
            csvHelp.RecordCSVList(fileName, candleSticks);
            LoadDataCSV(fileName, candleSticks);
            LoadChartCSV(fileName, candleSticks);
            //String message = "This is the CSV file you selected: \n" + Path.GetFileName(fileName);
            //MessageBox.Show(message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        private void button_ClearFile_Click(object sender, EventArgs e)
        {
            textBox_StockSelected.Clear();
            openFileDialog_OpenStock.FileName = string.Empty;
            dataGridView_StockData.Rows.Clear();
            dataGridView_StockData.Columns.Clear();
        }
    }
}


