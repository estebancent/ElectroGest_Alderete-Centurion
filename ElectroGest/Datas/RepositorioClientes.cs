using ElectroGest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;




namespace ElectroGest.Datas
{
    public class RepositorioClientes
    {
        private readonly SistemaVentasContext _context;

        public RepositorioClientes()
        {
            _context = new SistemaVentasContext();
        }

        // Obtener todos los clientes activos, con filtro opcional
        public List<Cliente> ObtenerClientes(string filtro = null)
        {
            var query = _context.Clientes
                                .Include(c => c.IdNavigation) // si Cliente tiene relación con Persona
                               // .Where(c => c.Activo == true)
                                .AsQueryable();

            if (!string.IsNullOrWhiteSpace(filtro))
            {
                query = query.Where(c =>
                    c.IdNavigation.Nombre.Contains(filtro) ||
                    c.IdNavigation.Email.Contains(filtro) ||
                    (c.IdNavigation.Dni != null && c.IdNavigation.Dni.ToString().Contains(filtro)) ||
                    c.IdNavigation.Telefono.Contains(filtro)
                );
            }

            return query.ToList();
        }
        public List<Cliente> ObtenerClientes2(string filtro = null)
        {
            var query = _context.Clientes
                .Include(c => c.IdNavigation)
                .Where(c => c.Activo == true || c.Activo == null)
                .AsQueryable();

            if (!string.IsNullOrWhiteSpace(filtro))
            {
                query = query.Where(c =>
                    c.IdNavigation.Nombre.Contains(filtro) ||
                    c.IdNavigation.Email.Contains(filtro) ||
                    c.IdNavigation.Telefono.Contains(filtro) ||
                    (c.IdNavigation.Dni.ToString().Contains(filtro))
                );
            }

            return query
                .Select(c => new
                {
                    c.Id,
                    Nombre = c.IdNavigation.Nombre,
                    DNI = c.IdNavigation.Dni,
                    c.IdNavigation.Email,
                    c.IdNavigation.Telefono,
                    c.Direccion,
                    c.FechaRegistro,
                    c.FechaModificacion
                })
                .ToList<object>() // para binding dinámico
                .Cast<Cliente>()  // si usás modelo Cliente directamente, ajustá esto según el tipo de retorno
                .ToList();
        }

        // Agregar un cliente
        public void AgregarCliente(Cliente cliente)
        {
            cliente.Activo = true;
            _context.Clientes.Add(cliente);
            _context.SaveChanges();
        }

        // Actualizar un cliente
        public void ActualizarClientes(Cliente cliente)
        {
            _context.Clientes.Update(cliente);
            _context.SaveChanges();
        }

        // Eliminar un cliente (baja lógica)
        public void EliminarCliente(int id)
        {
            var cliente = _context.Clientes.FirstOrDefault(c => c.Id == id);
            if (cliente != null)
            {
                cliente.Activo = false;
                _context.SaveChanges();
            }
        }

        // Verificar si existe email
        public bool EmailExiste(string email, int? idExcluido = null)
        {
            return _context.Clientes
                           .Include(c => c.IdNavigation)
                           .Any(c => c.IdNavigation.Email == email && (idExcluido == null || c.Id != idExcluido));
        }

        // Verificar si existe DNI
        public bool DniExiste(int dni, int? idExcluido = null)
        {
            return _context.Clientes
                           .Include(c => c.IdNavigation)
                           .Any(c => c.IdNavigation.Dni == dni && (idExcluido == null || c.Id != idExcluido));
        }

        public void ActualizarCliente(Cliente cliente)
        {
            var existente = _context.Clientes
                .Include(c => c.IdNavigation)
                .FirstOrDefault(c => c.Id == cliente.Id);

            if (existente == null)
                throw new Exception("Cliente no encontrado.");

            // Actualizar los datos de la persona
            existente.IdNavigation.Nombre = cliente.IdNavigation.Nombre;
            existente.IdNavigation.Dni = cliente.IdNavigation.Dni;
            existente.IdNavigation.Email = cliente.IdNavigation.Email;
            existente.IdNavigation.Telefono = cliente.IdNavigation.Telefono;

            // Actualizar los datos específicos del cliente
            existente.Direccion = cliente.Direccion;
            existente.FechaModificacion = DateTime.Now;

            // Si se desea, también se puede actualizar el estado
            existente.Activo = cliente.Activo;

            _context.SaveChanges();
        }


        // ✅ Activar o desactivar cliente (baja lógica)
        public bool CambiarEstadoCliente(int idCliente)
        {
            var cliente = _context.Clientes.FirstOrDefault(c => c.Id == idCliente);
            if (cliente == null)
                return false;

            cliente.Activo = (cliente.Activo == true) ? false : true;

            _context.SaveChanges();
            return true;
        }


        // ✅ Obtener cliente por Id
        public Cliente ObtenerPorId(int id)
        {
            return _context.Clientes
                .Include(c => c.IdNavigation)
                .FirstOrDefault(c => c.Id == id);
        }
    }
}

