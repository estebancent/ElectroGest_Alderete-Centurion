using System;
using System.Collections.Generic;

namespace ElectroGest.Models;

public partial class HistorialPrecioCompra
{
    public int IdHistorial { get; set; }

    public int IdProductoProveedor { get; set; }

    public decimal PrecioCompra { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public virtual ProductoProveedor IdProductoProveedorNavigation { get; set; } = null!;
}
