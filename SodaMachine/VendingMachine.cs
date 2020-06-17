using System;
using System.Collections.Generic;
using System.Text;

namespace SodaMachine
{
    class VendingMachine
    {  // member variables
        public List<Coin> coin;
        public List<Can> can;
        
        public VendingMachine()
        { // constructor
            coin = new List<Coin>();
            can = new List<Can>();
            // one of outgoing coins *** need to do
        }
        void AddCoins()
        {
            for (int i = 0; i < 20; i++)
            {
                Quarter quarter = new Quarter();
                coin.Add(quarter);
            }
            for (int i = 0; i < 10; i++)
            {
                Dime dime = new Dime();
                coin.Add(dime);
            }
            for (int i = 0; i < 20; i++)
            {
                Nickel nickel = new Nickel();
                coin.Add(nickel);
            }
            for (int i = 0; i < 50; i++)
            {
                Penny penny = new Penny();
                coin.Add(penny);
            }

        }
        void AddCans()
        {
            for (int i = 0; i < 10; i++)
            {
                Can rootBeer = new Can();
                can.Add(rootBeer);
            }
            for (int i = 0; i < 10; i++)
            {
                Can cola = new Can();
                can.Add(cola);
            }
            for (int i = 0; i < 10; i++)
            {
                Can orangeSoda = new Can();
                can.Add(orangeSoda);
            }
        }
        public void MakePurchase() 
        {

            // member method

            // Should take from wallet and send to backpack (loop)
           
            
            if (// make purchase issue )
            {
                //when attempting to buy a soda if i do not have enough money transaction 
                //      should not be completed and my money should be refunded
            }
            else if ()
            {
                //if too much money is passed in I should get my soda and the change 
                //       this goes to the list of coins in my wallet
            }
            else if ()
            {
                //if too much money gets put into the machine and the machine doesent 
                //     have enough money then no sale, refund to wallet list

            }
            else if () 
            {
                //if too much money is passed into vending machine and enough change but no soda refund to wallet

            }
        
        }
       
    }
}
