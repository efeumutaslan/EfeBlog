using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EfeBlog.Data.Abstract;
using EfeBlog.Data.Concrete;
using EfeBlog.Data.Concrete.EntityFramework.Contexts;
using EfeBlog.Services.Abstract;
using EfeBlog.Services.Concrete;
using Microsoft.Extensions.DependencyInjection;

namespace EfeBlog.Services.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection LoadMyServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddDbContext<EfeBlogContext>();
            serviceCollection.AddScoped<IUnitOfWork, UnitOfWork>();
            serviceCollection.AddScoped<ICategoryService, CategoryManager>();
            serviceCollection.AddScoped<IArticleService, ArticleManager>();
            return serviceCollection;
        }
    }
}
