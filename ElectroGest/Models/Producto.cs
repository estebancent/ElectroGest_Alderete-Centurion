using System;
using System.Collections.Generic;

namespace ElectroGest.Models;

public partial class Producto
{
    public int IdProducto { get; set; }

    public string Sku { get; set; } = null!;

    public string? CodigoBarras { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }

    public string? ImagenUrl { get; set; }

    public decimal? PrecioCompra { get; set; }

    public decimal? PrecioVenta { get; set; }

    public decimal? MargenGanancia { get; set; }

    public int? Stock { get; set; }

    public int? StockMinimo { get; set; }

    public int IdCategoria { get; set; }

    public int IdMarca { get; set; }

    public bool? Activo { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public DateTime? FechaActualizacion { get; set; }

    public virtual ICollection<DetalleCompra> DetalleCompras { get; set; } = new List<DetalleCompra>();

    public virtual ICollection<DetalleVentum> DetalleVenta { get; set; } = new List<DetalleVentum>();

    public virtual Categoria IdCategoriaNavigation { get; set; } = null!;

    public virtual Marca IdMarcaNavigation { get; set; } = null!;

    public virtual ICollection<ProductoProveedor> ProductoProveedors { get; set; } = new List<ProductoProveedor>();
}
