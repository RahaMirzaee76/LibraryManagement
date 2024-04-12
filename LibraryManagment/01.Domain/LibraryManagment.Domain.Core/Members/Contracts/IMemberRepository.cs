using LibraryManagment.Domain.Core.Members.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagment.Domain.Core.Members.Contracts
{
    public interface IMemberRepository
    {
        List<Member> GetAll();
        Member GetById(int id);
        Member Add(Member book);
        Member Update(Member book);
        Member Delete(int id);
    }
}
