using UrlShortener.Applications;
using UrlShortener.Infrastructure.DB;
using UrlShortener.Interfaces;
using UrlShortener.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add Dependencies 
builder.Services.AddScoped<IUrlRepository, UrlRepository>();
builder.Services.AddTransient<IAppApplication, AppApplication>();
builder.Services.AddTransient<IUrlShortenerApplication, UrlShortenerApplication>();

var connectionString = @"Server=localhost,1433;Database=master;User=sa;Password=Arash12313801354;";

builder.Services.AddDbContext<UrlShortenerContext>(x => x.UseSqlServer(connectionString));

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
