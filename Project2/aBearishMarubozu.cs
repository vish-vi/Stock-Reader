using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    internal class aBearishMarubozu : aRecognizer
    {
        /// constructs a recognizer for the Bearish Marubozu pattern, 
        /// which is a single-candlestick pattern characterized by a long bearish body with little to no shadows.
        public aBearishMarubozu(int v) : base(1, "Bearish Maribozu")
        {
        }
        public override bool MatchPattern(List<aSmartCandlestick> losc, int ps)
        {
            // The Bearish Marubozu pattern is identified by a single candlestick with a long bearish body and minimal or no shadows.
            var sc = losc[0];
            return sc.bodyRange == sc.Range && sc.isBearish;
        }
    }
}
