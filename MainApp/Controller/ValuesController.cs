using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MainApp.Controller
{
    [Route("User")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet("hello")]
        public IActionResult Hello() => Ok("Hello from UserApp");
    }
}
