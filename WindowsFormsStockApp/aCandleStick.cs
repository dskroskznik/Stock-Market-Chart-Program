using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsStockApp
{
    public class aCandleStick
    {
        public DateTime datetime { get; set; }
        public decimal open { get; set; }
        public decimal high{ get; set; }
        public decimal low { get; set; }
        public decimal close { get; set; }

        public long volume { get; set; }

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
