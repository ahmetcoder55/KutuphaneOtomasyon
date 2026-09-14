using KutuphaneOtomasyon.Entities.Concrete;

namespace KutuphaneOtomasyon.DataAccess.Abstract
{
    public interface IMemberRepository : IGenericRepository<Member>
    {
        Task<Member?> GetMemberWithBorrowingsAsync(int memberId);
    }
}
