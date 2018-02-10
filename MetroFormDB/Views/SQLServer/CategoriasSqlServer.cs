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
    public partial class CategoriasSqlServer : MetroFramework.Forms.MetroForm {
        public CategoriasSqlServer() {
            InitializeComponent();
        }

        private void CategoriasSqlServer_Load(object sender, EventArgs e) {
            GetCategorias();
        }

        private void metroTextBox2_Click(object sender, EventArgs e) {

        }

        private void SalirBtn_Click(object sender, EventArgs e) {
            SQLServer sqlServerVista = new SQLServer();
            sqlServerVista.Show();
            this.Close();
        }

        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }
        private List<Categories> categorias = new List<Categories>();
        private Categories categoria;

   


        
        private void btnAgregar_Click(object sender, EventArgs e) {
            try {
                Regex match = new Regex(@"^[A-Z]+[a-zA-Z0-9''-'\s]*$");
                if (categoriaTxt.MaxLength <= 15 && match.IsMatch(categoriaTxt.Text)) {
                    bool band;
                    CategoriesDAO oDAO = new CategoriesDAO();
                    if (AgregarBtn.Text.Equals("Agregar")) {
                        categoria = new Categories();
                        PasarObjeto();
                        band = oDAO.Create(categoria);
                    } else {
                        PasarObjeto();
                        band = oDAO.Update(categoria);
                    }

                    if (band) {
                        GetCategorias();
                        LimpiarControles();
                    }
                } else {
                    MessageBox.Show("No se permiten los siguientes aspectos:\n" + "Categoría" + " vacío,\nCapitalización,\nNo empezar con un número,\nMáximo a 15 caracteres.");
                }

            } catch (Exception ex) {
                MessageBox.Show("Error al agregar la categoria: " + ex.Message, "My Store Desktop",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void GetCategorias() {
            try {
                CategoriesDAO oDAO = new CategoriesDAO();
                categorias = oDAO.RetrieveAll();
                var tmpCategorias = (from c in categorias
                                     select new {
                                         Categoria = c.CategoryName,
                                         Descripcion = c.Description
                                     }).ToList();
                dgvDatos.DataSource = null;
                dgvDatos.DataSource = tmpCategorias;
            } catch (Exception e) {
                MessageBox.Show(e.Message, "MyStoreDesktop");
            }
        }
        private void LimpiarControles() {
            categoriaTxt.Text = "";
            descripcionTxt.Text = "";
        }

        private void PasarObjeto() {
            categoria.CategoryName = categoriaTxt.Text;
            categoria.Description = descripcionTxt.Text;
        }
        private void PasarAControles() {
            categoriaTxt.Text = categoria.CategoryName;
            descripcionTxt.Text = categoria.Description;
            AgregarBtn.Text = "Agregar";
        }

        private void btnEliminar_Click(object sender, EventArgs e) {
            bool result = false;
            try {
                DialogResult res = MessageBox.Show("¿Desea eliminar la categoria?",
                    "My Store Desktop", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes) {
                    int fila = dgvDatos.CurrentRow.Index;
                    categoria = categorias.ElementAt(fila);
                    CategoriesDAO cDAO = new CategoriesDAO();
                    result = cDAO.Delete(categoria.CategoryID);
                    if (result) {
                        GetCategorias();
                    } else {
                        MessageBox.Show("Error al eliminar la categoria",
                            "My Store Desktop", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            } catch (Exception ex) {
                MessageBox.Show("Error al eliminar la categoria: " + ex.Message, "My Store Desktop",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

     

        private void metroLabel2_Click(object sender, EventArgs e) {

        }

        private void AgregarBtn_Click(object sender, EventArgs e) {
            try {
                Regex match = new Regex(@"^[A-Z]+[a-zA-Z0-9''-'\s]*$");
                if ( match.IsMatch(categoriaTxt.Text)) {
                    bool band;
                    CategoriesDAO oDAO = new CategoriesDAO();
                    if (AgregarBtn.Text.Equals("Agregar")) {
                        categoria = new Categories();
                        PasarObjeto();
                        band = oDAO.Create(categoria);
                    } else {
                        PasarObjeto();
                        band = oDAO.Update(categoria);
                        AgregarBtn.Text = "Agregar";
                    }

                    if (band) {
                        GetCategorias();
                        LimpiarControles();
                    }
            } else {
                MessageBox.Show("No se permiten los siguientes aspectos:\n" + "Categoría" + " vacío,\nCapitalización,\nNo empezar con un número,\nMáximo a 15 caracteres.");
            }

        } catch (Exception ex) {
                MessageBox.Show("Error al agregar la categoria: " + ex.Message, "My Store Desktop",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ModificarBtn_Click(object sender, EventArgs e) {
            int fila = dgvDatos.CurrentRow.Index;
            categoria = categorias.ElementAt(fila);
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
                DialogResult res = MessageBox.Show("¿Desea eliminar la categoria?",
                    "My Store Desktop", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes) {
                    int fila = dgvDatos.CurrentRow.Index;
                    categoria = categorias.ElementAt(fila);
                    CategoriesDAO cDAO = new CategoriesDAO();
                    result = cDAO.Delete(categoria.CategoryID);
                    if (result) {
                        GetCategorias();
                    } else {
                        MessageBox.Show("Error al eliminar la categoria",
                            "My Store Desktop", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            } catch (Exception ex) {
                MessageBox.Show("Error al eliminar la categoria: " + ex.Message, "My Store Desktop",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
