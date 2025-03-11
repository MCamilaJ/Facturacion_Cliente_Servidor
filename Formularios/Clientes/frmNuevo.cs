using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Facturacion_Cliente_Servidor.Datos;
using MaterialSkin.Controls;

namespace Facturacion_Cliente_Servidor.Formularios.Clientes
{
    public partial class frmNuevo : MaterialForm
    {
        private Datos.ClientesDAO clientesDAO = new Datos.ClientesDAO();
        private Formularios.Clientes.frmClientes frmClientes;


        public frmNuevo(Formularios.Clientes.frmClientes frmClientes)
        {
            InitializeComponent();
            this.frmClientes = frmClientes;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            string numDocumento = txtDocumento.Text;
            string nombre = txtNombreCliente.Text;
            string email = txtEmail.Text;
            string telefono = txtTelefono.Text;
            string direccion = txtDireccion.Text;

            int resultado = clientesDAO.NuevoCliente(numDocumento, nombre, email, telefono, direccion);

            if (resultado > 0)
            {
                LimpiarCampos(); // Limpiar los campos después de guardar
                clientesDAO.CargarClientes(); // Actualizar el DataGridView en el formulario principal

            }
        }

        private void LimpiarCampos() // Metodo para limpiar los campos
        {
            txtDocumento.Text = string.Empty;
            txtNombreCliente.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtDireccion.Text = string.Empty;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            frmClientes.llenarDataGrid();
            this.Close();
        }
    }
}
