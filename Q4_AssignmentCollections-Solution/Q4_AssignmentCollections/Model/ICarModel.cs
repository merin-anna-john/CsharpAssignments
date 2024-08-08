using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4_AssignmentCollections.Model
{
    public interface ICarModel
    {
        string Brand { get; set; }
        string Model { get; set; }
        int Year { get; set; }
    }
}
