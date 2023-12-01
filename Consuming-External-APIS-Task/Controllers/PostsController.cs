using Consuming_External_APIS_Task.Models;
using Consuming_External_APIS_Task.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consuming_External_APIS_Task.Controllers
{
    public class PostsController
    {
        PostServices postServices = new PostServices();
        UserController userController = new UserController();
        public async Task getPosts()
        {
            await userController.getUsers();
            await Console.Out.WriteLineAsync("Select User ID");
            var userid =Console.ReadLine();
            var posts = await postServices.GetPostsAsync();
            Console.WriteLine($"Post Id \t User Id \t Post Title \t Post Body");
            foreach (var post in posts)
            {
                Console.WriteLine($" {post.Id} \t {post.userID} \t {post.Title} \t {post.Body}");

                
            }
        }
    }
}
