using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tiste.Feature.BeautifulResponse.Models
{
    public class BeautifulResponse
    {
        [JsonProperty("result")]
        public Result Result { get; set; }
    }
}
