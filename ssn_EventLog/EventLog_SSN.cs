using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 05/18/2018 06:19 am - SSN - Moved from Windows Service
 
namespace ssn_Event_log
{
    public class EventLog_SSN : EventLog
    {
         

        public EventLog_SSN()
        {

            string logname = "SSN_Log";
            string sourceName = "SSN_SelfHostAPI";

            if (!System.Diagnostics.EventLog.SourceExists(sourceName))
            {
                System.Diagnostics.EventLog.CreateEventSource(
                    sourceName, logname);
            }
            this.Source = sourceName ;
            this.Log = logname;
        }


    }
}
