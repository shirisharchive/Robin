using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdPassword
{
    internal class IdPassword
    {
        static void Main(string[] args)
        {
            
            string username = "Nirpesh";
            string password = "Lamichhane";

            int attempts = 0;
            // need to some condition.
            bool istry = false;

            do
            {
                Console.Write("Enter username: ");
                string MyUsername = Console.ReadLine();

                Console.Write("Enter password: ");
                string MyPassword = Console.ReadLine();

                if (MyUsername == username && MyPassword == password)
                {
                    istry = true;
                    Console.WriteLine("Login successful!");
                    break;
                }
                // need to increase attempt number 2 times i.e less than 3
                else
                {
                    attempts++;
                    Console.WriteLine("Invalid username or password. Please try again.");

                    // Program stops. Why? do-while loop conditon is met
                    if (attempts >= 3)
                    {
                        Console.WriteLine("You have exceeded the maximum number of attempts. Exiting...");
                        Console.ReadLine();
                        break;
                    }
                    Console.ReadLine();
                }
            } while (!istry);
        }
        
    }
}
