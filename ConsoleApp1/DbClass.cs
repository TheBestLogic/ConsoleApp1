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
        public DbSet<Product> Products { get; set; }
        public DbSet<Characteristic> Characteristics_ { get; set; }
        public DbSet<Reiews> _Rewiews_ { get; set; }
        public DbSet<Media> Media_ { get; set; }
        public DbSet<ProductToCharacteristic> ProductToCharacteristics_ { get; set; }
        //public DbSet<Characteristic> Characteristics { get; set; }

        /*public DbClass()
        {
            Database.EnsureCreated();
        }*/

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasKey(u => u.Id);
            modelBuilder.Entity<Characteristic>().HasKey(u => u.Id);
            modelBuilder.Entity<Reiews>().HasKey(u => u.Id);
            modelBuilder.Entity<Media>().HasKey(u => u.Id);
            modelBuilder.Entity<ProductToCharacteristic>().HasKey(u => new { u.ProductID, u.CharactericticID });
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=Database1;Trusted_Connection=True;");
        }

    }


}
