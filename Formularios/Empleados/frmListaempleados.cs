using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;


using System.Data.SqlClient;

using Facturacion_Cliente_Servidor.Datos;

namespace Facturacion_Cliente_Servidor.Formularios.Empleados
{
    public partial class frmListaempleados : MaterialForm
    {
        private ConexionBD conexion = new ConexionBD();
        private int idEmpleado;

        public frmListaempleados(int id, string nombre, string correo, string telefono, string direccion)
        {
            InitializeComponent();
            idEmpleado = id;
            txtNombreEmpleado.Text = nombre;
            txtEmail.Text = correo;
            txtTelefono.Text = telefono;
            txtDireccion.Text = direccion;
        }

        private void frmListaempleados_Load(object sender, EventArgs e)
        {
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = conexion.ObtenerConexion())
                {
                    con.Open();
                    string query = "UPDATE Empleados SET nombre=@nombre, correo=@correo, telefono=@telefono, direccion=@direccion WHERE id_empleado=@id";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@nombre", txtNombreEmpleado.Text);
                    cmd.Parameters.AddWithValue("@correo", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@telefono", txtTelefono.Text);
                    cmd.Parameters.AddWithValue("@direccion", txtDireccion.Text);
                    cmd.Parameters.AddWithValue("@id", idEmpleado);

                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Empleado actualizado correctamente.");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo actualizar el empleado.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar empleado: " + ex.Message);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
