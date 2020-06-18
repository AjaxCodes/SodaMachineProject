using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

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
            vendingMachine = new List<money>();
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
        public Can GetSoda(string selectCan)
        {
            for (int i = 0; i < can.Count; i++)
            {
                if (can[i].canName == selectCan)
                {
                    return can[i];
                }
            }
            return null;
        }
        public double GetPaymentValue(List<Coin> payment)
        {
            double totalCost = 0;
            for (int i = 0; i < payment.Count; i++)
            {
                totalCost += payment[i].coinValue;
            }
            return totalCost;
        }
        public void GetPayment(Customer customer) // grab payment from wallet to hand
        {
            List<Coin> payment = new List<Coin>();
            
            Console.WriteLine("How many quarters do you want to add to payment?");
            int numberOfQuarters = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfQuarters; i++)
            {
                GetCoin(customer, payment, "Quarter"); 
            }
           
            Console.WriteLine("How many dimes do you want to add to payment?"); 
            int numberOfDimes = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfDimes; i++)
            {
                GetCoin(customer, payment, "Dime"); 
            }
            
            Console.WriteLine("How many pennies  do you want to add to payment?"); 
            int numberOfPennies = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfPennies; i++)
            {
                GetCoin(customer, payment, "Penny"); 
            }
           
            Console.WriteLine("How many nickels do you want to add to payment?"); 
            int numberOfNickels = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfNickels; i++)
            {
                GetCoin(customer, payment, "Nickel"); 
            }
            
        }
        public void VerifyPayment(Customer customer, List<Coin> payment, double totalCanCost) // hand to register 
        {
            if (totalCanCost < GetPaymentValue(payment))
            {
                Console.WriteLine("You have enough money");
                GoodPurchase();
            }
            else if (totalCanCost < GetPaymentValue(payment))
            {
                Console.WriteLine("You do not have enough money");
                BadPurchase();
            }
            else if (can.Count == 0) 
            {
                Console.WriteLine("Sorry But we do not have that soda available");
                BadPurchase();
            }

        }

        public void GoodPurchase(Customer customer  string totalCanCost) 
        {
            if (can.Count >= 1 &&  = can.totalCanCost)       // cust list cans has selected item && value recieved is exact)
            {
                backPack.can ++;
            }
            else if (can.Count >= 1 && customer.wallet.coin, ++ totalCanCost)       // list cans has slected item &&  value is more than canCost)
            {
                backPack.can ++ && customer.wallet.coin + ;
            }
            
        
        }
        public void BadPurchase() 
        {
        
        }
        public void Transaction()
        {
            Can SelectedCan = SelectCanForPurchase();
            GetPayment();
            //do refund 
            //add soda

            // ***********

        }
        
        public void AddInitialCoins()
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
        public void AddCans()
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
        public Can SelectCanForPurchase(Customer customer)
        {

            // member method
            Can selectedSoda;
            // Should take from wallet and send to backpack (loop)

            string customerChoice = Console.ReadLine() ;
            if (customerChoice == "Cola")
            {
                Console.WriteLine("Cola is .60");
                selectedSoda = GetSoda("Cola");
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

            return selectedSoda;
        }
    }
}
