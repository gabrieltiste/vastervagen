using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Vastervagen.Feature.JSONPlaceholder;
using Vastervagen.Feature.JSONPlaceholder.Contracts;
using Vastervagen.Feature.JSONPlaceholder.Models;

namespace Vastervagen.API.Controllers
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