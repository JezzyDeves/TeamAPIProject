using API.Data;
using SocialMediaAPI.Models;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Service
{
    class PostService
    {
        private readonly Guid _userID;

        public PostService(Guid userID)
        {
            _userID = userID;
        }

        public bool CreatePost(Post model)
        {
            var entity =
                 new Post()
                 {
                     ID = _userID;
                     Title title = model
                     Text = model.Comment,
                 }

            using (var ctx = CreatePost(entity))
            {
                ctx.Post.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
    }
}
