namespace LibraryManagment.Domain.Core.Common.Entities
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public Guid Guid { get; set; }
        public DateTime CreationDate { get; set; }
        public int CreateBy { get; set; }
        public DateTime ModifyDate { get; set; }
        public int ModifyBy { get; set; }
    }
}
