using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace AdministrarTiendaElect.Data
{
    public class VentaControl
    {
        [Key]
        [Required(ErrorMessage = "El ID es obligatorio")]
        public int ID_Ticket { get; set; }
        [Required]
        public DateOnly Fecha { get; set; }
    }
}
