using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    internal class aCandlestick
    {
        public DateTime date { get; set; }
        public decimal open { get; set; }
        public decimal high { get; set; }
        public decimal low { get; set; }
        public decimal close { get; set; }
        public ulong volume { get; set; }

        /// Default constructor for an empty aCandlestick object.
        public aCandlestick() { }

        /// Initialize an instance of aCandlestick with explicit values.
        public aCandlestick(DateTime date, decimal open, decimal high, decimal low, decimal close, ulong volume)
        {
            // Parameters of class properties
            this.date = date; //Date of value
            this.open = open; //value at open
            this.high = high; //hieghest value
            this.low = low; //lowest value
            this.close = close; //value at close
            this.volume = volume; //volume traded
        }

        public aCandlestick(aCandlestick candle)
        {
            // Copy constructor to create a new instance based on an existing aCandlestick object
            this.date = candle.date;
            this.open = candle.open;
            this.high = candle.high;
            this.low = candle.low;
            this.close = candle.close;
            this.volume = candle.volume;
        }   

        /// Parse a CSV line string to create aCandlestick object.

        public aCandlestick(string data)
        {
            // Split the input string by commas into an array and remove quotes to handle formatting
            string[] parts = data.Split(',');

            date = DateTime.Parse(parts[0].Trim('"'));
            open = decimal.Parse(parts[1].Trim('"'));
            high = decimal.Parse(parts[2].Trim('"'));
            low = decimal.Parse(parts[3].Trim('"'));
            close = decimal.Parse(parts[4].Trim('"'));
            volume = ulong.Parse(parts[5].Trim('"'));
        }
    }
}
