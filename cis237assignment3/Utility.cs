using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class Utility : Droid
    {

        protected const decimal PART_COST = .41m;

        private bool toolbox;
        private bool computerConnection;
        private bool arm;

        public Utility(string Material, string Model, string Color, bool Toolbox, bool ComputerConnection, bool Arm) : base(Material,Model,Color)
        {
            this.toolbox = Toolbox;
            this.computerConnection = ComputerConnection;
            this.arm = Arm;
            CalculateTotalCost();
        }

        public override string ToString()
        {
            string s = base.ToString() + Environment.NewLine + " Utility droid";
            if (toolbox || computerConnection || arm) { s += " with utility parts:" + Environment.NewLine; }
            if (toolbox) { s += " toolbox"; }
            if (computerConnection) { s += " computer connection"; }
            if (arm) { s += " arm"; }
            s += Environment.NewLine + " Total Cost: " + totalCost.ToString("C");
            return s;
        }

        public override decimal CalculateTotalCost()
        {
            decimal total = baseCost;
            if (toolbox) { total += PART_COST; }
            if (computerConnection) { total += PART_COST; }
            if (arm) { total += PART_COST; }
            totalCost = total;
            return total;
        }
    }
}
