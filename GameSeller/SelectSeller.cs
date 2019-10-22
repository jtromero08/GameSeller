using System;
using System.Collections.Generic;
using System.Text;

namespace GameSeller
{
    public class SelectSeller
    {
        public void SelectingSeller(string name)
        {
            Console.WriteLine($"Welcome {name} to GameSellerApp!");
            Console.WriteLine("Please select your sellers: \n");

            for(var i = 0; i < 4; i++)
            {
                Console.WriteLine($"Seller_{i + 1}");
            }
        }
    }
}
