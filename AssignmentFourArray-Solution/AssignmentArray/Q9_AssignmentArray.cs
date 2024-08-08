using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program in C# for multiplication of two square Matrices

namespace AssignmentArray
{
    internal class Q9_AssignmentArray
    {
        static void Main(string[] args)
        {
            int i, j,k, temp;

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

            int[,] mul=new int[rowlimit1, columnlimit2]; 

            if (rowlimit1 == columnlimit2 && columnlimit1 == rowlimit2)
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
                for (i = 0; i < rowlimit2; i++)
                {
                    for (j = 0; j < columnlimit2; j++)
                    {
                        second[i, j] = int.Parse(Console.ReadLine());
                    }
                }

                //multiplied array elements
                for (i = 0; i < rowlimit1; i++)
                {
                    for (j = 0; j < columnlimit2; j++)
                    {
                        //k is used here beacuse we are taking the corresponding elements from the other array(rowlimit2=columnlimit1)
                        for(k=0;k<columnlimit1;k++)
                        {
                            mul[i, j] = mul[i,j]+(first[i, k] * second[k, j]);
                        }
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

                //displaying the second array elements
                Console.WriteLine("\nThe second array elements:");
                for (i = 0; i < rowlimit2; i++)
                {
                    for (j = 0; j < columnlimit2; j++)
                    {
                        Console.Write(second[i, j] + "\t");
                    }
                    Console.WriteLine(" ");
                }
                //displaying the multiplication array elements
                Console.WriteLine("\nThe multiplied array elements:");
                for (i = 0; i < rowlimit1; i++)
                {
                    for (j = 0; j < columnlimit2; j++)
                    {
                        Console.Write(mul[i, j] + "\t");
                    }
                    Console.WriteLine(" ");
                }
            }
            else
            {
                Console.WriteLine("Enter correct limit to both arrays to get multiplied");

            }
        }
    }
}

