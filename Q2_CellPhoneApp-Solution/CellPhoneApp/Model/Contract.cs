using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CellPhoneApp.Model
{
    public class Contract:Account
    {
        //data memeber
        public string AccountHolderName { get; set; }//simplified manner

        /*private string _accountHolderName;   //Encapsulation //at the time of validations we need to use this method
        public string AccountHolderName
        {
            get { return _accountHolderName; }//READ
            set { _accountHolderName = value; }//WRITE
        }
        */

        public string Address { get; set; }
        public int ContractLengthInMonths { get; set; }

        //Parameterized Constructor
        public Contract(string accountHolderName,string address,int contractLengthInMonths, string cellPhoneNumber, int totalCallTime, decimal totalCostOfCalls)
            :base( cellPhoneNumber,  totalCallTime,  totalCostOfCalls)//3 from parent so give base keyword to note that it is from parent class  
                                                                      //control +base click it will directly go to parent class
        {
            this.AccountHolderName=accountHolderName;
            this.Address=address;
            this.ContractLengthInMonths= contractLengthInMonths;
        }
        //Method
        public override void DisplayDetails()
        {
            base.DisplayDetails();
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Account Holder Name:{AccountHolderName}");
            stringBuilder.AppendLine($"Addres:{Address}");
            stringBuilder.AppendLine($"Contract Length In Months:{ContractLengthInMonths}months");

            Console.WriteLine(stringBuilder.ToString());

        }
    }
}
