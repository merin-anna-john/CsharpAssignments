using Q4_AssignmentCollections.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4_AssignmentCollections.Car
{
    public class Part : IPart
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal SalePrice { get; set; }
        public List<CarModel> CompatibleCarModels { get; set; }
        public ManufacturingCompany Manufacturer { get; set; }

        public Part(string code, string name, string category, decimal purchasePrice, decimal salePrice, List<CarModel> compatibleCarModels, ManufacturingCompany manufacturer)
        {
            Code = code;
            Name = name;
            Category = category;
            PurchasePrice = purchasePrice;
            SalePrice = salePrice;
            CompatibleCarModels = compatibleCarModels;
            Manufacturer = manufacturer;
        }

        public override string ToString()
        {
            string carModels = string.Join(", ", CompatibleCarModels);
            return $"\n{Name} ({Code}) - Category:{Category}, Purchase Price: {PurchasePrice}, Sale Price: {SalePrice}, Compatible Models: {carModels}. \nManufacturer details: {Manufacturer}";
        }
    }
}
