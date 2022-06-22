using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFrameWork;
using EntityFrameWork.Models;
using Microsoft.EntityFrameworkCore;

var _context = new ApplicationDbContext();

//var author = _context.Authers.Find(1);

//author.LastName = "ali";

//var author = new Auther
//{
//  FirstName="Mohamed",
//  LastName="Hesham"
//};
//_context.Authers.Add(author);

//var category = new Category
//{
//    Name="kozbara"
//};
//_context.Categories.Add(category);


_context.SaveChanges();
