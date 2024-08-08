using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmnetOneVariablesandDatatypes
{
    internal class Q2_AssignmentOne
    {
        static void Main(string[] args)
        {
            int width, length;
            //to enter width
            Console.Write("Enter width");
            width = int.Parse(Console.ReadLine());
            //to enter length
            Console.Write("Enter length");
            length = int.Parse(Console.ReadLine());
            //Printing area
            Console.Write("Area is" + (0.5 * width * length));
            Console.ReadKey();
        }
    }
}
