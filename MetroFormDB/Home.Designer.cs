namespace MetroFormDB {
    partial class Home {
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
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.FbBtn = new MetroFramework.Controls.MetroTile();
            this.MySqlBtn = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // SalirBtn
            // 
            this.SalirBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.SalirBtn.CustomBackground = true;
            this.SalirBtn.CustomForeColor = true;
            this.SalirBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SalirBtn.Location = new System.Drawing.Point(630, 518);
            this.SalirBtn.Name = "SalirBtn";
            this.SalirBtn.Size = new System.Drawing.Size(118, 64);
            this.SalirBtn.TabIndex = 5;
            this.SalirBtn.Text = "Salir";
            this.SalirBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SalirBtn.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.SalirBtn.Click += new System.EventHandler(this.SalirBtn_Click);
            // 
            // metroTile2
            // 
            this.metroTile2.BackColor = System.Drawing.Color.White;
            this.metroTile2.CustomBackground = true;
            this.metroTile2.Location = new System.Drawing.Point(10, 128);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(436, 284);
            this.metroTile2.TabIndex = 2;
            this.metroTile2.Text = "metroTile1";
            this.metroTile2.TileImage = global::MetroFormDB.Properties.Resources.logo_mssql;
            this.metroTile2.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile2.UseTileImage = true;
            this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // FbBtn
            // 
            this.FbBtn.CustomBackground = true;
            this.FbBtn.Location = new System.Drawing.Point(991, 66);
            this.FbBtn.Name = "FbBtn";
            this.FbBtn.Size = new System.Drawing.Size(337, 374);
            this.FbBtn.TabIndex = 3;
            this.FbBtn.Text = "metroTile1";
            this.FbBtn.TileImage = global::MetroFormDB.Properties.Resources.Logo_FirebirdSQL_svg;
            this.FbBtn.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FbBtn.UseTileImage = true;
            this.FbBtn.Click += new System.EventHandler(this.FbBtn_Click);
            // 
            // MySqlBtn
            // 
            this.MySqlBtn.CustomBackground = true;
            this.MySqlBtn.Location = new System.Drawing.Point(408, 66);
            this.MySqlBtn.Name = "MySqlBtn";
            this.MySqlBtn.Size = new System.Drawing.Size(588, 378);
            this.MySqlBtn.TabIndex = 4;
            this.MySqlBtn.Text = "metroTile1";
            this.MySqlBtn.TileImage = global::MetroFormDB.Properties.Resources.MySQL_Logo;
            this.MySqlBtn.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MySqlBtn.UseTileImage = true;
            this.MySqlBtn.Click += new System.EventHandler(this.MySqlBtn_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1339, 655);
            this.Controls.Add(this.SalirBtn);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.FbBtn);
            this.Controls.Add(this.MySqlBtn);
            this.Name = "Home";
            this.Text = "Elija una base de datos";
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile SalirBtn;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile FbBtn;
        private MetroFramework.Controls.MetroTile MySqlBtn;
    }
}