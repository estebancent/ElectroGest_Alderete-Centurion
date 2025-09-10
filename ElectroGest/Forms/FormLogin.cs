using ElectroGest.Datas;
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
         
            string debugInfo = _repoUsuarios.GetDebugInfo();
            MessageBox.Show(debugInfo, "Debug - Usuarios en BD",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
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

           
                UsuarioAutenticado = usuario;
                this.DialogResult = DialogResult.OK; // ← Importante
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

