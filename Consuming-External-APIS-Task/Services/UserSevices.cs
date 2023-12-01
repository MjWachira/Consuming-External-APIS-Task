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
    public class UserSevices:IUser
    {

        private readonly HttpClient _httpClient;
        private readonly string URL = "https://jsonplaceholder.typicode.com/users";

        public UserSevices()
        {
            _httpClient = new HttpClient();
        }
        public async Task<List<User>> GetUsersAsync()
        {
            var response = await _httpClient.GetAsync(URL);
            var content = await response.Content.ReadAsStringAsync();//string
            var users = JsonConvert.DeserializeObject<List<User>>(content);
            if (response.IsSuccessStatusCode && users != null)
            {
                return users;
            }
            return new List<User>();

        }




    }
}
