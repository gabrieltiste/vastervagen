using Microsoft.AspNetCore.Mvc;

namespace Vastervagen.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IndexController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Welcome to Vastervagen API";
        }
    }
}