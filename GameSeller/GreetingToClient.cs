using System;
using System.Collections.Generic;
using System.Text;

namespace GameSeller
{
    public class GreetingToClient
    {
        SelectSeller SelectSeller = new SelectSeller();

        public void GreetingMethod()
        {
            string name;

            Console.WriteLine("Please enter your name.");
            name = Console.ReadLine();

            // Try to look for 'End program' after 4 try. 
            while (String.IsNullOrEmpty(name))
            {
                Console.WriteLine("If you want to continue, name most be enter. \n Please enter your name: ");
                name = Console.ReadLine();
            }

            SelectSeller.SelectingSeller(name);
        }
    }
}
