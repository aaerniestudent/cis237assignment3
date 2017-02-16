using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class Program
    {
        static void Main(string[] args)
        {

            UserInterface UI = new UserInterface();
            DroidCollection Droids = new DroidCollection();

            UI.MainMenu();
            int input = UI.MenuInput();
            while (input !=3)
            {
                switch(input)
                {
                    case 1:
                        {
                            
                            break;
                        }
                UI.MainMenu();
                input = UI.MenuInput();
            }

        }


    }
}
