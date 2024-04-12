using LibraryManagement.Infrastructure.DAL.Books;
using LibraryManagment.Domain.Core.Books.Entities;
using LibraryManagment.Domain.Core.Members.Entities;
using LibraryManagment.Domain.Core.Personels.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Infrastructure.DAL.Common
{
    public class DatabaseContext:DbContext
    {
        public DbSet<Book> Books { set; get; }
        public DbSet<Member> Members { set; get; }
        public DbSet<Personel> Personels { set; get; }
        public DbSet<Reserve> Reserves { set; get; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=LibraryManagement;Integrated Security=True;MultipleActiveResultSets=True;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().Property(p => p.Title).IsRequired().HasMaxLength(500);
            modelBuilder.Entity<Book>().Property(p => p.Author).IsRequired();
        }

    }
}
