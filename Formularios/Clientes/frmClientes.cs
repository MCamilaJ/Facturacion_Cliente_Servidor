using Facturacion_Cliente_Servidor.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facturacion_Cliente_Servidor.Formularios.Clientes
{
    public partial class frmClientes : Form
    {
        private Datos.ClientesDAO clientesDAO = new Datos.ClientesDAO();

        public frmClientes()
        {
            InitializeComponent();
            llenarDataGrid();
        }

        public void llenarDataGrid() // Metodo para llenar el DataGridView
        {
            DataTable dataTable = clientesDAO.CargarClientes();
            dgClientes.DataSource = dataTable;
            dgClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgClientes.AutoGenerateColumns = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e) // Metodo para buscar un cliente
        {
            string terminoBusqueda = txtBuscar.Text.Trim();
            if (string.IsNullOrEmpty(terminoBusqueda))
            {
                MessageBox.Show("Por favor, ingrese un parametro de búsqueda.");
                return;
            }
            DataTable dataTable = clientesDAO.BuscarCliente(terminoBusqueda);
            dgClientes.DataSource = dataTable;
            dgClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgClientes.AutoGenerateColumns = false;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmNuevo clienteNuevo = new frmNuevo(this);
            clienteNuevo.ShowDialog();
        }

        private void dgClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }       

        private void frmClientes_Load(object sender, EventArgs e)
        {


        }

        private void txtBuscar_Click(object sender, EventArgs e)
        {

        }

        }        

    }
}
