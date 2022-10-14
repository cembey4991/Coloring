using Coloring.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Coloring.Infrastructure.Seeds
{
    public class ColorSeed : IEntityTypeConfiguration<Color>
    {
        public void Configure(EntityTypeBuilder<Color> builder)
        {
            builder.HasData(
                new Color { Id = 1, ColorName = "Kırmızı" },
                new Color { Id = 2, ColorName = "Sarı" },
                new Color { Id = 3, ColorName = "Yeşil" }
                );
        }
    }
}
