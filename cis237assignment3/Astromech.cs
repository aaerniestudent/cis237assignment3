using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class Astromech : Utility
    {

        private const decimal COST_PER_SHIP = 5.25m;

        private bool fireExtunguisher;
        private int numberShips;

        public Astromech(string Material,string Model,string Color,bool Toolbox,bool ComputerConnection,bool Arm, bool FireExtinguisher, int NumberShips) : base(Material,Model,Color,Toolbox,ComputerConnection,Arm)
        {
            this.fireExtunguisher = FireExtinguisher;
            this.numberShips = NumberShips;
            CalculateTotalCost();
        }
        public override string ToString()
        {
            string s = base.ToString();
            int index = s.IndexOf('U');            
            s = s.Insert(index, "Astromech ");
            index = s.IndexOf("Total");
            s = s.Remove(index - 3);
            if (!s.Contains("with") && fireExtunguisher) { s += " with utility parts:" + Environment.NewLine; }
            if (fireExtunguisher) { s += " fire extinguisher"; }
            s += ". This works on " + numberShips + " ships.";
            s += Environment.NewLine + " Total Cost: " + totalCost.ToString("C");
            return s;
        }
        public override void CalculateTotalCost()
        {
            base.CalculateTotalCost();
            decimal total = totalCost;
            if (fireExtunguisher) { total += PART_COST; }
            total += numberShips * COST_PER_SHIP;
            totalCost = total;
        }
    }
}
