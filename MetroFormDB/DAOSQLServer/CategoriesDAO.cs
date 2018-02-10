using MetroFormDB.DAOSQLServer.ConnectionSQLServer;
using MetroFormDB.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroFormDB.DAOSQLServer {
    public class CategoriesDAO {
        public bool Create(Categories categoria) {
            bool result = false;
            try {
                string sql =
                    string.Format("INSERT INTO Categories (CategoryName,Description) VALUES ('{0}','{1}')",
                    categoria.CategoryName, categoria.Description);
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



        public List<Categories> RetrieveAll() {
            List<Categories> categorias = new List<Categories>();
            try {
                string sql = "SELECT CategoryID,CategoryName,Description FROM Categories";
                SqlConnection conexion = ConexionSqlServer.ObtenerConexion();
                SqlCommand cmd = new SqlCommand(sql, conexion);
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read()) {
                    Categories categoria = new Categories() {
                        CategoryID = rd.GetInt32(0),
                        CategoryName = rd.GetString(1),
                        Description = rd.GetString(2)
                    };
                    categorias.Add(categoria);
                }
                conexion.Close();
                return categorias;
            } catch {
                throw;
            }
        }

        public bool Update(Categories categoria) {

            bool result = false;
            SqlConnection conexion = null;
            try {
                string sql = string.Format(
                "UPDATE Categories SET CategoryName ='{0}',Description ='{1}'  WHERE categoryid={2}", categoria.CategoryName, categoria.Description, categoria.CategoryID);
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

        public bool Delete(int CategoryID) {

            bool result = false;
            SqlConnection conexion = null;
            try {
                string sql = string.Format(
                "DELETE FROM categories WHERE categoryid={0}", CategoryID);
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
