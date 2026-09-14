using KutuphaneOtomasyon.DataAccess.Abstract;
using KutuphaneOtomasyon.DataAccess.Concrete.Contexts.EntityFramework;
using KutuphaneOtomasyon.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace KutuphaneOtomasyon.DataAccess.Concrete
{
    public class BookRepository : GenericRepository<Book, KutuphaneOtomasyonDbContext>, IBookRepository
    {
        public BookRepository(KutuphaneOtomasyonDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Book>> GetBooksWithDetailsAsync()
        {
            return await _context.Books
                .Include(b => b.Category)
                .Include(b => b.Publisher)
                .Include(b => b.BookAuthors)
                    .ThenInclude(ba => ba.Author)
                .ToListAsync();
        }
    }
}
