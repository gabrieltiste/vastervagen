using System;
using System.Collections.Generic;
using Vastervagen.Feature.JSONPlaceholder.Contracts;
using Vastervagen.Feature.JSONPlaceholder.Models;
using System.Net.Http;
using Newtonsoft.Json;

namespace Vastervagen.Feature.JSONPlaceholder
{
    public class JSONPlaceholderService : IJSONPlaceholderService
    {
        private readonly IHttpClientFactory _clientFactory;
        private readonly HttpClient _httpClient;
        public JSONPlaceholderService(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
            _httpClient = _clientFactory.CreateClient("jsonplaceholder");
        }
        public List<Comment> GetComments()
        {
            string json = _httpClient.GetStringAsync("comments").Result;
            return JsonConvert.DeserializeObject<List<Comment>>(json);
        }

        public List<Post> GetPosts()
        {
            string json = _httpClient.GetStringAsync("posts").Result;
            return JsonConvert.DeserializeObject<List<Post>>(json);
        }
    }
}
