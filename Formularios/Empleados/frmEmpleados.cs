using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using System.Data.SqlClient;

using Facturacion_Cliente_Servidor.Datos;

namespace Facturacion_Cliente_Servidor.Formularios.Empleados
{
    public partial class frmEmpleados : Form
    {
        private ConexionBD conexion = new ConexionBD();

        public frmEmpleados()
        {
            InitializeComponent();
        }

        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            CargarEmpleados();
        }

        private void CargarEmpleados()
        {
            try
            {
                using (SqlConnection con = conexion.ObtenerConexion())
                {
                    con.Open();
                    string query = "SELECT IdEmpleado, strNombre, StrEmail, StrTelefono, StrDireccion FROM TBLEMPLEADO;";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgEmpleados.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar empleados: " + ex.Message);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (dgEmpleados.SelectedRows.Count > 0)
            {
                // Obtener la celda del ID
                object cellValue = dgEmpleados.SelectedRows[0].Cells["IdEmpleado"].Value;

                // Validar si el valor es nulo o vacío
                if (cellValue == null || string.IsNullOrEmpty(cellValue.ToString()))
                {
                    MessageBox.Show("El ID del empleado es nulo o vacío.");
                    return;
                }

                // Intentar convertir el ID a entero
                int idEmpleado;
                if (!int.TryParse(cellValue.ToString(), out idEmpleado))
                {
                    MessageBox.Show("Error al convertir el ID del empleado.");
                    return;
                }

                // Obtener otros valores
                string nombre = dgEmpleados.SelectedRows[0].Cells["strNombre"].Value.ToString();
                string correo = dgEmpleados.SelectedRows[0].Cells["StrEmail"].Value.ToString();
                string telefono = dgEmpleados.SelectedRows[0].Cells["StrTelefono"].Value.ToString();
                string direccion = dgEmpleados.SelectedRows[0].Cells["StrDireccion"].Value.ToString();

                // ventana con los datos obtenidos
                frmListaempleados frmEmpleadosActualizar = new frmListaempleados(idEmpleado, nombre, correo, telefono, direccion);
                frmEmpleadosActualizar.ShowDialog();

                // Recargar datos
                CargarEmpleados();
            }
            else
            {
                MessageBox.Show("Seleccione un empleado para actualizar.");
            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }


}

