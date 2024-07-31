using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program in C# for addition of two Matrices of same size.
namespace AssignmentArray
{
    internal class Q8_AssignmentArray
    {
        static void Main(string[] args)
        {
            int i, j, temp;

            //entering limit of first array
            Console.WriteLine("Enter the row limit of first array");
            int rowlimit1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the column limit of first array");
            int columnlimit1 = int.Parse(Console.ReadLine());
            int[,] first = new int[rowlimit1,columnlimit1];

            //entering limit of second array
            Console.WriteLine("Enter the row limit second array limit");
            int rowlimit2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the column limit second array limit");
            int columnlimit2 = int.Parse(Console.ReadLine());
            int[,] second = new int[rowlimit2,columnlimit2];

            int[,]add=new int[rowlimit2,columnlimit2];

            if (rowlimit1==rowlimit2 && columnlimit1==columnlimit2)
            {
                //entering first array elements
                Console.WriteLine("Enter first array elements");
                for (i = 0; i < rowlimit1; i++)
                {
                    for(j=0;j<columnlimit1;j++)
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

                //adding array elements
                for (i = 0; i < rowlimit1; i++)
                {
                    for (j = 0; j < columnlimit1; j++)
                    {
                        add[i, j] = first[i, j] + second[i, j];
                    }
                }

                //displaying the first array elements
                Console.WriteLine("The first array elements:");
                for (i = 0; i < rowlimit1; i++)
                {
                    for (j = 0; j < columnlimit1; j++)
                    {
                        Console.Write(first[i,j] + "\t");
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

                //displaying the array elements after addition
                Console.WriteLine("\nThe array elements after addition:");
                for (i = 0; i < rowlimit2; i++)
                {
                    for (j = 0; j < columnlimit2; j++)
                    {
                        Console.Write(add[i, j] + "\t");
                    }
                    Console.WriteLine(" ");
                }
            }
            else
            {
                Console.WriteLine("Enter same limit to both arrays to get added");

            }
        }
    }
}
