using Newtonsoft.Json;
using System.Collections.Generic;
using Tiste.Feature.BeautifulResponse.Contracts;

namespace Tiste.Feature.BeautifulResponse.Models
{
    public class Result
    {
        [JsonProperty("success")]
        public bool? Success { get; private set; } = null;

        [JsonProperty("data")]
        public List<IDataEntity> Data { get; private set; } = null;

        [JsonProperty("errors")]
        public List<Error> Errors { get; set; }

        public Result SetSuccess(bool? success)
        {
            Success = success;
            return this;
        }

        public Result SetData(List<IDataEntity> data)
        {
            Data = data;
            return this;
        }
    }
}