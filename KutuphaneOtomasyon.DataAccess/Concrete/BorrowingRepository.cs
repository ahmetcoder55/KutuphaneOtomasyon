using KutuphaneOtomasyon.DataAccess.Abstract;
using KutuphaneOtomasyon.DataAccess.Concrete.Contexts.EntityFramework;
using KutuphaneOtomasyon.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace KutuphaneOtomasyon.DataAccess.Concrete
{
    public class BorrowingRepository : GenericRepository<Borrowing,KutuphaneOtomasyonDbContext>, IBorrowingRepository
    {
        public BorrowingRepository(KutuphaneOtomasyonDbContext context) : base(context) { }

        public async Task<IEnumerable<Borrowing>> GetActiveBorrowingsAsync()
        {
            return await _context.Borrowings
                .Include(b => b.Book)
                .Include(b => b.Member)
                .Where(b => !b.IsReturned)
                .ToListAsync();
        }
    }
}
