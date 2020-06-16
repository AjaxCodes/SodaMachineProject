using System;
using System.Collections.Generic;
using System.Text;

namespace SodaMachine
{
    class Penny : Coin      // inheritance (IS A TYPE OF)
    {
        // member variables (HAS A)

        // constructor (SPAWNER)
        public Penny()
        {
            coinName = "penny";
            coinValue = .01;
        }
        
        // member methods (CAN DO)
    }
}
