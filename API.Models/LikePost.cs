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
        public Post LikedPost { get; set; }
        public Guid Liker { get; set; }
    }
}