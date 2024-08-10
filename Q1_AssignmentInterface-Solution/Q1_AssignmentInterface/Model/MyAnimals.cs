using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1_AssignmentInterface.Model
{
    // Define the class MyAnimals that inherits from Animals and implements IMammals
    internal class MyAnimals : Animals, IMammals
    {
        // Property BodyTemp with getters and setters
        public int BodyTemp { get; set; }

        // Implementation of the GetBodyTemp method from the IMammals interface
        public int GetBodyTemp(string temp)
        {
            // Example implementation
            if (temp == "Normal")
            {
                BodyTemp = 37; // Normal body temperature in Celsius
            }
            else if (temp == "Fever")
            {
                BodyTemp = 38; // Fever body temperature in Celsius
            }
            else
            {
                BodyTemp = 0; // Default 
            }

            // Return the BodyTemp property value
            return BodyTemp;
        }

        // Implementation of the SaySomething method from the Animals abstract class
        public override void SaySomething()
        {
            Console.WriteLine("I am an animal.");
        }
    }
}
