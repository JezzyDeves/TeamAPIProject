using API.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Models
{
    public class CommentCreate
    {
        [Required]
        public int CommentId { get; set; }
        [Required]
        public string Text { get; set; }
        [Required]
        public User Author { get; set; }
    }

    //[Required]
    //[Display(Name = "Your Comment")]
    //public string Content { get; set; }

    //[Required]
    //public int PostId { get; set; }
    //[ForeignKey(nameof(PostId))]
    //public virtual Post post { get; set; }
}
