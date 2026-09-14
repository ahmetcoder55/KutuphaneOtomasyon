using KutuphaneOtomasyon.DataAccess.Abstract;
using KutuphaneOtomasyon.DataAccess.Abstract.UnitOfWorks;
using KutuphaneOtomasyon.DataAccess.Concrete.Contexts.EntityFramework;
using KutuphaneOtomasyon.DataAccess.Concrete.UnitOfWorks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace KutuphaneOtomasyon.DataAccess.Concrete.Extensions
{
    public static class DataAccessExtension
    {
        public static void ConfigureDatabase(this IServiceCollection services,String connectionString)
        {
            services.AddDbContext<KutuphaneOtomasyonDbContext>(opt =>
            {
                opt.UseSqlServer(connectionString);
            });
           
        }
        public static void ConfigureRepositories(this IServiceCollection services)
        {
            services.AddScoped<IBookRepository, BookRepository>();
            services.AddScoped<IAuthorRepository, AuthorRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IPublisherRepository, PublisherRepository>();
            services.AddScoped<IMemberRepository, MemberRepository>();
            services.AddScoped<IBorrowingRepository, BorrowingRepository>();
            services.AddScoped<IAppUserRepository, AppUserRepository>();

            services.AddScoped<IRepositoryManager, RepositoryManager>();
        }
    }
}
