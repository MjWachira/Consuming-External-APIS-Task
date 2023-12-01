using Consuming_External_APIS_Task.Models;
using Consuming_External_APIS_Task.Services.IServices;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consuming_External_APIS_Task.Services
{
    public class PostServices:IPosts
    {

        private readonly HttpClient _httpClient;
        private readonly string URL = "https://jsonplaceholder.typicode.com/posts";

        public PostServices()
        {
            _httpClient = new HttpClient();
        }
        public async Task<List<Posts>> GetPostsAsync()
        {
            var response = await _httpClient.GetAsync(URL);
            var content = await response.Content.ReadAsStringAsync();
            var posts = JsonConvert.DeserializeObject<List<Posts>>(content);
            if (response.IsSuccessStatusCode && posts != null)
            {
                return posts;
            }
            return new List<Posts>();

        }

    }
}
