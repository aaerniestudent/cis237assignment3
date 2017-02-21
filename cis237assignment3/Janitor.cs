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
        }

        public override string ToString()
        {
            string s = base.ToString();
            int index = base.ToString().IndexOf("U");
            s.Insert(index, "Janitor ");
            if (!s.Contains("with") && (trashCompactor || vacuum)) { s += " with utility parts:"; }
            if (trashCompactor) { s += " trash compactor"; }
            if (vacuum) { s += " vacuum"; }
            return s;
        }        
    }
}
