using Microsoft.AspNetCore.Mvc;

namespace WarmupApiTest
{
    [Route("api/persons")]
    [ApiController]
    public class PersonsController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string[]> GetAll()
        {
            return new[] { "Kim", "Tom" };
        }

        [HttpGet("kim")]
        public ActionResult<string> GetKim()
        {
            return "Kimserey";
        }
    }
}
