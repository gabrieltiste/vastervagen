using Microsoft.Extensions.Logging;
using System;
using Vastervagen.Feature.HelloWorld.Contracts;

namespace Vastervagen.Feature.HelloWorld
{
    public class HelloWorldService : IHelloWorldService
    {
        private readonly ILogger<HelloWorldService> _logger;

        public HelloWorldService(ILogger<HelloWorldService> logger)
        {
            _logger = logger;
        }
        public string HelloWorld()
        {
            _logger.LogInformation("Hello World!");
            return "Hello world!";
        }
    }
}
