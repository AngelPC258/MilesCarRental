using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MilesCarRental.Data.Entities
{
    [Table("DetalleRenta")]
    public class DetalleRenta
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public required DateTime Fecha { get; set; }

        //Llave foranea a Localidad Origen y Destino
        [Required]
        public required int LocalidadOrigenId { get; set; }
        public Localidad LocalidadOrigen { get; set; } = null!;

        [Required]
        public required int LocalidadDestinoId { get; set; }
        public Localidad LocalidadDestino { get; set; } = null!;

        //Llave foranea a Vehiculo
        [Required]
        public required int VehiculoId { get; set; }
        public Vehiculo Vehiculo { get; set; } = null!;

        [Required]
        public required DateTime FechaInicioRenta { get; set; }

        public DateTime FechaFinRenta { get; set; }

        //Llave foranea a Estado
        [Required]
        public required int EstadoId { get; set; }

        public Estado Estado { get; set; } = null!;
    }
}
