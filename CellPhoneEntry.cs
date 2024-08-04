using CellPhoneApp.Model;
using static System.Runtime.InteropServices.JavaScript.JSType;

/*
Develop a cellphone accounts system, which will be used to manage the
accounts of a cellphone company. The company has two types of
accounts, Contract and PayAsYouGo. For every account the cellphone
number, total call time used and total cost of calls needs to be stored. For
PayAsYouGo accounts, you also need to store the type, Callmore time,
Peak time or Any time (C, P, A). For Contract accounts you need to store
the account holders name, address, and the length of the contract in
months. The cellphone accounts system needs handle many accounts,
PayAsYouGo and Contract. It also needs to provide information to a user
interface, which allows a user to add new accounts, to display all the
accounts and to search for the details of a particular account using the
cellphone number.
*/

namespace CellPhoneApp
{
    internal class CellPhoneEntry
    {
        //store the details
        static Account[] accounts = new Account[100];
        static int accountCount = 0;
        #region Entry
        static void Main(string[] args)
        {
            //MENU
            while (true)
            {
                Console.WriteLine("\nCellPhone Accounts System");
                Console.WriteLine("1.Add New Account");
                Console.WriteLine("2.Display All Account");
                Console.WriteLine("3.Search Account by CellPhone Number");
                Console.WriteLine("4.Exit");
                Console.WriteLine("Enter the choice:");

                //get choice
                string choice = Console.ReadLine();
                //Check Condition
                switch (choice)
                {
                    case "1":
                        AddNewAccount();
                        break;
                    case "2":
                        DisplayAllAccounts();
                        break;
                    case "3":
                        SearchAccount();
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Invalid Choice!.Please try again...");
                        break;
                
                }

            }

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
        #endregion
        #region AddNewAccount
        private static void AddNewAccount()
        {
            Console.WriteLine("Add a New Account");

            //get input from the user and add it to accounts array
            if(accountCount>=accounts.Length)
            {
                Console.WriteLine("Account storage is full.Cannot add more accounts");
                return;
            }
            //Select Account Type
            Console.WriteLine("\nSelect Account Type");
            Console.WriteLine("1.Contract");
            Console.WriteLine("2.PayAsYouGo");
            Console.WriteLine("Enter your choice");
            string accountTypeChoice = Console.ReadLine();

            //Cell Phone Number
            Console.Write("Enter Cell phone number: ");
            string cellPhoneNumber = Console.ReadLine();//we are not able to store more than 10 characters so we are using string

            //Total Call Time
            Console.Write("Enter total call time in minutes: ");
            int totalCallTime = GetValidIntegerInput();

            //Total Cost of Calls
            Console.Write("Enter total Cost of Calls: ");
            decimal totalCostOfCalls = GetValidDecimalInput();


            //Check Account Type
            if (accountTypeChoice == "1")//Contract
            {
                //Account Holder Name
                Console.Write("Enter Account Holder Name: ");
                string accountHolderName = Console.ReadLine();

                //Address
                Console.Write("Enter Account Holder Address: ");
                string address = Console.ReadLine();

                //Contract Length
                Console.Write("Enter length of contract (in months): ");
                int contractlengthInMonths = GetValidIntegerInput();

                //Add elements in an array
                accounts[accountCount++] = new Contract(accountHolderName, address, contractlengthInMonths, cellPhoneNumber, totalCallTime, totalCostOfCalls);
            }
            else if (accountTypeChoice == "2")//PayAsYouGo
            {
                //Call More Time
                Console.Write("Enter Call More Time: ");
                int callMoreTime = GetValidIntegerInput();

                //Peak Time
                Console.Write("Enter Peak Time: ");
                int peakTime = GetValidIntegerInput();

                //Call Any Time
                Console.Write("Enter Call Any Time: ");
                int callAnyTime = GetValidIntegerInput();

                //Add elements in an array
                accounts[accountCount++] = new PayAsYouGo(callMoreTime, peakTime, callAnyTime, cellPhoneNumber, totalCallTime, totalCostOfCalls);

            }
            else
            {
                Console.WriteLine("Invalid Account Type Choice");
            }
        }

        //Validate Total Call Time
        private static int GetValidIntegerInput()
        {
            int validInput;
            while (!int.TryParse(Console.ReadLine(), out validInput))
            {
                Console.Write("Invalid Input!.Please enter a valid interger..: ");
            }
            return validInput;
        }

        //Validate Total Call Time
        private static decimal GetValidDecimalInput()
        {
            decimal validDecimal;
            while (!decimal.TryParse(Console.ReadLine(), out validDecimal))
            {
                Console.Write("Invalid Input.Please enter a valid decimal..: ");
            }
            return validDecimal;
        }
        #endregion
        #region DisplayAllAccounts
        private static void DisplayAllAccounts()
        {
            Console.WriteLine("Display All Accounts");
            for(int i=0;i< accountCount;i++)
            {
                accounts[i].DisplayDetails();
            }
        }
        #endregion
        #region SearchAccount
        private static void SearchAccount()
        {
            Console.WriteLine("Search an Account by Cell Phone Number");
            Console.Write("Enter Cell Phone Number: ");
            string cellPhoneNumber = Console.ReadLine();

            bool accountFound = false;
            for (int i = 0; i < accountCount; i++)
            {
                if (accounts[i].CellPhoneNumber == cellPhoneNumber)
                {
                    accounts[i].DisplayDetails();
                    accountFound = true;
                    break;
                }
            }

            if (!accountFound)
            {
                Console.WriteLine("Account not found.");
            }
        }
        #endregion
    }
}
