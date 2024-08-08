using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5_AssignmentCollections.NewModel
{
    public class Employee
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public int Experience { get; set; }

        public Employee(string name, string position, int experience)
        {
            Name = name;
            Position = position;
            Experience = experience;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Employee - Name: {Name}, Position: {Position}, Experience: {Experience} years");
        }
    }
}
