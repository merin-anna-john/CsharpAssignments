using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program in C# to accept two matrices and check whether they are equal
namespace AssignmentArray
{
    internal class Q10_AssignmentArray
    {
        static void Main(string[] args)
        {
            int i, j, temp,flag=0;

            //entering limit of first array
            Console.WriteLine("Enter the row limit of first array");
            int rowlimit1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the column limit of first array");
            int columnlimit1 = int.Parse(Console.ReadLine());
            int[,] first = new int[rowlimit1, columnlimit1];

            //entering limit of second array
            Console.WriteLine("Enter the row limit second array limit");
            int rowlimit2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the column limit second array limit");
            int columnlimit2 = int.Parse(Console.ReadLine());
            int[,] second = new int[rowlimit2, columnlimit2];

            if (rowlimit1 == rowlimit2 && columnlimit1 == columnlimit2)
            {
                //entering first array elements
                Console.WriteLine("Enter first array elements");
                for (i = 0; i < rowlimit1; i++)
                {
                    for (j = 0; j < columnlimit1; j++)
                    {
                        first[i, j] = int.Parse(Console.ReadLine());
                    }
                }

                //entering second array elements
                Console.WriteLine("Enter second array elements");
                for (i = 0; i < rowlimit1; i++)
                {
                    for (j = 0; j < columnlimit1; j++)
                    {
                        second[i, j] = int.Parse(Console.ReadLine());
                    }
                }

                //displaying the first array elements
                Console.WriteLine("The first array elements:");
                for (i = 0; i < rowlimit1; i++)
                {
                    for (j = 0; j < columnlimit1; j++)
                    {
                        Console.Write(first[i, j] + "\t");
                    }
                    Console.WriteLine(" ");

                }

                //displaying the seond array elements
                Console.WriteLine("\nThe second array elements:");
                for (i = 0; i < rowlimit2; i++)
                {
                    for (j = 0; j < columnlimit2; j++)
                    {
                        Console.Write(second[i, j] + "\t");
                    }
                    Console.WriteLine(" ");
                }

                //checking if both arrays are same
                for (i = 0; i < rowlimit1; i++)
                {
                    for (j = 0; j < columnlimit1; j++)
                    {
                        if (first[i,j] == second[i,j])
                        {
                            //flag is mentioned so that when each element is equal, it increments
                            flag++;
                        }
                    }
                    
                }
                if(flag>0)
                {
                    Console.WriteLine("\nThey are equal");

                }
            }
            else
            {
                Console.WriteLine("Enter same limit to both arrays to be checked if they are equal");

            }
        }
    }
}
