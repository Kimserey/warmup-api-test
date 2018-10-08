using Microsoft.AspNetCore.Mvc;

namespace WarmupApiTest
{
    [Route("/")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> Get()
        {
            return "OK";
        }
    }
}
