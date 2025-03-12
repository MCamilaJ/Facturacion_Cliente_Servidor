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
    public partial class frmUsuario: Form
    {
        public frmUsuario()
        {
            InitializeComponent();
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDatosAdicionales_Click(object sender, EventArgs e)
        {

        }

        private void txtFRetiro_Click(object sender, EventArgs e)
        {

        }

        private void txtFIngreso_Click(object sender, EventArgs e)
        {

        }

        private void txtRol_Click(object sender, EventArgs e)
        {

        }

        private void dateTimeF_Retiro_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimeF_Ingreso_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboRolEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtIdEmpleado_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            int idSeguridad = Convert.ToInt32(txtIdSeguridad.Text);
            int idEmpleado = Convert.ToInt32(txtIdEmpleado.Text);
            string usuario = txtUsuario.Text;
            string clave = txtClave.Text;
            DateTime fechaModificacion = DateTime.Now;
            string usuarioModifico = txtUsuarioModifico.Text;


            SeguridadDatos datos = new SeguridadDatos();
            bool resultado = datos.ActualizarNuevoUsuario(idSeguridad, idEmpleado, usuario, clave, fechaModificacion, usuarioModifico);

            if (resultado)
            {
                MessageBox.Show("Usuario actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al actualizar usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        

        private void txtEmail_Click(object sender, EventArgs e)
        {

        }

        private void txtTelefono_Click(object sender, EventArgs e)
        {

        }

        private void txtDireccion_Click(object sender, EventArgs e)
        {

        }

        private void txtDocumento_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_Click(object sender, EventArgs e)
        {

        }
    }
}
