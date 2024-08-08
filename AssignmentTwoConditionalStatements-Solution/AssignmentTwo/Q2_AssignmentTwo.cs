using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentTwo
{
    internal class Q2_AssignmentTwo
    {
        public static void Main(string[] args)
        {
            int x, y;
            //entering x coordinates
            Console.WriteLine("Enter X coordinate:");
            x = int.Parse(Console.ReadLine());
            //entering y coordinates
            Console.WriteLine("Enter Y coordinate:");
            y = int.Parse(Console.ReadLine());
            if (x>0 && y>0)
            {
                Console.WriteLine("First Quadrant");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Second Quadrant");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Third Quadrant");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("Forth Quadrant");
            }
            else if(x==0 && y==0)
            {
                Console.WriteLine("At Origin");
            }
            else
            {
                Console.WriteLine("Wrong input");
            }
        }
    }
}
