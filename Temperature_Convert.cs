using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature_Convert
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the temperature in Fahrenheit:");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());
            double celsius = (fahrenheit - 32) * 5 / 9;

            Console.WriteLine("You have entered: " + fahrenheit +" degree Fahrenheit");
            Console.WriteLine("Temperature in Celsius:" +celsius + "degree Celsius");

            Console.ReadLine();
        }
    }
}
