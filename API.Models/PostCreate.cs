using API.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Models
{
    public class PostCreate
    {
        [Required]
        public int PostId { get; set; }
        [Required]
        //[Display(Name = "Post Title")]
        public string Title { get; set; }
        [Required]
        //[Display(Name = "Your Post")]
        public string Text { get; set; }
        [Required]
        public User Author { get; set; }
    }
}
