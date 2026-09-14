using KutuphaneOtomasyon.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace KutuphaneOtomasyon.Entities.Concrete
{
    public class Member:BaseEntity,IEntity
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public string? Address { get; set; }
        public DateTime MembershipDate { get; set; } = DateTime.Now;

        // Navigation Property
        public ICollection<Borrowing> Borrowings { get; set; } = new List<Borrowing>();
    }
}
