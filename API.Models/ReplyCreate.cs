﻿using API.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Models
{
    public class ReplyCreate
    {
        public int PostId { get; set; }
        public Comment ReplyComment { get; set; }
    }
}