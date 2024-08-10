using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CellPhoneApp.Model
{
    public class Account
    {
        //declare dataMembers
        public string CellPhoneNumber { get; set; }
        public int TotalCallTime { get; set; }//in minutes
        public decimal TotalCostOfCalls { get; set; }//in currency
        /*compiler will create provatedecimal  _TotalCostOfCalls makes it as defaut values aslo it takes
         * private decimal _totalCostOfCalls=0.0
        public decimal TotalCostOfCalls=0.0;
        {
           get{return _totalCostOfCalls;}
           set{_totalCostOfCalls = value;}
        */
        //Default Constructor
        public Account()
        {

        }
        //Parametrized Constructor
        public Account(string cellPhoneNumber, int totalCallTime, decimal totalCostOfCalls)
        {
            this.CellPhoneNumber = cellPhoneNumber;
            this.TotalCallTime = totalCallTime;
            this.TotalCostOfCalls = totalCostOfCalls;
        }

        //Methods
        public virtual void DisplayDetails()
        {
            //Console.WriteLine($"Cell phone number:{CellPhoneNumber}\nTotal Call Time:{TotalCallTime} minutes\nTotal Cost Of Calls:{TotalCostOfCalls}");
            StringBuilder stringBuilder = new StringBuilder();
            /*
             * StringBuilder is used to build the output string efficiently,
             * especially when concatenating mutiple strings.
             */
            stringBuilder.AppendLine($"Cell phone number:{CellPhoneNumber}");
            stringBuilder.AppendLine($"\nTotal Call Time:{TotalCallTime} minutes");
            stringBuilder.AppendLine($"\nTotal Cost Of Calls:{ TotalCostOfCalls}");
            Console.WriteLine(stringBuilder.ToString());
        }
    }
}

