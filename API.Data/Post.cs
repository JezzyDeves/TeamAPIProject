﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Data
{
    public class Post
    {
        [Key]
        public int ID { get; set; }
        //[Required]
        //[Display(Name = "Post Title")]
        public string Title { get; set; }
        //[Required]
        //[Display(Name = "Your Post")]
        public string Text { get; set; }
        [Required]
        public User Author { get; set; }
    }
}
