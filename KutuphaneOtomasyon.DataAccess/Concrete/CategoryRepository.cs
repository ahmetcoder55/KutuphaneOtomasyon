using KutuphaneOtomasyon.DataAccess.Abstract;
using KutuphaneOtomasyon.DataAccess.Concrete.Contexts.EntityFramework;
using KutuphaneOtomasyon.Entities.Concrete;

namespace KutuphaneOtomasyon.DataAccess.Concrete
{
    public class CategoryRepository : GenericRepository<Category,KutuphaneOtomasyonDbContext>, ICategoryRepository
    {
        public CategoryRepository(KutuphaneOtomasyonDbContext context) : base(context) { }
    }
}
