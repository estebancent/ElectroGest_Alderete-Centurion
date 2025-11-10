using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ElectroGest.Models;
using Microsoft.EntityFrameworkCore;

namespace ElectroGest.Repositorios
{
    public class RepositorioVentas
    {
        private readonly SistemaVentasContext _context;

        public RepositorioVentas()
        {
            _context = new SistemaVentasContext();
        }
        public Venta ObtenerPorId(int id)
        {
            return _context.Ventas
                .Include(v => v.Cliente)
                    .ThenInclude(c => c.IdNavigation)
                .Include(v => v.Vendedor)
                    .ThenInclude(u => u.IdNavigation)
                .Include(v => v.DetalleVenta)
                    .ThenInclude(d => d.IdProductoNavigation)
                .FirstOrDefault(v => v.Id == id);
        }

        // ✅ Método para obtener todas las ventas
        public List<Venta> ObtenerTodas()
        {
            return _context.Ventas
                .Include(v => v.Cliente)
                    .ThenInclude(c => c.IdNavigation)
                .Include(v => v.Vendedor)
                    .ThenInclude(u => u.IdNavigation)
                .Include(v => v.Vendedor)
                    .ThenInclude(u => u.Rol)
                .Include(v => v.Supervisor)
                    .ThenInclude(s => s.IdNavigation)
                .ToList();
        }

        public List<Venta> ObtenerVentas(string filtro = null)
        {
            var query = _context.Ventas
                                .Include(v => v.Cliente) // si tiene relación con Cliente
                                .AsQueryable();

            //if (!string.IsNullOrWhiteSpace(filtro))
            //{
            //    query = query.Where(v =>
            //        v.Cliente.Nombre.Contains(filtro) ||
            //        v.Usuario.Nombre.Contains(filtro)
            //    );
            //}

            return query.ToList();
        }


        public string GenerarNumeroFactura()
        {
            int ultimoId = _context.Ventas
                .OrderByDescending(v => v.Id)
                .Select(v => v.Id)
                .FirstOrDefault();

            int nuevoNumero = ultimoId + 1;

            return $"FAC-{nuevoNumero:D6}"; // ejemplo: FAC-000123
        }
        public int InsertarVenta(Venta venta, List<DetalleVentum> detalles)
        {
            try
            {
                // 1️⃣ Generar número de factura
                int ultimoId = _context.Ventas.OrderByDescending(v => v.Id)
                                              .Select(v => v.Id)
                                              .FirstOrDefault();

                int nuevoNumero = ultimoId + 1;
                venta.NumeroFactura = $"FAC-{nuevoNumero:D6}";
                venta.FechaVenta = DateTime.Now;
                venta.FechaActualizacion = DateTime.Now;
                venta.Estado = "Completada";

                // 2️⃣ Insertar venta
                _context.Ventas.Add(venta);
                _context.SaveChanges(); // se genera el ID de la venta

                int idVenta = venta.Id;

                // 3️⃣ Insertar cada detalle
                foreach (var det in detalles)
                {
                    det.IdVenta = idVenta;
                    _context.DetalleVenta.Add(det);

                    // 4️⃣ Actualizar stock
                    var producto = _context.Productos.Find(det.IdProducto);
                    if (producto != null)
                    {
                        producto.Stock -= det.Cantidad;
                        producto.FechaActualizacion = DateTime.Now;
                    }
                }

                _context.SaveChanges();
                return idVenta; // devolvemos el id de la venta recién creada
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al insertar venta: {ex.Message}");
                return 0; // 0 = error
            }
        }



    }
}

