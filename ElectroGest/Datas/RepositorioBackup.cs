using ElectroGest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

namespace ElectroGest.Datas
{
    public class RepositorioBackup
    {
        private readonly SistemaVentasContext _context;

        public RepositorioBackup()
        {
            _context = new SistemaVentasContext();
        }

        public void RegistrarBackup(BackupHistorial backup)
        {
            _context.BackupHistorials.Add(backup);
            _context.SaveChanges();
        }

        public List<BackupHistorial> ObtenerHistorial()
        {
           

            
                return _context.BackupHistorials
                    .Include(b => b.IdUsuarioNavigation)
                    .ThenInclude(u => u.IdNavigation) // Incluye Persona
                    .OrderByDescending(b => b.FechaBackup)
                    .ToList();
           
        }

    }

}
