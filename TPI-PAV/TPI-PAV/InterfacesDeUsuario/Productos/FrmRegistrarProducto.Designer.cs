
namespace TPI_PAV.InterfacesDeUsuario.Productos
{
    partial class FrmRegistrarProducto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistrarProducto));
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.LblNombre = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.LblFechaAlta = new System.Windows.Forms.Label();
            this.LblStock = new System.Windows.Forms.Label();
            this.LblPrecio = new System.Windows.Forms.Label();
            this.DtpFechaAlta = new System.Windows.Forms.DateTimePicker();
            this.TxtPrecio = new System.Windows.Forms.TextBox();
            this.TxtStock = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.FlatAppearance.BorderSize = 0;
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuardar.Image")));
            this.BtnGuardar.Location = new System.Drawing.Point(279, 202);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(75, 52);
            this.BtnGuardar.TabIndex = 0;
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.FlatAppearance.BorderSize = 0;
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Image = ((System.Drawing.Image)(resources.GetObject("BtnSalir.Image")));
            this.BtnSalir.Location = new System.Drawing.Point(333, 209);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(75, 39);
            this.BtnSalir.TabIndex = 1;
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.Location = new System.Drawing.Point(61, 44);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(80, 17);
            this.LblNombre.TabIndex = 2;
            this.LblNombre.Text = "Nombre (*)";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(222, 44);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(200, 20);
            this.TxtNombre.TabIndex = 3;
            // 
            // LblFechaAlta
            // 
            this.LblFechaAlta.AutoSize = true;
            this.LblFechaAlta.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFechaAlta.Location = new System.Drawing.Point(61, 154);
            this.LblFechaAlta.Name = "LblFechaAlta";
            this.LblFechaAlta.Size = new System.Drawing.Size(117, 17);
            this.LblFechaAlta.TabIndex = 4;
            this.LblFechaAlta.Text = "Fecha de alta (*)";
            // 
            // LblStock
            // 
            this.LblStock.AutoSize = true;
            this.LblStock.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblStock.Location = new System.Drawing.Point(61, 120);
            this.LblStock.Name = "LblStock";
            this.LblStock.Size = new System.Drawing.Size(62, 17);
            this.LblStock.TabIndex = 5;
            this.LblStock.Text = "Stock (*)";
            // 
            // LblPrecio
            // 
            this.LblPrecio.AutoSize = true;
            this.LblPrecio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrecio.Location = new System.Drawing.Point(61, 84);
            this.LblPrecio.Name = "LblPrecio";
            this.LblPrecio.Size = new System.Drawing.Size(67, 17);
            this.LblPrecio.TabIndex = 6;
            this.LblPrecio.Text = "Precio (*)";
            // 
            // DtpFechaAlta
            // 
            this.DtpFechaAlta.CustomFormat = "dd/MM/yyyy";
            this.DtpFechaAlta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpFechaAlta.Location = new System.Drawing.Point(222, 154);
            this.DtpFechaAlta.Name = "DtpFechaAlta";
            this.DtpFechaAlta.Size = new System.Drawing.Size(200, 20);
            this.DtpFechaAlta.TabIndex = 7;
            // 
            // TxtPrecio
            // 
            this.TxtPrecio.Location = new System.Drawing.Point(222, 81);
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.Size = new System.Drawing.Size(200, 20);
            this.TxtPrecio.TabIndex = 9;
            // 
            // TxtStock
            // 
            this.TxtStock.BackColor = System.Drawing.Color.White;
            this.TxtStock.Location = new System.Drawing.Point(222, 120);
            this.TxtStock.Name = "TxtStock";
            this.TxtStock.Size = new System.Drawing.Size(200, 20);
            this.TxtStock.TabIndex = 10;
            // 
            // FrmRegistrarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.ClientSize = new System.Drawing.Size(434, 271);
            this.Controls.Add(this.TxtStock);
            this.Controls.Add(this.TxtPrecio);
            this.Controls.Add(this.DtpFechaAlta);
            this.Controls.Add(this.LblPrecio);
            this.Controls.Add(this.LblStock);
            this.Controls.Add(this.LblFechaAlta);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnGuardar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRegistrarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRegistrarProducto";
            this.Load += new System.EventHandler(this.FrmRegistrarProducto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label LblFechaAlta;
        private System.Windows.Forms.Label LblStock;
        private System.Windows.Forms.Label LblPrecio;
        private System.Windows.Forms.DateTimePicker DtpFechaAlta;
        private System.Windows.Forms.TextBox TxtPrecio;
        private System.Windows.Forms.TextBox TxtStock;
    }
}