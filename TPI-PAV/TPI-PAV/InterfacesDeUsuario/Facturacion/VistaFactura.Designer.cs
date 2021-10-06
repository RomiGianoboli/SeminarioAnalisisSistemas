
namespace TPI_PAV.InterfacesDeUsuario
{
    partial class VistaFactura
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
            this.LblNumeroFactura = new System.Windows.Forms.Label();
            this.TxtNumeroFactura = new System.Windows.Forms.TextBox();
            this.Cliente = new System.Windows.Forms.Label();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.CbCliente = new System.Windows.Forms.ComboBox();
            this.LblPrecio = new System.Windows.Forms.Label();
            this.LblCantidad = new System.Windows.Forms.Label();
            this.LblProducto = new System.Windows.Forms.Label();
            this.TxtCantidad = new System.Windows.Forms.TextBox();
            this.TxtPrecio = new System.Windows.Forms.TextBox();
            this.LblTotal = new System.Windows.Forms.Label();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.BtnGenerarFactura = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.CbProducto = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.TxtFechaAlta = new System.Windows.Forms.Label();
            this.DtpFechaAlta = new System.Windows.Forms.DateTimePicker();
            this.DgvDetalle = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // LblNumeroFactura
            // 
            this.LblNumeroFactura.AutoSize = true;
            this.LblNumeroFactura.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNumeroFactura.Location = new System.Drawing.Point(33, 35);
            this.LblNumeroFactura.Name = "LblNumeroFactura";
            this.LblNumeroFactura.Size = new System.Drawing.Size(136, 17);
            this.LblNumeroFactura.TabIndex = 0;
            this.LblNumeroFactura.Text = "Numero de factura:";
            // 
            // TxtNumeroFactura
            // 
            this.TxtNumeroFactura.Location = new System.Drawing.Point(177, 35);
            this.TxtNumeroFactura.Name = "TxtNumeroFactura";
            this.TxtNumeroFactura.ReadOnly = true;
            this.TxtNumeroFactura.Size = new System.Drawing.Size(200, 20);
            this.TxtNumeroFactura.TabIndex = 1;
            // 
            // Cliente
            // 
            this.Cliente.AutoSize = true;
            this.Cliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cliente.Location = new System.Drawing.Point(392, 36);
            this.Cliente.Name = "Cliente";
            this.Cliente.Size = new System.Drawing.Size(58, 17);
            this.Cliente.TabIndex = 3;
            this.Cliente.Text = "Cliente:";
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsuario.Location = new System.Drawing.Point(12, 389);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(58, 17);
            this.LblUsuario.TabIndex = 6;
            this.LblUsuario.Text = "Usuario:";
            this.LblUsuario.Click += new System.EventHandler(this.LblUsuario_Click);
            // 
            // CbCliente
            // 
            this.CbCliente.FormattingEnabled = true;
            this.CbCliente.Location = new System.Drawing.Point(500, 34);
            this.CbCliente.Name = "CbCliente";
            this.CbCliente.Size = new System.Drawing.Size(200, 21);
            this.CbCliente.TabIndex = 8;
            // 
            // LblPrecio
            // 
            this.LblPrecio.AutoSize = true;
            this.LblPrecio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrecio.Location = new System.Drawing.Point(33, 105);
            this.LblPrecio.Name = "LblPrecio";
            this.LblPrecio.Size = new System.Drawing.Size(52, 17);
            this.LblPrecio.TabIndex = 9;
            this.LblPrecio.Text = "Precio:";
            // 
            // LblCantidad
            // 
            this.LblCantidad.AutoSize = true;
            this.LblCantidad.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCantidad.Location = new System.Drawing.Point(392, 77);
            this.LblCantidad.Name = "LblCantidad";
            this.LblCantidad.Size = new System.Drawing.Size(75, 17);
            this.LblCantidad.TabIndex = 10;
            this.LblCantidad.Text = "Cantidad:";
            // 
            // LblProducto
            // 
            this.LblProducto.AutoSize = true;
            this.LblProducto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProducto.Location = new System.Drawing.Point(33, 70);
            this.LblProducto.Name = "LblProducto";
            this.LblProducto.Size = new System.Drawing.Size(72, 17);
            this.LblProducto.TabIndex = 11;
            this.LblProducto.Text = "Producto:";
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Location = new System.Drawing.Point(500, 70);
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(200, 20);
            this.TxtCantidad.TabIndex = 12;
            // 
            // TxtPrecio
            // 
            this.TxtPrecio.Location = new System.Drawing.Point(177, 104);
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.Size = new System.Drawing.Size(200, 20);
            this.TxtPrecio.TabIndex = 13;
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotal.Location = new System.Drawing.Point(510, 353);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(43, 17);
            this.LblTotal.TabIndex = 16;
            this.LblTotal.Text = "Total:";
            // 
            // TxtTotal
            // 
            this.TxtTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxtTotal.Location = new System.Drawing.Point(559, 350);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.ReadOnly = true;
            this.TxtTotal.Size = new System.Drawing.Size(107, 20);
            this.TxtTotal.TabIndex = 17;
            // 
            // BtnGenerarFactura
            // 
            this.BtnGenerarFactura.BackColor = System.Drawing.Color.Silver;
            this.BtnGenerarFactura.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGenerarFactura.Location = new System.Drawing.Point(470, 402);
            this.BtnGenerarFactura.Name = "BtnGenerarFactura";
            this.BtnGenerarFactura.Size = new System.Drawing.Size(142, 23);
            this.BtnGenerarFactura.TabIndex = 18;
            this.BtnGenerarFactura.Text = "Generar factura";
            this.BtnGenerarFactura.UseVisualStyleBackColor = false;
            this.BtnGenerarFactura.Click += new System.EventHandler(this.BtnGenerarFactura_Click_1);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.Silver;
            this.BtnAgregar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.ForeColor = System.Drawing.Color.Black;
            this.BtnAgregar.Location = new System.Drawing.Point(558, 141);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(142, 30);
            this.BtnAgregar.TabIndex = 19;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.BackColor = System.Drawing.Color.Olive;
            this.TxtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtUsuario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsuario.Location = new System.Drawing.Point(69, 389);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.ReadOnly = true;
            this.TxtUsuario.Size = new System.Drawing.Size(172, 16);
            this.TxtUsuario.TabIndex = 20;
            // 
            // CbProducto
            // 
            this.CbProducto.FormattingEnabled = true;
            this.CbProducto.Location = new System.Drawing.Point(177, 71);
            this.CbProducto.Name = "CbProducto";
            this.CbProducto.Size = new System.Drawing.Size(200, 21);
            this.CbProducto.TabIndex = 21;
            this.CbProducto.SelectedIndexChanged += new System.EventHandler(this.CbProducto_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(625, 402);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TxtFechaAlta
            // 
            this.TxtFechaAlta.AutoSize = true;
            this.TxtFechaAlta.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFechaAlta.Location = new System.Drawing.Point(392, 107);
            this.TxtFechaAlta.Name = "TxtFechaAlta";
            this.TxtFechaAlta.Size = new System.Drawing.Size(102, 17);
            this.TxtFechaAlta.TabIndex = 23;
            this.TxtFechaAlta.Text = "Fecha de alta:";
            // 
            // DtpFechaAlta
            // 
            this.DtpFechaAlta.CustomFormat = "dd-MM-yyyy";
            this.DtpFechaAlta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpFechaAlta.Location = new System.Drawing.Point(500, 104);
            this.DtpFechaAlta.MinDate = new System.DateTime(1960, 1, 1, 0, 0, 0, 0);
            this.DtpFechaAlta.Name = "DtpFechaAlta";
            this.DtpFechaAlta.Size = new System.Drawing.Size(200, 20);
            this.DtpFechaAlta.TabIndex = 24;
            // 
            // DgvDetalle
            // 
            this.DgvDetalle.AllowUserToAddRows = false;
            this.DgvDetalle.AllowUserToDeleteRows = false;
            this.DgvDetalle.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.DgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Producto,
            this.Precio,
            this.Cantidad,
            this.Total});
            this.DgvDetalle.Location = new System.Drawing.Point(69, 190);
            this.DgvDetalle.MultiSelect = false;
            this.DgvDetalle.Name = "DgvDetalle";
            this.DgvDetalle.ReadOnly = true;
            this.DgvDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvDetalle.Size = new System.Drawing.Size(598, 150);
            this.DgvDetalle.TabIndex = 25;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // Producto
            // 
            this.Producto.DataPropertyName = "NombreProducto";
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            this.Producto.Width = 140;
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "Precio";
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Width = 140;
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "Cantidad";
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 140;
            // 
            // Total
            // 
            this.Total.DataPropertyName = "Total";
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 140;
            // 
            // VistaFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.ClientSize = new System.Drawing.Size(721, 437);
            this.Controls.Add(this.DgvDetalle);
            this.Controls.Add(this.DtpFechaAlta);
            this.Controls.Add(this.TxtFechaAlta);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CbProducto);
            this.Controls.Add(this.TxtUsuario);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.BtnGenerarFactura);
            this.Controls.Add(this.TxtTotal);
            this.Controls.Add(this.LblTotal);
            this.Controls.Add(this.TxtPrecio);
            this.Controls.Add(this.TxtCantidad);
            this.Controls.Add(this.LblProducto);
            this.Controls.Add(this.LblCantidad);
            this.Controls.Add(this.LblPrecio);
            this.Controls.Add(this.CbCliente);
            this.Controls.Add(this.LblUsuario);
            this.Controls.Add(this.Cliente);
            this.Controls.Add(this.TxtNumeroFactura);
            this.Controls.Add(this.LblNumeroFactura);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VistaFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VistaFactura";
            this.Load += new System.EventHandler(this.VistaFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblNumeroFactura;
        private System.Windows.Forms.TextBox TxtNumeroFactura;
        private System.Windows.Forms.Label Cliente;
        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.ComboBox CbCliente;
        private System.Windows.Forms.Label LblPrecio;
        private System.Windows.Forms.Label LblCantidad;
        private System.Windows.Forms.Label LblProducto;
        private System.Windows.Forms.TextBox TxtCantidad;
        private System.Windows.Forms.TextBox TxtPrecio;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.TextBox TxtTotal;
        private System.Windows.Forms.Button BtnGenerarFactura;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.ComboBox CbProducto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label TxtFechaAlta;
        private System.Windows.Forms.DateTimePicker DtpFechaAlta;
        private System.Windows.Forms.DataGridView DgvDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}