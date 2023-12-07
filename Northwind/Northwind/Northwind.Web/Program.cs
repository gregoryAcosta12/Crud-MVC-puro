using Microsoft.EntityFrameworkCore;
using Northwind.Infrastructure.Context;
using Northwind.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Northwind.Domain.Repository;
using Northwind.Infrastructure.Repositories;
using Northwind.Infrastructure.Interfaces;
<<<<<<< HEAD
using Northwind.loc.Dependecies;
=======
using Northwind.
>>>>>>> 27810b607528a82277bd7f871bd8969b136687a7

var builder = WebApplication.CreateBuilder(args);



// Add services to the container.//


// context //
builder.Services.AddDbContext<NorthwindContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("NorthwindContext")));

<<<<<<< HEAD
builder.Services.AddProductsDependecies();
=======
//builder.Services.AddProductsDependecies();//
>>>>>>> 27810b607528a82277bd7f871bd8969b136687a7


builder.Services.AddControllersWithViews();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();