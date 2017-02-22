using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class Protocol : Droid
    {

        private const decimal PRICE_PER_LANGUAGE = 1.5m;

        private int numberLanguages;

        public Protocol(string Material, string Model, string Color, int NumberLanguages) : base(Material, Model, Color)
        {
            this.numberLanguages = NumberLanguages;
            CalculateTotalCost();
        }

        //fix this
        public override decimal CalculateTotalCost()
        {
            decimal total = baseCost + numberLanguages * PRICE_PER_LANGUAGE;
            totalCost = total;
            return total;
        }

        public override string ToString()
        {
            return base.ToString() + Environment.NewLine + " Protocol Droid with " + this.numberLanguages + " languages." + Environment.NewLine + " Total Cost: " + totalCost.ToString("C");
        }


    }
}
