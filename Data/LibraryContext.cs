using Microsoft.EntityFrameworkCore;
using ConsoleApp2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Data
{
    internal class LibraryContext : DbContext
    {
        public DbSet<Book> Books { get; set; } = null!;
        public DbSet<Reader> Readers { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source = localhost; Initial Catalog = MyLocalDb; Integrated Security = True; Trust Server Certificate = True");
        }

    }
}
