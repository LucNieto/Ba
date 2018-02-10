
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroFormDB.DAOMySQL.ConnectionMySQL {
    public class ConexionMySQL {
        public static MySqlConnection ObtenerConexion() {
            string strConexion = "server= 127.0.0.1; database=northwind; Uid=root; pwd=3.14159265358979; ";
            MySqlConnection conectar = new MySqlConnection(strConexion);
            conectar.Open();
            return conectar;
        }

    }
}
