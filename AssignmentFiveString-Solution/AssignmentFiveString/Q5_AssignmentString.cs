using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Write a program in C# to count a total number of alphabets, digits and special characters in a string.
namespace AssignmentFiveString
{
    internal class Q5_AssignmentString
    {
        public static void Main(string[] args)
        {
            //entering string
            Console.Write("Enter a string: ");
            string word = Console.ReadLine();
            int ac = 0, dc = 0, sc = 0;
            //going through each character
            foreach(char c in word)
            {
                //to count alphabets
                if ((c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z'))
                {
                    ac++;
                }

                //to count digits
                else if (c >= '0' && c <= '9')
                {
                    dc++;
                }

                //to count only special character and not to count space
                else if (!char.IsWhiteSpace(c))
                    sc++;
            }
            Console.Write("Alphabet count is: "+ac);
            Console.Write("\nDigit count is: " + dc);
            Console.Write("\nSpecial character count is: " + sc);
            Console.ReadKey();
        }
    }
}
