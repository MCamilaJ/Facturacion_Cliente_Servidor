using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Linq.Expressions;

namespace Facturacion_Cliente_Servidor.Datos
{
    internal class ClientesDAO
    {
        private readonly ConexionBD conexion;

        public ClientesDAO()
        {
            conexion = new ConexionBD();
        }

        public DataTable CargarClientes()
        {
            try
            {
                using (SqlConnection conex = conexion.ObtenerConexion())
                {
                    conex.Open();
                    string sql = "SELECT NumDocumento, StrNombre, StrEmail, StrTelefono, StrDireccion FROM TBLCLIENTES";

                    using (SqlCommand cmd = new SqlCommand(sql, conex))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            return dataTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos" + ex.Message);
                return null;
            }
        }

        public DataTable BuscarCliente(string terminoBusqueda)
        {
            try
            {
                using (SqlConnection conex = conexion.ObtenerConexion())
                {
                    conex.Open();
                    string query = "SELECT NumDocumento, StrNombre, StrEmail, StrTelefono, StrDireccion FROM TBLCLIENTES " +
                                  "WHERE StrNombre LIKE @terminoBusqueda OR " +
                                  "StrEmail LIKE @terminoBusqueda OR " +
                                  "StrTelefono LIKE @terminoBusqueda OR " +
                                  "StrDireccion LIKE @terminoBusqueda";
                    using (SqlCommand cmd = new SqlCommand(query, conex))
                    {
                        cmd.Parameters.AddWithValue("@terminoBusqueda", "%" + terminoBusqueda + "%");
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            return dataTable;
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar el cliente" + ex.Message);
                return null;
            }
        }

        public int NuevoCliente(string numDocumento, string nombre, string email, string telefono, string direccion)
        {
            try
            {
                using (SqlConnection conex = conexion.ObtenerConexion())
                {
                    conex.Open();
                    string query = "INSERT INTO TBLCLIENTES (NumDocumento, StrNombre, StrEmail, StrTelefono, StrDireccion) VALUES (@NumDocumento, @Name, @Email, @Telefono, @Direccion)"; // Query SQL para insertar

                    using (SqlCommand cmd = new SqlCommand(query, conex))
                    {
                        cmd.Parameters.AddWithValue("@NumDocumento", numDocumento);
                        cmd.Parameters.AddWithValue("@Name", nombre);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Telefono", telefono);
                        cmd.Parameters.AddWithValue("@Direccion", direccion);
                        int rowsAffected = cmd.ExecuteNonQuery(); // Ejecutar la consulta

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Registro agregado correctamente.");                            
                        }
                        else
                        {
                            MessageBox.Show("Error al agregar el registro.");
                        }

                        return 1;

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el registro: " + ex.Message);
                return 0;
            }
        }
    }
}
