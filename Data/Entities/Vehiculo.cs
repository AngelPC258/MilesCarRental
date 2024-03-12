using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MilesCarRental.Data.Entities
{
    [Table("Vehiculo")]
    [Index(nameof(Placa), IsUnique = true)]
    public class Vehiculo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [MaxLength(10), Required]
        public required string Marca { get; set; }

        [MaxLength(6), Required]
        public required string Placa { get; set; }

        //Llave foranea a Estado
        [Required]
        public int EstadoId { get; set; }
        public Estado Estado { get; set; } = null!;

        //Exporta datos dependientes segun relacion
        public ICollection<DetalleRenta> DetalleRenta { get; } = new List<DetalleRenta>();
    }
}
