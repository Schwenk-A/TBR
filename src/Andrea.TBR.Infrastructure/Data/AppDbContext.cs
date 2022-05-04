
using Microsoft.EntityFrameworkCore;
using Andrea.TBR.Core.Entities;

namespace Andrea.TBR.Infrastructure.Data;

public class AppDbContext : DbContext
{

  public DbSet<Book> Books { get; set; } 
  public DbSet<User> Users { get; set; } 
  public DbSet<Review> Reviews { get; set; }


  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    base.OnModelCreating(modelBuilder);

  }


}
