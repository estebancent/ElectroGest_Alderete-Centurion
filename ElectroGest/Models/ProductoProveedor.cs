using System;
using System.Collections.Generic;

namespace ElectroGest.Models;

public partial class ProductoProveedor
{
    public int IdProductoProveedor { get; set; }

    public int IdProducto { get; set; }

    public int IdProveedor { get; set; }

    public decimal PrecioCompra { get; set; }

    public bool? Activo { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public DateTime? FechaActualizacion { get; set; }

    public virtual ICollection<HistorialPrecioCompra> HistorialPrecioCompras { get; set; } = new List<HistorialPrecioCompra>();

    public virtual Producto IdProductoNavigation { get; set; } = null!;

    public virtual Proveedore IdProveedorNavigation { get; set; } = null!;
}
