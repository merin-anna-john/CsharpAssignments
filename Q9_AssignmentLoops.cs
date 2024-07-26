using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentThreeLoops
{
    internal class Q9_AssignmentLoops
    {
        public static void Main(string[] args)
        {
            int bin,i,x,rem,c=0;
            double sum=0,r,b,dec=0;
            //Get input from user
            Console.WriteLine("Enter the Binary number to get converted into decimal number:");
            bin = int.Parse(Console.ReadLine());
            //Use for loop to process each digit of the binary number
            x = bin;
            //i=i/10 crops the last digit
            /*for(i=bin;i>0;i=i/10)
            {
                rem = i % 10;
                sum = sum+(rem * Math.Pow(2, c));
                c++;
            }
            Console.WriteLine("Decimal number of " + x + "is:" + sum);
            Console.ReadKey();*/
            b = 1;
            for(i=bin;i>0;i=i/10)
            {
                rem = i % 10;
                if(rem==1)
                {
                    dec = dec + b;
                }
                b = b * 2;
            }
            Console.WriteLine("Decimal number of " + x + "is:" + dec);
        }
    }
}
