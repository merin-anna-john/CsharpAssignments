using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program in C# to calculate the sum of elements in an array using methods.

namespace AssignmentSixMethods
{
    internal class Q2_AssignmentMethods
    {
        //Main
        public static void Main(string[] args)
        {
            int sumofelemeents = sum();
            Console.WriteLine("The  sum of elements in an array is: " + sumofelemeents);
        }
        //Method
        public static int sum()
        {
            //Entering limit of array
            Console.WriteLine("Enter the array limit: ");
            int limit=int.Parse(Console.ReadLine());

            //Entering array elements
            Console.WriteLine("Enter the array elements");
            int[] sumarray = new int[limit];
            for(int i=0;i<limit;i++)
            {
                sumarray[i] = int.Parse(Console.ReadLine());
            }

            //calculating sum of elements
            int sumofelements = 0;
            for(int i=0; i<limit;i++)
            {
                sumofelements += sumarray[i];
            }
            return sumofelements;

        }
    }
}
