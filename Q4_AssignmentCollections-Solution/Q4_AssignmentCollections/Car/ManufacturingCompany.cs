﻿using Q4_AssignmentCollections.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4_AssignmentCollections.Car
{
    public class ManufacturingCompany : IManufacturingCompany
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }

        public ManufacturingCompany(string name, string country, string address, string phone, string fax)
        {
            Name = name;
            Country = country;
            Address = address;
            Phone = phone;
            Fax = fax;
        }

        public override string ToString()
        {
            return $"Name:{Name}, Country:{Country}, Address:{Address}, Phone:{Phone}, Fax:{Fax}";
        }
    }
}
