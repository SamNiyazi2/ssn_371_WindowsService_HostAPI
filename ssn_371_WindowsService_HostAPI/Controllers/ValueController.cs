
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;


//// Added for 'Produces'
// Needed for Route
// using System.Web.Http;
using Microsoft.AspNetCore.Mvc;

// 11/15/2022 11:45 am - SSN 
// https://www.c-sharpcorner.com/UploadFile/b1df45/web-api-self-hosting-using-windows-service/

namespace ssn_371_WindowsService_HostAPI.Controllers
{

    public class ValueController : ApiController
    {

        const string testVersionNo = "105";


        [System.Web.Http.HttpGet]
        [Route("/get")]
        public string Get()
        {
            return $"ssn-371-WindowsService-HostApi-20221115-1147 --- ({testVersionNo})";
        }


        //        [Produces("application/json")]
        [System.Web.Http.HttpPost]
        [Route("/slacktest")]
        public SlackReturnResult SlackTest()
        {
            SlackReturnResult r = new SlackReturnResult();
            r.OK = "True";
            r.Error_101 = $"Some error message  --- ({testVersionNo})";

            return r;
        }

        public class SlackReturnResult
        {
            public string OK { get; set; }
            public string Error_101 { get; set; }
        }
    }
}
