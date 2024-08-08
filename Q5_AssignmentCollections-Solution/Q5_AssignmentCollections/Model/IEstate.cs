using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5_AssignmentCollections.Model
{
    public abstract class IEstate
    {
        public double Area { get; set; }
        public decimal PricePerSquareMeter { get; set; }
        public string Location { get; set; }

        public IEstate(double area, decimal pricePerSquareMeter, string location)
        {
            Area = area;
            PricePerSquareMeter = pricePerSquareMeter;
            Location = location;
        }

        public abstract void DisplayInfo();
    }
}
