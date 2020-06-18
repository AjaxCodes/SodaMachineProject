using System;
using System.Collections.Generic;
using System.Text;

namespace SodaMachine
{
    class VendingMachine
    {  // member variables
        public List<Coin> register;
        public List<Can> can;




        public VendingMachine()
        { // constructor
            register = new List<Coin>();
            can = new List<Can>();
            // one of outgoing coins *** need to do
        }
        public void GetCoin(Customer customer, List<Coin> payment, string nameOfCoin)
        {
            for (int i = 0; i < customer.wallet.coin.Count; i++)
            {
                if (customer.wallet.coin[i].coinName == nameOfCoin)
                {
                    Coin coinToPayWith = customer.wallet.coin[i];
                    payment.Add(coinToPayWith);
                    customer.wallet.coin.Remove(coinToPayWith);
                    break; 
                }
            }
        }
        public void GetPayment(Customer customer)
        {
            List<Coin> payment = new List<Coin>();
            Console.WriteLine("How many quarters do you want to add to payment?");
            int numberOfQuarters = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfQuarters; i++)
            {
                GetCoin(customer, payment, "Quarter"); // multipule quarters
            }
            int numberOfDimes = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfDimes; i++)
            {
                GetCoin(customer, payment, "Dime"); // multipule quarters
            }
            int numberOfPennies = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfPennies; i++)
            {
                GetCoin(customer, payment, "Penny"); // multipule quarters
            }
            int numberOfNickels = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfNickels; i++)
            {
                GetCoin(customer, payment, "Nickel"); // multipule quarters
            }
            
        }
        public void VerifyPaynment(List<Coin> payment, double totalCanCost)
        {

        }
        void AddInitialCoins()
        {
            for (int i = 0; i < 20; i++)
            {
                Quarter quarter = new Quarter();
                register.Add(quarter);
            }
            for (int i = 0; i < 10; i++)
            {
                Dime dime = new Dime();
                register.Add(dime);
            }
            for (int i = 0; i < 20; i++)
            {
                Nickel nickel = new Nickel();
                register.Add(nickel);
            }
            for (int i = 0; i < 50; i++)
            {
                Penny penny = new Penny();
                register.Add(penny);
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




        public void PurchaseAttempt(Customer customer, Can can)
        {

            // member method

            // Should take from wallet and send to backpack (loop)

            string customerChoice;
            if (customerChoice == "Cola")
            {
                Console.WriteLine("Cola is .60");
                Console.ReadLine();
            }
            else if (customerChoice == "RootBeer")
            {
                Console.WriteLine("RootBeer is .35");
                Console.ReadLine();
            }
            else if (customerChoice == "orangeSoda")
            {
                Console.WriteLine("orangeSoda");
                Console.ReadLine();
            }





            //  if (customer.wallet.coin <= can.canCost)
            //{
            //when attempting to buy a soda if i do not have enough money transaction 
            //      should not be completed and my money should be refunded
            // }
            //else if ()
            // {
            //if too much money is passed in I should get my soda and the change 
            //       this goes to the list of coins in my wallet
            //  }
            // else if ()
            // {
            //if too much money gets put into the machine and the machine doesent 
            //     have enough money then no sale, refund to wallet list

            //  }
            // else if ()
            // {
            //if too much money is passed into vending machine and enough change but no soda refund to wallet

            //}


        }
    }
}
