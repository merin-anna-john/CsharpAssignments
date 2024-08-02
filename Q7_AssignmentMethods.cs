using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program in C# to display the individual digits of a given number using recursion.
namespace AssignmentSixMethods
{
    internal class Q7_AssignmentMethods
    {
        //Main method
        public static void Main(string[] args)
        {
            //entering number
            Console.WriteLine("Enter a number:");
            int number = int.Parse(Console.ReadLine());

            //displaying the individual digits by method 
            Console.WriteLine("The digits of the number are:");
            IndividualDigits(number);
        }
        //IndividualDigit method
        public static void IndividualDigits(int number)
        {
            if (number < 10)
            {
                Console.WriteLine(number);
                return;
            }
            // It calls itself with the number divided by 10 (to strip off the last digit),
            IndividualDigits(number / 10);

            //Prints the last digit of the number
            Console.WriteLine(number % 10);
        }
    }
}

