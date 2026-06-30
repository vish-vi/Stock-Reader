using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    internal class aBullishEngulfingRecognizer : aRecognizer
    {

        /// consists of two candlesticks. The first candlestick is a small bearish candlestick, 
        /// followed by a large bullish candlestick that completely engulfs the body of the first candlestick. 

        public aBullishEngulfingRecognizer(int v) : base(2, "Bullish Engulfing")
        {
        }

        /// Matches the pattern of a bullish engulfing candlestick pattern. 
        /// It checks if the first candlestick is bearish and the second candlestick is bullish,
        /// and if the body of the second candlestick completely engulfs the body of the first candlestick.
        public override bool MatchPattern(List<aSmartCandlestick> losc, int ps)
        {
            var sc1 = losc[0];
            var sc2 = losc[1];
            return sc1.isBearish && sc2.isBullish && sc2.bodyBottom < sc1.bodyBottom && sc2.bodyTop > sc1.bodyTop; ;
        }
    
    }
}
