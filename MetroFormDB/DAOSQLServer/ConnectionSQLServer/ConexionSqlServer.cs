using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroFormDB.DAOSQLServer.ConnectionSQLServer {
    public static class ConexionSqlServer {
        public static SqlConnection ObtenerConexion() {
            string strConexion = "Data Source =.; Initial Catalog=Northwind; Integrated Security=True ";
            SqlConnection conectar = new SqlConnection(strConexion);
            conectar.Open();
            return conectar;
        }
    }
}
