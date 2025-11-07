using ElectroGest.Models;
using System;
using System.Collections.Generic;
using System.Linq;

public class RepositorioProveedores
{
    private readonly SistemaVentasContext _context;
 
    public RepositorioProveedores()
    {
        _context = new SistemaVentasContext();
    }

    // 🔹 Obtener todos los proveedores activos
    public List<Proveedore> ObtenerProveedoresActivos()
    {
        return _context.Proveedores
            .Where(p => p.Activo == true)
            .OrderByDescending(p => p.IdProveedor)
            .ToList();
    }
    public List<Proveedore> ObtenerTodosProveedores()
    {
        return _context.Proveedores
            .OrderByDescending(p => p.IdProveedor)
            .ToList(); // incluye activas e inactivas
    }
    // 🔹 Buscar por nombre o CUIT
    public List<Proveedore> Buscar(string texto)
    {
        return _context.Proveedores
            .Where(p => p.Nombre.Contains(texto) || p.Cuit.Contains(texto))
            .OrderByDescending(p => p.IdProveedor)
            .ToList();
    }

    // 🔹 Agregar proveedor
    public void Agregar(Proveedore proveedor)
    {
        proveedor.FechaCreacion = DateTime.Now;
        proveedor.FechaActualizacion = DateTime.Now;
        proveedor.Activo = true;

        _context.Proveedores.Add(proveedor);
        _context.SaveChanges();
    }

    // 🔹 Actualizar proveedor
    public void Actualizar(Proveedore proveedor)
    {
        try
        {
            var proveedorExistente = _context.Proveedores.FirstOrDefault(p => p.IdProveedor == proveedor.IdProveedor);
            if (proveedorExistente == null)
                throw new Exception("El proveedor no existe.");

            proveedorExistente.Nombre = proveedor.Nombre;
            proveedorExistente.Cuit = proveedor.Cuit;
            proveedorExistente.Email = proveedor.Email;
            proveedorExistente.Telefono = proveedor.Telefono;
            proveedorExistente.Direccion = proveedor.Direccion;
            proveedorExistente.Activo = proveedor.Activo;
            proveedorExistente.FechaActualizacion = DateTime.Now;

            _context.SaveChanges();
        }
        catch (Exception ex)
        {
            throw new Exception("Error al actualizar el proveedor: " + ex.Message);
        }
    }


    // 🔹 Desactivar proveedor
    public void Desactivar(int idProveedor)
    {
        var proveedor = _context.Proveedores.Find(idProveedor);
        if (proveedor != null)
        {
            proveedor.Activo = false;
            proveedor.FechaActualizacion = DateTime.Now;
            _context.SaveChanges();
        }
    }
}
