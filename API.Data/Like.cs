using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Data
{
    public class Like
    {
        //[Required]
        //public int LikedPost { get; set; }

        //[ForeignKey(nameof(LikedPost))]
        //public virtual Post likedPost { get; set; }

        //public Guid Liker { get; set; }

        //[ForeignKey(nameof(Liker))]
        //public virtual User liker { get; set; }

        [ForeignKey(nameof(Post))]
        public int PostID { get; set; }
        public virtual Post Post { get; set; }

        [ForeignKey(nameof(User))]
        public Guid UserID { get; set; }
        public virtual User User { get; set; }
    }
}
