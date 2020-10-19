using Microsoft.SqlServer.Server;
using Microsoft.Win32;
using System;
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
        int ID { get; set; }
        [Required]
        string Title { get; set; }
        [Required]
        string Text { get; set; }

        public Post(int ID, string Title, string Text)
        {
            int id = ID;
            string title = Title;
            string text = Text;
            //User goes here
        }
    }
}
