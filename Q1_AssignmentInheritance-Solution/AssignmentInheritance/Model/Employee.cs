using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentInheritance.Model
{
    public class Employee : Person
    {
        public string BusinessPartner { get; set; }
        public string HumanResource { get; set; }
        public int Salary { get; set; }

        public Employee(string personName, string personAge,int personId, string businessPartner, string humanResource, int salary)
            : base(personName, personAge, personId)
        {
            this.BusinessPartner = businessPartner;
            this.HumanResource = humanResource;
            this.Salary = salary;
        }

        // Method
        public override void DisplayDetails()
        {
            base.DisplayDetails();
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Business Partner Name: {BusinessPartner}");
            stringBuilder.AppendLine($"Human Resource Name: {HumanResource}");
            stringBuilder.AppendLine($"Salary: {Salary}");


            Console.WriteLine(stringBuilder.ToString());
        }
    }
}
