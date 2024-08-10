using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Design a class Employee-no, Name, Designation, Basic Pay. Define a derived class Executive whose Basic_pay is more than Rs.10,000.


namespace Q3_AssignmentInheritance.Model
{
    internal class Company
    {
        // Store the details
        static Employee[] employees = new Employee[100];
        static int employeeCount = 0;

        #region Entry
        static void Main(string[] args)
        {
            // MENU
            while (true)
            {
                Console.WriteLine("\nCompany Employees");
                Console.WriteLine("1. Add New Employee");
                Console.WriteLine("2. Display All Employees");
                Console.WriteLine("3. Display All Executive Employees");
                Console.WriteLine("4. Search Member by Employee ID");
                Console.WriteLine("5. Exit");
                Console.WriteLine("Enter the choice:");

                // Get choice
                string choice = Console.ReadLine();
                // Check Condition
                switch (choice)
                {
                    case "1":
                        AddNewEmployee();
                        break;
                    case "2":
                        DisplayAllEmployee();
                        break;
                    case "3":
                        AllExecutiveMembers(); 
                        break;
                    case "4":
                        SearchEmployee();
                        break;
                    case "5":
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

        #region AddNewEmployee
        private static void AddNewEmployee()
        {
            Console.WriteLine("Add a New Employee");

            // Get input from the user and add it to members array
            if (employeeCount >= employees.Length)
            {
                Console.WriteLine("Employee storage is full. Cannot add more Employee");
                return;
            }
            
            // Employee Number
            Console.Write("Enter Employee Number: ");
            int employeeNumber = GetValidIntegerInput();

            // Employee Name
            Console.Write("Enter Employee Name: ");
            string employeeName = Console.ReadLine();

            // Basic Pay
            Console.Write("Enter Basic Pay: ");
            int basicPay = GetValidIntegerInput();

            // Check Employee Type
            if (basicPay >= 10000) // Executive
            {
                Console.Write("Employee designation: Executive Employee");
                employees[employeeCount++] = new Executive(employeeNumber, employeeName, basicPay);
                Console.WriteLine("\nAdded successfully as an Executive Employee");
            }
            else if (basicPay < 10000) // Employee
            {
                Console.Write("Employee designation: Normal Employee");
                employees[employeeCount++] = new Employee(employeeNumber, employeeName, basicPay);
                Console.WriteLine("\nAdded successfully as an Normal Employee");
            }
            else
            {
                Console.WriteLine("Invalid Employee Type Choice");
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

        #region DisplayAllEmployee
        private static void DisplayAllEmployee()
        {
            Console.WriteLine("Display All Employees");
            for (int i = 0; i < employeeCount; i++)
            {
                employees[i].DisplayDetails();
            }
        }
        #endregion
        //This fuction to display all the executive members whose basic pay is mre than 10000
        #region AllExecutiveMembers
        private static void AllExecutiveMembers()
        {
            Console.WriteLine("Display all EXECUTIVE members");
            int flag=0;
            for (int i = 0; i < employeeCount; i++)
            {
                if (employees[i] is Executive)
                {
                    employees[i].DisplayDetails();
                    flag++;
                }
            }

            if (flag==0)
            {
                Console.WriteLine("No executive employees found.");
            }
        }
        #endregion

        #region SearchEmployee
        private static void SearchEmployee()
        {
            Console.WriteLine("Search a Employee by Employee Number");
            Console.Write("Enter Employee Number: ");
            int employeeId = GetValidIntegerInput();

            int flag = 0;
            for (int i = 0; i < employeeCount; i++)
            {
                if (employees[i].EmployeeNumber == employeeId)
                {
                    employees[i].DisplayDetails();
                    flag++;
                    break;
                }
            }

            if (flag==0)
            {
                Console.WriteLine("Employee not found.");
            }
        }
        #endregion

    }
}

