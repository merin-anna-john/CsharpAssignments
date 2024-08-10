using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentInheritance.Model
{
    public class Person
    {
        public string PersonName { get; set; }
        public string PersonAge { get; set; }
        public int PersonId { get; set; }

        public Person(string personName, string personAge,int personId)
        {
            this.PersonName = personName;
            this.PersonAge = personAge;
            this.PersonId= personId;
        }

        //Method
        public virtual void DisplayDetails()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"\nPerson Name:{PersonName}");
            stringBuilder.AppendLine($"Person Name:{PersonAge}");
            stringBuilder.AppendLine($"Person Id:{PersonId}");

            Console.WriteLine(stringBuilder.ToString());
        }
    }
}
