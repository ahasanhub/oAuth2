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
            return Json(new
            {
                message="this is ok",
                client=calller?.FindFirst("client_id").Value
            });
        }
    }
}
