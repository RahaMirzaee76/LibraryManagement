using LibraryManagement.Infrastructure.DAL.Common;
using LibraryManagment.Domain.Core.Books.Contracts;
using LibraryManagment.Domain.Core.Books.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Infrastructure.DAL.Books
{
    public class BookRepository : IBookRepository
    {
        private readonly DatabaseContext _databaseContext;

        public BookRepository(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public Book Add(Book book)
        {
            throw new NotImplementedException();
        }

        public Book Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Book> GetAll()
        {
            return _databaseContext.Books.ToList();
        }

        public Book GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Book Update(Book book)
        {
            throw new NotImplementedException();
        }
    }
}
