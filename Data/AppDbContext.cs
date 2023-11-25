using Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<ContactEntity> Contacts { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"data source=d:\contacts.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ContactEntity>().HasKey(e => e.Id);
            modelBuilder.Entity<ContactEntity>().HasData(
                new ContactEntity()
                {
                    Id = 1,
                    Name = "Test",
                    Email = "Test@wsei.edu.pl",
                    Phone = "123456789",
                    Priority = 1,
                },
                new ContactEntity()
                {
                    Id = 2,
                    Name = "Test",
                    Email = "Test@wsei.edu.pl",
                    Phone = "123456789",
                    Priority = 3,
                    Birth = new DateTime(2000, 10, 10)
                }
                );
        }
    }
}
