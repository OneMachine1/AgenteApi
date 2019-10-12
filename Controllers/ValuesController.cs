using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json; 

namespace agenteapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<String> Get()
        {
            var os = new SystemInformationService().GetOperationSystemInformationService();
            
            string output = JsonConvert.SerializeObject(os);
            return output.ToString();
        }

       
    }
}
