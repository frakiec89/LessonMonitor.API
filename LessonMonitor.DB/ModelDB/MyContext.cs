using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace LessonMonitor.DB.ModelDB
{
    public class MyContext : DbContext
    {
        public DbSet<ModelDB.User> Users  { get; set; }

        public MyContext()
        {
           
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=helloappdb;Trusted_Connection=True;");
        }
    }
}
