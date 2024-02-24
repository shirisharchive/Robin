using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Enter the Value of X");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Value of Y");
            int y = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Choose switch condition R, D or C on your choice");
            //string SwitchValue = Console.ReadLine();
            // i did declartion of switchvalue so that i can use it inside the while.

            string SwitchValue = "";
            
            //while (SwitchValue== "R" || SwitchValue == "D" || SwitchValue == "C")

            //Asks from user until wrong is key is pressed.
            
           
            //while (!(SwitchValue == "R" || SwitchValue == "D" || SwitchValue == "C" || SwitchValue == "1" || SwitchValue == "2" || SwitchValue == "3")) 
            while (true) 
            {
                Console.WriteLine("Choose switch condition R, D or C on your choice. You can also choose 1, 2,and 3");
                SwitchValue = Console.ReadLine();
                
                switch (SwitchValue)
                {
                    case "R":
                    case "1":
                        Console.WriteLine("The sum of x and y is " + (x + y));
                        break;




                    case "D":
                    case "2":
                        Console.WriteLine("The subtraction of x and y is " + (x - y));
                        break;




                    case "C":
                    case "3":
                        Console.WriteLine("The multiplication of x and y is " + (x * y));
                        break;

                    default:
                        Console.WriteLine("Please choose among R D and C. Or 1,2 and 3. Other is invalid.");
                        
                        break;


                        

                }

                Console.ReadLine();
            }
            

        }
        
       }
   
    }

