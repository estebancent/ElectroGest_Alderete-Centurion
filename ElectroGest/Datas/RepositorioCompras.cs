using ElectroGest.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectroGest.Datas
{
    internal class RepositorioCompras
    {
    }
    public class RepositorioCompra
    {
        private readonly SistemaVentasContext _context;

        public RepositorioCompra()
        {
            _context = new SistemaVentasContext();
        }
    

        // ✅ Inserta la cabecera de la compra
        public int InsertarCompra(Compra compra)
        {
            _context.Compras.Add(compra);
            _context.SaveChanges();
            return compra.IdCompra; // Devuelve el ID generado
        }

        // ✅ Inserta los detalles de la compra
        // public void InsertarDetalle(DetalleCompra detalle)
        //{
        //  _context.DetalleCompras.Add(detalle);
        //_context.SaveChanges();
        //}
        public void InsertarDetalle(DetalleCompra detalle)
        {
            // 🧮 1️⃣ Calcular el subtotal en base a cantidad * precio de compra
            detalle.Subtotal = detalle.Cantidad * detalle.PrecioCompraUnitario;

            // ✅ 2️⃣ Validaciones básicas antes de insertar
            if (detalle.IdCompra <= 0)
                throw new ArgumentException("El ID de compra no es válido.");

            if (detalle.IdProducto <= 0)
                throw new ArgumentException("El ID de producto no es válido.");

            if (detalle.Cantidad <= 0)
                throw new ArgumentException("La cantidad debe ser mayor a cero.");

            if (detalle.PrecioCompraUnitario <= 0)
                throw new ArgumentException("El precio de compra debe ser mayor a cero.");

            // 🧾 3️⃣ Insertar directamente con SQL (evita conflictos con triggers)
            string sql = @"
        INSERT INTO DetalleCompra 
        (id_compra, id_producto, cantidad, precio_compra_unitario, precio_venta_calculado, subtotal) 
        VALUES ({0}, {1}, {2}, {3}, {4}, {5})";

            _context.Database.ExecuteSqlRaw(
                sql,
                detalle.IdCompra,
                detalle.IdProducto,
                detalle.Cantidad,
                detalle.PrecioCompraUnitario,
                detalle.PrecioVentaCalculado,
                detalle.Subtotal
            );
        }
        // 🧩 1️⃣ Agregar o actualizar la relación producto–proveedor
        public int RegistrarProductoProveedor(int idProducto, int idProveedor, decimal precioCompra)
        {
            var existente = _context.ProductoProveedors
                .FirstOrDefault(pp => pp.IdProducto == idProducto && pp.IdProveedor == idProveedor);

            if (existente == null)
            {
                var nuevo = new ProductoProveedor
                {
                    IdProducto = idProducto,
                    IdProveedor = idProveedor,
                    PrecioCompra = precioCompra,
                    Activo = true,
                    FechaCreacion = DateTime.Now,
                    FechaActualizacion = DateTime.Now
                };
                _context.ProductoProveedors.Add(nuevo);
                _context.SaveChanges();
                return nuevo.IdProductoProveedor;
            }
            else
            {
                existente.PrecioCompra = precioCompra;
                existente.FechaActualizacion = DateTime.Now;
                _context.SaveChanges();
                return existente.IdProductoProveedor;
            }
        }

        // 🧾 2️⃣ Registrar historial de precios
        public void RegistrarHistorialPrecioCompra(int idProductoProveedor, decimal precioCompra)
        {
            var historial = new HistorialPrecioCompra
            {
                IdProductoProveedor = idProductoProveedor,
                PrecioCompra = precioCompra,
                FechaRegistro = DateTime.Now
            };

            _context.HistorialPrecioCompras.Add(historial);
            _context.SaveChanges();
        }


        // ✅ (Opcional) Obtener todas las compras
        //  public List<Compra> ObtenerTodas()
        // {
        //   return _context.Compras
        //     .OrderByDescending(c => c.FechaCompra)
        //   .ToList();
        //}
        public List<Compra> ObtenerTodass()
        {
            return _context.Compras
                .Include(c => c.IdProveedorNavigation)
                .Include(c => c.IdUsuarioNavigation) // 👈 Incluye el usuario
                .OrderByDescending(c => c.FechaCompra)
                .AsNoTracking()
                .ToList();
        }
        public List<Compra> ObtenerTodas()
        {
            return _context.Compras
                .Include(c => c.IdProveedorNavigation)        // proveedor
                .Include(c => c.IdUsuarioNavigation)          // usuario
                    .ThenInclude(u => u.IdNavigation)        // persona asociada al usuario
                .Include(c => c.IdUsuarioNavigation)
                    .ThenInclude(u => u.Rol)                 // rol del usuario
                .OrderByDescending(c => c.FechaCompra)
                .AsNoTracking()
                .ToList();
        }



        // ✅ (Opcional) Obtener detalles por compra

        public List<DetalleCompra> ObtenerDetallesPorCompra(int idCompra)
        {
            return _context.DetalleCompras
                .Include(d => d.IdProductoNavigation)  // 🔥 Cargamos el producto
                .Where(d => d.IdCompra == idCompra)
                .AsNoTracking()                        // mejora rendimiento, solo lectura
                .ToList();
        }
        public int ObtenerUltimoNumeroFactura(string serie)
        {
            var ultimo = _context.Compras
                .Where(c => c.NumeroFactura.StartsWith(serie + "-"))
                .OrderByDescending(c => c.IdCompra)
                .Select(c => c.NumeroFactura)
                .FirstOrDefault();

            if (ultimo == null) return 0;

            string[] partes = ultimo.Split('-');
            if (partes.Length != 2) return 0;

            if (int.TryParse(partes[1], out int numero))
                return numero;

            return 0;
        }
        public int ObtenerProximoNumeroCompra()
        {
            int ultimoId = _context.Compras.Any()
                ? _context.Compras.Max(c => c.IdCompra)
                : 0;

            return ultimoId + 1;
        }

        public List<Compra> ObtenerCompras(string filtro = null)
        {
            var query = _context.Compras
                                .AsQueryable();

            //if (!string.IsNullOrWhiteSpace(filtro))
            //{
            //    query = query.Where(c =>
            //        c.Proveedor.Nombre.Contains(filtro)
            //    );
            //}

            return query.ToList();
        }


    }
}
