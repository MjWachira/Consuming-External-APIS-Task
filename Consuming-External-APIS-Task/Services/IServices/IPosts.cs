using Consuming_External_APIS_Task.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consuming_External_APIS_Task.Services.IServices
{
    internal interface IPosts
    {
        Task<List<Posts>> GetPostsAsync();
    }
}
