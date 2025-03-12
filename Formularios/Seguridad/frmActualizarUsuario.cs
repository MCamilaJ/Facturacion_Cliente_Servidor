using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Facturacion_Cliente_Servidor.Datos.UsuarioDAO;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Facturacion_Cliente_Servidor.Formularios.Seguridad
{
    public partial class frmActualizarUsurio: Form
    {
        public frmActualizarUsurio()
        {
            InitializeComponent();
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }


        private void btnActualizar_Click(object sender, EventArgs e)
        {
            SeguridadDatos datos = new SeguridadDatos();

            int idSeguridad = Convert.ToInt32(txtIdSeguridad.Text);
            int idEmpleado = Convert.ToInt32(txtIdEmpleado.Text);
            string usuario = txtUsuario.Text;
            string clave = txtClave.Text;

            bool resultado = datos.ActualizarUsuario(idSeguridad, idEmpleado, usuario, clave);

            if (resultado)
            {
                MessageBox.Show("Usuario actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al actualizar usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmUsuario frmUsuarioNuevo = new frmUsuario ();
            frmUsuarioNuevo.ShowDialog();
        }

        private void materialSingleLineTextField1_Click(object sender, EventArgs e)
        {

        }
    }
}
