using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714220063
{
    class Ethereum : Token
    {
        public string Founder { get; set; }

        public Ethereum(string founder, string name, double totalSupply, double allTimeHigh, double allTimeLow, double currentPrice, double marketCap, string website)
            : base(name, totalSupply, allTimeHigh, allTimeLow, currentPrice, marketCap, website)
        {
            Founder = founder;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Founder: {Founder}");
        }
    }
}