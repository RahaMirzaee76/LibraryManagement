using LibraryManagment.Domain.Core.Books.Entities;

namespace LibraryManagment.Domain.Core.Books.Contracts
{
    public interface IBookRepository
    {
        List<Book> GetAll();
        Book GetById(int id);
        Book Add(Book book);
        Book Update(Book book); 
        Book Delete(int id);    
    }
}
