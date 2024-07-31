using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program in C# to print individual characters of the string in reverse order
namespace AssignmentFiveString
{
    internal class Q2_AssignmentString
    {
        static void Main(string[] args)
        {
            //entering string
            Console.Write("Enter a string: ");
            string word = Console.ReadLine();

            //from last character to first letter
            Console.WriteLine("Characters of the string in reverse order:");
            for (int i = word.Length - 1; i >= 0; i--)
            {
                //strings in C# are immutable, meaning their contents cannot be changed after they are created.
                //Reading the input string and print its characters in reverse order without modifying the original string
                Console.Write(word[i]);
            }
            Console.WriteLine(); // for new line
        }
    }
}
