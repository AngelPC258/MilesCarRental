using Microsoft.EntityFrameworkCore;
using MilesCarRental.Data.Entities;
using MilesCarRental.Data.Seeds;
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

        public DbSet<TipoEstado> TipoEstado { get; set; }
        public DbSet<Estado> Estado { get; set; }
        public DbSet<Ciudad> Ciudad { get; set; }
        public DbSet<Localidad> Localidad { get; set; }
        public DbSet<Vehiculo> Vehiculo { get; set; }
        public DbSet<DetalleRenta> DetalleRenta { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DetalleRenta>()
                .HasOne(e => e.LocalidadOrigen)
                .WithMany(e => e.DetalleRentaOrigen)
                .HasForeignKey(e => e.LocalidadOrigenId)
                .IsRequired()
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<DetalleRenta>()
                .HasOne(e => e.LocalidadDestino)
                .WithMany(e => e.DetalleRentaDestino)
                .HasForeignKey(e => e.LocalidadDestinoId)
                .IsRequired()
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<DetalleRenta>()
                .HasOne(e => e.Vehiculo)
                .WithMany(e => e.DetalleRenta)
                .HasForeignKey(e => e.VehiculoId)
                .IsRequired()
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.ApplyConfiguration(new TipoEstadoSeed());
            modelBuilder.ApplyConfiguration(new EstadoSeed());
            modelBuilder.ApplyConfiguration(new CiudadSeed());
        }
    }
}
