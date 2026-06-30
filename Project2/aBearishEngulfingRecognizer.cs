using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    internal class aBearishEngulfingRecognizer : aRecognizer
    {

        /// Bearish Engulfing pattern: A two-candlestick pattern where the second candlestick completely engulfs the body of the first candlestick, 
        /// and the first candlestick is bullish while the second is bearish.
        /// Initializes the base class with the pattern size and the pattern name "Bearish Engulfing".
        public aBearishEngulfingRecognizer(int v) : base(2, "Bearish Engulfing")
        {
        }
        public override bool MatchPattern(List<aSmartCandlestick> losc, int ps)
        {
            var sc1 = losc[0];
            var sc2 = losc[1];
            return sc1.isBullish && sc2.isBearish && sc2.bodyBottom < sc1.bodyBottom && sc2.bodyTop > sc1.bodyTop;
        }
    }
}
