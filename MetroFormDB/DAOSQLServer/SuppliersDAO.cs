using MetroFormDB.DAOSQLServer.ConnectionSQLServer;
using MetroFormDB.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroFormDB.DAOSQLServer {
    public class SuppliersDAO {
        public bool Create(Suppliers proveedor) {
            bool result = false;
            try {
                string sql =
                    string.Format("INSERT INTO Suppliers (CompanyName,ContactName,ContactTitle,Address,City,PostalCode,Country,Phone) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')",
                    proveedor.CompanyName, proveedor.ContactName, proveedor.ContactTitle, proveedor.Address, proveedor.City, proveedor.PostalCode, proveedor.Country, proveedor.Phone);
                SqlConnection conexion = ConexionSqlServer.ObtenerConexion();
                SqlCommand cmd = new SqlCommand(sql, conexion);
                int resultquery = cmd.ExecuteNonQuery();
                if (resultquery == 1) {
                    result = true;
                }
            } catch {
                throw;
            }
            return result;
        }

        public List<Suppliers> RetrieveAll() {
            List<Suppliers> proveedores = new List<Suppliers>();
            try {
                string sql = "SELECT SupplierID,CompanyName,ContactName,ContactTitle,Address,City,PostalCode,Country,Phone FROM Suppliers";
                SqlConnection conexion = ConexionSqlServer.ObtenerConexion();
                SqlCommand cmd = new SqlCommand(sql, conexion);
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read()) {
                    Suppliers proveedor = new Suppliers() {
                        SupplierID = rd.GetInt32(0),
                        CompanyName = rd.GetString(1),
                        ContactName = rd.GetString(2),
                        ContactTitle = rd.GetString(3),
                        Address = rd.GetString(4),
                        City = rd.GetString(5),
                        //Region = rd.GetString(6),
                        PostalCode = rd.GetString(6),
                        Country = rd.GetString(7),
                        Phone = rd.GetString(8)
                        //Fax = rd.GetString(9)
                    };
                    proveedores.Add(proveedor);
                }
                conexion.Close();
                return proveedores;
            } catch {
                throw;
            }
        }

        public bool Update(Suppliers proveedor) {

            bool result = false;
            SqlConnection conexion = null;
            try {
                string sql = string.Format(
                "UPDATE Suppliers SET CompanyName ='{0}',ContactName ='{1}',ContactTitle ='{2}',Address ='{3}',City ='{4}',PostalCode ='{5}',Country ='{6}',Phone ='{7}'  WHERE SupplierID = {8}",
                proveedor.CompanyName, proveedor.ContactName, proveedor.ContactTitle, proveedor.Address, proveedor.City, proveedor.PostalCode, proveedor.Country, proveedor.Phone, proveedor.SupplierID);
                conexion = ConexionSqlServer.ObtenerConexion();
                SqlCommand cmd = new SqlCommand(sql, conexion);
                int resultquery = cmd.ExecuteNonQuery();
                if (resultquery == 1) {
                    result = true;
                }
            } catch {
                throw;
            } finally {
                if (conexion != null)
                    conexion.Close();
            }

            return result;

        }

        public bool Delete(int SupplierID) {

            bool result = false;
            SqlConnection conexion = null;
            try {
                string sql = string.Format(
                "DELETE FROM Suppliers WHERE SupplierID={0}", SupplierID);
                conexion = ConexionSqlServer.ObtenerConexion();
                SqlCommand cmd = new SqlCommand(sql, conexion);
                int resultquery = cmd.ExecuteNonQuery();
                if (resultquery == 1) {
                    result = true;
                }
            } catch {
                throw;
            } finally {
                if (conexion != null)
                    conexion.Close();
            }

            return result;

        }
    }
}
