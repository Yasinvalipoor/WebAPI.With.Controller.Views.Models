using API.Controller.View.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<WebApiControllerViewContext>(c => c.UseSqlServer(builder.Configuration.GetConnectionString("PeopleDbCnn")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllerRoute("Default", "{Controller=People}/{Action=GetAllPeople}/{id?}");
//app.MapDefaultControllerRoute(); ==> "Default", "{Controller=Home}/{Action=Index}/{id?}"

app.Run();
