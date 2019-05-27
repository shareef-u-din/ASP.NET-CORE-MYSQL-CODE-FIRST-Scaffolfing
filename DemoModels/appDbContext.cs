using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoModels
{
    public class AppDbContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public AppDbContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=localhost;Uid=root;password= ;persistsecurityinfo=True;database=testdemo;SslMode=none");
        }

        //public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        //{ }

        public DbSet<Employee> Book { get; set; }
    }
}
