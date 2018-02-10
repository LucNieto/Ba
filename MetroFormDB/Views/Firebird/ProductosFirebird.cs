using MetroFormDB.DAOFirebird;
using MetroFormDB.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetroFormDB {
    public partial class ProductosFirebird : MetroFramework.Forms.MetroForm {
        private List<ProductsCategorySupplier> productos = new List<ProductsCategorySupplier>();
        private List<Categories> categorias = new List<Categories>();
        private List<Suppliers> proveedores = new List<Suppliers>();
        private Products producto;
        public ProductosFirebird() {
            InitializeComponent();
        }

        private void ProductosFirebird_Load(object sender, EventArgs e) {

            GetProductos();
            CancelarBtn.Enabled = false;
            GetCategorias();
            GetSuppliers();
        }
        private void GetProductos() {
            try {
                ProductsDAO oDAO = new ProductsDAO();
                productos = oDAO.RetrieveAll();
                var tmpProductos = (from p in productos  
                                    select new {
                                        Producto_ID = p.ProductID,
                                        Nombre = p.ProductName,
                                        Cantidad = p.QuantityPerUnit,
                                        Unidad_Precio = p.UnitPrice,
                                        Unidades_Stock = p.UnitsInStock,
                                        Unidad_Orden = p.UnitsOnOrder,
                                        Reorder_Level = p.ReorderLevel,
                                        Descontinuado = p.Discontinued,
                                        Nombre_Categoria = p.CategoryName,
                                        Nombre_Compañia = p.CompanyName

                                    }).ToList();
                dgvDatos.DataSource = null;
                dgvDatos.DataSource = tmpProductos;

            } catch (Exception e) {
                MessageBox.Show(e.Message, "MyStoreDesktop");
            }
        }
        private void GetCategorias() {
            CategoriesDAO oDAO = new CategoriesDAO();
            categorias = oDAO.RetrieveAll();
            if (categorias != null) {
                if (categorias.Count != 0) {
                    categoriaCmBox.DisplayMember = "CategoryName";
                    categoriaCmBox.ValueMember = "CategoryID";
                    categoriaCmBox.DataSource = (from c in categorias
                                                 select new {
                                                     c.CategoryID,
                                                     c.CategoryName
                                                 }).ToList();
                }
            }
        }
        private void GetSuppliers() {
            SuppliersDAO oDAO = new SuppliersDAO();
            proveedores = oDAO.RetrieveAll();
            if (proveedores != null) {
                if (proveedores.Count != 0) {
                    proveedorCmBox.DisplayMember = "CompanyName";
                    proveedorCmBox.ValueMember = "SupplierID";
                    proveedorCmBox.DataSource = (from c in proveedores
                                                   select new {
                                                       c.SupplierID,
                                                       c.CompanyName
                                                   }).ToList();
                }
            }
            
        }
        private void AgregarBtn_Click(object sender, EventArgs e) {
            try {

                 Regex match = new Regex(@"^[A-Z]+[a-zA-Z0-9''-'\s]*$");
                if ( match.IsMatch(productoTxt.Text)) {
                bool band;
                ProductsDAO oDAO = new ProductsDAO();


              //  PasarObjeto();

                if (AgregarBtn.Text.Equals("Agregar")) {
                    producto = new Products();
                   // PasarObjeto();
                    band = oDAO.Create(producto);
                } else {
                   // btnEliminar.Enabled = true;
                    //PasarObjeto();
                    //band = oDAO.Update(producto);// MessageBox.Show("dentro de update");
                }
                //if (band) {
                //    //GetProductos(0);
                //    //LimpiarControles();
                //    //btnAgregar.Text = "Agregar";
                //}
                 } else {
                 MessageBox.Show("No se permiten los siguientes aspectos:\n" + "Producto" + " vacío,\nCapitalización,\nNo empezar con un número,\nMáximo a 40 caracteres.");
                 }


            } catch (Exception ex) {
                MessageBox.Show("Error al agregar el producto: " + ex.Message, "My Store Desktop",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ModificarBtn_Click(object sender, EventArgs e) {
            CancelarBtn.Enabled = true;
            EliminarBtn.Enabled = false;
            int fila = dgvDatos.CurrentRow.Index;
            producto = productos.ElementAt(fila);
            PasarControles();
            AgregarBtn.Text = "Actualizar";
        }
        private void PasarObjeto() {
            Regex match = new Regex(@"^[A-Z]+[a-zA-Z0-9''-'\s]*$");
            if (match.IsMatch(productoTxt.Text)) { producto.ProductName = productoTxt.Text; } else { lblNombre.Text = "Capitalización y solo caracteres permitidos"; }


            producto.CategoryID = Convert.ToInt32(categoriaCmBox.SelectedValue);
            producto.SupplierID = Convert.ToInt32(proveedorCmBox.SelectedValue);
            producto.QuantityPerUnit = CUnitariaTxt.Text;
            producto.UnitPrice = decimal.Parse(PUnitarioTxt.Text);

            producto.UnitsInStock = short.Parse(ExistenciaTxt.Text);
            producto.UnitsOnOrder = short.Parse(UCaminoTxt.Text);
            producto.ReorderLevel = short.Parse(SMPermitidoTxt.Text);

        }
        private void PasarControles() {
            int cat = producto.CategoryID;
            int prov = producto.SupplierID;
            MessageBox.Show(cat.ToString());
            MessageBox.Show(prov.ToString());

            productoTxt.Text = producto.ProductName;
            categoriaCmBox.SelectedIndex = producto.CategoryID;
            proveedorCmBox.SelectedIndex = producto.SupplierID;
            CUnitariaTxt.Text = producto.QuantityPerUnit;
            PUnitarioTxt.Text = producto.UnitPrice.ToString();
            ExistenciaTxt.Text = producto.UnitsInStock.ToString();
            UCaminoTxt.Text = producto.UnitsOnOrder.ToString();
            SMPermitidoTxt.Text = producto.ReorderLevel.ToString();

        }
        private void LimpiarControles() {
            categoriaCmBox.SelectedIndex = 0;
            proveedorCmBox.SelectedIndex = 0;
            productoTxt.Text = "";     
            CUnitariaTxt.Text = "";
            SMPermitidoTxt.Text = "";
            PUnitarioTxt.Text = "";
            ExistenciaTxt.Text = "";
            UCaminoTxt.Text = "";

        }
    }
}
