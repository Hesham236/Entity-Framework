using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWork.Models
{
    [Table("Posts")]
    public class Post
    {
        public int Id { get; set; }
        public string content { get; set; }
        public string title { get; set; }


        //Navigation Property
        public Blog blog { get; set; }
    }
}
