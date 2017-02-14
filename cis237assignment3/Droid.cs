using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    abstract class Droid : IDroid
    {

        //backing fields
        private string material;
        private string model;
        private string color;
        private decimal baseCost;
        private decimal totalCost;

        protected Droid(string Material, string Model, string Color)
        {
            this.material = Material;
            this.model = Model;
            this.color = Color;
        }

        //property
        public decimal TotalCost
        {
            get; //not done
            set;
        }
        
        public override string ToString()
        {
            return "Droid model " + model + ", material " + material + ", color " + color; //anything to add
        }

        protected virtual decimal CalculateBaseCost()
        {
            return baseCost; //make this
        }

        public virtual decimal CalculateTotalCost()
        {
            return totalCost; //make this
        }
    }
}
