using KutuphaneOtomasyon.Entities.Concrete;

namespace KutuphaneOtomasyon.DataAccess.Abstract
{
    public interface IBorrowingRepository : IGenericRepository<Borrowing>
    {
        Task<IEnumerable<Borrowing>> GetActiveBorrowingsAsync(); // Teslim edilmemiş olanlar
    }
}
