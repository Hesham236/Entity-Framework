using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFrameWork;
using Microsoft.EntityFrameworkCore;

var _context = new ApplicationDbContext();



_context.SaveChanges();
