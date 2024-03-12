using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MilesCarRental.Data.Entities
{
    [Table("Estado")]
    public class Estado
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [MaxLength(20), Required]
        public required string Nombre { get; set; }

        //Llave foranea a TipoEstado
        [Required]
        public int TipoEstadoId { get; set; }
        public TipoEstado TipoEstado { get; set; } = null!;

        //Exporta datos dependientes segun relacion
        public ICollection<Localidad> Localidad { get; } = new List<Localidad>();
        public ICollection<Vehiculo> Vehiculo { get; } = new List<Vehiculo>();
        public ICollection<DetalleRenta> DetalleRenta { get; } = new List<DetalleRenta>();
    }
}
