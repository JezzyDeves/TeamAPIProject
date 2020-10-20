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
	

//    public IENumerable<PostLineItem> GetPost()
//        {
//            using (var ctx = new ApplicationDbContext())
//            {
//                  {
//                    var query =
//                        ctx
//                            .Posts
//                                .Where(e => e.OwnerID == _userID)
//                                .Select(
//                                    e =>
//                                    new PostLineItem()
//                                      {
//                                          PostID = e.PostID,
//                                          Title = e.Title,
//                                      }
//                                  );
//                   }


//                   return query.ToArray();
//              }

    }
       


    
}
