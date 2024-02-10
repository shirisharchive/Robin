using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckAge
{
    internal class Program
    {
        public static void CheckAge()
        {
            Console.WriteLine("Enter your age");
            int age = int.Parse(Console.ReadLine());

            if (age < 18)
            {
                Console.WriteLine("You are not a Adult");
            }
            else
            {
                Console.WriteLine("You are Adult");
            }
            Console.ReadLine();
        }

static void Main(string[] args)
        {
            CheckAge();
            CheckAge();

        }
    }
}
