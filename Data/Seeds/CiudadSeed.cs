using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MilesCarRental.Data.Entities;

namespace MilesCarRental.Data.Seeds
{
    public class CiudadSeed : IEntityTypeConfiguration<Ciudad>
    {
        public void Configure(EntityTypeBuilder<Ciudad> builder)
        {
            builder.HasData(
                new Ciudad() { Id = 1, Nombre = "Bogota"},
                new Ciudad() { Id = 2, Nombre = "Medellin" },
                new Ciudad() { Id = 3, Nombre = "Cali" }
                );
        }
    }
}
