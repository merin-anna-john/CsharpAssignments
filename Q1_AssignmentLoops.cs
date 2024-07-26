using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentThreeLoops
{
    internal class Q1_AssignmentLoops
    {
        public static void Main(string[] args)
        {
            int n,i,sum=0,x;
            //entering the range till the sum to be printed
            Console.WriteLine("Enter the number:");
            n = int.Parse(Console.ReadLine());
            //storing value
            x = n;
            //starting from one till n number
            for(i=1;i<=n; i++)
            {
                //adding with its squares
                sum =sum + (i * i);
            }
            //printing sum
            Console.WriteLine("Sum of " + x + "natural numbers is:" + sum);
        }
    }
}
