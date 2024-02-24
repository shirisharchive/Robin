using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            bool isvalid = true;

            Console.WriteLine("Enter the Value of X");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Value of Y");
            int y = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Choose switch condition R, D or C on your choice");
            //string SwitchValue = Console.ReadLine();
            // i did declartion of switchvalue so that i can use it inside the while.

            string switchValue = "";

            //int counter = 0;
            //while (SwitchValue== "R" || SwitchValue == "D" || SwitchValue == "C")

            //Asks from user until wrong is key is pressed.
            do
            {
                Console.WriteLine("Choose switch condition R, D or C on your choice. You can also choose 1, 2,and 3");
                switchValue = Console.ReadLine();


                switch (switchValue)
                {
                    case "R":
                    case "1":
                        Console.WriteLine("The sum of x and y is " + (x + y));
                        Console.ReadLine();
                        break;




                    case "D":
                    case "2":
                        Console.WriteLine("The subtraction of x and y is " + (x - y));
                        Console.ReadLine();
                        break;




                    case "C":
                    case "3":
                        Console.WriteLine("The multiplication of x and y is " + (x * y));
                        Console.ReadLine();

                        break;

                    default:
                        Console.WriteLine("Please choose among R D and C. Or 1,2 and 3. Other is invalid.");
                        //counter++;

                        break;



                }

            
            count++;





        }
        while (count<3) ;
    }
    
}
}
    