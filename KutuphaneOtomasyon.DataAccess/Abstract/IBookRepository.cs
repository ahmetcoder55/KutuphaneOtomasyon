using KutuphaneOtomasyon.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace KutuphaneOtomasyon.DataAccess.Abstract
{
    public interface IBookRepository:IGenericRepository<Book>
    {
        Task<IEnumerable<Book>> GetBooksWithDetailsAsync();
    }
}
