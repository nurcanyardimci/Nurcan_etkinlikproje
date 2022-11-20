using EntityLayer.Concreate;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concreate
{
    public class Context : DbContext
    {
        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.; database=CoreBlogDb; User Id=nurcan; Password=8579;TrustServerCertificate=True ");
           
            //"server=.; database=CoreBlogDb; User Id=nurcan; Password=8579;TrustServerCertificate=True
        }
        public DbSet <About> Abouts { get; set; }   
        public DbSet <Activity> Activities { get; set; }   
        public DbSet <Admin> Admins  { get; set; }   
        public DbSet <Blog> Blogs  { get; set; }   
        public DbSet <Category> Categories { get; set; }   
        public DbSet <Comment> Comments { get; set; }   
        public DbSet <Contact> Contacts  { get; set; }   
        public DbSet <User> Users  { get; set; }   
        public DbSet <Writer> Writers  { get; set; }   
      

    }
}
