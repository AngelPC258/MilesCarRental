using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MilesCarRental.Data.Entities;

namespace MilesCarRental.Data.Seeds
{
    public class EstadoSeed : IEntityTypeConfiguration<Estado>
    {
        public void Configure(EntityTypeBuilder<Estado> builder)
        {
            builder.HasData(
                new Estado { Id = 1, Nombre = "Abierto", TipoEstadoId = 1 },
                new Estado { Id = 2, Nombre = "Cerrado", TipoEstadoId = 1 },
                new Estado { Id = 3, Nombre = "Disponible", TipoEstadoId = 2 },
                new Estado { Id = 4, Nombre = "Reparación", TipoEstadoId = 2 },
                new Estado { Id = 5, Nombre = "Rentado", TipoEstadoId = 2 },
                new Estado { Id = 6, Nombre = "Renta en curso", TipoEstadoId = 3 },
                new Estado { Id = 7, Nombre = "En proceso", TipoEstadoId = 3 },
                new Estado { Id = 8, Nombre = "Renta Finalizada", TipoEstadoId = 3 }
                );
        }
    }
}
