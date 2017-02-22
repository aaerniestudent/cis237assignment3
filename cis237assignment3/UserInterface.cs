using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class UserInterface
    {

        private string[] materials = { "Plastic" ,"Metal","Force Resistant Alloy" };
        private string[] models = { "Simple", "Complex", "Gonk" };
        private string[] colors = { "black", "white", "silver", "gold" };

        //*****************
        //*   Main Menu   *
        //*****************

        public void MainMenu()
        {
            Console.WriteLine("*****************");
            Console.WriteLine("*   MAIN MENU   *");
            Console.WriteLine("*****************");
            Console.WriteLine("1. New Droid");
            Console.WriteLine("2. Print Current List");
            Console.WriteLine("3. Exit");
        }

        //selection check for menus
        public int MenuInput(int MenuType)
        {
            string input = Console.ReadLine();
            int number = 10;
            while (number > MenuType)
            {
                while (input != "1" && input != "2"
                    && input != "3" && input != "4"
                    && input != "5")

                {
                    InputError();
                    input = Console.ReadLine();
                }
                number = int.Parse(input);
                //there is probably a better way of doing this
                if (number > MenuType)
                {
                    input = "0";
                }
            }
            Clear();
            return number;       
        }

        //*****************
        //*   New Droid   *
        //*****************

        //Menu to select a new droid
        public void NewDroidMenu()
        {
            Console.WriteLine("*****************");
            Console.WriteLine("*   NEW DROID   *");
            Console.WriteLine("*****************");
            Console.WriteLine("1. Protocol");
            Console.WriteLine("2. Utility");
            Console.WriteLine("3. Janitor");
            Console.WriteLine("4. Astromech");
            Console.WriteLine("5. Return to Main Menu");
        }



        //menu headers
        public void NewProtocolDroidHeader()
        {
            Console.WriteLine("*****************");
            Console.WriteLine("*   PROTOCOL    *");
            Console.WriteLine("*****************");
        }

        public void NewUtilityDroidHeader()
        {
            Console.WriteLine("*****************");
            Console.WriteLine("*    UTILITY    *");
            Console.WriteLine("*****************");
        }

        public void NewJanitorDroidHeader()
        {
            Console.WriteLine("*****************");
            Console.WriteLine("*    JANITOR    *");
            Console.WriteLine("*****************");
        }

        public void NewAstromechDroidHeader()
        {
            Console.WriteLine("*****************");
            Console.WriteLine("*   ASTROMECH   *");
            Console.WriteLine("*****************");
        }

        //********************
        //* DROID PROPERTIES * 
        //********************

        public void MaterialMenu()
        {
            Console.WriteLine("1. Plastic");
            Console.WriteLine("2. Metal"); 
            Console.WriteLine("3. Force Resistant Alloy");
        }
        
        public void ModelMenu()
        {
            Console.WriteLine("1. Simple"); 
            Console.WriteLine("2. Complex");
            Console.WriteLine("3. Gonk"); //the "best" choice            
        }

        //Color Menu
        public void ColorMenu()
        {
            Console.WriteLine("1. Black");
            Console.WriteLine("2. White");
            Console.WriteLine("3. Silver");
            Console.WriteLine("4. Gold");
        }

        //***********************
        //* PROTOCOL PROPERTIES *
        //***********************

        //protocol droid languages menu
        public void LanguagesMenu()
        {
            Console.WriteLine("Please input the number of languages this droid knows.");
        }

        //**********************
        //* UTILITY PROPERTIES *
        //**********************

        //tool addon menu for utility, janitor, astromech droids
        public void ToolAddOnMenu(String tool)
        {
            Console.WriteLine("Does this droid have the " + tool + " addition?");
            Console.WriteLine("1. Yes");
            Console.WriteLine("2. No");
        }

        //ship menu for astromech droids
        public void ShipMenu()
        {
            Console.WriteLine("Please input the number of types of ships this droid can work on.");
        }

        public int InputInteger()
        {
            string s = Console.ReadLine();
            int input = -1;
            while (input < 0)
            {
                try
                {
                    input = int.Parse(s);
                } catch
                {
                    InputError(s + " not a positive whole number");                   
                    input = -1;
                    s = Console.ReadLine();
                }
                
            }
            Clear();
            return input;
        }

        //*****************
        //*   NEW DROID   *
        //*****************

        public void NewDroid(ref DroidCollection droids)
        {
            NewDroidMenu();
            int type = MenuInput(5);
            switch (type)
            {
                case 1: // protocol
                    {
                        NewProtocolDroidHeader();
                        MaterialMenu();
                        int mat = MenuInput(3);
                        NewProtocolDroidHeader();
                        ModelMenu();
                        int mod = MenuInput(3);
                        NewProtocolDroidHeader();
                        ColorMenu();
                        int col = MenuInput(4);
                        NewProtocolDroidHeader();
                        LanguagesMenu();
                        int lang = InputInteger();
                        droids.Add(new Protocol(materials[mat - 1], models[mod - 1], colors[col - 1], lang));
                        break;
                    }
                case 2: // utility
                    {
                        bool arm = false;
                        bool tool = false;
                        bool comp = false;
                        NewUtilityDroidHeader();
                        MaterialMenu();
                        int mat = MenuInput(3);
                        NewUtilityDroidHeader();
                        ModelMenu();
                        int mod = MenuInput(3);
                        NewUtilityDroidHeader();
                        ColorMenu();
                        int col = MenuInput(4);
                        NewUtilityDroidHeader();
                        ToolAddOnMenu("toolbox");
                        int add = MenuInput(2);
                        if (add == 1)
                        {
                            tool = true;
                        }
                        NewUtilityDroidHeader();
                        ToolAddOnMenu("computer connection");
                        add = MenuInput(2);
                        if (add == 1)
                        {
                            comp = true;
                        }
                        NewUtilityDroidHeader();
                        ToolAddOnMenu("arm");
                        add = MenuInput(2);
                        if (add == 1)
                        {
                            arm = true;
                        }
                        droids.Add(new Utility(materials[mat - 1], models[mod - 1], colors[col - 1], tool, comp, arm));
                        break;
                    }
                case 3: // janitor
                    {
                        bool arm = false;
                        bool tool = false;
                        bool comp = false;
                        bool trash = false;
                        bool vac = false;
                        NewJanitorDroidHeader();
                        MaterialMenu();
                        int mat = MenuInput(3);
                        NewJanitorDroidHeader();
                        ModelMenu();
                        int mod = MenuInput(3);
                        NewJanitorDroidHeader();
                        ColorMenu();
                        int col = MenuInput(4);
                        NewJanitorDroidHeader();
                        ToolAddOnMenu("toolbox");
                        int add = MenuInput(2);
                        if (add == 1)
                        {
                            tool = true;
                        }
                        NewJanitorDroidHeader();
                        ToolAddOnMenu("computer connection");
                        add = MenuInput(2);
                        if (add == 1)
                        {
                            comp = true;
                        }
                        NewJanitorDroidHeader();
                        ToolAddOnMenu("arm");
                        add = MenuInput(2);
                        if (add == 1)
                        {
                            arm = true;
                        }
                        NewJanitorDroidHeader();
                        ToolAddOnMenu("trash compactor");
                        add = MenuInput(2);
                        if (add == 1)
                        {
                            trash = true;
                        }
                        NewJanitorDroidHeader();
                        ToolAddOnMenu("vacuum");
                        add = MenuInput(2);
                        if (add == 1)
                        {
                            vac = true;
                        }
                        droids.Add(new Janitor(materials[mat - 1], models[mod - 1], colors[col - 1], tool, comp, arm, trash, vac));
                        break;
                    }
                case 4: // astromech
                    {
                        bool arm = false;
                        bool tool = false;
                        bool comp = false;
                        bool fire = false;
                        NewAstromechDroidHeader();
                        MaterialMenu();
                        int mat = MenuInput(3);
                        NewAstromechDroidHeader();
                        ModelMenu();
                        int mod = MenuInput(3);
                        NewAstromechDroidHeader();
                        ColorMenu();
                        int col = MenuInput(4);
                        NewAstromechDroidHeader();
                        ToolAddOnMenu("toolbox");
                        int add = MenuInput(2);
                        if (add == 1)
                        {
                            tool = true;
                        }
                        NewAstromechDroidHeader();
                        ToolAddOnMenu("computer connection");
                        add = MenuInput(2);
                        if (add == 1)
                        {
                            comp = true;
                        }
                        NewAstromechDroidHeader();
                        ToolAddOnMenu("arm");
                        add = MenuInput(2);
                        if (add == 1)
                        {
                            arm = true;
                        }
                        NewAstromechDroidHeader();
                        ToolAddOnMenu("fire extinguisher");
                        add = MenuInput(2);
                        if (add == 1)
                        {
                            fire = true;
                        }
                        NewAstromechDroidHeader();
                        ShipMenu();
                        int ship = InputInteger();
                        droids.Add(new Astromech(materials[mat - 1], models[mod - 1], colors[col - 1], tool, comp, arm, fire, ship));                        
                        break;
                    }
            }
        }

        //*****************
        //*  UI COMMANDS  *
        //*****************

        public void Output(string s)
        {
            Console.WriteLine(s);
        }

        public void Clear()
        {
            Console.Clear();
        }

        public void Pause()
        {
            Console.Read();
        }

        private void InputError()
        {
            Output("Error: invalid input; please input the number associated with the menu choice you want.");
        }

        private void InputError(string type)
        {
            Output("Error: invalid input; " + type);
        }
    }
}
