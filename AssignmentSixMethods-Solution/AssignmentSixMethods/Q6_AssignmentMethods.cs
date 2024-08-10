using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program in C# to create a method to calculate the sum of the individual digits of a given number
namespace AssignmentSixMethods
{
    internal class Q6_AssignmentMethods
    {
        //Main
        public static void Main(string[] args)
        {
            int sumdigit=sumofdigits();
            Console.WriteLine("The sum of digits of the number is: " + sumdigit);
        }
        //Method(it doesn't return anything)
        public static int sumofdigits()
        {
            //Entering a number
            Console.WriteLine("Enter the number to calculate the sum of the individual digits of a given number");
            int n = int.Parse(Console.ReadLine());

            //counter variable to increment
            int rem,sum = 0;

            //checking prime or not
            while(n!=0)
            {
                rem = n % 10;
                sum = sum + rem;
                n = n / 10;
            }
            return sum;
        }
    }
}
