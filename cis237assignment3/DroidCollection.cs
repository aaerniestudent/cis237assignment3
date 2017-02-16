﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    //Similar to the assignment 1 wineItemsCollection, but with droids
    class DroidCollection
    {

        //array holding droids
        private Droid[] droids = new Droid[25];
        //count of items in the array
        private int length = 0;

        //length property
        public int Length
        {
            get { return length; }
            set { length = value; }
        }

        //not really necessary or used for the assignment, but could be useful(not used)
        public Droid getDroid(int index)
        {
            return droids[index];
        }

        //not really necessary or used for the assignment, but could be useful (not used)
        public Droid getLastDroid()
        {
            return droids[length - 1];
        }

        //add droid, pretty much the same from assignment 1
        public void Add(Droid addedItem, int index)
        {
            if (droids[index] == null)
            {
                droids[index] = addedItem;
                length++;
            }
            else
            {
                droids[index] = addedItem;
            }
        }

        //returns huge string with all droids, pretty much the same from assignment 1
        public String GetPrintString()
        {
            string printString = "";
            for (int i = 0; i < length; i++)
            {
                if (droids[i] != null)
                {
                    printString += droids[i].ToString() + Environment.NewLine;
                }
            }
            return printString;
        }
    }
}