using System.Collections.Generic;
using Tiste.Feature.JSONPlaceholder.Models;

namespace Tiste.Feature.JSONPlaceholder.Contracts
{
    public interface IJSONPlaceholderService
    {
        public List<Comment> GetComments();
        public List<Post> GetPosts();
    }
}
