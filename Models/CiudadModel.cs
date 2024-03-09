using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MilesCarRental.Models
{
    [Table("Ciudad")]
    public class CiudadModel
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(20)]
        public required string Nombre { get; set; }
        //Llave foranea a Estado
        public int EstadoId { get; set; }
        public EstadoModel Estado { get; set; } = null!;
    }
}
