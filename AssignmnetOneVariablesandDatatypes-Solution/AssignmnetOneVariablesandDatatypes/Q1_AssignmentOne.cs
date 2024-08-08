using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmnetOneVariablesandDatatypes
{
    internal class Q1_AssignmentOne
    {
        public static void Main(string[] args)
        {
            string u;
            int p;
            //for loop for only three attempts
            for (int i = 1; i <= 3; i++)
            {
                //entering username and password
                Console.WriteLine("Enter the userid:");
                u = Console.ReadLine();
                Console.WriteLine("Enter the password:");
                p = int.Parse(Console.ReadLine());
                //checking whether it matches this username and password
                if (u == "user" && p == 123)
                {
                    //display and break if the username and password is correct
                    Console.WriteLine("Correct password");
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect password!Try again.You only have few attempts");
                }
            }
        }
    }
}
