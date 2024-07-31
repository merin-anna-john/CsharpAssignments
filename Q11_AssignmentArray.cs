using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a C# program to sort a list of elements using Bubble sort.

namespace AssignmentArray
{
    internal class Q11_AssignmentArray
    {
        static void Main(string[] args)
        {
            int i, j, temp;

            //entering limit of array
            Console.WriteLine("Enter the array limit");
            int limit = int.Parse(Console.ReadLine());
            int[] sort = new int[limit];

            //entering array elemets for sorting
            Console.WriteLine("Enter elements");
            for (i = 0; i < limit; i++)
            {

                sort[i] = int.Parse(Console.ReadLine());
            }

            //starting from first position of outer loop
            for (i = 0; i < limit; i++)
            {
                //comparing it with the next position elements
                for (j = 0; j < limit - i - 1; j++)
                {
                    //sorting
                    if (sort[j] > sort[j + 1])
                    {
                        temp = sort[j];
                        sort[j] = sort[j + 1];
                        sort[j + 1] = temp;
                    }
                }
            }

            //displaying Sorted array
            Console.WriteLine("Bubble sorted array in ascending order is:");
            for (i = 0; i < limit; i++)
            {
                Console.Write(sort[i] + " ");
            }
        }
    }
}

