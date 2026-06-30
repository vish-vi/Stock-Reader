using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    internal class aGravestoneDoji : aRecognizer
    {
        /// Gravestone Doji pattern: A single candlestick pattern where the open, low, and close prices are all the same or very close, 
        /// and the high price is significantly higher than the open and close prices.
        /// Initializes the base class with the pattern size and the pattern name "Gravestone Doji".
        public aGravestoneDoji(int v) : base(1, "Gravestone Doji")
        {
        }
        public override bool MatchPattern(List<aSmartCandlestick> losc, int ps)
        {
            var sc = losc[0];
            return sc.isDoji && sc.lowerRange <= 0.05m * sc.Range;
        }               
    }
}
