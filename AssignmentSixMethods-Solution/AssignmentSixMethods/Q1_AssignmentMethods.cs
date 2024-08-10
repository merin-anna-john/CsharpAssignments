using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program in C# to create a method to input a string and count number of spaces are in the string

namespace AssignmentSixMethods
{
    internal class Q1_AssignmentMethods
    {
        //Main
        public static void Main(string[] args)
        {
            int spacecount=input();
            Console.WriteLine("The number of space count in the string: " + spacecount);
        }
        //Method
        public static int input()
        {
            //Entering string
            Console.WriteLine("Enter a string");
            string word=Console.ReadLine();
            int count = 0;
            //going through each character
            foreach (char c in word)
            {
                if (char.IsWhiteSpace(c))
                {
                    count++;
                }
            }
            return count;
        }
    }
}
