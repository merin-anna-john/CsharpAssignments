using Q5_AssignmentCollections.Model;
using Q5_AssignmentCollections.NewModel;

namespace Q5_AssignmentCollections
{
    public class Program
    {
        static void Main(string[] args)
        {
            Company company = new Company("Real Estate Co", "Vincent S", "123456789");

            Employee emp1 = new Employee("John Daniel", "Agent", 5);
            Employee emp2 = new Employee("Boby Johnny", "Manager", 10);

            company.AddEmployee(emp1);
            company.AddEmployee(emp2);

            Apartment apt = new Apartment(80, 1500, "Downtown", 5, true, true);
            House house = new House(250, 1200, "Suburbs", 200, 50, 2, true);
            UndevelopedArea undevelopedArea = new UndevelopedArea(500, 500, "Rural");
            Shop shop = new Shop(100, 2000, "Commercial Area");

            company.AddEstate(apt);
            company.AddEstate(house);
            company.AddEstate(undevelopedArea);
            company.AddEstate(shop);

            company.DisplayInfo();
        }
    }
}

