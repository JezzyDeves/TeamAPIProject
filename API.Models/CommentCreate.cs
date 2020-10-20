using API.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Models
{
    public class CommentCreate
    {
        public int CommentId { get; set; }
        public string Text { get; set; }
        public User Author { get; set; }
    }
}
