using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentTwo
{
    internal class Q6_AssignmentTwo
    {
        public static void Main(string[] args)
        {

            int a, b, ch;
            double sum, diff, pro, rem;
            //showing MENU
            Console.WriteLine("1.Addition \n2.Subtraction \n3.Multiplication \n4.Division");
            Console.WriteLine("Enter your choice");
            ch = int.Parse(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    {
                        //Addition details
                        Console.WriteLine("Enter first number");
                        a = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter second number");
                        b = int.Parse(Console.ReadLine());
                        sum = a + b;
                        Console.WriteLine("Sum is:" + sum);
                        break;
                    }
                case 2:
                    {
                        //Subtraction details
                        Console.WriteLine("Enter first number");
                        a = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter second number");
                        b = int.Parse(Console.ReadLine());
                        diff = a - b;
                        Console.WriteLine("Difference is:" + diff);
                        break;
                    }
                case 3:
                    {
                        //Multiplication details
                        Console.WriteLine("Enter first number");
                        a = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter second number");
                        b = int.Parse(Console.ReadLine());
                        pro = a * b;
                        Console.WriteLine("Product is:" + pro);
                        break;
                    }
                case 4:
                    {
                        //Division details
                        Console.WriteLine("Enter first number");
                        a = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter second number");
                        b = int.Parse(Console.ReadLine());
                        rem = a / b;
                        Console.WriteLine("Reaminder is:" + rem);
                        break;
                    }
            }
        }
    }
}
