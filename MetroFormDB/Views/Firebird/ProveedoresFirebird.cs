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
    public partial class ProveedoresFirebird : MetroFramework.Forms.MetroForm {
        private List<Suppliers> proveedores = new List<Suppliers>();
        private Suppliers proveedor;
        public ProveedoresFirebird() {
            InitializeComponent();
        }

        private void ProveedoresFirebird_Load(object sender, EventArgs e) {
            GetProveedores();
        }

        private void AgregarBtn_Click(object sender, EventArgs e) {
            try {

                Regex match = new Regex(@"^[A-Z]+[a-zA-Z0-9''-'\s]*$");
                if (match.IsMatch(proveedorTxt.Text)) {

                    bool band;

                    SuppliersDAO oDAO = new SuppliersDAO();
                    if (AgregarBtn.Text.Equals("Agregar")) {
                        proveedor = new Suppliers();
                        PasarObjeto();
                        band = oDAO.Create(proveedor);
                    } else {
                        PasarObjeto();
                        band = oDAO.Update(proveedor);
                    }

                    if (band) {
                        GetProveedores();
                        LimpiarControles();
                    }
                } else {
                    MessageBox.Show("No se permiten los siguientes aspectos:\n" + "Proveedor" + " vacío,\nCapitalización,\nNo empezar con un número,\nMáximo a 40 caracteres.");
                }
            } catch (Exception ex) {
                MessageBox.Show("Error al agregar al proveedor: " + ex.Message, "My Store Desktop",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ModificarBtn_Click(object sender, EventArgs e) {
            int fila = dgvDatos.CurrentRow.Index;
            proveedor = proveedores.ElementAt(fila);
            PasarAControles();
            AgregarBtn.Text = "Actualizar";
        }

        private void CancelarBtn_Click(object sender, EventArgs e) {
            LimpiarControles();
            AgregarBtn.Text = "Agregar";
        }

        private void EliminarBtn_Click(object sender, EventArgs e) {
            bool result = false;
            try {
                DialogResult res = MessageBox.Show("¿Desea eliminar el proveedor?",
                    "My Store Desktop", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes) {
                    int fila = dgvDatos.CurrentRow.Index;
                    proveedor = proveedores.ElementAt(fila);
                    SuppliersDAO cDAO = new SuppliersDAO();
                    result = cDAO.Delete(proveedor.SupplierID);
                    if (result) {
                        GetProveedores();
                    } else {
                        MessageBox.Show("Error al eliminar el proveedor",
                            "My Store Desktop", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            } catch (Exception ex) {
                MessageBox.Show("Error al eliminar el proveedor: " + ex.Message, "My Store Desktop",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SalirBtn_Click(object sender, EventArgs e) {
            Firebird fb = new Firebird();
            fb.Show();
            this.Close();
        }
        private void GetProveedores() {
            try {
                SuppliersDAO oDAO = new SuppliersDAO();
                proveedores = oDAO.RetrieveAll();
                var tmpProveedores = (from prov in proveedores
                                      select new {
                                          Compañia = prov.CompanyName,
                                          Contacto = prov.ContactName,
                                          TitContacto = prov.ContactTitle,
                                          Direccion = prov.Address,
                                          Ciudad = prov.City,
                                          CodigoPostal = prov.PostalCode,
                                          Pais = prov.Country,
                                          Telefono = prov.Phone

                                      }).ToList();
                dgvDatos.DataSource = null;
                dgvDatos.DataSource = tmpProveedores;
            } catch (Exception e) {
                MessageBox.Show(e.Message, "MyStoreDesktop");
            }

        }
        private void LimpiarControles() {
            companiaTxt.Text = "";
            proveedorTxt.Text = "";
            TContactoTxt.Text = "";
            direccionTxt.Text = "";
            ciudadTxt.Text = "";
            CPostalTxt.Text = "";
            paisTxt.Text = "";
            telefonoTxt.Text = "";
        }

        private void PasarObjeto() {
            proveedor.CompanyName = companiaTxt.Text;
            proveedor.ContactName = proveedorTxt.Text;
            proveedor.ContactTitle = TContactoTxt.Text;
            proveedor.Address = direccionTxt.Text;
            proveedor.City = ciudadTxt.Text;
            proveedor.PostalCode = CPostalTxt.Text;
            proveedor.Country = paisTxt.Text;
            proveedor.Phone = telefonoTxt.Text;
        }

        private void PasarAControles() {
            companiaTxt.Text = proveedor.CompanyName;
            proveedorTxt.Text = proveedor.ContactName;
            TContactoTxt.Text = proveedor.ContactTitle;
            direccionTxt.Text = proveedor.Address;
            ciudadTxt.Text = proveedor.City;
            CPostalTxt.Text = proveedor.PostalCode;
            paisTxt.Text = proveedor.Country;
            telefonoTxt.Text = proveedor.Phone;
            AgregarBtn.Text = "Actualizar";
        }
    }
}
