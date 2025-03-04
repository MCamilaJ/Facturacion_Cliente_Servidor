using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace Facturacion_Cliente_Servidor.Datos
{
    public class ConexionBD
    {
        private readonly string cadenaConexion;

        public ConexionBD()
        {
            //Leer la cadena de conexion
            cadenaConexion = ConfigurationManager.ConnectionStrings["ConexionFacturacion"].ConnectionString;
        }

        //Metodo para obtener la conexion
        public SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadenaConexion);
        }
    }
}
