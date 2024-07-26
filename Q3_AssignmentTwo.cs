using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentTwo
{
    internal class Q3_AssignmentTwo
    {
        static void Main(string[] args)
        {
            int rollno, m1, m2, m3;
            string name;
            double percent,sum;
            char grade='0';

            //entering name
            Console.WriteLine("Enter your name");
            name=Console.ReadLine();

            //entering roll number
            Console.WriteLine("Enter your roll number:");
            rollno = int.Parse(Console.ReadLine());

            //entering marks of three subjects
            Console.WriteLine("Enter marks of three subjects:");
            Console.Write("Physics:");
            m1 = int.Parse(Console.ReadLine());
            Console.Write("Chemistry:");
            m2 = int.Parse(Console.ReadLine());
            Console.Write("Malayalam:");
            m3 = int.Parse(Console.ReadLine());

            //calculating sum
            sum = m1 + m2 + m3;

            //calculating percentage
            percent = (sum/ 300) * 100;

            //determining grade
            if(percent==100)
            {
                grade = 'S';
            }
            else if (percent>90)
            {
                grade = 'A';
            }
            else if(percent>80 && percent<=90)
            {
                grade = 'B';
            }
            else if(percent>70 && percent<=80)
            {
                grade = 'C';
            }
            else if(percent>60 && percent<=70)
            {
                grade = 'D';
            }
            else if(percent<60)
            {
                grade = 'F';
            }

            //prinitng all
            Console.WriteLine("Name is:" + name);
            Console.WriteLine("Roll number is:" + rollno);
            Console.WriteLine("Total mark is:" + sum);
            Console.WriteLine("Percentage is:" + percent + "%");
            Console.WriteLine("Grade:" + grade);
            Console.ReadKey();
        }
    }
}
