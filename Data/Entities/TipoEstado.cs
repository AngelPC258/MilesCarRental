using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MilesCarRental.Data.Entities
{
    [Table("TipoEstado")]
    [Index(nameof(Tipo), IsUnique = true)]
    public class TipoEstado
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [MaxLength(20), Required]
        public required string Tipo { get; set; }

        //Exporta datos dependientes segun relacion
        public ICollection<Estado> Estado { get; } = new List<Estado>();
    }
}
