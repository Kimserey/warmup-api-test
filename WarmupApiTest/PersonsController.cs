using Microsoft.AspNetCore.Mvc;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace WarmupApiTest
{
    [Route("api/persons")]
    [ApiController]
    public class PersonsController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<string[]>> GetAll([FromServices] IHttpClientFactory factory)
        {
            var client = factory.CreateClient();
            client.BaseAddress = new Uri("http://extraapi");
            await client.GetAsync("/api/test");
            return new[] { "Kim", "Tom" };
        }

        [HttpGet("kim")]
        public ActionResult<string> GetKim()
        {
            return "Kimserey";
        }
    }
}
