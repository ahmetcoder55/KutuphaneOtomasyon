using KutuphaneOtomasyon.DataAccess.Abstract;
using KutuphaneOtomasyon.DataAccess.Abstract.UnitOfWorks;
using KutuphaneOtomasyon.DataAccess.Concrete.Contexts.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace KutuphaneOtomasyon.DataAccess.Concrete.UnitOfWorks
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly KutuphaneOtomasyonDbContext _context;
        private readonly IBookRepository _bookRepository;
        private readonly IAuthorRepository _authorRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly IPublisherRepository _publisherRepository;
        private readonly IMemberRepository _memberRepository;
        private readonly IBorrowingRepository _borrowingRepository;
        private readonly IAppUserRepository _appUserRepository;

        public RepositoryManager(KutuphaneOtomasyonDbContext context, IBookRepository bookRepository, IAuthorRepository authorRepository, ICategoryRepository categoryRepository, IPublisherRepository publisherRepository, IMemberRepository memberRepository, IBorrowingRepository borrowingRepository, IAppUserRepository appUserRepository)
        {
            _context = context;
            _bookRepository = bookRepository;
            _authorRepository = authorRepository;
            _categoryRepository = categoryRepository;
            _publisherRepository = publisherRepository;
            _memberRepository = memberRepository;
            _borrowingRepository = borrowingRepository;
            _appUserRepository = appUserRepository;
        }

        public IBookRepository Books => _bookRepository;

        public IAuthorRepository Authors => _authorRepository;

        public ICategoryRepository Categories => _categoryRepository;

        public IPublisherRepository Publishers => _publisherRepository;

        public IMemberRepository Members => _memberRepository;

        public IBorrowingRepository Borrowings => _borrowingRepository;

        public IAppUserRepository AppUsers => _appUserRepository;

        public async ValueTask DisposeAsync()
        {
            await _context.DisposeAsync();
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
