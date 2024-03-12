using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MilesCarRental.Data.Entities
{
    [Table("Ciudad")]
    [Index(nameof(Nombre), IsUnique = true)]
    public class Ciudad
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [MaxLength(20), Required]
        public required string Nombre { get; set; }

        //Exporta datos dependientes segun relacion
        public ICollection<Localidad> Localidad { get; } = new List<Localidad>();
    }
}
