using Microsoft.AspNetCore.Mvc;

namespace Authentication.System.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Authentication : ControllerBase
    {
        [HttpGet]
        public OkObjectResult Get()
        {
            return Ok("Ok");
        }
    }
}
