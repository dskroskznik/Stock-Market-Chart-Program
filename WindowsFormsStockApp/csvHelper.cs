using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;
using Microsoft.Win32;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

/*  COP4365 Software System Development - Project 1 */
/*  Stock Entry App by Dylan Skroskznik */
namespace WindowsFormsStockApp
{
    /* CSVfile represents the structure of csv stock data file */
    internal class CSVfile
    {
        public String ticker { get; set; } /*   Stock ticker symbol */
        public String period {  get; set; } /*  Time period */
        public DateTime datetime { get; set; } /*   Date and time */
        public decimal open { get; set; } /*    Opening price */                                      
        public decimal high { get; set; } /*  Highest price   */
        public decimal low { get; set; } /*  Lowest price  */
        public decimal close { get;  set; } /*  Closing price   */
        public long volume { get; set; } /*  Trading volume */

    }
    /* CSVfileClassMap defines a class map for to map these values in CSVfile to the specific CSV columns   */
    internal class CSVfileClassMap : ClassMap<CSVfile>
    {
        public CSVfileClassMap()
        {
            Map(m => m.ticker).Name("Ticker");
            Map(m => m.period).Name("Period");
            Map(m => m.datetime).Name("Date");
            Map(m => m.open).Name("Open");
            Map(m => m.high).Name("High");
            Map(m => m.low).Name("Low");
            Map(m => m.close).Name("Close");
            Map(m => m.volume).Name("Volume");
        }
    }
    /*  CSVread defines a class that only records the csv data found and configues it to a list of candlestick objects   */
    public class CSVread
    {
        public void RecordCSVList(string filePath, List<aCandleStick> candleStickList)
        {
            try
            {
                /* implement CSV configuration with settings like header presence   */
                var configuration = new CsvConfiguration(CultureInfo.InvariantCulture)
                {
                    HasHeaderRecord = true,
                };
                using (var sr = new StreamReader(filePath))
                using (var csv = new CsvReader(sr, configuration))
                {
                    /*  register CSVfileClassMap to map CSV columns to CSVfile properties */
                    csv.Context.RegisterClassMap<CSVfileClassMap>();
                    var record = csv.GetRecords<CSVfile>().ToList();

                    /*  iterate through the CSV records and convert them to 'aCandleStick' objects    */
                    foreach(var rec in record)
                    {
                        var candleStick = new aCandleStick
                        {
                            datetime = rec.datetime,
                            open = rec.open,
                            high = rec.high,
                            low = rec.low,
                            close = rec.close,
                            volume = rec.volume
                        };
                        candleStickList.Add(candleStick);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error Occurred: Empty File Path Selected", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /* Function that filters a list of aCandleStick objects based on a date range. */
        public List<aCandleStick> FilterCSVList(List<aCandleStick> candleStickRange, DateTime startDate, DateTime endDate)
        {
            return candleStickRange.Where(candle => candle.datetime >= startDate && candle.datetime <= endDate).ToList();
        }
    }
}
