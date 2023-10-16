using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*  COP4365 Software System Development - Project 1 */
/*  Stock Entry App by Dylan Skroskznik */
namespace WindowsFormsStockApp
{
    public class aCandleStick
    {
        /*  The values represent various attributes of a stock candlestick:   */
        public DateTime datetime { get; set; } /*   Date and time for the candlestick */
        public decimal open { get; set; } /*    Opening price for stock of that period */
        public decimal high{ get; set; } /*  Highest price reached for stock */
        public decimal low { get; set; } /* Lowest price reached for stock */
        public decimal close { get; set; } /* Closing price for stock of that period */

        public long volume { get; set; } /* Trading volume for the stock of that period */
        /*  Unused additional methods for a candlestick object  */
        /*  Will potentially use in later editions   */
        /*
        public bool Bearish()
        {
            return close < open;
        }
            
        public bool Bullish()
        {
            return close > open;
        }*/
    }
}
