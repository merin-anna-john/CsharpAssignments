using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentThreeLoops
{
    internal class Q10_AssignmentLoops
    {
        public static void Main(string[] args)
        {
            int i, j;
            /*
             A
             ABA
             ABCBA
             ABCDCBA
             */
            //Define the row
            int outer = 4;
            //Loop
            /*(char)('A' + outer);
             * Note:When you add an integer to a character, C# performs arithmetic based on the ASCII value of the character
             * Example:Console.WriteLine((char)('A' + 1));
             * Output will be -----> B
             */
            for (i = 0; i <= outer; i++)
            {
                //Print the first half of the patter
                for (j = 0; j <= i; j++)
                {
                    Console.Write((char)('A' + j) + " ");
                }
                //Print the second half of the pattern in decreasing order
                for (j = i - 1; j >= 0; j--)
                {
                    Console.Write((char)('A' + j) + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
