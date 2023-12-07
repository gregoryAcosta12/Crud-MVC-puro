using Microsoft.Extensions.DependencyInjection;
using Northwind.Application.Contracts;
using Northwind.Application.Services;
<<<<<<< HEAD
using Northwind.Infrastructure.Interfaces;
=======
using Northwind.
>>>>>>> 27810b607528a82277bd7f871bd8969b136687a7
using Northwind.Infrastructure.Repositories;

namespace Northwind.loc.Dependecies
{
    public static class ProductsDependecies
    {
        public static void AddProductsDependecies(this IServiceCollection service)
        {

            service.AddScoped<IProductsService, ProductsService>();
            service.AddTransient<IProductsRepository, ProductsRepository>();


        }



    }
}
