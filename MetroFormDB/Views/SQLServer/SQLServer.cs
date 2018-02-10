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
    public partial class SQLServer : MetroFramework.Forms.MetroForm {
        public SQLServer() {
            InitializeComponent();
        }

        private void SalirBtn_Click(object sender, EventArgs e) {
            Home home = new Home();
            home.Show();
            this.Close();
        }

        private void ProductosBtn_Click(object sender, EventArgs e) {
            ProductosSqlServer productosVista = new ProductosSqlServer();
            this.Hide();
            productosVista.ShowDialog();
        }

        private void CategoriasBtn_Click(object sender, EventArgs e) {
            CategoriasSqlServer categoriaVista = new CategoriasSqlServer();
            this.Hide();
            categoriaVista.ShowDialog();
        }

        private void ProveedoresBtn_Click(object sender, EventArgs e) {
            ProveedoresSqlServer proveedoresVista = new ProveedoresSqlServer();
            this.Hide();
            proveedoresVista.ShowDialog();
        }
    }
}
