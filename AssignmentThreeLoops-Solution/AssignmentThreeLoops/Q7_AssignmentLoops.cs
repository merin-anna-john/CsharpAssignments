using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program in C# to check whether a number is a palindrome or not.
namespace AssignmentThreeLoops
{
    internal class Q7_AssignmentLoops
    {
        public static void Main(string[] args)
        {
            int n,x;
            int rem, rev=0;
            //entering number
            Console.WriteLine("Enter the a number to check whether it is a palindrome number or not:");
            n = int.Parse(Console.ReadLine());
            //storing number in another variable
            x = n;
            //reversing number
            while(n!=0)
            {
                rem = n % 10;
                rev = rev * 10 + rem;
                n = n / 10;
            }
            //checking palindrome
            if(x==rev)
            {
                Console.WriteLine("Palindrome Number");
            }
            else
            {
                Console.WriteLine("Not Palindrome Number");

            }
        }
    }
}
