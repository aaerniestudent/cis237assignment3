using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class Janitor: Utility
    {

        private bool trashCompactor;
        private bool vacuum;

        public Janitor(string Material, string Model, string Color, bool Toolbox, bool ComputerConnection, bool Arm, bool TrashCompactor, bool Vacuum): base(Material,Model,Color,Toolbox,ComputerConnection,Arm)
        {
            this.trashCompactor = TrashCompactor;
            this.vacuum = Vacuum;
            CalculateTotalCost();
        }

        public override string ToString()
        {
            string s = base.ToString();
            int index = s.IndexOf('U');
            s = s.Insert(index, "Janitor ");
            index = s.IndexOf("Total");
            s = s.Remove(index-3);
            if (!s.Contains("with") && (trashCompactor || vacuum)) { s += " with utility parts:" + Environment.NewLine; }
            if (trashCompactor) { s += " trash compactor"; }
            if (vacuum) { s += " vacuum"; }
            s += Environment.NewLine + " Total Cost: " + totalCost.ToString("C");
            return s;
        }

        public override decimal CalculateTotalCost()
        {
            decimal total = base.CalculateTotalCost();
            if (trashCompactor) { total += PART_COST; }
            if (vacuum) { total += PART_COST; }
            totalCost = total;
            return total;
        }
    }
}
