using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentInheritance.Model
{
    public class Student : Person
    {
        public int Roll { get; set; }
        public int Mark { get; set; }

        public Student(string personName, string personAge,int personId, int roll, int mark)
            : base(personName, personAge,personId)
        {
            this.Roll = roll;
            this.Mark = mark;
        }

        // Method
        public override void DisplayDetails()
        {
            base.DisplayDetails();
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Roll Number: {Roll}");
            stringBuilder.AppendLine($"Mark : {Mark}");

            Console.WriteLine(stringBuilder.ToString());
        }
    }
}
