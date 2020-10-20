using API.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Models
{
    public class LikePost
    {
        public int PostId { get; set; }
        public Post PostLike { get; set; }
        public User Liker { get; set; }
    }
}