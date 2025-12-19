using System.ComponentModel.DataAnnotations;

namespace GestorEntradas.Models;

public class EntradaDetalle
{
    [Key]
    public int EntradaDetalleId { get; set; }

    public int EntradaId { get; set; }
    public int ProductoId { get; set; }
    public int Cantidad { get; set; }
    public decimal Costo { get; set; } 
}
