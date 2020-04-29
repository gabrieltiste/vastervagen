using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Vastervagen.Feature.HelloWorld;
using Vastervagen.Feature.HelloWorld.Contracts;

namespace Vastervagen.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloWorldController : ControllerBase
    {
        private readonly ILogger<HelloWorldController> _logger;
        private readonly IHelloWorldService _service;

        public HelloWorldController(ILogger<HelloWorldController> logger, IHelloWorldService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpGet]
        public string Get()
        {
            _logger.LogInformation("Hello World - GET");
            return _service.HelloWorld();
        }
    }
}