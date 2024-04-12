using LibraryManagment.Domain.Core.Books.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Infrastructure.DAL.Books
{
    public class BookConfig : IEntityTypeConfiguration<Book>
    {
        public BookConfig()
        {

        }
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Book> builder)
        {
           builder.Property(p=> p.Title).IsRequired().HasMaxLength(500);
            builder.Property(p => p.Author).IsRequired();
        }
    }
}
