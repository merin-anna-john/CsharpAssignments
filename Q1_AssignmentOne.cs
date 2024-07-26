using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_One
{
    internal class Q1_AssignmentOne
    {
        public static void Main(string[] args)
        {
            string u;
            int p;
            Console.WriteLine("Enter the userid:");
            u = Console.ReadLine();
            Console.WriteLine("Enter the password:");
            p = int.Parse(Console.ReadLine());
            for(int i=1;i<=3;i++)
            {
                if (u == "user" && p == 123) 
                {
                    Console.WriteLine("Correct password");
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect password");

                }
            }
        }
    }
}
