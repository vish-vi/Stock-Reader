using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    internal class aEngulfingRecognizer :aRecognizer
    {
        /// constructor for Engulfing pattern recognizer, 
        /// which takes in an integer value representing the pattern size 
        /// and initializes the base class with the pattern size and the pattern name "Engulfing".
        public aEngulfingRecognizer(int v) : base(2, "Engulfing")
        {
        }   

        public override bool MatchPattern(List<aSmartCandlestick> losc, int ps)
        {
            // This method checks if the given list of smart candlesticks (losc) matches the Engulfing pattern.
            var sc1 = losc[0];
            var sc2 = losc[1];
            return (sc1.isBearish && sc2.isBullish && sc2.bodyBottom < sc1.bodyBottom && sc2.bodyTop > sc1.bodyTop) || (sc1.isBullish && sc2.isBearish && sc2.bodyBottom < sc1.bodyBottom && sc2.bodyTop > sc1.bodyTop);
        }
    }
}
