using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MilesCarRental.Models
{
    [Table("DetalleRenta")]
    public class DetalleRentaModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public required DateTime Fecha { get; set; }

        //Llave foranea a Localidad Origen y Destino
        [Required]
        public required int LocalidadOrigenId { get; set; }
        public LocalidadModel LocalidadOrigen { get;set;} = null!;

        [Required]
        public required int LocalidadDestinoId { get; set; }
        public LocalidadModel LocalidadDestino{ get; set; } = null!;

        //Llave foranea a Vehiculo
        [Required]
        public required int VehiculoId { get; set; }
        public VehiculoModel Vehiculo { get; set; } = null!;

        [Required]
        public required DateTime FechaInicioRenta { get; set; }

        public DateTime FechaFinRenta { get; set; }

        //Llave foranea a Estado
        [Required]
        public required int EstadoId { get; set; }

        public EstadoModel Estado { get; set; } = null!;
    }
}
