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
        public class SeguridadDatos
        {
            public bool ActualizarNuevoUsuario(int idSeguridad, int idEmpleado, string usuario, string clave, DateTime fechaModificacion, string usuarioModifico)
            {
                bool actualizado = false;
                string sql = @"UPDATE TBLSEGURIDAD 
                           SET IdEmpleado = @IdEmpleado, 
                               StrUsuario = @Usuario, 
                               StrClave = @Clave, 
                               DtmFechaModifica = @FechaModificacion, 
                               StrUsuarioModifico = @UsuarioModifico 
                           WHERE IdSeguridad = @IdSeguridad";

                using (SqlConnection conn = new ConexionBD().ObtenerConexion())
                {
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@IdSeguridad", idSeguridad);
                        cmd.Parameters.AddWithValue("@IdEmpleado", idEmpleado);
                        cmd.Parameters.AddWithValue("@Usuario", usuario);
                        cmd.Parameters.AddWithValue("@Clave", clave);
                        cmd.Parameters.AddWithValue("@FechaModificacion", fechaModificacion);
                        cmd.Parameters.AddWithValue("@UsuarioModifico", usuarioModifico);

                        actualizado = cmd.ExecuteNonQuery() > 0;
                    }
                }
                return actualizado;
            }

            public bool ActualizarUsuario(int idSeguridad, int idEmpleado, string usuario, string clave)
            {
                bool actualizado = false;
                string sql = @"UPDATE TBLSEGURIDAD 
                           SET IdEmpleado = @IdEmpleado, 
                               StrUsuario = @Usuario, 
                               StrClave = @Clave
                           WHERE IdSeguridad = @IdSeguridad";

                using (SqlConnection conn = new ConexionBD().ObtenerConexion())
                {
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@IdSeguridad", idSeguridad);
                        cmd.Parameters.AddWithValue("@IdEmpleado", idEmpleado);
                        cmd.Parameters.AddWithValue("@Usuario", usuario);
                        cmd.Parameters.AddWithValue("@Clave", clave);

                        actualizado = cmd.ExecuteNonQuery() > 0;
                    }
                }
                return actualizado;
            }
        }
    }
}