using System.Collections.Generic;
using Tiste.Feature.BeautifulResponse.Contracts;

namespace Tiste.Feature.JSONPlaceholder.Models
{
    public class Post : IDataEntity
    {
        public long UserId { get; set; }
        public long Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public Dictionary<string, string> Links { get; set; } = new Dictionary<string, string>();
    }

}
