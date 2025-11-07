using ElectroGest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ElectroGest.Datas
{
    public class RepositorioProductoProveedores
    {
        private readonly SistemaVentasContext _context;

        public RepositorioProductoProveedores()
        {
            _context = new SistemaVentasContext();
        }

        // Obtener todos los productos-proveedor
        public List<ProductoProveedor> ObtenerProductosProveedores()
        {
            return _context.ProductoProveedors
                .Include(pp => pp.IdProductoNavigation)
                .Include(pp => pp.IdProveedorNavigation)
                .AsNoTracking()
                .ToList();


        }
    }

}
