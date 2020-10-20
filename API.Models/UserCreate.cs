using API.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Models
{
    public class UserCreate
    {
        public Guid UserId { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }
    }
}
