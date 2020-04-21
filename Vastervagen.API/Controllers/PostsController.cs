using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
        public PostsController(IJSONPlaceholderService jsonService)
        {
            _jsonService = jsonService;
        }

        [HttpGet]
        public IEnumerable<Post> Get()
        {
            return _jsonService.GetPosts();
        }
    }
}