using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

//Write a program in C# to compare two string without using string library functions.
namespace AssignmentFiveString
{
    internal class Q4_AssignmentString
    {
        public static void Main(string[] args)
        {
            //entering first string
            Console.Write("Enter first string: ");
            string wordone = Console.ReadLine();

            //entering second string
            Console.Write("Enter second string: ");
            string wordtwo = Console.ReadLine();
            int count = 0;
            if (wordone.Length == wordtwo.Length)
            {
                for (int i = 0; i < wordone.Length; i++)
                {
                    if (wordone[i] != wordtwo[i])
                    {
                        Console.WriteLine("They are not equal");
                        break;
                    }
                        count++;
                }
            }
            else
            {
                Console.WriteLine("Since the length is not same enter the string again...");
            }
            if(count==wordone.Length)
            {
                Console.WriteLine("They are equal");
            }
        }
    }
}
