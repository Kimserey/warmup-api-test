using Microsoft.AspNetCore.Mvc;

namespace ExtraApi
{
    [Route("api/test")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> Get()
        {
            return "Test";
        }
    }
}
