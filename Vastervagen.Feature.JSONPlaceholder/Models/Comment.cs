using System;
using System.Collections.Generic;
using System.Text;
using Tiste.Feature.BeautifulResponse.Contracts;

namespace Tiste.Feature.JSONPlaceholder.Models
{
    public class Comment : IDataEntity
    {
        public int PostId { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Body { get; set; }
        public Dictionary<string, string> Links { get; set; } = new Dictionary<string, string>();
    }
}
