namespace MetroFormDB {
    partial class ProductosSqlServer {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.SalirBtn = new MetroFramework.Controls.MetroTile();
            this.EliminarBtn = new MetroFramework.Controls.MetroTile();
            this.CancelarBtn = new MetroFramework.Controls.MetroTile();
            this.ModificarBtn = new MetroFramework.Controls.MetroTile();
            this.AgregarBtn = new MetroFramework.Controls.MetroTile();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.proveedoresCmBox = new MetroFramework.Controls.MetroComboBox();
            this.categoriaCmBox = new MetroFramework.Controls.MetroComboBox();
            this.productoTxt = new MetroFramework.Controls.MetroTextBox();
            this.CUnitariaTxt = new MetroFramework.Controls.MetroTextBox();
            this.PUnitarioTxt = new MetroFramework.Controls.MetroTextBox();
            this.existenciaTxt = new MetroFramework.Controls.MetroTextBox();
            this.UCaminoTxt = new MetroFramework.Controls.MetroTextBox();
            this.SMPermitidoTxts = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.lblNombre = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // SalirBtn
            // 
            this.SalirBtn.Location = new System.Drawing.Point(1161, 577);
            this.SalirBtn.Name = "SalirBtn";
            this.SalirBtn.Size = new System.Drawing.Size(131, 121);
            this.SalirBtn.TabIndex = 8;
            this.SalirBtn.Text = "Salir";
            this.SalirBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SalirBtn.Click += new System.EventHandler(this.SalirBtn_Click);
            // 
            // EliminarBtn
            // 
            this.EliminarBtn.Location = new System.Drawing.Point(1161, 450);
            this.EliminarBtn.Name = "EliminarBtn";
            this.EliminarBtn.Size = new System.Drawing.Size(131, 121);
            this.EliminarBtn.TabIndex = 9;
            this.EliminarBtn.Text = "Eliminar";
            this.EliminarBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EliminarBtn.Click += new System.EventHandler(this.EliminarBtn_Click);
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.Location = new System.Drawing.Point(1161, 323);
            this.CancelarBtn.Name = "CancelarBtn";
            this.CancelarBtn.Size = new System.Drawing.Size(131, 121);
            this.CancelarBtn.TabIndex = 10;
            this.CancelarBtn.Text = "Cancelar";
            this.CancelarBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CancelarBtn.Click += new System.EventHandler(this.CancelarBtn_Click);
            // 
            // ModificarBtn
            // 
            this.ModificarBtn.Location = new System.Drawing.Point(1161, 196);
            this.ModificarBtn.Name = "ModificarBtn";
            this.ModificarBtn.Size = new System.Drawing.Size(131, 121);
            this.ModificarBtn.TabIndex = 11;
            this.ModificarBtn.Text = "Modificar";
            this.ModificarBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ModificarBtn.Click += new System.EventHandler(this.ModificarBtn_Click);
            // 
            // AgregarBtn
            // 
            this.AgregarBtn.Location = new System.Drawing.Point(1161, 69);
            this.AgregarBtn.Name = "AgregarBtn";
            this.AgregarBtn.Size = new System.Drawing.Size(131, 121);
            this.AgregarBtn.TabIndex = 12;
            this.AgregarBtn.Text = "Agregar";
            this.AgregarBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AgregarBtn.Click += new System.EventHandler(this.AgregarBtn_Click);
            // 
            // dgvDatos
            // 
            this.dgvDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDatos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(396, 170);
            this.dgvDatos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.RowHeadersWidth = 40;
            this.dgvDatos.Size = new System.Drawing.Size(756, 528);
            this.dgvDatos.TabIndex = 13;
            this.dgvDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatos_CellContentClick);
            // 
            // proveedoresCmBox
            // 
            this.proveedoresCmBox.FormattingEnabled = true;
            this.proveedoresCmBox.ItemHeight = 24;
            this.proveedoresCmBox.Location = new System.Drawing.Point(212, 187);
            this.proveedoresCmBox.Name = "proveedoresCmBox";
            this.proveedoresCmBox.Size = new System.Drawing.Size(175, 30);
            this.proveedoresCmBox.TabIndex = 14;
            this.proveedoresCmBox.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged);
            // 
            // categoriaCmBox
            // 
            this.categoriaCmBox.FormattingEnabled = true;
            this.categoriaCmBox.ItemHeight = 24;
            this.categoriaCmBox.Location = new System.Drawing.Point(212, 274);
            this.categoriaCmBox.Name = "categoriaCmBox";
            this.categoriaCmBox.Size = new System.Drawing.Size(175, 30);
            this.categoriaCmBox.TabIndex = 14;
            this.categoriaCmBox.SelectedIndexChanged += new System.EventHandler(this.metroComboBox2_SelectedIndexChanged);
            // 
            // productoTxt
            // 
            this.productoTxt.Location = new System.Drawing.Point(214, 360);
            this.productoTxt.Name = "productoTxt";
            this.productoTxt.Size = new System.Drawing.Size(175, 35);
            this.productoTxt.TabIndex = 15;
            this.productoTxt.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // CUnitariaTxt
            // 
            this.CUnitariaTxt.Location = new System.Drawing.Point(212, 427);
            this.CUnitariaTxt.Name = "CUnitariaTxt";
            this.CUnitariaTxt.Size = new System.Drawing.Size(175, 35);
            this.CUnitariaTxt.TabIndex = 15;
            this.CUnitariaTxt.Click += new System.EventHandler(this.metroTextBox2_Click);
            // 
            // PUnitarioTxt
            // 
            this.PUnitarioTxt.Location = new System.Drawing.Point(212, 490);
            this.PUnitarioTxt.Name = "PUnitarioTxt";
            this.PUnitarioTxt.Size = new System.Drawing.Size(175, 35);
            this.PUnitarioTxt.TabIndex = 15;
            this.PUnitarioTxt.Click += new System.EventHandler(this.metroTextBox3_Click);
            // 
            // existenciaTxt
            // 
            this.existenciaTxt.Location = new System.Drawing.Point(212, 548);
            this.existenciaTxt.Name = "existenciaTxt";
            this.existenciaTxt.Size = new System.Drawing.Size(175, 35);
            this.existenciaTxt.TabIndex = 15;
            this.existenciaTxt.Click += new System.EventHandler(this.metroTextBox4_Click);
            // 
            // UCaminoTxt
            // 
            this.UCaminoTxt.Location = new System.Drawing.Point(212, 608);
            this.UCaminoTxt.Name = "UCaminoTxt";
            this.UCaminoTxt.Size = new System.Drawing.Size(175, 35);
            this.UCaminoTxt.TabIndex = 15;
            this.UCaminoTxt.Click += new System.EventHandler(this.metroTextBox5_Click);
            // 
            // SMPermitidoTxts
            // 
            this.SMPermitidoTxts.Location = new System.Drawing.Point(214, 663);
            this.SMPermitidoTxts.Name = "SMPermitidoTxts";
            this.SMPermitidoTxts.Size = new System.Drawing.Size(175, 35);
            this.SMPermitidoTxts.TabIndex = 15;
            this.SMPermitidoTxts.Click += new System.EventHandler(this.metroTextBox6_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(36, 187);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(74, 20);
            this.metroLabel1.TabIndex = 16;
            this.metroLabel1.Text = "Proveedor";
            this.metroLabel1.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(35, 284);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(68, 20);
            this.metroLabel2.TabIndex = 16;
            this.metroLabel2.Text = "Categoría";
            this.metroLabel2.Click += new System.EventHandler(this.metroLabel2_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(36, 363);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(65, 20);
            this.metroLabel3.TabIndex = 16;
            this.metroLabel3.Text = "Producto";
            this.metroLabel3.Click += new System.EventHandler(this.metroLabel3_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(35, 430);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(114, 20);
            this.metroLabel4.TabIndex = 16;
            this.metroLabel4.Text = "Cantidad Unitaria";
            this.metroLabel4.Click += new System.EventHandler(this.metroLabel4_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(35, 493);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(100, 20);
            this.metroLabel5.TabIndex = 16;
            this.metroLabel5.Text = "Precio Unitario";
            this.metroLabel5.Click += new System.EventHandler(this.metroLabel5_Click);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(36, 551);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(69, 20);
            this.metroLabel6.TabIndex = 16;
            this.metroLabel6.Text = "Existencia";
            this.metroLabel6.Click += new System.EventHandler(this.metroLabel6_Click);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(35, 611);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(136, 20);
            this.metroLabel7.TabIndex = 16;
            this.metroLabel7.Text = "Unidades en camino";
            this.metroLabel7.Click += new System.EventHandler(this.metroLabel7_Click);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(4, 678);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(155, 20);
            this.metroLabel8.TabIndex = 16;
            this.metroLabel8.Text = "Stock mínimo permitido";
            this.metroLabel8.Click += new System.EventHandler(this.metroLabel8_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(219, 337);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(0, 0);
            this.lblNombre.TabIndex = 16;
            this.lblNombre.Click += new System.EventHandler(this.metroLabel3_Click);
            // 
            // ProductosSqlServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1313, 745);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.SMPermitidoTxts);
            this.Controls.Add(this.UCaminoTxt);
            this.Controls.Add(this.existenciaTxt);
            this.Controls.Add(this.PUnitarioTxt);
            this.Controls.Add(this.CUnitariaTxt);
            this.Controls.Add(this.productoTxt);
            this.Controls.Add(this.categoriaCmBox);
            this.Controls.Add(this.proveedoresCmBox);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.SalirBtn);
            this.Controls.Add(this.EliminarBtn);
            this.Controls.Add(this.CancelarBtn);
            this.Controls.Add(this.ModificarBtn);
            this.Controls.Add(this.AgregarBtn);
            this.Name = "ProductosSqlServer";
            this.Text = "Productos (SqlServer)";
            this.Load += new System.EventHandler(this.ProductosSqlServer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile SalirBtn;
        private MetroFramework.Controls.MetroTile EliminarBtn;
        private MetroFramework.Controls.MetroTile CancelarBtn;
        private MetroFramework.Controls.MetroTile ModificarBtn;
        private MetroFramework.Controls.MetroTile AgregarBtn;
        private System.Windows.Forms.DataGridView dgvDatos;
        private MetroFramework.Controls.MetroComboBox proveedoresCmBox;
        private MetroFramework.Controls.MetroComboBox categoriaCmBox;
        private MetroFramework.Controls.MetroTextBox productoTxt;
        private MetroFramework.Controls.MetroTextBox CUnitariaTxt;
        private MetroFramework.Controls.MetroTextBox PUnitarioTxt;
        private MetroFramework.Controls.MetroTextBox existenciaTxt;
        private MetroFramework.Controls.MetroTextBox UCaminoTxt;
        private MetroFramework.Controls.MetroTextBox SMPermitidoTxts;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel lblNombre;
    }
}