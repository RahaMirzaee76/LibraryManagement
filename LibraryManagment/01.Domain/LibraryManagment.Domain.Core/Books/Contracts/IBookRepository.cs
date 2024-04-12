using LibraryManagment.Domain.Core.Personels.Entities;

namespace LibraryManagment.Domain.Core.Books.Contracts
{
    public interface IBookRepository
    {
        List<Personel> GetAll();
        Personel GetById(int id);
        Personel Add(Personel book);
        Personel Update(Personel book); 
        Personel Delete(int id);    
    }
}
