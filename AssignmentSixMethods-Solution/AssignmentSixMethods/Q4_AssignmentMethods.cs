using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

//Write a program in C# to create a method to display the n number Fibonacci sequence
namespace AssignmentSixMethods
{
    internal class Q4_AssignmentMethods
    {
        //Main 
        public static void Main(string[] args)
        {
            fibonacci();
        }
        //Method(it doesn't return anything)
        public static void fibonacci()
        {
            Console.WriteLine("Enter the limit");
            int limit = int.Parse(Console.ReadLine());
            int a = 0;
            int b = 1;
            int c;
            Console.WriteLine("The fibonacci sequence is: ");
            //First two is printing
            Console.Write(a+" ");
            Console.Write(b+" ");
            //Printing from the third onwards
            for (int i=3; i<=limit;i++)
            {
                
                c = a + b;
                Console.Write(c+" ");
                a=b;
                b=c;
            }
        }
    }
}
