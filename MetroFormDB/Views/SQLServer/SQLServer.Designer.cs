namespace MetroFormDB {
    partial class SQLServer {
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
            this.ProductosBtn = new MetroFramework.Controls.MetroTile();
            this.CategoriasBtn = new MetroFramework.Controls.MetroTile();
            this.ProveedoresBtn = new MetroFramework.Controls.MetroTile();
            this.SalirBtn = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // ProductosBtn
            // 
            this.ProductosBtn.Location = new System.Drawing.Point(385, 221);
            this.ProductosBtn.Name = "ProductosBtn";
            this.ProductosBtn.Size = new System.Drawing.Size(131, 121);
            this.ProductosBtn.TabIndex = 0;
            this.ProductosBtn.Text = "Productos";
            this.ProductosBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ProductosBtn.Click += new System.EventHandler(this.ProductosBtn_Click);
            // 
            // CategoriasBtn
            // 
            this.CategoriasBtn.Location = new System.Drawing.Point(522, 221);
            this.CategoriasBtn.Name = "CategoriasBtn";
            this.CategoriasBtn.Size = new System.Drawing.Size(131, 121);
            this.CategoriasBtn.TabIndex = 0;
            this.CategoriasBtn.Text = "Categorías";
            this.CategoriasBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CategoriasBtn.Click += new System.EventHandler(this.CategoriasBtn_Click);
            // 
            // ProveedoresBtn
            // 
            this.ProveedoresBtn.Location = new System.Drawing.Point(659, 221);
            this.ProveedoresBtn.Name = "ProveedoresBtn";
            this.ProveedoresBtn.Size = new System.Drawing.Size(131, 121);
            this.ProveedoresBtn.TabIndex = 0;
            this.ProveedoresBtn.Text = "Proveedores";
            this.ProveedoresBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ProveedoresBtn.Click += new System.EventHandler(this.ProveedoresBtn_Click);
            // 
            // SalirBtn
            // 
            this.SalirBtn.Location = new System.Drawing.Point(796, 221);
            this.SalirBtn.Name = "SalirBtn";
            this.SalirBtn.Size = new System.Drawing.Size(131, 121);
            this.SalirBtn.TabIndex = 0;
            this.SalirBtn.Text = "Salir";
            this.SalirBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SalirBtn.Click += new System.EventHandler(this.SalirBtn_Click);
            // 
            // SQLServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1339, 655);
            this.Controls.Add(this.SalirBtn);
            this.Controls.Add(this.ProveedoresBtn);
            this.Controls.Add(this.CategoriasBtn);
            this.Controls.Add(this.ProductosBtn);
            this.Name = "SQLServer";
            this.Text = "SQLServer";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile ProductosBtn;
        private MetroFramework.Controls.MetroTile CategoriasBtn;
        private MetroFramework.Controls.MetroTile ProveedoresBtn;
        private MetroFramework.Controls.MetroTile SalirBtn;
    }
}