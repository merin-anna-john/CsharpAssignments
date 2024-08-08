using Q4_AssignmentCollections.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4_AssignmentCollections.Car
{
    public class CarModel : ICarModel
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public CarModel(string brand, string model, int year)
        {
            Brand = brand;
            Model = model;
            Year = year;
        }

        public override string ToString()
        {
            return $"{Brand} {Model}, {Year}";
        }
    }

}
