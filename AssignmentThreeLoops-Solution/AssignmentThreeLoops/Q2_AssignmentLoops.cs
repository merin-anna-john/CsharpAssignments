using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program in C# to display the pattern like a diamond.
namespace AssignmentThreeLoops
{
    internal class Q2_AssignmentLoops
    {
        static void Main()
        {
            int n;

            Console.Write("Enter the number of rows for the diamond pattern (odd number): ");
            n = int.Parse(Console.ReadLine());

            if (n % 2 == 0)
            {
                Console.WriteLine("Please enter an odd number.");
                return;
            }

            int spaces = n / 2;
            int stars = 1;

            // Upper part of the diamond
            for (int i = 0; i <= n / 2; i++)
            {
                for (int j = 0; j < spaces; j++)
                    Console.Write(" ");
                for (int j = 0; j < stars; j++)
                    Console.Write("*");

                Console.WriteLine();
                spaces--;
                stars += 2;
            }

            spaces = 1;
            stars = n - 2;

            // Lower part of the diamond
            for (int i = n / 2 + 1; i < n; i++)
            {
                for (int j = 0; j < spaces; j++)
                    Console.Write(" ");
                for (int j = 0; j < stars; j++)
                    Console.Write("*");

                Console.WriteLine();
                spaces++;
                stars -= 2;
            }
        }
    }
}
