using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NFS.API.UNITY.Controllers
{
    public class HealthCheckController : ApiController
    {
        [HttpGet]
        [AllowAnonymous]
        public IHttpActionResult Get()
        {
            return this.Json("API is up...");
        }
    }
}
