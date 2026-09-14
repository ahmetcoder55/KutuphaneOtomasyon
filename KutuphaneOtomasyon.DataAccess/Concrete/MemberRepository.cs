using KutuphaneOtomasyon.DataAccess.Abstract;
using KutuphaneOtomasyon.DataAccess.Concrete.Contexts.EntityFramework;
using KutuphaneOtomasyon.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace KutuphaneOtomasyon.DataAccess.Concrete
{
    public class MemberRepository : GenericRepository<Member,KutuphaneOtomasyonDbContext>, IMemberRepository
    {
        public MemberRepository(KutuphaneOtomasyonDbContext context) : base(context) { }

        public async Task<Member?> GetMemberWithBorrowingsAsync(int memberId)
        {
            return await _context.Members
                .Include(m => m.Borrowings)
                    .ThenInclude(b => b.Book)
                .FirstOrDefaultAsync(m => m.Id == memberId);
        }
    }
}
