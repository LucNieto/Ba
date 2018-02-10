
using MetroFormDB.DAOSQLServer;
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
    public partial class ProductosSqlServer : MetroFramework.Forms.MetroForm {
        private List<ProductsCategorySupplier> productos = new List<ProductsCategorySupplier>();
        private List<Categories> categorias = new List<Categories>();
        private List<Suppliers> proveedores = new List<Suppliers>();
        private Products producto;

        public ProductosSqlServer() {
            InitializeComponent();
        }

        private void ProductosSqlServer_Load(object sender, EventArgs e) { 
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
                    proveedoresCmBox.DisplayMember = "CompanyName";
                    proveedoresCmBox.ValueMember = "SupplierID";
                    proveedoresCmBox.DataSource = (from c in proveedores
                                               select new {
                                                   c.SupplierID,
                                                   c.CompanyName
                                               }).ToList();
                }
            }
            productoTxt.MaxLength = 40;
            CUnitariaTxt.MaxLength = 20;
            PUnitarioTxt.MaxLength = 15;
            UCaminoTxt.MaxLength = 4;
            SMPermitidoTxts.MaxLength = 4;
            existenciaTxt.MaxLength = 4;
        }

        private void SalirBtn_Click(object sender, EventArgs e) {
            SQLServer sqlServerVista = new SQLServer();
            sqlServerVista.Show();
            this.Close();
        }

        private void metroLabel7_Click(object sender, EventArgs e) {

        }

        private void metroLabel6_Click(object sender, EventArgs e) {

        }

        private void metroLabel5_Click(object sender, EventArgs e) {

        }

        private void metroLabel4_Click(object sender, EventArgs e) {

        }

        private void metroLabel3_Click(object sender, EventArgs e) {

        }

        private void metroLabel2_Click(object sender, EventArgs e) {

        }

        private void metroLabel1_Click(object sender, EventArgs e) {

        }

        private void metroTextBox6_Click(object sender, EventArgs e) {

        }

        private void metroTextBox5_Click(object sender, EventArgs e) {

        }

        private void metroTextBox4_Click(object sender, EventArgs e) {

        }

        private void metroTextBox3_Click(object sender, EventArgs e) {

        }

        private void metroTextBox2_Click(object sender, EventArgs e) {

        }

        private void metroTextBox1_Click(object sender, EventArgs e) {

        }

        private void metroComboBox2_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void metroLabel8_Click(object sender, EventArgs e) {

        }

        private void EliminarBtn_Click(object sender, EventArgs e) {
            bool result = false;
            try {
                DialogResult res = MessageBox.Show("¿Desea eliminar el proveedor?",
                    "My Store Desktop", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes) {
                    int fila = dgvDatos.CurrentRow.Index;
                    producto = productos.ElementAt(fila);
                    ProductsDAO pDAO = new ProductsDAO();
                    result = pDAO.Delete(producto.ProductID);
                    if (result) {
                        GetProductos();
                    } else {
                        MessageBox.Show("Error al eliminar el producto",
                            "My Store Desktop", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            } catch (Exception ex) {
                MessageBox.Show("Error al eliminar el producto: " + ex.Message, "My Store Desktop",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CancelarBtn_Click(object sender, EventArgs e) {
            EliminarBtn.Enabled = true;
            LimpiarControles();
            AgregarBtn.Text = "Agregar";
            CancelarBtn.Enabled = false;
        }

        private void ModificarBtn_Click(object sender, EventArgs e) {
            CancelarBtn.Enabled = true;
            EliminarBtn.Enabled = false;
            int fila = dgvDatos.CurrentRow.Index;
            producto = productos.ElementAt(fila);
            PasarControles();
            AgregarBtn.Text = "Actualizar";
        }

        private void AgregarBtn_Click(object sender, EventArgs e) {
            try {

                Regex match = new Regex(@"^[A-Z]+[a-zA-Z0-9''-'\s]*$");
              if (match.IsMatch(productoTxt.Text)) {
                bool band;
                ProductsDAO oDAO = new ProductsDAO();


                PasarObjeto();

                if (AgregarBtn.Text.Equals("Agregar")) {
                    producto = new Products();
                    PasarObjeto();
                    band = oDAO.Create(producto);
                } else {
                    EliminarBtn.Enabled = true;
                    PasarObjeto();
                    band = oDAO.Update(producto);
                }
                if (band) {
                    GetProductos();
                    LimpiarControles();
                    AgregarBtn.Text = "Agregar";
                }
              } else {
                MessageBox.Show("No se permiten los siguientes aspectos:\n" + "Producto" + " vacío,\nCapitalización,\nNo empezar con un número,\nMáximo a 40 caracteres.");
              }


            } catch (Exception ex) {
                MessageBox.Show("Error al agregar el producto: " + ex.Message, "My Store Desktop",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
             
    }
        private void PasarObjeto() {
            Regex match = new Regex(@"^[A-Z]+[a-zA-Z0-9''-'\s]*$");
            if (match.IsMatch(productoTxt.Text)) { producto.ProductName = productoTxt.Text; } else { lblNombre.Text = "Capitalización y solo caracteres permitidos"; }


            producto.CategoryID = Convert.ToInt32(categoriaCmBox.SelectedValue);
            producto.SupplierID = Convert.ToInt32(proveedoresCmBox.SelectedValue);
            producto.QuantityPerUnit = CUnitariaTxt.Text;
            producto.UnitPrice = decimal.Parse(PUnitarioTxt.Text);
        
            producto.UnitsInStock = short.Parse(existenciaTxt.Text);
            producto.UnitsOnOrder = short.Parse(UCaminoTxt.Text);
            producto.ReorderLevel = short.Parse(SMPermitidoTxts.Text);

        }
        private void PasarControles() {
        int cat = producto.CategoryID;
        int prov = producto.SupplierID;
        MessageBox.Show(cat.ToString());
        MessageBox.Show(prov.ToString());

        productoTxt.Text = producto.ProductName;
        categoriaCmBox.SelectedIndex = producto.CategoryID;
        proveedoresCmBox.SelectedIndex = producto.SupplierID;
        CUnitariaTxt.Text = producto.QuantityPerUnit;
        PUnitarioTxt.Text = producto.UnitPrice.ToString();
        existenciaTxt.Text = producto.UnitsInStock.ToString();
        UCaminoTxt.Text = producto.UnitsOnOrder.ToString();
        SMPermitidoTxts.Text = producto.ReorderLevel.ToString();

    }
        private void LimpiarControles() {
            categoriaCmBox.SelectedIndex = 0;
            proveedoresCmBox.SelectedIndex = 0;
            productoTxt.Text = "";
            CUnitariaTxt.Text = "";
            SMPermitidoTxts.Text = "";
            PUnitarioTxt.Text = "";
            existenciaTxt.Text = "";
            UCaminoTxt.Text = "";

        }
    }
}
