using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5_AssignmentCollections.Model
{
    // Derived class for Apartment
    public class Apartment : IEstate
    {
        public int FloorNumber { get; set; }
        public bool HasElevator { get; set; }
        public bool IsFurnished { get; set; }

        public Apartment(double area, decimal pricePerSquareMeter, string location, int floorNumber, bool hasElevator, bool isFurnished)
            : base(area, pricePerSquareMeter, location)
        {
            FloorNumber = floorNumber;
            HasElevator = hasElevator;
            IsFurnished = isFurnished;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Apartment - Area: {Area}, Price/SqM: {PricePerSquareMeter}, Location: {Location}, Floor: {FloorNumber}, Elevator: {HasElevator}, Furnished: {IsFurnished}");
        }
    }
}
