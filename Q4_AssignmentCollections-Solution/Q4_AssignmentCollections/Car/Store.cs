using Q4_AssignmentCollections.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4_AssignmentCollections.Car
{
    public class Store
    {
        public List<IPart> Parts { get; set; }

        public Store()
        {
            Parts = new List<IPart>();
        }

        public void AddPart(IPart part)
        {
            Parts.Add(part);
        }

        public void ShowAllParts()
        {
            foreach (var part in Parts)
            {
                Console.WriteLine(part);
            }
        }
    }
}
