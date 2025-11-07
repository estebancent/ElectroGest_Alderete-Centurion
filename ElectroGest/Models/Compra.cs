using System;
using System.Collections.Generic;

namespace ElectroGest.Models;

public partial class Compra
{
    public int IdCompra { get; set; }

    public int IdProveedor { get; set; }

    public DateTime? FechaCompra { get; set; }

    public decimal TotalCompra { get; set; }

    public string? NumeroFactura { get; set; }

    public string? Observaciones { get; set; }

    public int IdUsuario { get; set; }

    public virtual ICollection<DetalleCompra> DetalleCompras { get; set; } = new List<DetalleCompra>();

    public virtual Proveedore IdProveedorNavigation { get; set; } = null!;

    public virtual Usuario IdUsuarioNavigation { get; set; } = null!;
}
