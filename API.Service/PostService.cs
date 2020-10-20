using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Service
{
        public class PostService
        {
            private readonly Guid _userID;
            private int PostID;

            public bool CreatePost(PostCreate newPost)
            {
                var entity =
                    new Post()
                    {
                        OwnerID = _userID,
                        Title = newPost.Title,
                        Content = newPost.Text
                    };

                using (var ctx = new ApplicationDbContext())
                {
                    ctx.Posts.Add(entity);
                    return ctx.SaveChanges() == 1;
                }
            }
        }
}
