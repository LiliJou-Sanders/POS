namespace pos
{
    partial class titulo
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Nombre = new System.Windows.Forms.Label();
            this.dataGridproductos = new System.Windows.Forms.DataGridView();
            this.Desarrollado = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.time = new System.Windows.Forms.Timer(this.components);
            this.FechaHora = new System.Windows.Forms.Label();
            this.LblTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridproductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre.Location = new System.Drawing.Point(344, 49);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(177, 28);
            this.Nombre.TabIndex = 0;
            this.Nombre.Text = "Punto de Venta";
            // 
            // dataGridproductos
            // 
            this.dataGridproductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridproductos.Location = new System.Drawing.Point(321, 211);
            this.dataGridproductos.Name = "dataGridproductos";
            this.dataGridproductos.RowHeadersVisible = false;
            this.dataGridproductos.Size = new System.Drawing.Size(184, 95);
            this.dataGridproductos.TabIndex = 1;
            // 
            // Desarrollado
            // 
            this.Desarrollado.AutoSize = true;
            this.Desarrollado.Location = new System.Drawing.Point(343, 95);
            this.Desarrollado.Name = "Desarrollado";
            this.Desarrollado.Size = new System.Drawing.Size(140, 13);
            this.Desarrollado.TabIndex = 3;
            this.Desarrollado.Text = "Desarrollado por: Lilibombon";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::pos.Properties.Resources.yo;
            this.pictureBoxLogo.Location = new System.Drawing.Point(696, 12);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(69, 47);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 4;
            this.pictureBoxLogo.TabStop = false;
            // 
            // txtcodigo
            // 
            this.txtcodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigo.Location = new System.Drawing.Point(74, 267);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(170, 35);
            this.txtcodigo.TabIndex = 5;
            this.txtcodigo.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtcodigo_PreviewKeyDown);
            // 
            // time
            // 
            this.time.Enabled = true;
            this.time.Interval = 1000;
            this.time.Tick += new System.EventHandler(this.time_Tick);
            // 
            // FechaHora
            // 
            this.FechaHora.AutoSize = true;
            this.FechaHora.Location = new System.Drawing.Point(387, 126);
            this.FechaHora.Name = "FechaHora";
            this.FechaHora.Size = new System.Drawing.Size(60, 13);
            this.FechaHora.TabIndex = 6;
            this.FechaHora.Text = "FechaHora";
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotal.Location = new System.Drawing.Point(605, 135);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(83, 16);
            this.LblTotal.TabIndex = 7;
            this.LblTotal.Text = "Total $0.00";
            // 
            // titulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblTotal);
            this.Controls.Add(this.FechaHora);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.Desarrollado);
            this.Controls.Add(this.dataGridproductos);
            this.Controls.Add(this.Nombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "titulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Punto de Venta Lilibombon";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.titulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridproductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.DataGridView dataGridproductos;
        private System.Windows.Forms.Label Desarrollado;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Timer time;
        private System.Windows.Forms.Label FechaHora;
        private System.Windows.Forms.Label LblTotal;
    }
}

