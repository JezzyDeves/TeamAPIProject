using Microsoft.Win32;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace API.Data
{
    public class Reply : Comment
    {
        public Comment Reply { get; set;}
    }
}
