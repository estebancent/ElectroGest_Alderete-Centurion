using ElectroGest.Datas;
using ElectroGest.Forms;

namespace ElectroGest
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Verificar si existe supervisor
            var repo = new RepositoriosUsuarios();

            if (!repo.ExisteSupervisor())
            {
                // Mostrar formulario para crear supervisor
                var formCrearSupervisor = new FormCrearSupervisor();
                if (formCrearSupervisor.ShowDialog() != DialogResult.OK)
                {
                    return; // Salir si no se creó el supervisor
                }
            }

            // Mostrar login normal
       
           
            bool sesionActiva = true;

            while (sesionActiva)
            {
                using (var login = new FormLogin())
                {
                    if (login.ShowDialog() == DialogResult.OK)
                    {
                        // Login exitoso, abrir dashboard
                        using (var dashboard = new Dashboard(login.UsuarioAutenticado))
                        {
                            Application.Run(dashboard);

                            // Si se cerró sesión, volver al login
                            if (dashboard.CerrandoSesion)
                            {
                                continue; // Volver al while
                            }
                            else
                            {
                                sesionActiva = false; // Salir completamente
                            }
                        }
                    }
                    else
                    {
                        sesionActiva = false; // Usuario canceló login
                    }
                }
            }
        }
    }
}
