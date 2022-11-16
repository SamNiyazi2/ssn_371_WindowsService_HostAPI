using ssn_Event_log;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.SelfHost;

// 11/15/2022 11:48 am - SSN - Creating service

namespace ssn_371_WindowsService_HostAPI
{
    internal class SelfHostService : ServiceBase
    {
        static EventLog_SSN eventLog1 = new EventLog_SSN();
        protected override void OnStart(string[] args)
        {

            eventLog1.WriteEntry($"ssn_371_WindowsService_HostAPI-20221115-1205: Starting service. (103)", System.Diagnostics.EventLogEntryType.Warning);

            string serviceAPIHostName_EnvVarName = "ssn-371-ServiceAPIHostName";
            string serviceAPIHostName = Environment.GetEnvironmentVariable(serviceAPIHostName_EnvVarName);
            if (string.IsNullOrWhiteSpace(serviceAPIHostName))
            {

                eventLog1.WriteEntry($"ssn_371_WindowsService_HostAPI-20221115-1207:\n\n Missing variable [{serviceAPIHostName_EnvVarName}]\n\nStopping service.", System.Diagnostics.EventLogEntryType.Warning);
                Stop();
                return;
            }

            eventLog1.WriteEntry($"ssn_371_WindowsService_HostAPI-20221115-1615: API URL [{serviceAPIHostName}]", System.Diagnostics.EventLogEntryType.Warning);


            var config = new HttpSelfHostConfiguration(serviceAPIHostName);
            
            config.Routes.MapHttpRoute(
                name: "ps_371_API",
                routeTemplate: "{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
                );

            HttpSelfHostServer server = new HttpSelfHostServer(config);
            server.OpenAsync().Wait();


        }

        protected override void OnStop()
        {
            eventLog1.WriteEntry($"ssn_371_WindowsService_HostAPI-20221115-1208: Stopping service.", System.Diagnostics.EventLogEntryType.Warning);
        }

    }
}
