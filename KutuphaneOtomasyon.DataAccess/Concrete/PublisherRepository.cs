using KutuphaneOtomasyon.DataAccess.Abstract;
using KutuphaneOtomasyon.DataAccess.Concrete.Contexts.EntityFramework;
using KutuphaneOtomasyon.Entities.Concrete;

namespace KutuphaneOtomasyon.DataAccess.Concrete
{
    public class PublisherRepository : GenericRepository<Publisher,KutuphaneOtomasyonDbContext>, IPublisherRepository
    {
        public PublisherRepository(KutuphaneOtomasyonDbContext context) : base(context) { }
    }
}
