using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreaterValue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of x:");
             int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the value of y:");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine("x :" + x);
            Console.WriteLine("y :" + y);

            if (x > y)
            {
                Console.WriteLine("The x is greater than y");
            }
            else if (x == y)
            {
                Console.WriteLine("The value of x and y is equal");
            }

            else
            {
                Console.WriteLine("The y is greater than x");
            }
            Console.ReadLine();
        }
    }
}
