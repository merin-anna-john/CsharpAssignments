using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmnetOneVariablesandDatatypes
{
    internal class Q3_AssignmentOne
    {
        static void Main(string[] args)
        {
            int distance, time;
            //to enter distance
            Console.Write("Enter distance in meters:");
            distance = int.Parse(Console.ReadLine());
            //to enter time
            Console.Write("Enter time in seconds:");
            time = int.Parse(Console.ReadLine());
            //Printing speed
            Console.WriteLine("Speed in kilometers per hours is:" + ((distance / 1000) / (time / (60 * 60))) + "km/hr");
            Console.WriteLine("Speed in miles per hours is:" + ((distance * 0.000621371) / (time / (60 * 60))) + "km/hr");
            Console.ReadKey();
        }
    }
}
