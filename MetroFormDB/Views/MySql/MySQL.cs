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
    public partial class MySQL : MetroFramework.Forms.MetroForm {
        public MySQL() {
            InitializeComponent();
        }

        private void SalirBtn_Click(object sender, EventArgs e) {
            Home home = new Home();
            home.Show();
            this.Dispose();
        }

        private void CategoriasBtn_Click(object sender, EventArgs e) {
            CategoriasMySql categoriaVista = new CategoriasMySql();
            
            categoriaVista.ShowDialog();
            this.Hide();
        }

        private void ProductosBtn_Click(object sender, EventArgs e) {
            ProductosMySql productosVista = new ProductosMySql();
            
            productosVista.ShowDialog();
            this.Hide();

        }

        private void ProveedoresBtn_Click(object sender, EventArgs e) {
            ProveedoresMySql proveedoresVista = new ProveedoresMySql();
            proveedoresVista.ShowDialog();
            this.Hide();

        }
    }
}
