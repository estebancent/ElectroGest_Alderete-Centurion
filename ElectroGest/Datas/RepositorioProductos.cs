using ElectroGest.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectroGest.Datas
{
    public class RepositorioProductos
    {
        private readonly SistemaVentasContext _context;

        public RepositorioProductos()
        {
            _context = new SistemaVentasContext();
        }

        // ✅ Obtener todos los productos (activos e inactivos)
        public List<Producto> ObtenerTodos()
        {
            

         return _context.Productos
        .Include(p => p.IdCategoriaNavigation)
        .Include(p => p.IdMarcaNavigation)
        .AsNoTracking() // fuerza a leer desde la BD
        .OrderByDescending(p => p.IdProducto)
        .ToList();
        }

        // ✅ Obtener solo productos activos
        public List<Producto> ObtenerActivos()
        {
            return _context.Productos
                .Where(p => p.Activo == true)
                .OrderBy(p => p.Nombre)
                .ToList();
        }

        // ✅ Obtener un producto por ID
        public Producto ObtenerPorId(int id)
        {
            return _context.Productos.FirstOrDefault(p => p.IdProducto == id);
        }

        // ✅ Agregar producto nuevo

        public void Agregar(Producto producto)
        {
            // Insertamos con valores temporales
            producto.Sku = "TEMP";
            producto.CodigoBarras = null;

            _context.Productos.Add(producto);
            _context.SaveChanges();

            // SKU final con prefijo identificativo
            string prefijo = "T2025-EG"; // Taller 2025 ElectroGeste
            producto.Sku = $"{prefijo}-{producto.IdProducto:D5}";

            // Generar código de barras
            producto.CodigoBarras = GenerarCodigoBarras(producto.IdProducto);

            _context.Update(producto);
            _context.SaveChanges();
        }



        // ✅ Actualizar producto existente
        public void Actualizar(Producto producto)
        {
            var existente = _context.Productos.FirstOrDefault(p => p.IdProducto == producto.IdProducto);

            if (existente != null)
            {
                existente.Nombre = producto.Nombre;
                existente.Descripcion = producto.Descripcion;
                existente.ImagenUrl = producto.ImagenUrl;
                existente.PrecioCompra = producto.PrecioCompra;
                existente.PrecioVenta = producto.PrecioVenta;
                existente.MargenGanancia = producto.MargenGanancia;
                existente.IdCategoria = producto.IdCategoria;
                existente.IdMarca = producto.IdMarca;
                existente.Activo = producto.Activo;
                existente.FechaActualizacion = DateTime.Now;

                _context.SaveChanges();
            }
        }

        // ✅ Desactivar o reactivar un producto
        public void CambiarEstado(int idProducto, bool estado)
        {
            var producto = _context.Productos.FirstOrDefault(p => p.IdProducto == idProducto);
            if (producto != null)
            {
                producto.Activo = estado;
                producto.FechaActualizacion = DateTime.Now;
                _context.SaveChanges();
            }
        }

        // ✅ Eliminar producto definitivamente
        public void Eliminar(int id)
        {
            var producto = _context.Productos.FirstOrDefault(p => p.IdProducto == id);
            if (producto != null)
            {
                _context.Productos.Remove(producto);
                _context.SaveChanges();
            }
        }

        // ✅ Generador de código de barras interno
        private string GenerarCodigoBarras(int idProducto)
        {
            string baseCodigo = "779" + idProducto.ToString().PadLeft(9, '0'); // 12 dígitos base
            int checksum = CalcularDigitoVerificador(baseCodigo);
            return baseCodigo + checksum; // 13 dígitos totales
        }

        private int CalcularDigitoVerificador(string codigo12)
        {
            int suma = 0;
            for (int i = 0; i < codigo12.Length; i++)
            {
                int num = int.Parse(codigo12[i].ToString());
                suma += (i % 2 == 0) ? num : num * 3;
            }
            int resto = suma % 10;
            return resto == 0 ? 0 : 10 - resto;
        }

        public List<Producto> BuscarProductos(string termino, int? idCategoria = null, int? idMarca = null)
        {
            var query = _context.Productos
                .Include(p => p.IdCategoriaNavigation)
                .Include(p => p.IdMarcaNavigation)
                .AsQueryable();

            // 🔹 Filtrar por término de búsqueda (sku, código de barras, nombre o descripción)
            if (!string.IsNullOrWhiteSpace(termino))
            {
                query = query.Where(p =>
                    p.Sku.Contains(termino) ||
                    p.CodigoBarras.Contains(termino) ||
                    p.Nombre.Contains(termino) ||
                    p.Descripcion.Contains(termino));
            }

            // 🔹 Filtrar por categoría si se seleccionó
            if (idCategoria.HasValue)
            {
                query = query.Where(p => p.IdCategoria == idCategoria.Value);
            }

            // 🔹 Filtrar por marca si se seleccionó
            if (idMarca.HasValue)
            {
                query = query.Where(p => p.IdMarca == idMarca.Value);
            }

            // 🔹 Ordenar descendente por IdProducto (los últimos primero)
            return query.OrderByDescending(p => p.IdProducto).ToList();
        }

    }
}
