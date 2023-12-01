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
    public class CommentServices:IComments
    {
        private readonly HttpClient _httpClient;
        private readonly string URL = "https://jsonplaceholder.typicode.com/posts";

        public CommentServices()
        {
            _httpClient = new HttpClient();
        }
        public async Task<List<Comments>> GetCommentsAsync()
        {
            var response = await _httpClient.GetAsync(URL);
            var content = await response.Content.ReadAsStringAsync();
            var coments = JsonConvert.DeserializeObject<List<Comments>>(content);
            if (response.IsSuccessStatusCode && coments != null)
            {
                return coments;
            }
            return new List<Comments>();

        }
    }
}
