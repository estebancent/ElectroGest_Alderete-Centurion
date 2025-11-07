
using ElectroGest.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ElectroGest.Datas
{
    public class RepositoriosCategorias
    {
        private readonly SistemaVentasContext _context;

        public RepositoriosCategorias()
        {
            _context = new SistemaVentasContext();
        }

        // Obtener todas las categorías activas
        public List<Categoria> ObtenerTodasCategorias()
        {
            return _context.Categorias
                .OrderBy(c => c.Nombre)
                .ToList(); // incluye activas e inactivas
        }
        public List<Categoria> ObtenerCategoriasActivas()
        {
            return _context.Categorias
                .Where(c => c.Activo == true) // solo activas
                .OrderBy(c => c.Nombre)
                .ToList();
        }
        // Agregar nueva categoría
        public void AgregarCategoria(Categoria categoria)
        {
            categoria.FechaCreacion = DateTime.Now;
            categoria.FechaActualizacion = DateTime.Now;
            categoria.Activo = true;

            _context.Categorias.Add(categoria);
            _context.SaveChanges();
        }

        // Actualizar categoría
        public void ActualizarCategoria(Categoria categoria)
        {
            _context.Categorias.Update(categoria);
            categoria.FechaActualizacion = DateTime.Now; // Actualizamos la fecha
            _context.SaveChanges();
        }


        // Baja lógica
        public void EliminarCategoria(int id)
        {
            var cat = _context.Categorias.FirstOrDefault(c => c.IdCategoria == id);
            if (cat != null)
            {
                cat.Activo = false;
                cat.FechaActualizacion = DateTime.Now;
                _context.SaveChanges();
            }
        }

        // Verificar si existe una categoría con ese nombre
        public bool NombreExiste(string nombre)
        {
            return _context.Categorias.Any(c => c.Nombre == nombre);
        }
    }
}
