using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Z.BulkOperations;

namespace ConsoleApp1
{
    class DbClass : DbContext
    {
        public DbSet<SomeProduct> Products { get; set; }
        public DbSet<Characteristic> Characteristics { get; set; }
        //public DbSet<Characteristic> Characteristics { get; set; }

        /*public DbClass()
        {
            Database.EnsureCreated();
        }*/

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SomeProduct>();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=Database1;Trusted_Connection=True;");
        }

    }


}
