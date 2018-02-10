using MetroFormDB.DAOFirebird;
using MetroFormDB.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetroFormDB {
    public partial class CategoriasFirebird : MetroFramework.Forms.MetroForm {
        private List<Categories> categorias = new List<Categories>();
        private Categories categoria;
        public CategoriasFirebird() {
            InitializeComponent();
        }

        private void CategoriasFirebird_Load(object sender, EventArgs e) {

        }

        private void SalirBtn_Click(object sender, EventArgs e) {
            Firebird fb = new Firebird();
            fb.Show();
            this.Close();
        }
        private void GetCategorias() {
            try {
                CategoriesDAO oDAO = new CategoriesDAO();
                categorias = oDAO.RetrieveAll();
                var tmpCategorias = (from c in categorias
                                     select new {
                                         Categoria = c.CategoryName,
                                         Descripcion = c.Description,
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
            AgregarBtn.Text = "Actualizar";
        }

        private void AgregarBtn_Click(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(categoriaTxt.Text)) {

                MessageBox.Show("Inserte una categoria",
                  "ALERTA",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Exclamation,
                  MessageBoxDefaultButton.Button1);

                return;

            } else {

                try {
                    bool band;
                    CategoriesDAO oDAO = new CategoriesDAO();
                    if (AgregarBtn.Text.Equals("Agregar")) {
                        EliminarBtn.Enabled = true;
                        categoria = new Categories();
                        PasarObjeto();
                        band = oDAO.Create(categoria);
                    } else {
                        EliminarBtn.Enabled = true;
                        dgvDatos.Enabled = true;
                        CancelarBtn.Enabled = false;
                        PasarObjeto();
                        band = oDAO.Update(categoria);
                        AgregarBtn.Text = "Agregar";
                    }

                    if (band) {
                        GetCategorias();
                        LimpiarControles();
                    }
                } catch (Exception ex) {
                    MessageBox.Show("Error al agregar la categoria: " + ex.Message, "My Store Desktop",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ModificarBtn_Click(object sender, EventArgs e) {
            EliminarBtn.Enabled = false;
            dgvDatos.Enabled = false;
            int fila = dgvDatos.CurrentRow.Index;
            categoria = categorias.ElementAt(fila);
            PasarAControles();
            AgregarBtn.Text = "Actualizar";
            CancelarBtn.Enabled = true;
        }

        private void CancelarBtn_Click(object sender, EventArgs e) {
            LimpiarControles();
            CancelarBtn.Enabled = false;
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
