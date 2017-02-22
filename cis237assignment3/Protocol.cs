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
       
        public override void CalculateTotalCost()
        {
            //have the total cost match the base cost
            base.CalculateTotalCost();
            //add language value
            decimal total = totalCost + numberLanguages * PRICE_PER_LANGUAGE;
            totalCost = total;
        }

        public override string ToString()
        {
            //format looks like this
            //Droid model: (model), material: (material), color: (color) 
            // Protocol Droid with X languages.
            // Total Cost: $23.00;
            return base.ToString() + Environment.NewLine + " Protocol Droid with " + this.numberLanguages + " languages." + Environment.NewLine + " Total Cost: " + totalCost.ToString("C");
        }


    }
}
