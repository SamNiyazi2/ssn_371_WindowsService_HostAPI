using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

// 11/15/2022 11:45 am - SSN 
// https://www.c-sharpcorner.com/UploadFile/b1df45/web-api-self-hosting-using-windows-service/

namespace ssn_371_WindowsService_HostAPI.Controllers
{
    public class ValueController:ApiController
    {

        public string Get()
        {
            return "ssn-371-WindowsService-HostApi-20221115-1147";
        }
    }
}
