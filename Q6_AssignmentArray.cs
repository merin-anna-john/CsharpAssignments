using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program in C# to delete an element at desired position from an array.
namespace AssignmentArray
{
    internal class Q6_AssignmentArray
    {
        static void Main(string[] args)
        {
            int i, j, temp,pos;

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
            Console.WriteLine("Enter the position where you want to delete.This array of elements starts with position 0:");
            pos = int.Parse(Console.ReadLine());

            //to delete element from array by comparing with position
            for (i = 0; i < limit; i++)
            {
                if (i == pos)
                {
                    //storing the element in the postion in a temporary variable and not using it again in the program
                    temp = original[i];

                    //shifting the elements by position and breaking it then because we need not to shift thereafter
                    original[i] = original[i + 1];
                    break;
                }
            }

            //shifting the rest of the elements from which the posiiton is found
            for(i=pos+1;i<limit-1;i++)
            {
                original[i] = original[i + 1];
            }

            //displaying the array after deleting the element of the required position
            Console.WriteLine("Array after deleting the element:");
            for (i=0;i<limit-1;i++)
            {
                Console.Write(original[i] + " ");
            }
        }
    }
}
