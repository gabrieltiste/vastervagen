using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Tiste.Feature.JSONPlaceholder.Contracts;
using Tiste.Feature.JSONPlaceholder.Models;

namespace Tiste.API.Controllers
{
    [Produces("application/vnd.posts+json")]
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        private readonly IJSONPlaceholderService _jsonService;
        private readonly ILogger<PostsController> _logger;
        public PostsController(ILogger<PostsController> logger, IJSONPlaceholderService jsonService)
        {
            _logger = logger;
            _jsonService = jsonService;
        }

        [HttpGet]
        public IEnumerable<Post> Get()
        {
            _logger.LogInformation("PostsController - GET");
            return _jsonService.GetPosts();
        }
    }
}