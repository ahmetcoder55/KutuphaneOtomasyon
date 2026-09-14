using KutuphaneOtomasyon.DataAccess.Abstract;
using KutuphaneOtomasyon.DataAccess.Concrete.Contexts.EntityFramework;
using KutuphaneOtomasyon.Entities.Concrete;

namespace KutuphaneOtomasyon.DataAccess.Concrete
{
    public class AppUserRepository : GenericRepository<AppUser,KutuphaneOtomasyonDbContext>, IAppUserRepository
    {
        public AppUserRepository(KutuphaneOtomasyonDbContext context) : base(context) { }
    }
}
