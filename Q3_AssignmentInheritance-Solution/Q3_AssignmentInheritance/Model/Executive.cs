using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3_AssignmentInheritance.Model
{
    public class Executive:Employee
    {
        public Executive (int employeeNumber, string name,  int basicPay)
            :base(employeeNumber,name,basicPay)
        {
           if(basicPay<10000)
            {
                Console.WriteLine("Basic salary should be more than 10000 to be executive");
            }
        }

        // Method
        public override void DisplayDetails()
        {
            Console.WriteLine("Executive details:");
            base.DisplayDetails();
        }
    }
}
