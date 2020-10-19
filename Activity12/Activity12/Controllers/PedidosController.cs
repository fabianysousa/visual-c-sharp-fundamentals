using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Http;

namespace Activity12.Controllers
{
    public class PedidosController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "9876542020 - 1", "3216542020 - 8", "4569872020 - 7" };
        }
    }
}