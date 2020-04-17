using System;
using System.Collections.Generic;
using System.Text;

namespace GameSeller
{
    public class SelectSeller
    {

        public void SellerSelected()
        {
            string seller = Console.ReadLine();

            // Here I check if the number that was enter
            string message = Int32.TryParse(seller, out int n) ? 
                $"You have selected Seller_{seller}" :
                $"Error: '{seller}' is not a number";

            while(message == $"Error: '{seller}' is not a number")
            {
                Console.WriteLine("Remember only number\n" +
                    "Please select your seller again: \n");
                seller = Console.ReadLine();

                message = Int32.TryParse(seller, out n) ?
                $"You have selected Seller_{seller}" :
                $"Error: '{seller}' is not a number";
                
            }
            Console.WriteLine($"{message}\n");
        }
        public void SelectingSeller(string name)
        {
            Console.WriteLine($"Welcome {name} to GameSellerApp!");
            Console.WriteLine("Please select your seller by entering the number: \n");

            for(var i = 1; i <= 4; i++)
            {
                Console.WriteLine($"Seller_{i}");
            }
            Console.WriteLine("\n");
            SellerSelected();
        }
    }
}
