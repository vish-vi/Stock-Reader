using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    internal class aBullishMarubozu : aRecognizer
    {

        /// constructs a recognizer for the Bullish Marubozu pattern, 
        /// which is a single-candlestick pattern characterized by a long bullish body with little to no shadows.
        public aBullishMarubozu(int v) : base(1, "Bullish Maribozu")
        {
        }

        public override bool MatchPattern(List<aSmartCandlestick> losc, int ps)
        {
            // A Bullish Marubozu is identified by a single candlestick with a long bullish body and minimal shadows.
            var sc = losc[0];
            return sc.bodyRange == sc.Range && sc.isBullish;
        }
    }
}
