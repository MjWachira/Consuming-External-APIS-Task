﻿using Consuming_External_APIS_Task.Services;
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
        public async Task getPosts()
        {
            var posts = await postServices.GetPostsAsync();
            Console.WriteLine($"Id \t Name \t Username \t Email");
            foreach (var post in posts)
            {
                Console.WriteLine($" {post.Id} \t {post.userID} \t {post.Title} \t {post.Body}");
            }

        }
    }
}