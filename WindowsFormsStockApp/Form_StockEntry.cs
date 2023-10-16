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

/*  COP4365 Software System Development - Project 1 */
/*  Stock Entry App by Dylan Skroskznik */
namespace WindowsFormsStockApp
{
    public partial class Form_StockEntry : Form
    {
        public Form_StockEntry()
        {
            /*  Initialize form components and launch form   */
            InitializeComponent();
            /*  Function call fills comboBox_Stock with stock/ticker names  */
            comboBox_StockFill();
        }

        /*  Global declarations, one a private form object && string for stored stock csv data  */
        private Form_StockChartDisplay stockChartDisplay;
        string dirPath = "../../../Stock Data";

        /*  Load in Stock Date CSV file from Stock Data folder into the DataGridView */
        private void LoadDataCSV(string filename, List<aCandleStick> candleStickData)
        {
            try
            {   /*  Clear & refresh the data grid view for new data */
                dataGridView_StockData.DataSource = null;
                dataGridView_StockData.Refresh();
                dataGridView_StockData.Rows.Clear();
                dataGridView_StockData.Columns.Clear();
                dataGridView_StockData.AutoGenerateColumns = true;

                /*  Creates columns in the format of the aCandlestick class properties */
                /*  And adds those columns into the the data grid view */
                var candleStickProperties = typeof(aCandleStick).GetProperties();
                foreach(var prop in candleStickProperties)
                {
                    dataGridView_StockData.Columns.Add(prop.Name, prop.Name);
                }
               
                /*  Populate data grid view with all candlestick row data */
                /*  associated with the candlestick data value */
                foreach(var data in candleStickData)    
                {
                    /*  includes each row by index and fills in those cells in given order */
                    int rowIndex = dataGridView_StockData.Rows.Add();
                    dataGridView_StockData.Rows[rowIndex].Cells["DateTime"].Value = data.datetime;
                    dataGridView_StockData.Rows[rowIndex].Cells["Open"].Value = data.open;
                    dataGridView_StockData.Rows[rowIndex].Cells["High"].Value = data.high;
                    dataGridView_StockData.Rows[rowIndex].Cells["Low"].Value = data.low;
                    dataGridView_StockData.Rows[rowIndex].Cells["Close"].Value = data.close;
                    dataGridView_StockData.Rows[rowIndex].Cells["Volume"].Value = data.volume;
                }
                /*  Refreshes stock datagridview with data for safety */
                dataGridView_StockData.Refresh();

            }
            catch 
            {
                MessageBox.Show("There was an ERROR successfuly loading CSV Data Source.","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        /*  Load in Stock Date CSV file from Stock Data folder into the Stock Chart */
        private void LoadCandlestickChartCSV(string fileName, List<aCandleStick> candleStickList)
        {
            try
            {
                /* All chart settings implemented in code here  */
                /* But manually entered in the designer and engineered to candleStickList */
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
                /*  Reverses candlestick list in proper ascending order for charts   */
                /*  newest stock entry down to oldest   */
                candleStickList.Reverse();
                /*  Grabs datasource from candlestick list object parameter passed in and binds  */
                chart_StockData.DataSource = candleStickList;
                chart_StockData.DataBind();
                /*  Logic function to assigned colors in accordance to stock opening and closing data   */
                for(int value=0; value<candleStickList.Count;value++)
                {
                    decimal priceOpen = candleStickList[value].open;
                    decimal priceClose = candleStickList[value].close;
                    
                    /*  stock opening price is greater than close, it down trends and is red*/
                    if(priceOpen > priceClose) {
                        chart_StockData.Series["Ticker"].Points[value]["PriceDownColor"] = "Red";
                        chart_StockData.Series["Ticker"].Points[value]["PriceUpColor"] = "Red";

                    }
                    /*  otherwise it will be up trending and be green   */
                    else {
                        chart_StockData.Series["Ticker"].Points[value]["PriceUpColor"] = "Green";
                        chart_StockData.Series["Ticker"].Points[value]["PriceDownColor"] = "Green";
                    }
                }
               
            }
            catch 
            {
                MessageBox.Show("There was an ERROR successfuly loading Chart Data Source.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /*  Addition help button: when clicked displays instructions for applications use    */
        private void button_Help_Click(object sender, EventArgs e)
        {
            string helpText = " -- How To Use -- \n\n " +
                "Selecting Stock:\n\tSelect the stock name and time interval " +
                "\n\tfrom the dropdown boxes or directly select " +
                "\n\tyour own stock csv file. You are welcome to " +
                "\n\tshow both candlestick and volume charts as well. " +
                "\nSelecting Dates:\n\tDates for each stock selected will auto-generate " +
                "\n\tthe start date at the beginning, use each date " +
                "\n\tpick to display the stock data within " +
                "\n\ttheir date ranges. " +
                "\nSubmit:\n\tYou will only be able to submit a chart using" +
                "\n\tone select option at a time. ";
            MessageBox.Show(helpText, "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        /*  Additional website button: when clicked displays prompt to move to finance website */
        private void button_WebLink_Click(object sender, EventArgs e)
        {
            if((MessageBox.Show("This link will transport you to \"https://finance.yahoo.com\". \n Would Like To Proceed?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes))
            {
                string webLink = "https://finance.yahoo.com/trending-tickers";
                Process.Start(webLink);
            }
        }
        /*  Tooltip descriptor for the website button   */
        private void toolTip_WebLink_Popup(object sender, PopupEventArgs e)
        {
            toolTip_WebLink.SetToolTip(button_WebLink, "");
        }
        /*  Tooltip descriptor for the help button   */
        private void toolTip_HelpBox_Popup(object sender, PopupEventArgs e)
        {
            toolTip_HelpBox.SetToolTip(button_Help, "");
        }
        /*  Populates stock combobox of stock names after form is initialized and executed   */
        private void comboBox_StockFill()
        { 
            /*  when directory for stock data is found, executes filteration for populating */
            if(Directory.Exists(dirPath))
            {
                /*  loops through files in filepath */
                string[] filePath = Directory.GetFiles(dirPath);
                foreach (string files in filePath)
                {
                    /*  extracts file parts pertaining to stock names/tickers   */
                    string fileNames = Path.GetFileNameWithoutExtension(files);
                    string[] fileNameParts = fileNames.Split('-');
                    if(fileNameParts[0].Length >= 3)
                    {
                        /* if ticker is not already in combobox, plop it in */
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
        /*  Functioned to work around what ever stock you load in, the object will change with it   */
        /*  Event handles for stock selection changing and adjust other object around the new selection  */
        private void comboBox_Stock_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*  changes selection objects according to the stock you select */
            dateTimePicker_StartDate.Value = DateTime.Now;
            dateTimePicker_EndDate.Value = DateTime.Now;
            comboBox_TimeInt.Text = "Daily";
            string timeInterval = comboBox_TimeInt.Text;
            string stockName = comboBox_Stock.Text;
            string filePathName;
            /*  function to load stock file and edit start  */
            /*  date to the start date of the stock chart    */
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
        /*  Event handles for time interval data changes and researches the files again */
        /*  and edits the stock combobox to only show files available for the time interval */
        private void comboBox_TimeInt_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*  change time interval to lowercase   */
            string selectedTime = comboBox_TimeInt.Text.ToLower();
            
            /*  when directory for stock data is found, executes filteration for populating */
            if (Directory.Exists(dirPath))
            {
                /*  loops through files in filepath */
                string[] filePath = Directory.GetFiles(dirPath);

                foreach(string files in filePath)
                {
                    /*  extracts file parts pertaining to stock names/tickers   */
                    string fileNames = Path.GetFileNameWithoutExtension(files);
                    string[] fileNameParts = fileNames.Split('-');
                    string timeInterval = fileNameParts[1];
                    /*  file filtering conditions for grabbing specific stock data files  */
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
        /*  Opens file explorer dialog box when button for directly selecting csv stock file    */
        private void button_OpenFile_Click(object sender, EventArgs e)
        {
            /*  sets combobox options to disable when using direct selection to avoid overlap of selections */
            textBox_StockSelected.Enabled = false;
            comboBox_Stock.Enabled = false;
            comboBox_TimeInt.Enabled = false;
            comboBox_Stock.Text = null;
            comboBox_TimeInt.Text = null;
            /*  displays file dialog box to selecting a file    */
            DialogResult fileDialog = openFileDialog_OpenStock.ShowDialog();
            if(fileDialog == DialogResult.OK)
            {
                /*  gets file name in the path, places file name text in textbox    */
                /*  and reads csv file and records the data into a candlestick object    */
                string selFile = Path.GetFileName(openFileDialog_OpenStock.FileName);
                textBox_StockSelected.Text = selFile;
                textBox_StockSelected.Text.Normalize();
                CSVread csvHelp = new CSVread();
                List<aCandleStick> candleStickList = new List<aCandleStick>();
                string fileName = openFileDialog_OpenStock.FileName;
                csvHelp.RecordCSVList(fileName, candleStickList);
                /*  searches datetime column and changes start date picker to beginning stock date*/
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
        /*  Location of csv file path for combobox selection only and returns filedirectory string  */
        private string LocateFileCSV(string stockTickerName, string stockTimeInterval)
        {
            string filePath = "";
            /*  continues if stockdata folder exists    */
            if(Directory.Exists(dirPath))
            {
                /*  when comboboxes are enabled, start searching through files  */
                if((comboBox_TimeInt.Enabled == true) || (comboBox_TimeInt.Enabled == true))
                {
                    /*  locates files only in the stock data folder that match the selected stock ticker name */
                    string[] files = Directory.GetFiles(dirPath, stockTickerName + "-*", SearchOption.TopDirectoryOnly);

                    foreach (string file in files)
                    {
                        /*  extracts file parts pertaining to stock names/tickers   */
                        string fileNames = Path.GetFileNameWithoutExtension(file);
                        string[] fileNameParts = fileNames.Split('-');
                        string timeInterval = fileNameParts[1];
                        /*  file filtering conditions for grabbing specific stock file directory  */
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
            /*  returns full file path found    */
            return filePath;
        }
        /* Submission button: handles all csv data loaded in and constructs objects */
        /*  to display results in charts and datagridview */
        private void button_SubmitStock_Click(object sender, EventArgs e)
        {
            /*  handles the submission of stock data displaying*/
            CSVread csvHelp = new CSVread(); /* instance of csvhelper for data handling */
            List<aCandleStick> candleSticks = new List<aCandleStick>(); /* instance of a candlestick list for storing csv data */
            /*  grabs start date and end date values for filtering data displayed   */
            DateTime startDate = dateTimePicker_StartDate.Value;
            DateTime endDate = dateTimePicker_EndDate.Value;
            /*  values for file name handling and locating the specific stock files */
            string fileDialogName = openFileDialog_OpenStock.FileName;
            string stockName = comboBox_Stock.Text;
            string timeInterval = comboBox_TimeInt.Text;
            string filePathName;

            /*  checks if textbox for displaying filename in direct file selection is true  */
            /*  if textbox is enabled the user must be using comboboxes to search and submit stock files  */
            if (textBox_StockSelected.Enabled == true)
            {
                /*  calls locating csv stock file with name and timeinterval    */
                /*  records finding with csv helper and fitlers data selection from start/end date values submitted    */
                filePathName = LocateFileCSV(stockName, timeInterval);
                csvHelp.RecordCSVList(filePathName, candleSticks);
                List<aCandleStick> filteredCandleStickData = csvHelp.FilterCSVList(candleSticks, startDate.AddDays(-1), endDate.AddDays(-1));
                /*  loads stock data to datagridview    */
                LoadDataCSV(filePathName, filteredCandleStickData);
                /*  when show chart with volume checked: display charts with candlesticks and volume    */
                if ((checkBox_Volume.Checked))
                {
                    /*  checks for any existing or non-existing other chart forms open  */
                    if (stockChartDisplay == null || stockChartDisplay.IsDisposed)
                    {
                        /*  creates new form and calls candlestick charter to display both charts */
                        stockChartDisplay = new Form_StockChartDisplay();
                        LoadCandlestickChartCSV(filePathName, filteredCandleStickData);
                        stockChartDisplay.LoadDisplayChartCSV(filePathName, filteredCandleStickData);
                        stockChartDisplay.Show();
                    }
                    else if (stockChartDisplay != null)
                    {
                        /*  creates new form and calls candlestick charter to display both charts */
                        stockChartDisplay = new Form_StockChartDisplay();
                        LoadCandlestickChartCSV(filePathName, filteredCandleStickData);
                        stockChartDisplay.LoadDisplayChartCSV(filePathName, filteredCandleStickData);
                        stockChartDisplay.Show();
                    }
                }
                /*  when unchecked: just display candlestick chart data in the form, and dispose any open forms*/
                else
                {
                    stockChartDisplay?.Dispose();
                    LoadCandlestickChartCSV(filePathName, filteredCandleStickData);
                }
            }
            /*  else: if textbox is disabled the user must have loaded in a stock csv file directly     */
            else
            {
                /*  records filedialog selection with csv helper and fitlers data   */
                /*  selection from start/end date values submitted    */
                csvHelp.RecordCSVList(fileDialogName, candleSticks);
                List<aCandleStick> filteredCandleStickData = csvHelp.FilterCSVList(candleSticks, startDate.AddDays(-1), endDate.AddDays(-1));
                /*  loads stock data to datagridview    */
                LoadDataCSV(fileDialogName, filteredCandleStickData);
                /*  when show chart with volume checked: display charts with candlesticks and volume    */
                if ((checkBox_Volume.Checked))
                {
                    /*  checks for any existing or non-existing other chart forms open  */
                    if (stockChartDisplay == null || stockChartDisplay.IsDisposed)
                    {
                        /*  creates new form and calls candlestick charter to display both charts */
                        stockChartDisplay = new Form_StockChartDisplay();
                        LoadCandlestickChartCSV(fileDialogName, filteredCandleStickData);
                        stockChartDisplay.LoadDisplayChartCSV(fileDialogName, filteredCandleStickData);
                        stockChartDisplay.Show();
                    }
                    else if (stockChartDisplay != null)
                    {
                        /*  creates new form and calls candlestick charter to display both charts */
                        stockChartDisplay = new Form_StockChartDisplay();
                        LoadCandlestickChartCSV(fileDialogName, filteredCandleStickData);
                        stockChartDisplay.LoadDisplayChartCSV(fileDialogName, filteredCandleStickData);
                        stockChartDisplay.Show();
                    }
                }
                /*  when unchecked: just display candlestick chart data in the form, and dispose any open forms*/
                else
                {
                    stockChartDisplay?.Dispose();
                    LoadCandlestickChartCSV(fileDialogName, filteredCandleStickData);
                }
            }
        }
        /*  Addtional function: link label with my name and link to github  */
        private void linkLabel_Name_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if((MessageBox.Show("This link will transport you off the app. \n Would Like To Proceed?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes))
            { 
                string webLink = "https://www.github.com/dskroskznik";
                Process.Start(webLink);
            }
            else { }
        }
        /*  Displays specific candlestick data when mouse is over the object  */
        private void chart_StockData_MouseMove(object sender, MouseEventArgs e)
        {
            /*  mouse hitting movement handler if its over correct position */
            HitTestResult result = chart_StockData.HitTest(e.X, e.Y);
            /* performs if mouse over specific chart elements   */
            if (result.ChartElementType == ChartElementType.DataPoint)
            {
                /* Convert X Axis value from double to DateTime */
                double xValue = chart_StockData.Series[0].Points[result.PointIndex].XValue;
                DateTime xDateTime = DateTime.FromOADate(xValue);
                string tooltipText = $"Open: {chart_StockData.Series[0].Points[result.PointIndex].YValues[2]:F2}" +
                    $"\nHigh: {chart_StockData.Series[0].Points[result.PointIndex].YValues[1]:F2}" +
                    $"\nLow: {chart_StockData.Series[0].Points[result.PointIndex].YValues[0]:F2}" +
                    $"\nClose: {chart_StockData.Series[0].Points[result.PointIndex].YValues[3]:F2}" +
                    $"\nDate: {xDateTime:yyyy-MM-dd}";
                /*  assigned tooltip from string    */
                chart_StockData.Series[0].ToolTip = tooltipText;
            }
            else
            {
                /*  tooltip is set to empty otherwise   */
                chart_StockData.Series[0].ToolTip = string.Empty;
            }
        }
        /*  Clearing button for object and tool mangement and reset file selection options */
        private void button_ClearFile_Click(object sender, EventArgs e)
        {
            /*  when pressed: */
            dateTimePicker_StartDate.Value = DateTime.Now; /*   resets start and end datepicker values  */
            dateTimePicker_EndDate.Value = DateTime.Now;
            comboBox_Stock.Text = string.Empty; /*  empties comboboxes text displaying  */
            comboBox_TimeInt.Text = string.Empty;   
            comboBox_Stock.Enabled = true; /*   reenables comboboxes if they are disabled   */
            comboBox_TimeInt.Enabled = true;
            textBox_StockSelected.Enabled = true; /*    reenables stock select textbox and clears its text  */
            textBox_StockSelected.Clear();
            openFileDialog_OpenStock.FileName = string.Empty; /*    empties opened file string that was previously selected  */
            dataGridView_StockData.Rows.Clear(); /* clears datagridview rows loaded in from previous stock */
            stockChartDisplay?.Dispose(); /*    disposes load chart forms created */
            comboBox_StockFill(); /*    refills the combobox of stock ticker names  */

        }
    }
}


