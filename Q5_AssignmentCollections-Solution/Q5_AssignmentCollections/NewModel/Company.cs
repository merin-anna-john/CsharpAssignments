using Q5_AssignmentCollections.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5_AssignmentCollections.NewModel
{
    public class Company
    {
        public string Name { get; set; }
        public string Owner { get; set; }
        public string TaxID { get; set; }
        public List<Employee> Employees { get; set; }
        public List<IEstate> EstatesForSale { get; set; }

        public Company(string name, string owner, string taxID)
        {
            Name = name;
            Owner = owner;
            TaxID = taxID;
            Employees = new List<Employee>();
            EstatesForSale = new List<IEstate>();
        }

        public void AddEmployee(Employee employee)
        {
            Employees.Add(employee);
        }

        public void AddEstate(IEstate estate)
        {
            EstatesForSale.Add(estate);
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Company - Name: {Name}, Owner: {Owner}, TaxID: {TaxID}");
            Console.WriteLine("Employees:");
            foreach (var employee in Employees)
            {
                employee.DisplayInfo();
            }

            Console.WriteLine("Estates for Sale:");
            foreach (var estate in EstatesForSale)
            {
                estate.DisplayInfo();
            }
        }
    }
}
