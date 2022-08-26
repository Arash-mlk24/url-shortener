namespace UrlShortener.Infrastructure.DB;

using UrlShortener.Entities;
using Microsoft.EntityFrameworkCore;

public class UrlShortenerContext : DbContext
{
  public DbSet<Url> UrlItems { get; set; } = null!;
  public UrlShortenerContext(DbContextOptions<UrlShortenerContext> options) : base(options) { }

  // protected override void OnModelCreating(ModelBuilder modelBuilder)
  // {

  //   // modelBuilder.Entity<UrlEntity>()
  //   //     .HasKey(x => x.ID)
  //   modelBuilder.Entity<Url>(entity =>
  //     {

  //       entity.HasKey(x => x.ID);

  //     });

  // }

  // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
  // {
  //   var configuration = new ConfigurationBuilder()
  //       .SetBasePath(Directory.GetCurrentDirectory())
  //       .AddJsonFile("appsettings.json")
  //       .Build();
  //   var connectionString = configuration.GetConnectionString("AppDb");
  //   optionsBuilder.UseSqlServer(connectionString);
  // }

}
