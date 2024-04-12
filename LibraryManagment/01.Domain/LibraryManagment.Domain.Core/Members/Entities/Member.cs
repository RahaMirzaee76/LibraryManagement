using LibraryManagment.Domain.Core.Books.Entities;
using LibraryManagment.Domain.Core.Common.Entities;
using LibraryManagment.Domain.Core.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagment.Domain.Core.Members.Entities
{
    public class Member : BaseEntity
    {
        public string FullName { get; set; }
        public string Address { get; set; }
        public string Phonenuber { get; set; }
        public bool IsActive { get; set; }
        public DateTime MembershipDate { get; set; }
        public DateTime ModifyDate { get; set; }
        public Gender Gender { get; set; }
        public DateTime Birthdate { get; set; }
        public IList<Reserve> Reserves { get; set; }
    }
}
