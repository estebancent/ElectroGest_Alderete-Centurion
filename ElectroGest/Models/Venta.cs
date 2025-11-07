using System;
using System.Collections.Generic;

namespace ElectroGest.Models;

public partial class Venta
{
    public int Id { get; set; }

    public int VendedorId { get; set; }

    public int ClienteId { get; set; }

    public int? SupervisorId { get; set; }

    public DateTime? FechaVenta { get; set; }

    public decimal Total { get; set; }

    public string? Estado { get; set; }

    public string? NumeroFactura { get; set; }

    public string? Observaciones { get; set; }

    public DateTime? FechaActualizacion { get; set; }

    public string? MetodoPago { get; set; }

    public decimal? Descuento { get; set; }

    public decimal? Recargo { get; set; }

    public decimal? TotalFinal { get; set; }

    public virtual Cliente Cliente { get; set; } = null!;

    public virtual ICollection<DetalleVentum> DetalleVenta { get; set; } = new List<DetalleVentum>();

    public virtual Usuario? Supervisor { get; set; }

    public virtual Usuario Vendedor { get; set; } = null!;
}
