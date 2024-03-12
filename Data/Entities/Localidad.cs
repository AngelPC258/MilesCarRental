using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MilesCarRental.Data.Entities
{
    [Table("Localidad")]
    [Index(nameof(Nombre), IsUnique = true)]
    public class Localidad
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [MaxLength(50), Required]
        public required string Nombre { get; set; }

        //Llave foranea a Ciudad
        [Required]
        public int CiudadId { get; set; }
        public Ciudad Ciudad { get; set; } = null!;

        //Llave foranea a Estado
        [Required]
        public int EstadoId { get; set; }
        public Estado Estado { get; set; } = null!;

        //Exporta datos dependientes segun relacion
        public ICollection<DetalleRenta> DetalleRentaOrigen { get; } = new List<DetalleRenta>();
        public ICollection<DetalleRenta> DetalleRentaDestino { get; } = new List<DetalleRenta>();
    }
}
