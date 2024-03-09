using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MilesCarRental.Models
{
    [Table("Vehiculo")]
    [Index(nameof(Placa), IsUnique = true)]
    public class VehiculoModel
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(10), Required]
        public required string Marca { get; set; }

        [MaxLength(6), Required]
        public required string Placa { get; set; }

        //Llave foranea a Estado
        [Required]
        public int EstadoId { get; set; }
        public EstadoModel Estado { get; set; } = null!;

        //Exporta datos dependientes segun relacion
        public ICollection<DetalleRentaModel> DetalleRenta { get; } = new List<DetalleRentaModel>();
    }
}
