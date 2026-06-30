using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    internal class aDragonflyDoji : aRecognizer
    {
        /// Dragonfly Doji pattern: A single candlestick pattern where the open, high, and close prices are all the same or very close, 
        /// and the low price is significantly lower than the open and close prices.
        /// Initializes the base class with the pattern size and the pattern name "Dragonfly Doji".
        public aDragonflyDoji(int v) : base(1, "Dragonfly Doji")
        {
        }
        public override bool MatchPattern(List<aSmartCandlestick> losc, int ps)
        {
            var sc = losc[0];
            return sc.isDoji && sc.upperRange <= 0.05m * sc.Range;
        }
    }
}
