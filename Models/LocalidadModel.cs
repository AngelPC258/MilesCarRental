using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MilesCarRental.Models
{
    [Table("Localidad")]
    [Index(nameof(Nombre), IsUnique = true)]
    public class LocalidadModel
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(50), Required]
        public required string Nombre { get; set; }

        //Llave foranea a Ciudad
        [Required]
        public int CiudadId { get; set; }
        public CiudadModel Ciudad { get; set; } = null!;

        //Llave foranea a Estado
        [Required]
        public int EstadoId { get; set; }
        public EstadoModel Estado { get; set; } = null!;

        //Exporta datos dependientes segun relacion
        public ICollection<DetalleRentaModel> DetalleRentaOrigen { get;} = new List<DetalleRentaModel>();
        public ICollection<DetalleRentaModel> DetalleRentaDestino { get; } = new List<DetalleRentaModel>();
    }
}
