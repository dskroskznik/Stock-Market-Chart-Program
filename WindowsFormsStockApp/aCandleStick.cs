using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsStockApp
{
    public class aCandleStick
    {
        public String ticker { get; set; }
        public String period { get; set; }
        public DateTime datetime { get; set; }
        public decimal open { get; set; }
        public decimal high{ get; set; }
        public decimal low { get; set; }
        public decimal close { get; set; }

        public long volume { get; set; }


        /*public aCandleStick(DateTime datetime, decimal open, decimal high, decimal low, decimal close, long volume)
        {
            this.datetime = datetime;
            this.open = open;
            this.high = high;
            this.low = low;
            this.close = close;
            this.volume = volume;
        }*/

        public bool Bearish()
        {
            return close < open;
        }
            
        public bool Bullish()
        {
            return close > open;
        }
    }
}
