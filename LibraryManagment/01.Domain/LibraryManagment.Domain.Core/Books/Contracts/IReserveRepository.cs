using LibraryManagment.Domain.Core.Books.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagment.Domain.Core.Books.Contracts
{
    public interface IReserveRepository
    {
        List<Reserve> GetAll();
        Reserve GetById(int id);
        Reserve Add(Reserve reserve);
        Reserve Update(Reserve reserve);
      
    }
}
