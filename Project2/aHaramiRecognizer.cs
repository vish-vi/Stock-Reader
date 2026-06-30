using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    internal class aHaramiRecognizer : aRecognizer
    {
        /// Harami pattern: A two-candlestick pattern where the second candlestick is contained within the body of the first candlestick, 
        /// Initializes the base class with the pattern size and the pattern name "Harami".
        public aHaramiRecognizer(int v) : base(2, "Harami")
        {
        }
        public override bool MatchPattern(List<aSmartCandlestick> losc, int ps)
        {
            var sc1 = losc[0];
            var sc2 = losc[1];
            return (sc1.isBullish && sc2.isBearish && sc2.bodyBottom > sc1.bodyBottom && sc2.bodyTop < sc1.bodyTop) ||
                   (sc1.isBearish && sc2.isBullish && sc2.bodyBottom > sc1.bodyBottom && sc2.bodyTop < sc1.bodyTop);
        }
    }
}
