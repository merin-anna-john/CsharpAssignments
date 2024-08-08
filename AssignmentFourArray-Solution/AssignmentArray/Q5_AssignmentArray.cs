using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program in C# to insert New value in the array(sorted list).
namespace AssignmentArray
{
    internal class Q5_AssignmentArray
    {
        static void Main(string[] args)
        {
            int i, j, temp,ele;

            //entering limit of array
            Console.WriteLine("Enter the array limit");
            int limit = int.Parse(Console.ReadLine());
            int[] sortarray = new int[100];

            //entering array elements
            Console.WriteLine("Enter elements");
            for (i = 0; i < limit; i++)
            {
                sortarray[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter an element to be inserted:");
            ele = int.Parse(Console.ReadLine());
            sortarray[limit] = ele;

            //displaying old array elements
            Console.WriteLine("Old Sorted array is:");
            for (i = 0; i < limit; i++)
            {
                Console.Write(sortarray[i] + " ");
            }

            //displaying new element
            Console.WriteLine("\nNew element is:" + ele);

            for (i = 0; i <= limit; i++)
            {
                //comparing it with the next position elements
                for (j = 0; j <= limit - 1-i ; j++)
                {
                    //sorting
                    if (sortarray[j] > sortarray[j+1])
                    {
                        temp = sortarray[j+1];
                        sortarray[j+1] = sortarray[j];
                        sortarray[j] = temp;
                    }
                }
            }
            //displaying new array elements
            Console.WriteLine("New Sorted array after entering new element is:");
            for (i = 0; i <= limit; i++)
            {
                Console.Write(sortarray[i] + " ");
            }
        }
    }
}
