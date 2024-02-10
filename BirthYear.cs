using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthYear
{
    internal class Program
    {
        public static void BirthYear()
        {
            Console.WriteLine("What is your BirthYear?");
            int Year = int.Parse(Console.ReadLine());

            int Current_Year = 2024;
            int YearDiff = Current_Year - Year;
            int MinWorkingAge = 18;
            int MaxWorkingAge = 65;

            Console.WriteLine("The age difference is : "+YearDiff);

            if (YearDiff >= MinWorkingAge && YearDiff <= MaxWorkingAge)
            {
                Console.WriteLine("You are within working Age");
            }
            else
            {
                Console.WriteLine("You are not working age");
            }
            Console.ReadLine();
        }

        
        static void Main(string[] args)
        {
            BirthYear();
            BirthYear();

        }
    }
}
