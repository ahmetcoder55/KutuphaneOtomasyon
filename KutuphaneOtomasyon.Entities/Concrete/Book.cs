using KutuphaneOtomasyon.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace KutuphaneOtomasyon.Entities.Concrete
{
    public class Book:BaseEntity, IEntity
    {
        public string Title { get; set; } = null!;
        public string ISBN { get; set; } = null!;
        public int PageCount { get; set; }
        public int PublishYear { get; set; }
        public int Quantity { get; set; } // Toplam Stok
        public int AvailableQuantity { get; set; } // Kütüphanede Kalan Stok

        // Foreign Keys
        public int CategoryId { get; set; }
        public int PublisherId { get; set; }

        // Navigation Properties
        public Category Category { get; set; } = null!;
        public Publisher Publisher { get; set; } = null!;
        public ICollection<BookAuthor> BookAuthors { get; set; } = new List<BookAuthor>();
        public ICollection<Borrowing> Borrowings { get; set; } = new List<Borrowing>();
    }
}
