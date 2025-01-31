using AppDataRepository.CompanyCars;
using AppDataRepository.Db;
using AppDomainCore.CompanyCars.Conteract;
using AppDomainCore.Configs;
using DomainAppService.CompanyCars;
using DomainAppService.Users;
using DomainService.CompanyCars;
using DomainService.Users;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var ConnectionString = builder.Configuration.GetConnectionString("sql");
builder.Services.AddDbContext<AppDbContext>(option => option.UseSqlServer(ConnectionString));

var limit = builder.Configuration.GetSection("Limits").Get<Limits>();
builder.Services.AddSingleton(limit);

builder.Services.AddScoped<ICompanyCarAppService, CompanyCarAppService>();
builder.Services.AddScoped<ICompanyCarService, CompanyCarService>();
builder.Services.AddScoped<ICompanyCarRepository, CompanyCarRepository>();




var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
