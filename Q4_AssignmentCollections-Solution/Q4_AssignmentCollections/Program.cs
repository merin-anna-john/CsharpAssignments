using Q4_AssignmentCollections.Car;
using static System.Formats.Asn1.AsnWriter;

namespace Q4_AssignmentCollections
{
    internal class Program
    {
        static void Main()
        {
            Store store = new Store();

            Console.WriteLine("Enter number of parts to add:");
            int numberOfParts = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfParts; i++)
            {
                Console.WriteLine($"Enter details for part {i + 1}:");

                Console.Write("Code: ");
                string code = Console.ReadLine();

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Category: ");
                string category = Console.ReadLine();

                Console.Write("Purchase Price: ");
                decimal purchasePrice = decimal.Parse(Console.ReadLine());

                Console.Write("Sale Price: ");
                decimal salePrice = decimal.Parse(Console.ReadLine());

                Console.WriteLine("Enter number of compatible car models:");
                int numberOfCarModels = int.Parse(Console.ReadLine());

                List<CarModel> compatibleCarModels = new List<CarModel>();

                for (int j = 0; j < numberOfCarModels; j++)
                {
                    Console.WriteLine($"Enter details for car model {j + 1}:");

                    Console.Write("Brand: ");
                    string brand = Console.ReadLine();

                    Console.Write("Model: ");
                    string model = Console.ReadLine();

                    Console.Write("Year: ");
                    int year = int.Parse(Console.ReadLine());

                    CarModel carModel = new CarModel(brand, model, year);
                    compatibleCarModels.Add(carModel);
                }

                Console.WriteLine("Enter manufacturer details:");

                Console.Write("Name: ");
                string manufacturerName = Console.ReadLine();

                Console.Write("Country: ");
                string manufacturerCountry = Console.ReadLine();

                Console.Write("Address: ");
                string manufacturerAddress = Console.ReadLine();

                Console.Write("Phone: ");
                string manufacturerPhone = Console.ReadLine();

                Console.Write("Fax: ");
                string manufacturerFax = Console.ReadLine();

                ManufacturingCompany manufacturer = new ManufacturingCompany(manufacturerName, manufacturerCountry, manufacturerAddress, manufacturerPhone, manufacturerFax);

                Part part = new Part(code, name, category, purchasePrice, salePrice, compatibleCarModels, manufacturer);
                store.AddPart(part);
            }

            // Show all auto parts
            store.ShowAllParts();
        }
    }
}

