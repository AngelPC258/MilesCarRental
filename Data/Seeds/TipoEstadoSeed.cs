using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MilesCarRental.Data.Entities;

namespace MilesCarRental.Data.Seeds
{
    public class TipoEstadoSeed : IEntityTypeConfiguration<TipoEstado>
    {
        public void Configure(EntityTypeBuilder<TipoEstado> builder)
        {
            builder.HasData(
                new TipoEstado { Id = 1, Tipo = "Localidad"},
                new TipoEstado { Id = 2, Tipo = "Vehiculo" },
                new TipoEstado { Id = 3, Tipo = "Detalle Renta" }
                );
        }
    }
}
