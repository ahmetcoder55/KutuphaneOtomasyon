using KutuphaneOtomasyon.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace KutuphaneOtomasyon.Entities.Concrete
{
    public class AppUser:BaseEntity, IEntity
    {
        public string Username { get; set; } = null!;
        public string PasswordHash { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Role { get; set; } = "Staff"; // "Admin", "Staff" vb.
    }
}
