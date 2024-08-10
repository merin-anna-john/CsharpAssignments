using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program in C to print even or odd numbers in a given range using recursion
namespace AssignmentSixMethods
{
    internal class Q8_AssignmentMethods
    {
        //Main method
        public static void Main(string[] args)
        {
            // entering range
            Console.Write("Enter start range: ");
            int start = int.Parse(Console.ReadLine());
            Console.Write("Enter end range: ");
            int end = int.Parse(Console.ReadLine());

            // displaying the even or odd numbers in the given range
            Console.WriteLine("Even numbers in the range:");
            PrintEvenNumbers(start, end);

            Console.WriteLine("Odd numbers in the range:");
            PrintOddNumbers(start, end);
        }

        // Method to print even numbers in the given range using recursion
        public static void PrintEvenNumbers(int start, int end)
        {
            if (start > end)
            {
                return;
            }

            if (start % 2 == 0)
            {
                Console.WriteLine(start);
            }

            PrintEvenNumbers(start + 1, end);
        }

        // Method to print odd numbers in the given range using recursion
        public static void PrintOddNumbers(int start, int end)
        {
            if (start > end)
            {
                return;
            }

            if (start % 2 != 0)
            {
                Console.WriteLine(start);
            }

            PrintOddNumbers(start + 1, end);
        }
    }
}
