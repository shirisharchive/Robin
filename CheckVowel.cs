using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CheckVowel
{
    internal class Program
    {

        static void Main(string[] args)
        {

            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            Console.WriteLine("Enter the character");
            char InputValue = char.Parse(Console.ReadLine());
            bool isVowels = false;
            // This is initially set false because we dont know either vowels or consonant is coming.


            foreach (char elements in vowels)
            {
                //Console.WriteLine(elements);
                if (elements == InputValue)
                {
                    //Console.WriteLine("You have entered Vowel.");
                    isVowels = true;
                    break;
                    // If elements and InputValue is matched then isVolwels becomes true;
                }
            }

                if (isVowels)
                {
                    Console.WriteLine(InputValue+ " is a Vowel.");
                }

                else
                {
                    Console.WriteLine(InputValue+ " is a Consonant");
                }

                Console.ReadLine();

            }
        }
    }



