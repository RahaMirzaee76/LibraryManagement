using LibraryManagment.Domain.Core.Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagment.Domain.Core.Books.Entities
{
    public class Reserve:BaseEntity
    {
        public int BookId { get; set; }
        public int MemberId { get; set; }
        public int PersonelId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime Reclaimingdate { get; set; }

    }
}
