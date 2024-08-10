using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program in C# to count the total number of words in a string
namespace AssignmentFiveString
{
    internal class Q3_AssignmnetString
    {
        public static void Main(string[] args)
        {
            //entering string
            Console.Write("Enter a string: ");
            string word = Console.ReadLine();
            //count is set to one because it only counts white spaces in between the lines
            int count = 1;
            //going through each charaacter
            foreach(char c in word)
            {
                if(char.IsWhiteSpace(c))
                {
                    count++;
                }
            }
            //displaying the word count
            Console.Write("Total number of words is:" + count);
        }
    }
}
