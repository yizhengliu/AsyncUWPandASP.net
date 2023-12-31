using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestTimeConsumingOperationWebAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TestLongOperationController : ControllerBase
    {
        [HttpGet]
        //task based asynchronous pattern
        public async Task<IActionResult> Get() 
        {
            //pasue for 5s
            await Task.Delay(5000);

            return Content("Web API Long Operation Completed");
        }
    }
}
