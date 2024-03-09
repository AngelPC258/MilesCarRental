using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MilesCarRental.Models
{
    [Table("TipoEstado")]
    public class TipoEstadoModel
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(20)]
        public required string Tipo { get; set; }
        //Exporta datos dependientes segun relacion
        public ICollection<EstadoModel> Estado { get; } = new List<EstadoModel>();
    }
}
