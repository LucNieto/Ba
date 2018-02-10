using FirebirdSql.Data.FirebirdClient;
using MetroFormDB.DAOFirebird.ConnectionFirebird;
using MetroFormDB.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroFormDB.DAOFirebird {
    public class ProductsDAO {
        public static List<Categories> Get_Categories() {
            List<Categories> lista = new List<Categories>();

            try {

                string sql =
                    string.Format("SELECT CategoryID,CategoryName from Categories");
                FbConnection conexion = conexionFirebird.ObtenerConexion();
                FbCommand cmd = new FbCommand(sql, conexion);
                FbDataReader reader = cmd.ExecuteReader();


                while (reader.Read()) {
                    Categories categoria = new Categories();
                    categoria.CategoryID = reader.GetInt32(0);
                    categoria.CategoryName = reader.GetString(1);
                    lista.Add(categoria);
                }
            } catch {
                throw;
            }
            return lista;
        }

        public int Get_Products_cont() {
            int cont = 0;
            try {
                string sql =
                    string.Format("SELECT ProductID from Products");
                FbConnection conexion = conexionFirebird.ObtenerConexion();
                FbCommand cmd = new FbCommand(sql, conexion);
                FbDataReader reader = cmd.ExecuteReader();
                while (reader.Read()) {
                    cont++;
                }
            } catch {
                throw;
            }
            return cont;
        }


        public static int Get_Categories_cont() {
            int cont = 0;
            try {

                string sql =
                    string.Format("SELECT CategoryID from Categories");
                FbConnection conexion = conexionFirebird.ObtenerConexion();
                FbCommand cmd = new FbCommand(sql, conexion);
                FbDataReader reader = cmd.ExecuteReader();


                while (reader.Read()) {
                    cont++;

                }
            } catch {
                throw;
            }
            return cont;
        }


        public static List<Suppliers> Get_Suppliers() {
            List<Suppliers> lista = new List<Suppliers>();

            try {

                string sql =
                    string.Format("SELECT SupplierID,CompanyName from Suppliers");
                FbConnection conexion = conexionFirebird.ObtenerConexion();
                FbCommand cmd = new FbCommand(sql, conexion);
                FbDataReader reader = cmd.ExecuteReader();


                while (reader.Read()) {
                    Suppliers suppliers = new Suppliers();
                    suppliers.SupplierID = reader.GetInt32(0);
                    suppliers.CompanyName = reader.GetString(1);
                    lista.Add(suppliers);
                }
            } catch {
                throw;
            }
            return lista;
        }


        public bool Create(Products producto) {
            bool result = false;
            try {
                string sql =
                    string.Format("INSERT INTO Products (ProductName,SupplierID,CategoryID,QuantityPerUnit,UnitPrice,UnitsInStock,UnitsOnOrder,ReorderLevel) VALUES ('{0}',{1},{2},'{3}',{4},{5},{6},{7})",
                    producto.ProductName, producto.SupplierID, producto.CategoryID, producto.QuantityPerUnit,
                    producto.UnitPrice, producto.UnitsInStock, producto.UnitsOnOrder, producto.ReorderLevel);
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

        public bool Update(Products producto) {

            bool result = false;
            FbConnection conexion = null;
            try {
                string sql = string.Format(
                "UPDATE Products SET ProductName ='{0}',QuantityPerUnit ='{1}',UnitsInStock ={2} ,ReorderLevel ={3} ,UnitsOnOrder ={4},UnitPrice ={5},SupplierID ={6}, CategoryID={7} WHERE ProductID={8} ",
                producto.ProductName, producto.QuantityPerUnit, producto.UnitsInStock, producto.ReorderLevel, producto.UnitsOnOrder, producto.UnitPrice, producto.SupplierID, producto.CategoryID, producto.ProductID);



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
        public List<ProductsCategorySupplier> RetrieveAll() {
            List<ProductsCategorySupplier> productos = new List<ProductsCategorySupplier>();
            try {
                string sql = "SELECT P.ProductID, P.ProductName,P.QuantityPerUnit,P.UnitPrice,P.UnitsInStock,P.UnitsOnOrder,P.ReorderLevel,P.Discontinued ,C.CategoryName,S.CompanyName FROM Products as P";
                sql += " INNER JOIN Categories as C  ON P.CategoryID = C.CategoryID INNER JOIN Suppliers as S ON P.SupplierID = S.SupplierID ";

                FbConnection conexion = conexionFirebird.ObtenerConexion();
                FbCommand cmd = new FbCommand(sql, conexion);
                FbDataReader rd = cmd.ExecuteReader();
                while (rd.Read()) {
                    ProductsCategorySupplier producto = new ProductsCategorySupplier() {
                        ProductID = rd.GetInt32(0),
                        ProductName = rd.GetString(1),
                        QuantityPerUnit = rd.GetString(2),
                        UnitPrice = rd.GetDecimal(3),
                        UnitsInStock = rd.GetInt16(4),
                        UnitsOnOrder = rd.GetInt16(5),
                        ReorderLevel = rd.GetInt16(6),
                        // Discontinued = rd.GetBoolean(7),
                        CategoryName = rd.GetString(8),
                        CompanyName = rd.GetString(9)
                    };
                    productos.Add(producto);
                }
                conexion.Close();
                return productos;
            } catch {
                throw;
            }
        }

        public List<Products> RetrieveOnlyProducts() {
            List<Products> productos = new List<Products>();
            try {
                string sql = "SELECT P.ProductID, P.ProductName,P.SupplierID,P.CategoryID,P.QuantityPerUnit,P.UnitPrice,P.UnitsInStock,P.UnitsOnOrder,P.ReorderLevel,P.Discontinued FROM Products as P";

                FbConnection conexion = conexionFirebird.ObtenerConexion();
                FbCommand cmd = new FbCommand(sql, conexion);
                FbDataReader rd = cmd.ExecuteReader();
                while (rd.Read()) {
                    Products producto = new Products() {
                        ProductID = rd.GetInt32(0),
                        ProductName = rd.GetString(1),
                        SupplierID = rd.GetInt32(2),
                        CategoryID = rd.GetInt32(3),
                        QuantityPerUnit = rd.GetString(4),
                        UnitPrice = rd.GetDecimal(5),
                        UnitsInStock = rd.GetInt16(6),
                        UnitsOnOrder = rd.GetInt16(7),
                        ReorderLevel = rd.GetInt16(8),
                        //  Discontinued = rd.GetBoolean(9)
                    };
                    productos.Add(producto);
                }
                conexion.Close();
                return productos;
            } catch {
                throw;
            }
        }

        public List<Products> RetrieveOnlyProductsByCategory(int CategoryID) {
            List<Products> productos = new List<Products>();
            try {
                string sql = "SELECT P.ProductID, P.ProductName,P.SupplierID,P.CategoryID,P.QuantityPerUnit,P.UnitPrice,P.UnitsInStock,P.UnitsOnOrder,P.ReorderLevel,P.Discontinued FROM Products as P Where P.CategoryID =" + CategoryID.ToString();

                FbConnection conexion = conexionFirebird.ObtenerConexion();
                FbCommand cmd = new FbCommand(sql, conexion);
                FbDataReader rd = cmd.ExecuteReader();
                while (rd.Read()) {
                    Products producto = new Products() {
                        ProductID = rd.GetInt32(0),
                        ProductName = rd.GetString(1),
                        SupplierID = rd.GetInt32(2),
                        CategoryID = rd.GetInt32(3),
                        QuantityPerUnit = rd.GetString(4),
                        UnitPrice = rd.GetDecimal(5),
                        UnitsInStock = rd.GetInt16(6),
                        UnitsOnOrder = rd.GetInt16(7),
                        ReorderLevel = rd.GetInt16(8),
                        // Discontinued = rd.GetBoolean(9)
                    };
                    productos.Add(producto);
                }
                conexion.Close();
                return productos;
            } catch {
                throw;
            }
        }

        public bool Delete(int ProductID) {
            bool result = false;
            FbConnection conexion = null;
            try {
                string sql = string.Format(
                "DELETE FROM products WHERE productID={0} ", ProductID);

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
    }
}
