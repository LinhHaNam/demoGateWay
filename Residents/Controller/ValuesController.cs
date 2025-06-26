using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Residents.Controller
{
    [Route("Residents")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet("hello")]
        public IActionResult Hello() => Ok("Hello from Residents");
    }
}
