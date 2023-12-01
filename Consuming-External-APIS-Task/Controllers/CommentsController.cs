using Consuming_External_APIS_Task.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consuming_External_APIS_Task.Controllers
{
    public class CommentsController
    {
        CommentServices commentServices = new CommentServices();    
        public async Task getComments()
        {
            var comments = await commentServices.GetCommentsAsync();
            Console.WriteLine($"Comment Id \t Post ID \t Email \t Name\t Body");
            foreach (var comment in comments)
            {
                Console.WriteLine($" {comment.Id} \t {comment.PostID} " +
                    $"\t {comment.Email} \t {comment.Name}\t {comment.Body}");
            }


        }
    }
}
