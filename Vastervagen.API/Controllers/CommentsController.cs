using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Tiste.Feature.JSONPlaceholder;
using Tiste.Feature.JSONPlaceholder.Contracts;
using Tiste.Feature.JSONPlaceholder.Models;

namespace Tiste.API.Controllers
{
    [Produces("application/vnd.comments+json")]
    [Route("api/[controller]")]
    [ApiController]
    public class CommentsController : ControllerBase
    {
        private readonly IJSONPlaceholderService _jsonService;
        public CommentsController(IJSONPlaceholderService jsonService)
        {
            _jsonService = jsonService;
        }

        [HttpGet]
        public IEnumerable<Comment> Get()
        {

            return _jsonService.GetComments();
        }
    }
}