using Microsoft.EntityFrameworkCore;
using GestorEntradas.Models;

namespace GestorEntradas.DAL;

public class Contexto : DbContext
{
    public Contexto(DbContextOptions<Contexto> options) : base(options) { }

    public DbSet<Entrada> Entradas { get; set; }
    public DbSet<EntradaDetalle> EntradaDetalles { get; set; }
    public DbSet<Producto> Productos { get; set; }
}
