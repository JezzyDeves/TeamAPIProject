using API.Models;
using API.Service;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SocialMediaAPI.Controllers
{
    public class PostController : ApiController
    {
        public PostService CreatePostService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var postService = new PostService(userId);
            return postService;
        }
        public IHttpActionResult Post(PostCreate model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreatePostService();

            if (!service.CreatePost(model))
                return InternalServerError();

            return Ok();
        }

        public IHttpActionResult Get()
        {
            PostService postService = CreatePostService();
            var posts = postService.GetPost();
            return Ok(posts);
        }
    }

}
