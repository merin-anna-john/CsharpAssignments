using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5_AssignmentCollections.Model
{
    // Derived class for House
    public class House : IEstate
    {
        public double DevelopedArea { get; set; }
        public double UndevelopedArea { get; set; }
        public int NumberOfFloors { get; set; }
        public bool IsFurnished { get; set; }

        public House(double area, decimal pricePerSquareMeter, string location, double developedArea, double undevelopedArea, int numberOfFloors, bool isFurnished)
            : base(area, pricePerSquareMeter, location)
        {
            DevelopedArea = developedArea;
            UndevelopedArea = undevelopedArea;
            NumberOfFloors = numberOfFloors;
            IsFurnished = isFurnished;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"House - Area: {Area}, Price/SqM: {PricePerSquareMeter}, Location: {Location}, Developed Area: {DevelopedArea}, Undeveloped Area: {UndevelopedArea}, Floors: {NumberOfFloors}, Furnished: {IsFurnished}");
        }
    }
}
