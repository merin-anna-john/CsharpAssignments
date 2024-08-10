using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

//Write a program in C# to extract a substring from a given string without using the library function
namespace AssignmentFiveString
{
    internal class Q6_AssignmentString
    {
        public static void Main(string[] args)
        {
            // Entering string
            Console.Write("Enter a string: ");
            string word = Console.ReadLine();

            // Entering start index
            Console.Write("Enter the start index: ");
            int startIndex = int.Parse(Console.ReadLine());

            // Entering length of the substring
            Console.Write("Enter the length of the substring: ");
            int length = int.Parse(Console.ReadLine());

            // Validate startIndex and length
            if (startIndex < 0 || startIndex >= word.Length)
            {
                Console.WriteLine("Start index is out of bounds.");
                return;
            }

            if (length < 0 || startIndex + length > word.Length)
            {
                Console.WriteLine("Invalid length.");
                return;
            }

            // Extracting substring
            char[] result = new char[length];
            for (int i = 0; i < length; i++)
            {
                result[i] = word[startIndex + i];
            }

            // Converting char array to string
            string substring = new string(result);

            // Displaying result
            Console.WriteLine("Extracted substring: " + substring);
        }
    }
}
