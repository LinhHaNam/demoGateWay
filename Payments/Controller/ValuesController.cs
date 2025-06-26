using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Payments.Controller
{
    [Route("Payments")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet("hello")]
        public IActionResult Hello() => Ok("Hello from Payment");
    }
}
