using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arithesum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Enter the number of your choice.");
                int amount = Convert.ToInt32(Console.ReadLine());
                int total = 0;
                Random rand = new Random();

                for (int i = 0; i < amount; i++)
                {
                    int value = rand.Next(0, 101);
                    total += value;
                }

                float average = total / (float)amount;

                Console.WriteLine("The Average of "+amount+" is");
                Console.WriteLine("Average is : " + average);
                Console.ReadLine();
            }
        }
    }
}
  
  
