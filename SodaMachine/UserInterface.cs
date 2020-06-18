using System;
using System.Collections.Generic;
using System.Text;

namespace SodaMachine
{
    static class UserInterface
    {

       public static string WhatSodaInput() 
       {
            Console.WriteLine("What type of soda would you like");
            //different choices and prices
            string userInput = Console.ReadLine();
            return userInput;

            
        }

    }
}   
