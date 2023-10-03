using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsStockApp
{
    internal class aCandleStick
    {
        public Decimal open { get; private set; }
        public Decimal close{ get; private set; }
        public Decimal high{ get; private set; }
        public Decimal low { get; private set; }
        public long vol { get; private set; }
        public DateTime datetime { get; private set; }

        public aCandleStick(Decimal open, Decimal high, Decimal low, Decimal close, long vol, DateTime datetime)
        {
            this.open = open;
            this.close = close;
            this.high = high;
            this.low = low;
            this.vol = vol;
            this.datetime = datetime;
        }

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
