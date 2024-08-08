using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentTwo
{
    internal class Q5_AssignmentTwo
    {
        public static void Main(string[] args)
        {
            double side, l, b, r, area;
            int ch;
            //showing MENU
            Console.WriteLine("1.Square \n2.Rectangle \n3.Traingle \n4.Circle");
            Console.WriteLine("Enter your choice");
            ch = int.Parse(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    {
                        //Square details
                        Console.WriteLine("You chose Square");
                        Console.WriteLine("Enter the side");
                        side = double.Parse(Console.ReadLine());
                        area = side * side;
                        Console.WriteLine("Area of square is:" + area);
                        break;
                    }
                case 2:
                    {
                        //Rectangle details
                        Console.WriteLine("You chose Rectangle");
                        Console.WriteLine("Enter the length");
                        l = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the breadth");
                        b = double.Parse(Console.ReadLine());
                        area = l * b;
                        Console.WriteLine("Area of rectangle is:" + area);
                        break;
                    }
                case 3:
                    {
                        //Traingle details
                        Console.WriteLine("You chose Triangle");
                        Console.WriteLine("Enter the length");
                        l = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the breadth");
                        b = double.Parse(Console.ReadLine());
                        area = 0.5 * (l * b);
                        Console.WriteLine("Area of triangle is:" + area);
                        break;
                    }
                case 4:
                    {
                        //Circle details
                        Console.WriteLine("You chose Circle");
                        Console.WriteLine("Enter the radius");
                        r = double.Parse(Console.ReadLine());
                        area = 3.14 * (r * r);
                        Console.WriteLine("Area of circle is:" + area);
                        break;
                    }

            }
        }
    }
}
