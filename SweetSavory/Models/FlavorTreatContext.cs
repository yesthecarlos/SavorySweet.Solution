using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace SweetSavoryTreats.Models
{
  public class SweetSavoryTreatsContext :  IdentityDbContext<ApplicationUser>
  {
  
   public virtual DbSet<Flavor> Flavors { get; set; }
   public virtual DbSet<Treat> Treats { get; set; }
   public DbSet<FlavorTreat> FlavorTreat { get; set; }
   
    public SweetSavoryTreatsContext(DbContextOptions options) : base(options) { }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}