using Microsoft.EntityFrameworkCore;

namespace API.Data;

public class ApplicationDbContext : DbContext
{
       public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
       : base(options) { }
       
       public DbSet<MyFirstSchema> MyFirstQueries { get; set; }

       protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
       {
              if (!optionsBuilder.IsConfigured)
              {
                  optionsBuilder.UseSqlServer("Name=Test.API");
              }
              base.OnConfiguring(optionsBuilder);
       }
       
}
