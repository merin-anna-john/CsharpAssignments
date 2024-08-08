using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program in C# to separate odd and even integers in separate arrays.
namespace AssignmentArray
{
    internal class Q3_AsignmentArray
    {
        static void Main(string[] args)
        {
            int i, j, k, temp, even = 0, odd = 0;

            //entering limit of array
            Console.WriteLine("Enter the array limit");
            int limit = int.Parse(Console.ReadLine());
            int[] original = new int[limit];
            int[] evenarray = new int[limit];
            int[] oddarray = new int[limit];

            //entering array elements
            Console.WriteLine("Enter elements");
            for (i = 0; i < limit; i++)
            {
                original[i] = int.Parse(Console.ReadLine());
            }

            //starting from first position of outer loop
            for (i = 0; i < limit; i++)
            {
                if (original[i] % 2 == 0)
                {
                    evenarray[even] = original[i];
                    even++;
                }
                else
                {
                    oddarray[odd] = original[i];
                    odd++;
                }
            }

            //even is the limit and to display
            Console.WriteLine("Even array is:");
            for (j = 0; j < even; j++)
            {
                Console.Write(evenarray[j]+" ");
            }

            //odd is the limit and to display
            Console.WriteLine("\nOdd array is:");
            for (j = 0; j < odd; j++)
            {
                Console.Write(oddarray[j]+" ");
            }
        }
    }
}
