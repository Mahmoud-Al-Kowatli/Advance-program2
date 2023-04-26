using Microsoft.EntityFrameworkCore;
using myhomework.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore.Design;


namespace myHomeWorkForm.MyCont
{
    public class MyDbContext : DbContext
    {

        //public MyDbContext() : base("name=MyDbContext")
        //{

        //}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-DOI5329;Initial Catalog=homeworkDB;Integrated Security=True; TrustServerCertificate=True ");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public virtual DbSet<Student> students1 { get; set; }
    }
}
