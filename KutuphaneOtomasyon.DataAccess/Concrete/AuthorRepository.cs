using KutuphaneOtomasyon.DataAccess.Abstract;
using KutuphaneOtomasyon.DataAccess.Concrete.Contexts.EntityFramework;
using KutuphaneOtomasyon.Entities.Concrete;

namespace KutuphaneOtomasyon.DataAccess.Concrete
{
    public class AuthorRepository : GenericRepository<Author,KutuphaneOtomasyonDbContext>, IAuthorRepository
    {
        public AuthorRepository(KutuphaneOtomasyonDbContext context) : base(context) { }
    }
}
