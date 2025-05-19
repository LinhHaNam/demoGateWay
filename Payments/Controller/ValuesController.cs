using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Payments.Controller
{
    [Route("payments")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet("hello")]
        public IActionResult Hello() => Ok("Hello from Payment");
    }
}
