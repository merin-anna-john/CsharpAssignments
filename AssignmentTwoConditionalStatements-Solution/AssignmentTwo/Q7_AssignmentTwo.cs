using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentTwo
{
    internal class Q7_AssignmentTwo
    {
        public static void Main(string[] args)
        {
            string name;
            int id, unit;

            //entering name
            Console.WriteLine("Enter name of customer:");
            name = Console.ReadLine();

            //entering customer id
            Console.WriteLine("Enter customer ID:");
            id = int.Parse(Console.ReadLine());

            //entering unit consumed by customer
            Console.WriteLine("Enter unit consumed by customer:");
            unit = int.Parse(Console.ReadLine());

            //displaying details
            Console.WriteLine("Name of customer:" + name);
            Console.WriteLine("Customer ID:" + id);
            Console.WriteLine("Unit consumed by customer:" + unit);

            //calculatind total amount
            if (unit <= 199)
            {
                Console.WriteLine("Total amount to be paid is:" + (unit * 1.20));
            }
            else if (unit > 200 && unit <= 400)
            {
                Console.WriteLine("Total amount to be paid is:" + (unit * 1.50));
            }
            else if (unit > 400 && unit <= 600)
            {
                Console.WriteLine("Total amount to be paid is:" + (unit * 1.80));
            }
            else
            {
                Console.WriteLine("Total amount to be paid is:" + (unit * 2.00));
            }
        }
    }
}
