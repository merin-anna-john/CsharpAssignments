using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentThreeLoops
{
    internal class Q6_AssignmentLoops
    {
        public static void Main(string[] args)
        {
        int n,i,a,b,c;
        //entering range
        Console.WriteLine("Enter a range for fibonacci series:");
        n = int.Parse(Console.ReadLine());
        //intializing first two values
        a=0;
        b=1;

        Console.WriteLine(a);
        Console.WriteLine(b);
        //starting from the third position of fibonacci series
        for(i=3;i<=n;i++)
        {
            c=a+b;
            Console.WriteLine(c);
            //exchanging the values 
            a=b;
            b=c;
        }
        
        }
    }
}
