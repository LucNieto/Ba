namespace MetroFormDB {
    partial class CategoriasSqlServer {
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
            this.EliminarBtn = new MetroFramework.Controls.MetroTile();
            this.CancelarBtn = new MetroFramework.Controls.MetroTile();
            this.ModificarBtn = new MetroFramework.Controls.MetroTile();
            this.AgregarBtn = new MetroFramework.Controls.MetroTile();
            this.SalirBtn = new MetroFramework.Controls.MetroTile();
            this.descripcionTxt = new MetroFramework.Controls.MetroTextBox();
            this.categoriaTxt = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // EliminarBtn
            // 
            this.EliminarBtn.Location = new System.Drawing.Point(679, 440);
            this.EliminarBtn.Name = "EliminarBtn";
            this.EliminarBtn.Size = new System.Drawing.Size(131, 121);
            this.EliminarBtn.TabIndex = 4;
            this.EliminarBtn.Text = "Eliminar";
            this.EliminarBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EliminarBtn.Click += new System.EventHandler(this.EliminarBtn_Click);
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.Location = new System.Drawing.Point(679, 313);
            this.CancelarBtn.Name = "CancelarBtn";
            this.CancelarBtn.Size = new System.Drawing.Size(131, 121);
            this.CancelarBtn.TabIndex = 5;
            this.CancelarBtn.Text = "Cancelar";
            this.CancelarBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CancelarBtn.Click += new System.EventHandler(this.CancelarBtn_Click);
            // 
            // ModificarBtn
            // 
            this.ModificarBtn.Location = new System.Drawing.Point(679, 186);
            this.ModificarBtn.Name = "ModificarBtn";
            this.ModificarBtn.Size = new System.Drawing.Size(131, 121);
            this.ModificarBtn.TabIndex = 6;
            this.ModificarBtn.Text = "Modificar";
            this.ModificarBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ModificarBtn.Click += new System.EventHandler(this.ModificarBtn_Click);
            // 
            // AgregarBtn
            // 
            this.AgregarBtn.Location = new System.Drawing.Point(679, 59);
            this.AgregarBtn.Name = "AgregarBtn";
            this.AgregarBtn.Size = new System.Drawing.Size(131, 121);
            this.AgregarBtn.TabIndex = 7;
            this.AgregarBtn.Text = "Agregar";
            this.AgregarBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AgregarBtn.Click += new System.EventHandler(this.AgregarBtn_Click);
            // 
            // SalirBtn
            // 
            this.SalirBtn.Location = new System.Drawing.Point(679, 567);
            this.SalirBtn.Name = "SalirBtn";
            this.SalirBtn.Size = new System.Drawing.Size(131, 121);
            this.SalirBtn.TabIndex = 4;
            this.SalirBtn.Text = "Salir";
            this.SalirBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SalirBtn.Click += new System.EventHandler(this.SalirBtn_Click);
            // 
            // descripcionTxt
            // 
            this.descripcionTxt.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.descripcionTxt.Location = new System.Drawing.Point(450, 153);
            this.descripcionTxt.Name = "descripcionTxt";
            this.descripcionTxt.Size = new System.Drawing.Size(202, 35);
            this.descripcionTxt.TabIndex = 8;
            this.descripcionTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // categoriaTxt
            // 
            this.categoriaTxt.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.categoriaTxt.Location = new System.Drawing.Point(450, 110);
            this.categoriaTxt.Name = "categoriaTxt";
            this.categoriaTxt.Size = new System.Drawing.Size(202, 35);
            this.categoriaTxt.TabIndex = 8;
            this.categoriaTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.categoriaTxt.Click += new System.EventHandler(this.metroTextBox2_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(288, 110);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(68, 20);
            this.metroLabel1.TabIndex = 10;
            this.metroLabel1.Text = "Categoría";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(288, 168);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(82, 20);
            this.metroLabel2.TabIndex = 10;
            this.metroLabel2.Text = "Descripción";
            this.metroLabel2.Click += new System.EventHandler(this.metroLabel2_Click);
            // 
            // dgvDatos
            // 
            this.dgvDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDatos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(24, 198);
            this.dgvDatos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 1);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.Size = new System.Drawing.Size(628, 483);
            this.dgvDatos.TabIndex = 11;
            this.dgvDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatos_CellContentClick);
            // 
            // CategoriasSqlServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 732);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.categoriaTxt);
            this.Controls.Add(this.descripcionTxt);
            this.Controls.Add(this.SalirBtn);
            this.Controls.Add(this.EliminarBtn);
            this.Controls.Add(this.CancelarBtn);
            this.Controls.Add(this.ModificarBtn);
            this.Controls.Add(this.AgregarBtn);
            this.Name = "CategoriasSqlServer";
            this.Text = "Categorías (SqlServer)";
            this.Load += new System.EventHandler(this.CategoriasSqlServer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile EliminarBtn;
        private MetroFramework.Controls.MetroTile CancelarBtn;
        private MetroFramework.Controls.MetroTile ModificarBtn;
        private MetroFramework.Controls.MetroTile AgregarBtn;
        private MetroFramework.Controls.MetroTile SalirBtn;
        private MetroFramework.Controls.MetroTextBox descripcionTxt;
        private MetroFramework.Controls.MetroTextBox categoriaTxt;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.DataGridView dgvDatos;
    }
}