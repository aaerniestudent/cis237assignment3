using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class Utility : Droid
    {

        private bool toolbox;
        private bool computerConnection;
        private bool arm;

        public Utility(string Material, string Model, string Color, bool Toolbox, bool ComputerConnection, bool Arm) : base(Material,Model,Color)
        {
            this.toolbox = Toolbox;
            this.computerConnection = ComputerConnection;
            this.arm = Arm;
        }

        public override string ToString()
        {
            string s = base.ToString() + " utility droid";
            if (toolbox || computerConnection || arm) { s += " with utility parts:"; }
            if (toolbox) { s += " toolbox"; }
            if (computerConnection) { s += " computer connection"; }
            if (arm) { s += " arm"; }
            return s;
        }

        public override decimal CalculateTotalCost()
        {
            return base.CalculateTotalCost();
        }
    }
}
