using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentThreeLoops
{
    internal class Q11_AssignmentLoops
    {
        public static void Main(string[] args)
        {
            int n,i,j,rem,sum,f,r1,r2,temp;
            Console.WriteLine("Enter lowerrange to find the whether it is strongest number or not");
            r1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter higherrange to find the whether it is strongest number or not");
            r2 = int.Parse(Console.ReadLine());
            //starting the range
            for (i = r1; i <= r2; i++)
            {
                //storing the first number (... continuous to next number) to temporary variable
                temp = i;
                sum = 0;
                //to extract the last digit of the first number while loop starts
                while (temp != 0)
                {
                    rem = temp % 10;
                    //to find the factorial number assigning f to 1
                    f = 1;
                    for (j = 1; j <= rem; j++)
                    {
                        f = f * j;
                    }
                    //finding the sum of factorial with rest of digits
                    sum = sum + f;
                    temp = temp / 10;
                }
                //checking if the sum and the original number is same or not
                if (sum == i)
                {
                    Console.Write(i+" ");
                }
            }
            Console.ReadKey();
        }
    }
}
