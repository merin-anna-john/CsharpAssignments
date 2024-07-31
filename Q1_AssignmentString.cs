using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program in C# to find the length of a string without using library function.

namespace AssignmentFiveString
{
    internal class Q1_AssignmentString
    {
        public static void Main(string[] args)
        {
            int count = 0;
            // Entering a string
            Console.WriteLine("Enter a word to find the length");
            string word = Console.ReadLine();

            //The foreach loop iterates through each character in the string word, incrementing the count variable for each character.
            foreach (char c in word)
            {
                count++;
            }
            //displaying the length
            Console.WriteLine("The length of the string is: " + count);
        }
    }
}
