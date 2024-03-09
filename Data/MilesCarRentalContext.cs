using Microsoft.EntityFrameworkCore;
using MilesCarRental.Models;

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
    }
}
