using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class Protocol : Droid
    {

        private const decimal PRICE_PER_LANGUAGE = 5;

        private int numberLanguages;

        public Protocol(string Material, string Model, string Color, decimal baseCost) : base(Material, Model, Color)
        {
            //whatever this is
        }

        //fix this
        public override decimal CalculateTotalCost()
        {
            return base.CalculateBaseCost() + numberLanguages * PRICE_PER_LANGUAGE;
        }


    }
}
