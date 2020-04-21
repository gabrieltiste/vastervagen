using System.Collections.Generic;
using Vastervagen.Feature.JSONPlaceholder.Models;

namespace Vastervagen.Feature.JSONPlaceholder.Contracts
{
    public interface IJSONPlaceholderService
    {
        public List<Comment> GetComments();
        public List<Post> GetPosts();
    }
}
