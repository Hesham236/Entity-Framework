using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFrameWork.Models;
using EntityFrameWork.Config;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameWork
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options) =>
            options.UseSqlServer(@"Data Source=DESKTOP-T9MRPA3;Initial Catalog=EFCore ;Integrated Security=True");
    
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AuditEntery>();
            new BlogEntityTypeConfig().Configure(modelBuilder.Entity<Blog>());
            // modelBuilder.Ignore<Post>();
            //modelBuilder.Entity<Post>()
            //   .ToTable("Posts"); 
            //modelBuilder.Entity<Post>()
            //  .ToTable("Posts");
            modelBuilder.Entity<Blog>()
                .Property(e => e.Url)
                .HasColumnType("nvarchar(70)");
            modelBuilder.Entity<Blog>()
               .Property(e => e.Url)
               .HasMaxLength(50);
            modelBuilder.Entity<Blog>()
                .Property(e => e.Url)
                .HasComment("Making Comment on URL");
            modelBuilder.Entity<Book>()
                .HasKey(e => new { e.Author, e.Name })
                .HasName("PK_BookKey");
            modelBuilder.Entity<Blog>()
                .Property(e => e.Rating)
                .HasDefaultValue(2);
            modelBuilder.Entity<Blog>()
               .Property(e => e.InsertedOn)
               .HasDefaultValueSql("GETDATE()");
            modelBuilder.Entity<Auther>()
                .Property(p => p.DisplayName)
                .HasComputedColumnSql("[LastName] + ',' + [FirstName]");
            modelBuilder.Entity<Category>()
                .Property(e => e.Id)
                .ValueGeneratedOnAdd();
        }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Auther> Authers { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
