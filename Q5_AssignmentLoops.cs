using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentThreeLoops
{
    internal class Q5_AssignmentLoops
    {
        public static void Main(string[] args)
        {
            int r, n, i, c,r1,r2;
            // entering any range
            Console.WriteLine("Enter a lowerrange to check for prime numbers:");
            r1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a higherrange to check for prime numbers:");
            r2 = int.Parse(Console.ReadLine());
            // finding out its divisibility
            for (n = r1; n <= r2; n++)
            {
                c = 0; // Reset counter for each number
                for (i = 1; i <= n; i++)
                {
                    if (n % i == 0)
                    {
                        c++;
                    }
                }
                // checking prime 
                if (c == 2)
                {
                    Console.Write(n+" ");
                }
            }
        }
    }
}
