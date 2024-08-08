using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmnetOneVariablesandDatatypes
{
    internal class Q4_AssignmentOne
    {
        static void Main(string[] args)
        {
            int y;
            //Inputting value of y
            Console.Write("Enter value of y:");
            y = int.Parse(Console.ReadLine());
            //Printing value of x
            Console.WriteLine("The value of x is:" + ((y * y) + (2 * y) + 1));
            Console.ReadKey();
        }
    }
}
