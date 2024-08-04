using AssignmentInheritance.Model;
using System.Diagnostics.Contracts;
using System.Security.Principal;

namespace AssignmentInheritance
{
    internal class Company
    {
        // Store the details
        static Person[] members = new Person[100];
        static int memberCount = 0;

        #region Entry
        static void Main(string[] args)
        {
            // MENU
            while (true)
            {
                Console.WriteLine("\nCompany Members");
                Console.WriteLine("1. Add New Member");
                Console.WriteLine("2. Display All Members");
                Console.WriteLine("3. Search Member by Member ID");
                Console.WriteLine("4. Exit");
                Console.WriteLine("Enter the choice:");

                // Get choice
                string choice = Console.ReadLine();
                // Check Condition
                switch (choice)
                {
                    case "1":
                        AddNewMember();
                        break;
                    case "2":
                        DisplayAllMembers();
                        break;
                    case "3":
                        SearchMember();
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Invalid Choice! Please try again...");
                        break;
                }
            }

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
        #endregion

        #region AddNewMember
        private static void AddNewMember()
        {
            Console.WriteLine("Add a New Member");

            // Get input from the user and add it to members array
            if (memberCount >= members.Length)
            {
                Console.WriteLine("Member storage is full. Cannot add more members");
                return;
            }

            // Select Member Type
            Console.WriteLine("\nSelect Member Type");
            Console.WriteLine("1. Student");
            Console.WriteLine("2. Employee");
            Console.WriteLine("Enter your choice:");
            string memberTypeChoice = Console.ReadLine();

            // Member ID
            Console.Write("Enter Person ID: ");
            int personId = GetValidIntegerInput();

            // Person Name
            Console.Write("Enter Person Name: ");
            string personName = Console.ReadLine();

            // Person Age
            Console.Write("Enter Person Age: ");
            string personAge = Console.ReadLine();

            // Check Member Type
            if (memberTypeChoice == "1") // Student
            {
                // Roll Number
                Console.Write("Enter Roll Number: ");
                int roll = GetValidIntegerInput();

                // Mark
                Console.Write("Enter Mark: ");
                int mark = GetValidIntegerInput();

                // Add elements in an array
                members[memberCount++] = new Student(personName, personAge, personId, roll, mark);
                Console.WriteLine("Added successfully");
            }
            else if (memberTypeChoice == "2") // Employee
            {
                // BusinessPartner
                Console.Write("Enter Business Partner: ");
                string businessPartner = Console.ReadLine();

                // HumanResource
                Console.Write("Enter Human Resource: ");
                string humanResource = Console.ReadLine();

                //Salary
                Console.Write("Enter Salary: ");
                int salary = GetValidIntegerInput();

                // Add elements in an array
                members[memberCount++] = new Employee(personName, personAge, personId, businessPartner, humanResource, salary);
            }
            else
            {
                Console.WriteLine("Invalid Member Type Choice");
            }
        }

        // Validate integer input
        private static int GetValidIntegerInput()
        {
            int validInput;
            while (!int.TryParse(Console.ReadLine(), out validInput))
            {
                Console.Write("Invalid Input! Please enter a valid integer: ");
            }
            return validInput;
        }
        #endregion

        #region DisplayAllMembers
        private static void DisplayAllMembers()
        {
            Console.WriteLine("Display All Members");
            for (int i = 0; i < memberCount; i++)
            {
                members[i].DisplayDetails();
            }
        }
        #endregion

        #region SearchMember
        private static void SearchMember()
        {
            Console.WriteLine("Search a member by Member ID");
            Console.Write("Enter Member ID: ");
            int memberId = GetValidIntegerInput();

            bool memberFound = false;
            for (int i = 0; i < memberCount; i++)
            {
                if (members[i].PersonId == memberId)
                {
                    members[i].DisplayDetails();
                    memberFound = true;
                    break;
                }
            }

            if (!memberFound)
            {
                Console.WriteLine("Member not found.");
            }
        }
        #endregion
    }
}
