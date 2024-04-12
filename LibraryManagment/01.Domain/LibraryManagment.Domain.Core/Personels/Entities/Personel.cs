using LibraryManagment.Domain.Core.Common.Entities;
using LibraryManagment.Domain.Core.Common.Enums;

namespace LibraryManagment.Domain.Core.Personels.Entities
{
    public class Personel : BaseEntity
    {
        public string FullName { get; set; }
        public string Phonenuber { get; set; }
        public bool IsActive { get; set; }
        public DateTime RegisterDate { get; set; }
        public DateTime ModifyDate { get; set; }
        public Gender Gender { get; set; }
        public DateTime Birthdate { get; set; }
    }
}
