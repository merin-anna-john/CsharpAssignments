using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Write a C# program to display alphabet pattern like A
with an asterisk.
Reversed string is: Display the pattern like
'A' with an asterisk:
---------------------------------------------

 ***
*   *
*   *
*****
*   *
*   *
*   *
*   * 
 */
namespace AssignmentThreeLoops
{
    internal class Q12_AssignmentLoop
    {
        static void Main()
        {
            int height = 8; // Height of the letter 'A'
            int width = 7;  // Width of the letter 'A'
            int mid = width / 2;

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (i == 0 && j >= mid - 1 && j <= mid + 1) // Top of 'A'
                        Console.Write("*");
                    else if (i == 3) // Middle bar of 'A'
                        Console.Write("*");
                    else if (j == 0 && i > 0) // Left side of 'A', excluding the top corner
                        Console.Write("*");
                    else if (j == width - 1 && i > 0) // Right side of 'A', excluding the top corner
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
