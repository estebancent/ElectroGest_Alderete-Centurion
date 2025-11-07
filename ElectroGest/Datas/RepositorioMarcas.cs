using ElectroGest.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ElectroGest.Datas
{
    public class RepositoriosMarcas
    {
        private readonly SistemaVentasContext _context;

        public RepositoriosMarcas()
        {
            _context = new SistemaVentasContext();
        }

        // Obtener todas las marcas activas
      
        public List<Marca> ObtenerMarcasActivas()
        {
            return _context.Marcas
                .Where(m => m.Activo == true)
                .OrderBy(m => m.Nombre)
                .ToList();
        }
        public List<Marca> ObtenerTodasMarcas()
        {
            return _context.Marcas
                .OrderBy(m => m.Nombre)
                .ToList(); // incluye activas e inactivas
        }
        // Agregar nueva marca
        public void AgregarMarca(Marca marca)
        {
            marca.FechaCreacion = DateTime.Now;
            marca.FechaActualizacion = DateTime.Now;
            marca.Activo = true;

            _context.Marcas.Add(marca);
            _context.SaveChanges();
        }

        // Actualizar marca
        public void ActualizarMarca(Marca marca)
        {
            var mar = _context.Marcas.FirstOrDefault(m => m.IdMarca == marca.IdMarca);
            if (mar != null)
            {
                mar.Nombre = marca.Nombre;
                mar.FechaActualizacion = DateTime.Now;

                _context.SaveChanges();
            }
        }

        // Baja lógica
        public void EliminarMarca(int id)
        {
            var mar = _context.Marcas.FirstOrDefault(m => m.IdMarca == id);
            if (mar != null)
            {
                mar.Activo = false;
                mar.FechaActualizacion = DateTime.Now;
                _context.SaveChanges();
            }
        }

        // Verificar si existe una marca con ese nombre
        public bool NombreExiste(string nombre)
        {
            return _context.Marcas.Any(m => m.Nombre == nombre);
        }
    }
}

