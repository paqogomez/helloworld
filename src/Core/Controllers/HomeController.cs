using Microsoft.AspNetCore.Mvc;

namespace helloWorld.Core.Controllers
{
    [Route("")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        // GET
        [HttpGet]
        public ActionResult<string> Get()
        {
            return "Get Hello World!";
        }
        // POST 
        [HttpPost]
        public ActionResult<string> Post([FromBody]string value)
        {
            return $"Post Hello World! - {value}";
        }

        // PUT
        [HttpPut]
        public ActionResult<string> Put([FromBody]string helloworldGuid)
        {
            return $"Put Hello World! - {helloworldGuid:N}";
        }
    }
}
