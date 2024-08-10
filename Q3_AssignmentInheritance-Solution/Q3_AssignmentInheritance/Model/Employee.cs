using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Q3_AssignmentInheritance.Model
{
    public class Employee
    {
        public int EmployeeNumber { get; set; }
        public string Name { get; set; }
        public int BasicPay { get; set; }
        public Employee(int employeeNumber, string name, int basicPay)
        {
            EmployeeNumber = employeeNumber;
            Name = name;
            BasicPay = basicPay;
        }

        //Method
        public virtual void DisplayDetails()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"\nEmployee Name:{EmployeeNumber}");
            stringBuilder.AppendLine($"Employee Name:{Name}");
            stringBuilder.AppendLine($"Employee's Basic Pay:{BasicPay}");
            
            Console.WriteLine(stringBuilder.ToString());
        }
    }
}
