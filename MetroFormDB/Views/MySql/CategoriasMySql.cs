using MetroFormDB.DAOMySQL;
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
    public partial class CategoriasMySql : MetroFramework.Forms.MetroForm {
        private List<Categories> categorias = new List<Categories>();
        private Categories categoria;
        public CategoriasMySql() {
            InitializeComponent();
        }

        private void CategoriasMySql_Load(object sender, EventArgs e) {
            GetCategorias();

        }

        private void SalirBtn_Click(object sender, EventArgs e) {
            MySQL mysql = new MySQL();
            mysql.Show();
            this.Close();
        }
        private void GetCategorias() {
            try {
                DAOMySQL.CategoriesDAO oDAO = new CategoriesDAO();
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

        private void AgregarBtn_Click(object sender, EventArgs e) {
            try {
                Regex match = new Regex(@"^[A-Z]+[a-zA-Z0-9''-'\s]*$");
                if (match.IsMatch(categoriaTxt.Text)) {
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
