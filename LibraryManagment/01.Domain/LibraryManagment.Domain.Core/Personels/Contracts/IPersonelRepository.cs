using LibraryManagment.Domain.Core.Personels.Entities;

namespace LibraryManagment.Domain.Core.Personels.Contracts
{
    public interface IPersonelRepository
    {
        List<Personel> GetAll();
        Personel GetById(int id);
        Personel Add(Personel personel);
        Personel Update(Personel personel);
        Personel Delete(int id);
    }
}
