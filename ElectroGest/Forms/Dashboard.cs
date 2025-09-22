using ElectroGest.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectroGest.Forms
{
    public partial class Dashboard : Form
    {
        // Declara la variable de clase aquí
        private Usuario _usuario;
        public bool CerrandoSesion { get; private set; } = false;
        private Form formularioActivo = null;

        public Dashboard(Usuario usuario)
        {
            InitializeComponent();

            _usuario = usuario;
            welcomeuser.Text = $"En linea: {_usuario.IdNavigation.Nombre}";
            userrol.Text = $"({_usuario.Rol.Nombre})";
        }
        private void VerificarPanel()
        {
            MessageBox.Show($"Panel contenedor:\n" +
                           $"Size: {panelPrimario.Size}\n" +
                           $"Visible: {panelPrimario.Visible}\n" +
                           $"Dock: {panelPrimario.Dock}\n" +
                           $"Controls count: {panelPrimario.Controls.Count}",
                           "Debug Panel");
        }

        //  Load del Dashboard
        private void Dashboard_Load(object sender, EventArgs e)
        {
            //VerificarPanel();  //Temporal debug
            btnInicio.PerformClick();
            // Ocultar todos los botones primero
            OcultarTodosBotones();

            // Mostrar botones según el rol
            switch (_usuario.Rol.Nombre)
            {
                case "Supervisor":
                    btnReportes.Visible = true;
                    btnUsuarios.Visible = true;
                    btnBackup.Visible = true;
                    btnProveedor.Enabled = false;
                    btnClientes.Enabled = false;
                    btnInicio.Visible = true;
                    btnProductos.Enabled = false;
                    btnVentas.Enabled = false;
                    break;
                case "Administrador":
                    btnReportes.Enabled = true;
                    btnUsuarios.Enabled = false;
                    btnBackup.Enabled = false;
                    btnProveedor.Enabled = true;
                    btnClientes.Enabled = true;
                    btnInicio.Visible = true;
                    btnProductos.Enabled = true;
                    btnVentas.Enabled = true;

                    break;
                case "Vendedor":
                    btnReportes.Enabled = false;
                    btnUsuarios.Enabled = false;
                    btnBackup.Enabled = false;
                    btnProveedor.Enabled = true;
                    btnClientes.Enabled = true;
                    btnInicio.Visible = true;
                    btnProductos.Enabled = true;
                    btnVentas.Enabled = true;

                    break;
            }
        }


        private void OcultarTodosBotones()
        {
            // btnReportes.Visible = false;
            // btnUsuarios.Visible = false;
            //btnBackup.Visible = false;

            // ... ocultar todos los botones
        }
        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            CerrarSesion();
        }
        private void CerrarSesion()
        {
            DialogResult result = MessageBox.Show("¿Está seguro que desea cerrar sesión?",
                                                "Cerrar Sesión",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                CerrandoSesion = true;
                this.Close(); // Cierra el dashboard
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (!CerrandoSesion && e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true; // Cancelar temporalmente el cierre

                MostrarOpcionesCierre();
            }

            base.OnFormClosing(e);
        }

        private void MostrarOpcionesCierre()
        {
            // Pregunta si quiere salir de la aplicación
            DialogResult resultado = MessageBox.Show(
                "¿Desea salir de la aplicación?",
                "Cerrar aplicación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
            // Si es No, no hace nada y se queda en la app
        }

        private void AbrirFormulario(Form formHijo)
        {
            // Cerrar formulario activo si existe
            if (formularioActivo != null)
            {
                formularioActivo.Close();
                formularioActivo.Dispose();
            }

            formularioActivo = formHijo;
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;

            // Limpiar controles existentes antes de agregar nuevo
            panelPrimario.Controls.Clear();
            panelPrimario.Controls.Add(formHijo);

            formHijo.BringToFront();
            formHijo.Show();
        }


        private void ResaltarBoton(Button botonActivo)
        {
            foreach (Control control in panelSidebar.Controls)
            {
                if (control is Button btn)
                {

                    btn.ForeColor = Color.Gainsboro;
                }
            }

            botonActivo.ForeColor = Color.White;
        }
        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new GestionUsuarios());
            ResaltarBoton(btnUsuarios);
        }
        private void btnProductos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new GestionProductos());
            ResaltarBoton(btnProductos);
        }
        private void btnInicio_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new PanelForm());
            ResaltarBoton(btnInicio);
        }
        private void btnReportes_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new ReportesForm());
            ResaltarBoton(btnReportes);
        }
        private void btnClientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new GestionClientes());
            ResaltarBoton(btnClientes);
        }
        private void btnVentas_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new VentasForm());
            ResaltarBoton(btnVentas);
        }
        private void btnBackup_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new BackupForm());
            ResaltarBoton(btnBackup);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new ProveedoresForm());
            ResaltarBoton(btnProveedor);
        }
    }
}
