using API.Data;
using API.Models;
using SocialMediaAPI.Models;
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
                    ID = PostID,
                    Title = newPost.Title,
                    Text = newPost.Text,
                    Author = _userID
                    
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Posts.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
        
        public IEnumerable<PostDetail> GetPost()
        {
            using (var ctx = new ApplicationDbContext())
            {
                    var query =
                        ctx
                            .Posts
                                .Where(e => e.Author == _userID)
                                .Select(e =>
                                        new PostDetail()
                                        {
                                            PostID = e.ID,
                                            Title = e.Title,
                                        }
                                  );

                    return query.ToArray();
            }
        }

        public int LikePost(int postID, LikePost Like)
        {
            //using (var ctx = new ApplicationDbContext())
            //Other stuff
            return 1;
        }

        public bool CommentPost(int postID, PostCommentDetail newPostComment)
        {
            var entity =
                new Comment()
                {
                    Text = newPostComment.Text,
                    Author = _userID,
                    PostID = newPostComment.PostId
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Comments.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
    }
}
