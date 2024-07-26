using System.Diagnostics.CodeAnalysis;
using System.Runtime.Intrinsics.Arm;

namespace AssignmentThreeLoops
{
    internal class Q3_AssignmentThreeLoops
    {
        public static void Main(string[] args)
        {
            int n,sum=0,rem;
            int x;
            //entering any number
            Console.WriteLine("Enter a number to check it is amstrong or not:");
            n = int.Parse(Console.ReadLine());
            //storing it in another variable
            x = n;
            //calculating the sum by extracting each digit and its cube
            while (n!=0)
            {
                rem = n % 10;
                sum = sum + (rem * rem * rem);
                n = n / 10;
            }
            //printing sum
            Console.WriteLine("Sum is:" + sum);
            //checking amstrong number
            if(sum==x)
            {
                Console.WriteLine("Amstrong Number");
            }
            else
            {
                Console.WriteLine("Not Amstrong Number");

            }
        }
    }
}
