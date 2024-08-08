using Q4_AssignmentCollections.Car;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4_AssignmentCollections.Model
{
    public interface IPart
    {
        string Code { get; set; }
        string Name { get; set; }
        string Category { get; set; }
        decimal PurchasePrice { get; set; }
        decimal SalePrice { get; set; }
        List<CarModel> CompatibleCarModels { get; set; }
        ManufacturingCompany Manufacturer { get; set; }
    }
}
