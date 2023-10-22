using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714220063
{
    class Token
    {
        public string Name { get; set; }
        public double TotalSupply { get; set; }
        public double AllTimeHigh { get; set; }
        public double AllTimeLow { get; set; }
        public double CurrentPrice { get; set; }
        public double MarketCap { get; set; }
        public string Website { get; set; }

        public Token(string name, double totalSupply, double allTimeHigh, double allTimeLow, double currentPrice, double marketCap, string website)
        {
            Name = name;
            TotalSupply = totalSupply;
            AllTimeHigh = allTimeHigh;
            AllTimeLow = allTimeLow;
            CurrentPrice = currentPrice;
            MarketCap = marketCap;
            Website = website;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Total Supply: {TotalSupply}");
            Console.WriteLine($"All-Time High: {AllTimeHigh}");
            Console.WriteLine($"All-Time Low: {AllTimeLow}");
            Console.WriteLine($"Current Price: {CurrentPrice}");
            Console.WriteLine($"Market Cap: {MarketCap}");
            Console.WriteLine($"Website: {Website}");
        }
    }
}