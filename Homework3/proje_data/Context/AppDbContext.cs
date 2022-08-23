using Microsoft.EntityFrameworkCore;
using proje_data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje_data.Context
{
    public class AppDbContext:DbContext
    {
        public AppDbContext()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
        //Entities
        public DbSet<Account> Account { get; set; }
        public DbSet<Person> Person { get; set; }
    }
}
