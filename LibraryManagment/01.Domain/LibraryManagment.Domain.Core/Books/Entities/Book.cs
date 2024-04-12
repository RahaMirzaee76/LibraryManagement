using LibraryManagment.Domain.Core.Common.Entities;

namespace LibraryManagment.Domain.Core.Books.Entities
{
    public class Book : BaseEntity
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public string Translator { get; set; }
        public string Shabak { get; set; }
        public DateTime PublishDate { get; set; }
        public int PageCount { get; set; }
        public DateTime RegisterDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public bool IsActive { get; set; }
        public bool IsReserved { get; set; }
    }
}
