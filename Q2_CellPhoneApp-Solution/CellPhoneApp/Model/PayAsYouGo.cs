using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CellPhoneApp.Model
{
    public class PayAsYouGo:Account
    {
        public int CallMoreTime { get; set; }
        public int PeakTime { get; set; }
        public int CallAnyTime { get; set; }

        //Parameterized Constructor
        public PayAsYouGo(int callMoreTime,int peakTime, int callAnyTime, string cellPhoneNumber, int totalCallTime, decimal totalCostOfCalls)
            : base(cellPhoneNumber, totalCallTime, totalCostOfCalls)//3 from parent so give base keyword to note that it is from parent class  
                                                                    //control +base click it will directly go to parent class
        {
            this.CallMoreTime = callMoreTime;  
            this.PeakTime=peakTime;
            this.CallAnyTime = callAnyTime;
        }

        //Method
        public override void DisplayDetails()
        {
            base.DisplayDetails();
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Call More Time:{CallMoreTime}");
            stringBuilder.AppendLine($"Peak Time:{PeakTime}");
            stringBuilder.AppendLine($"Call Any Time:{CallAnyTime}");

            Console.WriteLine(stringBuilder.ToString());
        }
    }
}
