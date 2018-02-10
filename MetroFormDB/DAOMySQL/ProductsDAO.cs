using MetroFormDB.DAOMySQL.ConnectionMySQL;
using MetroFormDB.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroFormDB.DAOMySQL {
    public class ProductsDAO {
        public List<ProductsCategorySupplier> RetrieveAll() {
            List<ProductsCategorySupplier> productos = new List<ProductsCategorySupplier>();
            try {
                string sql = "SELECT P.ProductID, P.ProductName, P.QuantityPerUnit, P.UnitPrice, P.CategoryID, P.SupplierID, P.UnitsInStock, P.UnitsOnOrder, P.ReorderLevel, P.Discontinued, C.CategoryName, S.CompanyName FROM Products as P";
                sql += " INNER JOIN Categories as C  ON P.CategoryID = C.CategoryID INNER JOIN Suppliers as S ON P.SupplierID = S.SupplierID ";
                MySqlConnection conexion = ConexionMySQL.ObtenerConexion();
                MySqlCommand cmd = new MySqlCommand(sql, conexion);
                MySqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read()) {
                    ProductsCategorySupplier producto = new ProductsCategorySupplier() {
                        ProductID = rd.GetInt32(0),
                        ProductName = rd.GetString(1),
                        QuantityPerUnit = rd.GetString(2),
                        UnitPrice = rd.GetDecimal(3),
                        CategoryID = rd.GetInt32(4),
                        SupplierID = rd.GetInt32(5),
                        UnitsInStock = rd.GetInt16(6),
                        UnitsOnOrder = rd.GetInt16(7),
                        ReorderLevel = rd.GetInt16(8),
                        Discontinued = rd.GetBoolean(9),
                        CategoryName = rd.GetString(10),
                        CompanyName = rd.GetString(11)
                    };
                    productos.Add(producto);
                }
                conexion.Close();
                return productos;
            } catch {
                throw;
            }
        }


        public bool Create(Products producto) {
            bool result = false;
            try {
                string sql =
                    string.Format("INSERT INTO Products (ProductName, SupplierID, CategoryID, QuantityPerUnit, UnitPrice, UnitsInStock, UnitsOnOrder, ReorderLevel, Discontinued) VALUES ('{0}','{1}','{2}','{3}', '{4}','{5}','{6}','{7}','{8}')",
                    producto.ProductName, producto.SupplierID, producto.CategoryID, producto.QuantityPerUnit, producto.UnitPrice, producto.UnitsInStock, producto.UnitsOnOrder, producto.ReorderLevel, producto.Discontinued);
                MySqlConnection conexion = ConexionMySQL.ObtenerConexion(); MySqlCommand cmd = new MySqlCommand(sql, conexion);
                int resultquery = cmd.ExecuteNonQuery();
                if (resultquery == 1) {
                    result = true;
                }
            } catch {
                throw;
            }
            return result;
        }

        public bool Update(Products producto) {

            bool result = false;
            MySqlConnection conexion = null;
            try {
                string sql = string.Format(
                "UPDATE Products SET ProductName ='{0}', SupplierID ='{1}', CategoryID ='{2}', QuantityPerUnit ='{3}', UnitPrice ='{4}', UnitsInStock ='{5}', UnitsOnOrder ='{6}', ReorderLevel ='{7}', Discontinued ='{8}' WHERE productid={9}",
                            producto.ProductName, producto.SupplierID, producto.CategoryID, producto.QuantityPerUnit, producto.UnitPrice, producto.UnitsInStock, producto.UnitsOnOrder, producto.ReorderLevel, producto.Discontinued, producto.ProductID);
                conexion = ConexionMySQL.ObtenerConexion();
                MySqlCommand cmd = new MySqlCommand(sql, conexion);
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

        public bool Delete(int ProductID) {

            bool result = false;
            MySqlConnection conexion = null;
            try {
                string sql = string.Format(
                "DELETE FROM Products WHERE ProductID={0}", ProductID);
                conexion = ConexionMySQL.ObtenerConexion();
                MySqlCommand cmd = new MySqlCommand(sql, conexion);
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
