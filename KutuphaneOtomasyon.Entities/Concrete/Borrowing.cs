using KutuphaneOtomasyon.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace KutuphaneOtomasyon.Entities.Concrete
{
    public class Borrowing:BaseEntity, IEntity
    {
        public DateTime BorrowDate { get; set; } = DateTime.Now;
        public DateTime DueDate { get; set; } // Son Teslim Tarihi
        public DateTime? ReturnDate { get; set; } // Gerçek Teslim Tarihi
        public decimal LateFee { get; set; } = 0; // Gecikme Cezası
        public bool IsReturned { get; set; } = false;

        // Foreign Keys
        public int BookId { get; set; }
        public int MemberId { get; set; }

        // Navigation Properties
        public Book Book { get; set; } = null!;
        public Member Member { get; set; } = null!;
    }
}
