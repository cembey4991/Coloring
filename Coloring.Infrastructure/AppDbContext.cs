using Coloring.Entity.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Coloring.Infrastructure
{
    public class AppDbContext : IdentityDbContext<AppUser,AppRole,int>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
           base.OnModelCreating(modelBuilder);

        }
        public DbSet<Color> Colors { get; set; }
        public DbSet<ColorImage> ColorImages { get; set; }
        public DbSet<ColorType> ColorTypes { get; set; }
        public DbSet<ImageArea> ImageAreas { get; set; }

    }
}
