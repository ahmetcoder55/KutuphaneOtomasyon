using KutuphaneOtomasyon.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace KutuphaneOtomasyon.Entities.Concrete
{
    public class Author:BaseEntity, IEntity
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string? Biography { get; set; }
        public DateTime? DateOfBirth { get; set; }

        // Navigation Property (Çoka-Çok İlişki Tablosu)
        public ICollection<BookAuthor> BookAuthors { get; set; } = new List<BookAuthor>();
    }
}
