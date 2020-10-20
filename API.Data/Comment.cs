﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
﻿using Microsoft.Win32;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace API.Data
{

        public class Comment
    {
        [Key]
        public int CommentId { get; set; }
        [Required]
        public Guid OwnerId { get; set; }
        [Required]
        public int PostId { get; set; }
        [ForeignKey(nameof(PostId))]
        public virtual Post post { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Content { get; set; }
        [Required]
        public DateTimeOffset Created { get; set; }
        [Required]
        public DateTimeOffset? Modified { get; set; }
     }
}
