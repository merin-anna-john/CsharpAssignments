using Q4_AssignmentCollections.Model;

namespace Q4_AssignmentCollections
{
    internal class Program
    {
        static void Main()
        {
            // Creating manufacturing companies
            ManufacturingCompany company1 = new ManufacturingCompany("AutoCorp", "Germany", "1234 Autobahn", "123-456-7890", "123-456-7891");
            ManufacturingCompany company2 = new ManufacturingCompany("PartsUnlimited", "USA", "5678 Broadway", "987-654-3210", "987-654-3211");

            // Creating car models
            CarModel carModel1 = new CarModel("Mercedes", "C320", 2008);
            CarModel carModel2 = new CarModel("BMW", "X5", 2012);

            // Creating auto parts
            Part part1 = new Part(
                "P001",
                "Brake Pad",
                "Suspension",
                50.00m,
                75.00m,
                new List<CarModel> { carModel1, carModel2 },
                company1
            );

            Part part2 = new Part(
                "P002",
                "Engine Oil",
                "Engine",
                30.00m,
                45.00m,
                new List<CarModel> { carModel2 },
                company2
            );

            // Creating store and add parts
            Store store = new Store();
            store.AddPart(part1);
            store.AddPart(part2);

            // Show all auto parts
            store.ShowAllParts();
        }
    }
}
