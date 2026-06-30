using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    internal abstract class aRecognizer
    {
        // Base class for pattern recognizers
        // Derived classes should implement specific pattern recognition logic

        public int patternSize; // Size of the pattern to recognize
        public string pattern;
        public abstract bool MatchPattern(List<aSmartCandlestick> losc, int ps);

        /// constructs a recognizer for a specific candlestick pattern, initializing the pattern size and pattern name.
        /// patternSize is the size of the pattern to recognize.
        /// pattern is The name of the pattern.
        public aRecognizer(int patternSize, string pattern)
        {
            this.patternSize = patternSize;
            this.pattern = pattern;
        }

        // Static method to initialize a list of pattern recognizers
        List<aRecognizer> recognizers = new List<aRecognizer>();

        /// Initializes and returns a list of default candlestick pattern recognizers.
        /// The returned list includes recognizers for common candlestick patterns such as
        /// Marubozu and Engulfing patterns. Additional recognizers may be added to the list in future versions.
        /// A list of instances representing the default set of candlestick pattern recognizers.
        public static List<aRecognizer> InitializeRecognizer()
        {
            List<aRecognizer> recognizers = new List<aRecognizer>();

            recognizers.Add(new aMarubozuRecognizer(1));
            recognizers.Add(new aBullishMarubozu(1));
            recognizers.Add(new aBearishMarubozu(1));
            recognizers.Add(new aEngulfingRecognizer(2));
            recognizers.Add(new aBullishEngulfingRecognizer(2));
            recognizers.Add(new aBearishEngulfingRecognizer(2));
            recognizers.Add(new aHaramiRecognizer(2));
            recognizers.Add(new aDragonflyDoji(1));
            recognizers.Add(new aGravestoneDoji(1));
            
            return recognizers;
        }

        /// recognizes the pattern in the list of smart candlesticks and returns the indices of the last candlestick in each pattern match
        /// Losc is List of smart candlesticks to analyze
        /// List of indices representing the last candlestick in each pattern match
        public List<int> recognize_pattern(List<aSmartCandlestick> losc)
        {
            List<int> list_of_Indices = new List<int>(losc.Count);
            for (int i = 0; i <= losc.Count - patternSize; i++)
            {
                int ps = patternSize; 
                aSmartCandlestick sc = losc[i];
                if (MatchPattern(losc.GetRange(i, ps), ps))
                {
                    list_of_Indices.Add(i + ps - 1);
                }          
            }
            return list_of_Indices;
        }
            
    }

}

