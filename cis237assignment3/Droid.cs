using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    abstract class Droid : IDroid
    {
        //constants to create a base value based on material/model
        private const decimal BASE_VALUE = 20m;
        private const decimal MATERIAL_VALUE = 10m;
        private const decimal MODEL_VALUE = 4m;
        //backing fields
        private string material;
        private string model;
        private string color;
        protected decimal baseCost;
        protected decimal totalCost;

        protected Droid(string Material, string Model, string Color)
        {
            this.material = Material;
            this.model = Model;
            this.color = Color;
            CalculateBaseCost();
            CalculateTotalCost();
        }

        //property from interface
        public decimal TotalCost
        {
            get { return totalCost; }
            set { totalCost = value;  }
        }
        
        public override string ToString()
        {   
            //first line of string on all droids.         
            return "Droid model: " + model + ", material: " + material + ", color: " + color;
        }

        protected virtual void CalculateBaseCost()
        {
            decimal baseValue = BASE_VALUE;
            if (material == "Metal") { baseValue += MATERIAL_VALUE; }
            if (material == "Force Resistant Alloy") { baseValue += MATERIAL_VALUE * 4; }
            if (model == "Complex") { baseValue += MODEL_VALUE; }
            //this is the joke one
            if (model == "Gonk") { baseValue = MODEL_VALUE + baseValue / 2; }
            baseCost = baseValue; 
        }

        //method from interface
        public virtual void CalculateTotalCost()
        {
            totalCost = baseCost;
        }
    }
}
