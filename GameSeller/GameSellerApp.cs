using System;

namespace GameSeller
{
    public class GameSellerApp
    {
        static void Main(string[] args)
        {
            GreetingToClient GreetingToClient = new GreetingToClient();
            
            GreetingToClient.GreetingMethod();

            foreach(GameCategories gameCat in Enum.GetValues(typeof(GameCategories)))
            {
                /*  
                 *  I concat the result of the names and values coverted
                 *  to a int number so the user can choose which option 
                 *  select. Also using interpolation, since it could be 
                 *  more cleaner and simple code. 
                 */

                Console.WriteLine($"_{Convert.ToInt32(gameCat)}_ {gameCat}");
            }

            
            
        }
    }
}
