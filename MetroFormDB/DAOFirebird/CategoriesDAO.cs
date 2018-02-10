using FirebirdSql.Data.FirebirdClient;
using MetroFormDB.DAOFirebird.ConnectionFirebird;
using MetroFormDB.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroFormDB.DAOFirebird {
    public class CategoriesDAO {
        public bool Create(Categories categoria) {
            bool result = false;
            try {
                string sql =
                    string.Format("INSERT INTO Categories (CategoryName,Description) VALUES ('{0}','{1}')",
                    categoria.CategoryName, categoria.Description);
                FbConnection conexion = conexionFirebird.ObtenerConexion();
                FbCommand cmd = new FbCommand(sql, conexion);
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
                FbConnection conexion = conexionFirebird.ObtenerConexion();
                FbCommand cmd = new FbCommand(sql, conexion);
                FbDataReader rd = cmd.ExecuteReader();
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
            FbConnection conexion = null;
            try {
                string sql = string.Format(
                "UPDATE Categories SET CategoryName ='{0}',Description ='{1}'  WHERE categoryid={2}", categoria.CategoryName, categoria.Description, categoria.CategoryID);
                conexion = conexionFirebird.ObtenerConexion();
                FbCommand cmd = new FbCommand(sql, conexion);
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
            FbConnection conexion = null;
            try {
                string sql = string.Format(
                "DELETE FROM categories WHERE categoryid={0}", CategoryID);
                conexion = conexionFirebird.ObtenerConexion();
                FbCommand cmd = new FbCommand(sql, conexion);
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

        public Categories RetrieveByIdlWithProducts(int id) {
            Categories categoria = new Categories();
            try {
                string sql = "SELECT CategoryID,CategoryName,Description FROM Categories";
                FbConnection conexion = conexionFirebird.ObtenerConexion();
                FbCommand cmd = new FbCommand(sql, conexion);
                FbDataReader rd = cmd.ExecuteReader();
                if (rd.Read()) {
                    categoria = new Categories();
                    categoria.CategoryID = rd.GetInt32(0);
                    categoria.CategoryName = rd.GetString(1);
                    categoria.Description = rd.GetString(2);
                    ProductsDAO pDAO = new ProductsDAO();
                }
                conexion.Close();
                return categoria;
            } catch {
                throw;
            }
        }
    }
}
