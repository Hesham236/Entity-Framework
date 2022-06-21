using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWork.Models
{
    public class AuditEntery
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Action { get; set; }

    }
}
