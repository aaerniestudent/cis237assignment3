using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class UserInterface
    {

        public void mainMenu()
        {
            Console.WriteLine("*****************");
            Console.WriteLine("*   MAIN MENU   *");
            Console.WriteLine("*****************");
            Console.WriteLine("1. New Droid");
            Console.WriteLine("2. Print Current List");
            Console.WriteLine("3. Exit");            
        }
        
        public int MenuInput()
        {
            string input = Console.ReadLine();
            while (input != "1" && input != "2"
                && input != "3" && input != "4")
            {
                InputError();
                input = Console.ReadLine();
            }
            return int.Parse(input);
        }

        public void Output(string s)
        {
            Console.WriteLine(s);
        }

        public void Clear()
        {
            Console.Clear();
        }

        private void InputError()
        {
            Console.WriteLine("Error: invalid input; please input the number associated with the menu choice you want.");
        }
    }
}
