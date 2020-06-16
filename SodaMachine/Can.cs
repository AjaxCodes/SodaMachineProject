using System;
using System.Collections.Generic;
using System.Text;

namespace SodaMachine
{
    class Can : VendingMachine
    {
        double canCost;
        string canName;


        // member variables
        // constructor
        // member method

        Can(double canCost, string canName)
        {



            this.canName = canName;
            this.canCost = canCost;
           
            
            // list <Coin> coin = new List<Coin>();




        }

        private void PopulateCans() 
        {
   // rootBeer =60 cents    cola = 35 cents orangeSoda = 6 cents (*** only a note ***)


            // canOne = new Can("cola", 0.35);
            // canOne = new Can("orange", 0.06);
            // canOne = new Can("Rootbeer", 0.60);

            //Cans.Add(canOne);
            //Cans.Add(canTwo);
            //Cans.Add(canThree);






        }







    }
        // should be abstract
        // cans should be bought with coins out of wallet then put in backpack

    }
}
