using System;
using System.Collections.Generic;
using System.Text;

namespace SodaMachine
{
    class Simulation
    {
        // member variables
        public VendingMachine sodaMachine;
        Customer customer;

        Simulation()
        {
            sodaMachine = new VendingMachine();
            customer = new Customer();
            // constructor
            //this is where I run the senario

        }

        public void RunSodaMachine()
        {
           
        }
    }
}