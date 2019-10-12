using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace agenteapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            var os = new SystemInformationService().GetOperationSystemInformationService();
            
            return new string[] { "osName", os.oSName, "hostName", os.hostName , "userName", os.userName};
        }

       
    }
}
