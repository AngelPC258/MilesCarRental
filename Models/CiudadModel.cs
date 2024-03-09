using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MilesCarRental.Models
{
    [Table("Ciudad")]
    [Index(nameof(Nombre), IsUnique = true)]
    public class CiudadModel
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(20), Required]
        public required string Nombre { get; set; }

        //Exporta datos dependientes segun relacion
        public ICollection<LocalidadModel> Localidad { get; } = new List<LocalidadModel>();
    }
}
