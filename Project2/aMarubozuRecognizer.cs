using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    internal class aMarubozuRecognizer: aRecognizer
    {
        /// constructs a recognizer for the Marubozu pattern, which is a single-candlestick pattern characterized by a long body with little to no shadows.
        public aMarubozuRecognizer(int patternSize) : base(patternSize, "Maribozu")
        {
        }

        public override bool MatchPattern(List<aSmartCandlestick> losc, int ps)
        {
            // A Marubozu candlestick has a long body with little to no shadows. This means that the range of the candlestick should be almost equal to the body range, indicating that there are minimal upper and lower shadows.
            aSmartCandlestick sc = losc[0];
            return (sc.Range == sc.bodyRange);
        }
    }
}
