using Newtonsoft.Json;
using System.Collections.Generic;

namespace Tiste.Feature.BeautifulResponse.Models
{
    public class Error
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("links")]
        public Dictionary<string, string> links { get; set; }
    }
}