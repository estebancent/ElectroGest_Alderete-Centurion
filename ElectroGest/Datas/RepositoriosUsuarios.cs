using ElectroGest.Models;
using ElectroGest.Utils;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;

namespace ElectroGest.Datas
{
    public class RepositoriosUsuarios
    {
        private readonly SistemaVentasContext _context;

        public RepositoriosUsuarios(SistemaVentasContext context)
        {
            _context = context;
        }


        // Listar todos los usuarios con su Rol y Persona

        public RepositoriosUsuarios()
        {
            _context = new SistemaVentasContext(); // Asume que el constructor por defecto de tu DbContext está configurado con connection string
        }


            public List<Usuario> ObtenerUsuarios()
            {
                return _context.Usuarios
                    .Include(u => u.IdNavigation) // Persona asociada
                    .Include(u => u.Rol)          // Rol
                    //.Where(u => (bool)u.Activo)         // Solo activos
                    .ToList();

            }

        public void AgregarUsuario(Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();
        }

        public void ActualizarUsuario(Usuario usuario)
        {
            _context.Usuarios.Update(usuario);
            _context.SaveChanges();
        }

        public void EliminarUsuario(int id)
        {
            var usuario = _context.Usuarios.FirstOrDefault(u => u.Id == id);
            if (usuario != null)
            {
                usuario.Activo = false; // Baja lógica
                _context.SaveChanges();
            }
        }

        public void DebugUsuarios()
        {
            var usuarios = _context.Usuarios
                .Include(u => u.IdNavigation)
                .Include(u => u.Rol)
                .ToList();

            foreach (var user in usuarios)
            {
                Console.WriteLine($"User: {user.IdNavigation.Nombre}, " +
                                 $"Email: {user.IdNavigation.Email}, " +
                                 $"Rol: {user.Rol.Nombre}, " +
                                 $"PasswordHash: {user.PasswordHash}");
            }
        }
        // Método para información de roles
       private string GetRolesInfo()
        {
           var roles = _context.Roles.ToList();
            if (!roles.Any()) return "No hay roles en la base de datos";

            StringBuilder sb = new StringBuilder();
            foreach (var role in roles)
            {
                sb.AppendLine($"- {role.Nombre}: {role.Descripcion}");
            }
            return sb.ToString();
        }
        // Obtener roles
        public List<Role> ObtenerRoles()
        {
            return _context.Roles.OrderBy(r => r.Nombre).ToList();
        }
        public string GetDebugInfo()
        {
            var usuarios = _context.Usuarios
                .Include(u => u.IdNavigation)
                .Include(u => u.Rol)
                .ToList();

            if (!usuarios.Any())
            {
                return "No hay usuarios en la base de datos.\n\nRoles existentes:\n" + GetRolesInfo();
            }

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("=== USUARIOS EN BASE DE DATOS ===");

            foreach (var user in usuarios)
            {
                sb.AppendLine($"ID: {user.Id}");
                sb.AppendLine($"Nombre: {user.IdNavigation.Nombre}");
                sb.AppendLine($"Email: {user.IdNavigation.Email}");
                sb.AppendLine($"Rol: {user.Rol?.Nombre ?? "N/A"}");
                sb.AppendLine($"Activo: {user.Activo}");
                sb.AppendLine($"PasswordHash: {user.PasswordHash}");
                sb.AppendLine("---------------------------");
            }

            sb.AppendLine("\n=== ROLES EXISTENTES ===");
            sb.AppendLine(GetRolesInfo());

            return sb.ToString();
        }

        // Verifica si existe un Supervisor
        public bool ExisteSupervisor()
        {
            return _context.Usuarios
                           .Include(u => u.Rol)
                           .Any(u => u.Rol.Id == 2);//2-SUPERVISOR
        }
        public void CrearUsuarioSupervisor(Persona persona, string password, int rolId)
        {
            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    // Guardar la persona
                    _context.Personas.Add(persona);
                    _context.SaveChanges();

                    // Hashear la contraseña
                    string passwordHash = PasswordHasher.HashPassword(password);

                    // Crear el usuario
                    var usuario = new Usuario
                    {
                        Id = persona.Id,
                        RolId = rolId,
                        PasswordHash = passwordHash,
                        Activo = true,
                        FechaCreacion = DateTime.Now
                    };

                    _context.Usuarios.Add(usuario);
                    _context.SaveChanges();

                    transaction.Commit();
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }
        // Crear un usuario nuevo
       // public void CrearUsuario(Usuario usuario)
        //7{
           // _context.Usuarios.Add(usuario);
            //_context.SaveChanges();
        //}

        // Validar login
        // En RepositorioUsuarios, cambia el método:
        public Usuario ValidarLogin(string credencial, string password)
        {
            // Buscar por EMAIL o NOMBRE
            var usuario = _context.Usuarios
                               .Include(u => u.IdNavigation)
                               .Include(u => u.Rol)
                               .FirstOrDefault(u => (u.IdNavigation.Email == credencial ||
                                                   u.IdNavigation.Nombre == credencial)
                                                 && u.Activo == true);

            if (usuario == null)
                return null;

            if (PasswordHasher.VerifyPassword(password, usuario.PasswordHash))
            {
                return usuario;
            }

            return null;
        }
    }
}
