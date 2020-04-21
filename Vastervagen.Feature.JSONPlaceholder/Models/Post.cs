using System;
using System.Collections.Generic;
using System.Text;

namespace Vastervagen.Feature.JSONPlaceholder.Models
{
    public class Post
    {
        public long UserId { get; set; }
        public long Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
    }

}
