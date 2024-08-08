using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a C# program to determine whether a given number is prime or not  
namespace AssignmentThreeLoops
{
    internal class Q4_AssignmentLoops
    {
        public static void Main(string[] args)
        {
            int n,i,c=0;
            //entering any number
            Console.WriteLine("Enter a number to check it is prime or not:");
            n = int.Parse(Console.ReadLine());
            //finding out its divisibility
            for(i=1;i<=n;i++)
            {
                if(n%i==0)
                {
                    c++;
                }
            }
            //checking prime 
            if(c==2)
            {
                Console.WriteLine("Prime Number");
            }
            else
            {
                Console.WriteLine("Not Prime Number");

            }
        }
    }
}
