using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroFormDB.DAOFirebird.ConnectionFirebird {
    public static class conexionFirebird {
        public static FbConnection ObtenerConexion() {

            FbConnectionStringBuilder cs = new FbConnectionStringBuilder();

            cs.UserID = "SYSDBA";
            cs.Password = "masterkey";
            cs.Database = "northwind";
            FbConnection conexion = new FbConnection(cs.ToString());
            return conexion;
        }

    }
}
