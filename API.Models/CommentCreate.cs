﻿using API.Data;
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
        public string Text { get; set; }
        //[Required]
        //public User Author { get; set; }
    }
}
