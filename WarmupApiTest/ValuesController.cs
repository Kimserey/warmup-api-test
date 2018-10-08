using Microsoft.AspNetCore.Mvc;

namespace WarmupApiTest
{
    [Route("api/values")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string[]> GetAll()
        {
            return new[] { "Value 1", "Value 2" };
        }

        [HttpGet("one")]
        public ActionResult<string> GetOne()
        {
            return "Value 1";
        }
    }
}
