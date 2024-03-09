using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MilesCarRental.Models
{
    [Table("Localidad")]
    public class LocalidadModel
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Nombre { get; set; }
        public int CiudadId { get; set; }
        public int EstadoId { get; set; }

    }
}
