using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentTwo
{
    internal class Q4_AssignmentTwo
    {
        public static void Main(string[] args)
        {
            //Entering the marks for maths,phy,chem
            double maths,phy,chem,sum,summp,summc;
            Console.WriteLine("Enter the mark for Maths:");
            maths = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the mark for Physics:");
            phy = double.Parse(Console.ReadLine()); 
            Console.WriteLine("Enter the mark for Chemistry:");
            chem = double.Parse(Console.ReadLine());
            //Calculating total marks
            sum = maths + phy + chem;
            //Calculating mark of maths and physics
            summp = maths + phy;
            //Calculating mark of maths and chemistry
            summc = maths + chem;
            //cheking eligibility
            if(((maths >= 65 && phy >= 55 && chem>= 50) && (sum > 180))||((summp >= 140) || (summc >= 140)))
            {
                Console.WriteLine("Eligible for Admission");
            }
            else
            {
                Console.WriteLine("Not eligible for Admission");
            }

        }

    }
}
