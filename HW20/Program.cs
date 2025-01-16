using AppDataRepository.Cars;
using AppDataRepository.Db;
using AppDataRepository.OldCars;
using AppDataRepository.Users;
using AppDomainCore.HW20.Cars.Contract._1_Repository;
using AppDomainCore.HW20.Cars.Contract._2_Service;
using AppDomainCore.HW20.Cars.Contract._3_AppService;
using AppDomainCore.HW20.Users.Contract._1_Repository;
using AppDomainCore.HW20.Users.Contract._2_Service;
using AppDomainCore.HW20.Users.Contract._3_AppService;
using AppDomainCore.OldCars.Contract._1_Repository;
using AppDomainCore.OldCars.Contract._2_Service;
using AppDomainCore.OldCars.Contract._3_AppService;
using DomainAppService.Cars;
using DomainAppService.OldCars;
using DomainAppService.Users;
using DomainService.Cars;
using DomainService.OldCars;
using DomainService.Users;
using Microsoft.EntityFrameworkCore;
using System;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var ConnectionString = builder.Configuration.GetConnectionString("sql");
builder.Services.AddDbContext<AppDbContext>(option => option.UseSqlServer(ConnectionString));

builder.Services.AddScoped<IUserAppService, UserAppService>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IUserRepository, UserRepository>();

builder.Services.AddScoped<ICardAppService, CarAppService>();
builder.Services.AddScoped<ICarService, CarService>();
builder.Services.AddScoped<ICarRepository, CarRepository>();

builder.Services.AddScoped<IOldCarAppService, OldCarAppService>();
builder.Services.AddScoped<IOldCarService, OldCarService>();
builder.Services.AddScoped<IOldCarRepository, OldCarRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
