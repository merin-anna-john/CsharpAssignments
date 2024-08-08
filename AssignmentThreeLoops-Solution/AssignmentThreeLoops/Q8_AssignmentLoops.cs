using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program in C# to find the number and sum of all integer between 100 and 200 which are divisible by 9.
namespace AssignmentThreeLoops
{
    internal class Q8_AssignmentLoops
    {
        public static void Main(string[] args)
        {
            //loop from 100 to 200
            int i,sum=0;
            for (i=100;i<200;i++)
            {
                //checking divisibility by 9
                if(i%9==0)
                {
                    Console.Write(i+" ");
                    sum = sum + i;
                }
            }
            //printing sum of them
            Console.WriteLine("\n Sum of numbers is:"+sum);
        }
    }
}
