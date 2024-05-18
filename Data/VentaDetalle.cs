using AdministrarTiendaElect.Data;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

public class VentaDetalle
{
    [Key]
    public int ID_Venta { get; set; }

    [Required(ErrorMessage = "La hora de la venta es obligatoria")]
    public TimeOnly Hora { get; set; }

    [Required(ErrorMessage = "La cantidad de productos vendidos es obligatoria")]
    public int Cantidad { get; set; }

    [Required(ErrorMessage = "El total de la venta es obligatorio")]
    public decimal Total { get; set; }
    //propiedades de navegación de Entity Framework
    public int ProductoID_Producto { get; set; }
    public virtual Producto Producto { get; set; }
    public int VentaControlID_Ticket { get; set; }
    public virtual VentaControl VentaControl { get; set; }
}
