using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5_AssignmentCollections.Model
{
    // Derived class for UndevelopedArea
    public class UndevelopedArea : IEstate
    {
        public UndevelopedArea(double area, decimal pricePerSquareMeter, string location)
            : base(area, pricePerSquareMeter, location)
        {
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Undeveloped Area - Area: {Area}, Price/SqM: {PricePerSquareMeter}, Location: {Location}");
        }
    }
}
