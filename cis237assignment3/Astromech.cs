using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class Astromech : Utility
    {

        private const decimal COST_PER_SHIP = 1.2m;

        private bool fireExtunguisher;
        private int numberShips;

        public Astromech(string Material,string Model,string Color,bool Toolbox,bool ComputerConnection,bool Arm, bool FireExtinguisher, int NumberShips) : base(Material,Model,Color,Toolbox,ComputerConnection,Arm)
        {
            this.fireExtunguisher = FireExtinguisher;
            this.numberShips = NumberShips;
        }
        public override string ToString()
        {
            string s = base.ToString();
            int index = base.ToString().IndexOf("U");
            s.Insert(index, "Astromech ");
            if (!s.Contains("with") && fireExtunguisher) { s += " with utility parts:"; }
            if (fireExtunguisher) { s += " fire extinguisher"; }
            s += ". This works on " + numberShips + " ships.";
            return s;
        }

    }
}
