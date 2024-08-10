using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program in C# to create a method to swap the values of two integer numbers.
namespace AssignmentSixMethods
{
    internal class Q3_AssignmentMethods
    {
        //Main method
        public static void Main(string[] args)
        {
            int numberOne, numberTwo;

            //entering numbers
            Console.WriteLine("Enter two numbers");
            numberOne = int.Parse(Console.ReadLine());
            numberTwo = int.Parse(Console.ReadLine());

            //displaying before swapping
            Console.WriteLine("Before swapping, first number is:" + numberOne + " second number is: " + numberTwo);

            //passing paramters into swap function
            swap(ref numberOne, ref numberTwo);

            //Displaying after swapping
            Console.WriteLine("After swapping, first number is:" + numberOne + " second number is: " + numberTwo);

        }
        //Swap Method
        public static void swap(ref int a,ref int b)
        {
            //swapping by storing one number in a temporary variable
            int temp;
            temp = a;
            a = b;
            b = temp;
        }
    }
}
