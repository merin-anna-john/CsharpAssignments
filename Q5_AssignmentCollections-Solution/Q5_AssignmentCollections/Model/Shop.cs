using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5_AssignmentCollections.Model
{
    // Derived class for Shop
    public class Shop : IEstate
    {
        public Shop(double area, decimal pricePerSquareMeter, string location)
            : base(area, pricePerSquareMeter, location)
        {
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Shop - Area: {Area}, Price/SqM: {PricePerSquareMeter}, Location: {Location}");
        }
    }
}
