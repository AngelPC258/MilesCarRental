using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MilesCarRental.Models
{
    [Table("Estado")]
    public class EstadoModel
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(20), Required]
        public required string Nombre { get; set; }

        //Llave foranea a TipoEstado
        [Required]
        public int TipoEstadoId { get; set; }
        public TipoEstadoModel TipoEstado { get; set; } = null!;

        //Exporta datos dependientes segun relacion
        public ICollection<LocalidadModel> Localidad { get; } = new List<LocalidadModel>();
        public ICollection<VehiculoModel> Vehiculo { get; } = new List<VehiculoModel>();
        public ICollection<DetalleRentaModel> DetalleRenta { get; } = new List<DetalleRentaModel>();
    }
}
