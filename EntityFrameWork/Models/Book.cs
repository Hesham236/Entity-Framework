using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWork.Models
{
    public class Book
    {
        public int BookKey { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
    }
}
