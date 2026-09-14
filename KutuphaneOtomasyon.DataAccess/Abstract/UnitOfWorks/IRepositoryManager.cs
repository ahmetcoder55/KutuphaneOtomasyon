using System;
using System.Collections.Generic;
using System.Text;

namespace KutuphaneOtomasyon.DataAccess.Abstract.UnitOfWorks
{
    public interface IRepositoryManager:IAsyncDisposable
    {
        IBookRepository Books { get; }
        IAuthorRepository Authors { get; }
        ICategoryRepository Categories { get; }
        IPublisherRepository Publishers { get; }
        IMemberRepository Members { get; }
        IBorrowingRepository Borrowings { get; }
        IAppUserRepository AppUsers { get; }

        Task<int> SaveChangesAsync();
    }
}
