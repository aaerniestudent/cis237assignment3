﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class UserInterface
    {

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

        //selection check for main menu
        public int MenuInput(int MenuType)
        {
            string input = Console.ReadLine();
            while (input != "1" && input != "2"
                && input != "3" && (input != "4" && MenuType >= 4) 
                && (input != "5" && MenuType >= 5))

            {
                InputError();
                input = Console.ReadLine();
            }
            Clear();
            return int.Parse(input);
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
        public void NewProtocolDroidMenuHeader()
        {
            Console.WriteLine("*****************");
            Console.WriteLine("*   PROTOCOL    *");
            Console.WriteLine("*****************");
        }

        public void NewUtilityDroidMenuHeader()
        {
            Console.WriteLine("*****************");
            Console.WriteLine("*    UTILITY    *");
            Console.WriteLine("*****************");
        }

        public void NewJanitorDroidMenuHeader()
        {
            Console.WriteLine("*****************");
            Console.WriteLine("*    JANITOR    *");
            Console.WriteLine("*****************");
        }

        public void NewAstromechDroidMenuHeader()
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
            Console.WriteLine("1. material1");
            Console.WriteLine("2. mat2"); //remember to change these
            Console.WriteLine("3. m3");
        } 
        
        //the only choice
        public void UtilityModelMenu()
        {
            Console.WriteLine("1. Gonk"); //the only choice
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
        public void ProtocolLanguagesMenu()
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
            Console.Write("Y/N?   ");
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
                }catch
                {                                  
                    s = Console.ReadLine();
                    input = -1;
                }
            }                           
            Clear();
            return input;
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
