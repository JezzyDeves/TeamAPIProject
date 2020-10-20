using API.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Models
{
    public class ReplyCreate
    {
        //[Required]
        //public Comment ReplyComment { get; set; }

        [Required]
        public string Text { get; set; }
    }
}