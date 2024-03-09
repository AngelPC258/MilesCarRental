using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MilesCarRental.Models
{
    [Table("Estado")]
    public class EstadoModel
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(20)]
        public required string Nombre { get; set; }
        //Llave foranea a TipoEstado
        public int TipoEstadoId { get; set; }
        public TipoEstadoModel TipoEstado { get; set; } = null!;
        //Exporta datos dependientes segun relacion
        public ICollection<CiudadModel> Ciudad { get; } = new List<CiudadModel>();
    }
}
