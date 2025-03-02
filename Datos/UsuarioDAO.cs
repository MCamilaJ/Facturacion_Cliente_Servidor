using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Facturacion_Cliente_Servidor.Datos
{
    internal class UsuarioDAO
    {
        private readonly ConexionBD conexion;

        public UsuarioDAO()
        {
            conexion = new ConexionBD();
        }

        public bool ValidarUsuario(string usuario, string contrasena)
        {
            bool valido = false;
            string sql = "SELECT COUNT(*) FROM TBLSEGURIDAD WHERE StrUsuario = @usuario AND StrClave = @contrasena";

            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    cmd.Parameters.AddWithValue("@contrasena", contrasena);

                    int count = (int)cmd.ExecuteScalar();
                    valido = count > 0;
                }
            }
            return valido;
        }
    }
}
