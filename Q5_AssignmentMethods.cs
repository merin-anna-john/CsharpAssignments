using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Write a program in C# to create a method to check whether a number is prime or not.
namespace AssignmentSixMethods
{
    internal class Q5_AssignmentMethods
    {
        //Main
        public static void Main(string[] args)
        {
            prime();
        }
        //Method(it doesn't return anything)
        public static void prime()
        {
            //Entering a number
            Console.WriteLine("Enter the number to check whether a number is prime or not");
            int n = int.Parse(Console.ReadLine());

            //counter variable to increment
            int count = 0;

            //checking prime or not
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    count++;
                }
            }
            if (count == 2)
            {
                Console.WriteLine("Prime number");
            }
            else
            {
                Console.WriteLine("Not Prime number");
            }
        }
    }
}
