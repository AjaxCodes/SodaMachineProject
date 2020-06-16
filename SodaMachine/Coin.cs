using System;
using System.Collections.Generic;
using System.Text;

namespace SodaMachine
{
    class Coin : Wallet
    {
        // member variables
        // constructor
        // member method


        string coinName;
        double coinValue;

        Coin(string coinName, double coinValue) 
        {
            this.coinName = coinname;
            this.coinValue = coinvalue;
        
         // list <Coin> coin = new List<Coin>();
               
            
           
        
        
        
        }
        private void PopulateCoin()
        { 
            //This whole thing might get moved to wallet??


            // coinOne = new Coin("penny,0.01"); 
            // coinTwo = new Coin("nickel",0.05);
            // coinThree = new Coin("dime", 0.10)
            // coinFour = new Coin ("quarter"0.25)
           
            
            //Coins.Add(coinOne);
            //Coins.Add(coinTwo);
            //Coins.Add(coinThree);
            //Coins.Add(coinFour);
            




        }

        // should be read only get method or private
        // I want to have the coins im using as payment added to a list
    }
}
