/*
# Author : Nirpesh Lamichhane
# Program: Assignment week 3 source codes
*/

// Greeting player.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace greeting
{
    internal class greeting

    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("Welcome " + name);
            Console.ReadLine();
        }
    }
}
//3.Odd even by numeric method.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine($"{number} is even.");
            }
            else
            {
                Console.WriteLine($"{number} is odd.");
            }
            Console.ReadLine();
        }
    }
}

//3.Odd even by boolean method
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEvenBool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            bool isEven = IsEven(number);
            //Here I am invoking the function.

            if (isEven)
            {
                Console.WriteLine($"{number} is even.");
            }
            else
            {
                Console.WriteLine($"{number} is odd.");
            }
            Console.ReadLine();
        }

        static bool IsEven(int num)
        {
            // The entered number is verified here.
            return num % 2 == 0;
        }

    }
}




//2. Area of rectangle
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter width");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter height:");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The area for width " + x + " and height is " + y + " is:" + (x * y));
            Console.ReadLine();
        }
    }
}


//4. Area of cylinder
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCylinder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter radius:");
            double radius = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter height:");
            double height = Convert.ToDouble(Console.ReadLine());

            double volume = Math.PI * Math.Pow(radius, 2) * height;
            Console.WriteLine($"The volume of the cylinder is: {volume} ");
            Console.ReadLine();
        }
    }
}


//5. If user gives radius,diameter or circumference of circle
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose the option for input: ");
            Console.WriteLine("1. Radius");
            Console.WriteLine("2. Diameter");
            Console.WriteLine("3. Circumference");

            int option = Convert.ToInt32(Console.ReadLine());

            double radius = 0;
            double diameter = 0;
            double circumference = 0;
            double height = 0;

            switch (option)
            {
                case 1:
                    Console.WriteLine("Enter radius:");
                    radius = Convert.ToDouble(Console.ReadLine());
                    break;
                case 2:
                    Console.WriteLine("Enter diameter:");
                    diameter = Convert.ToDouble(Console.ReadLine());
                    radius = diameter / 2; 
                    break;
                case 3:
                    Console.WriteLine("Enter circumference:");
                    circumference = Convert.ToDouble(Console.ReadLine());
                    radius = circumference / (2 * Math.PI); 
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    return;
            }

            Console.WriteLine("Enter height:");
            height = Convert.ToDouble(Console.ReadLine());

            double volume = Math.PI * Math.Pow(radius, 2) * height;
            Console.WriteLine($"The volume of the cylinder is: {volume}");
            Console.ReadLine();
        }
    }
}
