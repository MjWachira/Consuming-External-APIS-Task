using Consuming_External_APIS_Task.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consuming_External_APIS_Task.Controllers
{
    public class UserController:UserSevices
    {
        UserSevices userSevices = new UserSevices();    
        public async Task getUsers()
        {
            var users = await userSevices.GetUsersAsync();
            Console.WriteLine($"Id \t Name \t Username \t Email");
            foreach (var user in users)
            {
                Console.WriteLine($" {user.Id} \t {user.Name} \t {user.UserName} \t {user.Email}");
            }
        }
    }
}
