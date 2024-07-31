using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

//Write a program in C# to sort elements of the array in descending order. (Without using array functions).

namespace AssignmentArray
{
    internal class Q4_AssignmentArray
    {
        static void Main(string[] args)
        {
            int i, j, temp;

            //entering limit of array
            Console.WriteLine("Enter the array limit");
            int limit = int.Parse(Console.ReadLine());
            int[] arraysort = new int[limit];

            //entering array elements
            Console.WriteLine("Enter elements");
            for (i = 0; i < limit; i++)
            {

                arraysort[i] = int.Parse(Console.ReadLine());
            }

            //starting from first position of outer loop
            for (i = 0; i < limit; i++)
            {
                //comparing it with the next position elements
                for (j = 0; j < limit - i - 1; j++)
                {
                    //descending sorting
                    if (arraysort[j] < arraysort[j + 1])
                    {
                        temp = arraysort[j];
                        arraysort[j] = arraysort[j + 1];
                        arraysort[j + 1] = temp;
                    }
                }
            }
            //displaying array elements
            Console.WriteLine("Descending Sorted array is:");
            for (i = 0; i < limit; i++)
            {
                Console.Write(arraysort[i] + " ");
            }
        }
    }
}
