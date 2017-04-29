using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Web.Http;
using Newtonsoft.Json.Linq;

namespace Apis.Controllers
{
    [Route("test")]
    public class TestController : ApiController
    {
        public IHttpActionResult Get()
        {
            var calller = User as ClaimsPrincipal;
            var subjectClaim = calller?.FindFirst("sub");
            if (subjectClaim!=null)
            {
                return Json(new
                {
                    message = "ok user",
                    client = calller?.FindFirst("client_id").Value,
                    subject=subjectClaim.Value
                });
            }
            else
            {
                return Json(new
                {
                    message = "ok Computer",
                    client = calller?.FindFirst("client_id").Value
                });
            }
            
        }
    }
}
