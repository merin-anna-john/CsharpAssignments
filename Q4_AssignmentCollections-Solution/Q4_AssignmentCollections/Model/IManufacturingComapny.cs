using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4_AssignmentCollections.Model
{
    public interface IManufacturingCompany
    {
        string Name { get; set; }
        string Country { get; set; }
        string Address { get; set; }
        string Phone { get; set; }
        string Fax { get; set; }
    }
}
