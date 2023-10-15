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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace WindowsFormsStockApp
{
    internal class CSVfile
    {
        public String ticker { get; set; }
        public String period {  get; set; }
        public DateTime datetime { get; set; }
        public decimal open { get; set; }
        public decimal high { get; set; }
        public decimal low { get; set; }
        public decimal close { get;  set; }
        public long volume { get; set; }

        //public readonly string fileDirectory;
 
    }
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
    public class CSVread
    {
        public void RecordCSVList(string filePath, List<aCandleStick> candleStickList)
        {
            try
            {
                var configuration = new CsvConfiguration(CultureInfo.InvariantCulture)
                {
                    HasHeaderRecord = true,
                };
                using (var sr = new StreamReader(filePath))
                using (var csv = new CsvReader(sr, configuration))
                {
                    csv.Context.RegisterClassMap<CSVfileClassMap>();
                    var record = csv.GetRecords<CSVfile>().ToList();

                    foreach (var rec in record)
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
            catch (Exception ex)
            {
                MessageBox.Show("Error Occurred: Empty File Path Selected", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public List<aCandleStick> FilterCSVList(List<aCandleStick> candleStickRange, DateTime startDate, DateTime endDate)
        {
            return candleStickRange.Where(candle => candle.datetime >= startDate && candle.datetime <= endDate).ToList();
        }
    }
}
