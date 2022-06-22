using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWork.Models
{
    public class Blog
    {
        public int Id { get; set; }

        
        public DateTime? InsertedOn { get; set; }
        public string? Url { get; set; }
        public int Rating { get; set; }
        public List<Post> Posts { get; set; }

    }
}
