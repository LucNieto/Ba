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
    public partial class Firebird : MetroFramework.Forms.MetroForm {
        public Firebird() {
            InitializeComponent();
        }

        private void metroTile4_Click(object sender, EventArgs e) {
            
            Home home = new Home();
            home.Show();
            this.Dispose();
        }

        private void ProductosBtn_Click(object sender, EventArgs e) {
            ProductosFirebird productosVista = new ProductosFirebird();
            this.Hide();
            productosVista.ShowDialog();
        }

        private void CategoriasBtn_Click(object sender, EventArgs e) {
            CategoriasFirebird categoriaVista = new CategoriasFirebird();
            this.Hide();
            categoriaVista.ShowDialog();
        }

        private void ProveedoresBtn_Click(object sender, EventArgs e) {
            ProveedoresFirebird proveedores = new ProveedoresFirebird();
            this.Hide();
            proveedores.ShowDialog();
        }
    }
}
