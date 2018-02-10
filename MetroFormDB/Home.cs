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
    public partial class Home : MetroFramework.Forms.MetroForm {
        public Home() {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e) {

        }

        private void metroTile2_Click(object sender, EventArgs e) {
            SQLServer sqlServerVista = new SQLServer();
            this.Hide();
            sqlServerVista.ShowDialog();
        }

        private void SalirBtn_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void MySqlBtn_Click(object sender, EventArgs e) {
            MySQL MySQLVista = new MySQL();
           
            MySQLVista.ShowDialog();
            this.Hide();
        }

        private void FbBtn_Click(object sender, EventArgs e) {
            Firebird fbVista = new Firebird();
            
            fbVista.ShowDialog();
            this.Hide();
        }
    }
}
