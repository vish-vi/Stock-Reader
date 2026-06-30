using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    internal class aSmartCandlestick : aCandlestick
    {
        /// <summary>
        /// computes and stores additional properties of a candlestick that are useful for pattern recognition, such as body range, upper and lower shadows, and whether the candlestick is bullish or bearish.
        /// </summary>
        public decimal bodyRange { get; set; }
        public decimal bodyTop { get; set; }
        public decimal bodyBottom { get; set; }
        public decimal upperRange { get; set; }
        public decimal lowerRange { get; set; }
        public decimal Range { get; set; }
        public bool isBullish { get; set; }
        public bool isBearish { get; set; }
        public bool isDoji { get; set; }


        /// Initializes a new instance of the aSmartCandlestick class with default values and computes the ranges and properties based on the default candlestick values.
        public aSmartCandlestick() : base()
        {
            computeRanges();

        }

        /// constructs a new instance of the aSmartCandlestick class with the specified date, open, high, low, close, and volume values.
        public aSmartCandlestick(DateTime date, decimal open, decimal high, decimal low, decimal close, ulong volume)
            : base(date, open, high, low, close, volume)
        {
            computeRanges();
        }

        /// constructs a new instance of the aSmartCandlestick class by parsing a CSV line string, initializing the base class with the parsed values, and then computing the ranges and properties based on those values.
        public aSmartCandlestick(string data) : base(data)
        {
            computeRanges();
        }

        /// constructs a new instance of the aSmartCandlestick class by copying the properties of an existing aCandlestick object, initializing the base class with those values, and then computing the ranges and properties based on those values.
        public aSmartCandlestick(aCandlestick candle) : base(candle.date, candle.open, candle.high, candle.low, candle.close, candle.volume)
        {
            computeRanges();
        }
  
        /// constructs a new instance of the aSmartCandlestick class by copying the properties of an existing aSmartCandlestick object, initializing the base class with those values, and then computing the ranges and properties based on those values
        public aSmartCandlestick(aSmartCandlestick candle) : base(candle.date, candle.open, candle.high, candle.low, candle.close, candle.volume)
        {
            computeRanges();
        }

        /// computes the various ranges and properties of the candlestick, such as the total range (high - low), 
        /// body range (absolute difference between close and open), upper shadow range (high - body top), 
        /// lower shadow range (body bottom - low), and determines whether the candlestick is bullish (close > open) or bearish (close < open).
        void computeRanges()
        {
            Range = high - low;
            bodyRange = Math.Abs(close - open);
            bodyTop = Math.Max(open, close);
            bodyBottom = Math.Min(open, close);
            upperRange = high - bodyTop;
            lowerRange = bodyBottom - low;
            isBullish = close > open;
            isBearish = close < open;
            // isDoji added
            isDoji = (bodyRange <= 0.05m * Range) && (upperRange <= 0.05m * Range || lowerRange <= 0.05m * Range); 

        }

    }   
}
