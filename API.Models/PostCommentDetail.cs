﻿using API.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Models
{
    public class PostCommentDetail
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
    }
}
