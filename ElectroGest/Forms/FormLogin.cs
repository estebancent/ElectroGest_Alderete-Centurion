using ElectroGest.Datas;
using ElectroGest.Models;
using ElectroGest.Utils;
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

    public partial class FormLogin : Form
    {
        public Usuario UsuarioAutenticado { get; private set; }
        private readonly RepositoriosUsuarios _repoUsuarios;


        public FormLogin()
        {
            InitializeComponent();
            _repoUsuarios = new RepositoriosUsuarios();

        }


        private void FormLogin_Load(object sender, EventArgs e)
        {
            timerError.Interval = 5000; // 5 segundos (5000 ms)
            pnlError.Visible = false;
            //string debugInfo = _repoUsuarios.GetDebugInfo();
          //  MessageBox.Show(debugInfo, "Debug - Usuarios en BD",
            //               MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void TextBoxes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                e.SuppressKeyPress = true; // evita que se escriba el espacio en el textbox
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void TimerError_Tick(object sender, EventArgs e)
        {
            pnlError.Visible = false;
            timerError.Stop(); // detener el timer
        }

        private void MostrarError(string mensaje)
        {

            lblError.Text = mensaje;
            pnlError.Visible = true;

            timerError.Stop(); // reinicia 
            timerError.Start();
        }
        private void btnCerrarError_Click(object sender, EventArgs e)
        {
            pnlError.Visible = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuarioIngresado = txtUsuario.Text.Trim();
            string passwordIngresada = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(usuarioIngresado) || string.IsNullOrEmpty(passwordIngresada))
            {
                MessageBox.Show("Debe ingresar usuario y contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var usuario = _repoUsuarios.ValidarLogin(usuarioIngresado, passwordIngresada);

            if (usuario != null)
            {
                MessageBox.Show($"Bienvenido {usuario.IdNavigation.Nombre} - Rol: {usuario.Rol.Nombre}", "Login Exitoso");

                Sesion.UsuarioActual = usuario;
                UsuarioAutenticado = usuario;
                this.DialogResult = DialogResult.OK; // ← Importante
                this.Close();
            }
            else
            {
               
                MostrarError("* Usuario o contraseña incorrectos.");
                return;
              //  MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnVisible_Click(object sender, EventArgs e)
        {
            if (txtPassword.UseSystemPasswordChar)
            {
                // Mostrar la contraseña
                txtPassword.UseSystemPasswordChar = false;
                btnVisible.Image = Properties.Resources.icons8_visible_24; // cambia a "visible"
            }
            else
            {
                // Ocultar la contraseña
                txtPassword.UseSystemPasswordChar = true;
                btnVisible.Image = Properties.Resources.icons8_invisible_24; // cambia a "oculto"
            }
        }

    }
}

