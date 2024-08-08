using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program in C# to count a total number of duplicate elements in an array
namespace AssignmentArray
{
    internal class Q1_AssignmentArray
    {
        static void Main(string[] args)
        {
            int i, j, c = 0;
            //entering limit of array
            Console.WriteLine("Enter the array limit");
            int limit = int.Parse(Console.ReadLine());
            int[] count = new int[limit];
            //entering array elements
            Console.WriteLine("Enter elements");
            for (i = 0; i < limit; i++)
            {

                count[i] = int.Parse(Console.ReadLine());
            }
            //starting from first position of outer loop
            for (i = 0; i < limit; i++)
            {
                //comparing it with the next position elements
                for (j = i + 1; j < limit; j++)
                {
                    //if any elements is having the same value it counts
                    if (count[i] == count[j])
                    {
                        c++;
                    }
                }
            }
            Console.WriteLine("Count is:" + c);
        }
    }
}
