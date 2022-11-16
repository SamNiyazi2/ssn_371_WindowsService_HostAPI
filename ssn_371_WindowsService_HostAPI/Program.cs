using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace ssn_371_WindowsService_HostAPI
{
    // 11/15/2022 12:18 pm - SSN - Project created 

    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[]
            {
                new SelfHostService()
            };
            ServiceBase.Run(ServicesToRun);
        }
    }
}
