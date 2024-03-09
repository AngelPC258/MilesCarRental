using Microsoft.EntityFrameworkCore;
using MilesCarRental.Models;
using System.Reflection.Metadata;

namespace MilesCarRental.Data
{
    internal class MilesCarRentalContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public MilesCarRentalContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer(_configuration.GetSection("ConnectionString").Value);

        public DbSet<TipoEstadoModel> TipoEstado { get; set; }
        public DbSet<EstadoModel> Estado { get; set; }
        public DbSet<CiudadModel> Ciudad { get; set; }
        public DbSet<LocalidadModel> Localidad { get; set; }
        public DbSet<VehiculoModel> Vehiculo { get; set; }
        public DbSet<DetalleRentaModel> DetalleRenta { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DetalleRentaModel>()
                .HasOne(e => e.LocalidadOrigen)
                .WithMany(e => e.DetalleRentaOrigen)
                .HasForeignKey(e => e.LocalidadOrigenId)
                .IsRequired()
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<DetalleRentaModel>()
                .HasOne(e => e.LocalidadDestino)
                .WithMany(e => e.DetalleRentaDestino)
                .HasForeignKey(e => e.LocalidadDestinoId)
                .IsRequired()
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<DetalleRentaModel>()
                .HasOne(e => e.Vehiculo)
                .WithMany(e => e.DetalleRenta)
                .HasForeignKey(e => e.VehiculoId)
                .IsRequired()
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
