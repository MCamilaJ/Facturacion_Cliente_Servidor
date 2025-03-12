using Facturacion_Cliente_Servidor.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facturacion_Cliente_Servidor.Formularios
{
    public partial class frmLogin : Form
    {
        private UsuarioDAO usuarioDAO;

        public frmLogin()
        {
            InitializeComponent();
            usuarioDAO = new UsuarioDAO();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contrasena = txtContrasena.Text;

            if (usuarioDAO.ValidarUsuario(usuario, contrasena))
            {
                MessageBox.Show("Ingreso Exitoso", "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
