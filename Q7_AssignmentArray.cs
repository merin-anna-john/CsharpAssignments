using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

//Write a program in C# to find the second smallest element in an array.
namespace AssignmentArray
{
    internal class Q7_AssignmentArray
    {
        static void Main(string[] args)
        {
            int i, j, temp;

            //entering limit of array
            Console.WriteLine("Enter the array limit");
            int limit = int.Parse(Console.ReadLine());
            int[] original = new int[limit];

            //entering array elements
            Console.WriteLine("Enter elements");
            for (i = 0; i < limit; i++)
            {

                original[i] = int.Parse(Console.ReadLine());
            }

            //starting from first position of outer loop
            for (i = 0; i < limit; i++)
            {
                //comparing it with the next position elements
                for (j = 0; j < limit - i - 1; j++)
                {
                    //sorting
                    if (original[j] > original[j + 1])
                    {
                        temp = original[j];
                        original[j] = original[j + 1];
                        original[j + 1] = temp;
                    }
                }
            }

            //displaying Sorted array
            Console.WriteLine("Sorted array is:");
            for (i = 0; i < limit; i++)
            {
                Console.Write(original[i] + " ");
            }

            //displaying second smallest element
            Console.WriteLine("\nSecond smallest element in array is:");
            Console.Write(original[1] + " ");
        }
    }
}
