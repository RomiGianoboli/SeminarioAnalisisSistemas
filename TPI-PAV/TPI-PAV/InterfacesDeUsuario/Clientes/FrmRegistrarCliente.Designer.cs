
namespace TPI_PAV.InterfacesDeUsuario.Clientes
{
    partial class FrmRegistrarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistrarCliente));
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.LblNombre = new System.Windows.Forms.Label();
            this.CbBarrio = new System.Windows.Forms.ComboBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.LblFechaAlta = new System.Windows.Forms.Label();
            this.LblNumero = new System.Windows.Forms.Label();
            this.LblCalle = new System.Windows.Forms.Label();
            this.LblBarrio = new System.Windows.Forms.Label();
            this.LblEmail = new System.Windows.Forms.Label();
            this.TxtNumero = new System.Windows.Forms.TextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtCalle = new System.Windows.Forms.TextBox();
            this.DtpFechaAlta = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.FlatAppearance.BorderSize = 0;
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuardar.Image")));
            this.BtnGuardar.Location = new System.Drawing.Point(211, 283);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(75, 36);
            this.BtnGuardar.TabIndex = 0;
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.FlatAppearance.BorderSize = 0;
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Image = ((System.Drawing.Image)(resources.GetObject("BtnSalir.Image")));
            this.BtnSalir.Location = new System.Drawing.Point(264, 282);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(75, 38);
            this.BtnSalir.TabIndex = 1;
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.Location = new System.Drawing.Point(40, 50);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(80, 17);
            this.LblNombre.TabIndex = 2;
            this.LblNombre.Text = "Nombre (*)";
            // 
            // CbBarrio
            // 
            this.CbBarrio.FormattingEnabled = true;
            this.CbBarrio.Location = new System.Drawing.Point(165, 88);
            this.CbBarrio.Name = "CbBarrio";
            this.CbBarrio.Size = new System.Drawing.Size(198, 21);
            this.CbBarrio.TabIndex = 3;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(165, 50);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(198, 20);
            this.TxtNombre.TabIndex = 4;
            // 
            // LblFechaAlta
            // 
            this.LblFechaAlta.AutoSize = true;
            this.LblFechaAlta.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFechaAlta.Location = new System.Drawing.Point(40, 195);
            this.LblFechaAlta.Name = "LblFechaAlta";
            this.LblFechaAlta.Size = new System.Drawing.Size(118, 17);
            this.LblFechaAlta.TabIndex = 5;
            this.LblFechaAlta.Text = "Fecha De Alta (*)";
            // 
            // LblNumero
            // 
            this.LblNumero.AutoSize = true;
            this.LblNumero.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNumero.Location = new System.Drawing.Point(40, 161);
            this.LblNumero.Name = "LblNumero";
            this.LblNumero.Size = new System.Drawing.Size(79, 17);
            this.LblNumero.TabIndex = 6;
            this.LblNumero.Text = "Número (*)";
            // 
            // LblCalle
            // 
            this.LblCalle.AutoSize = true;
            this.LblCalle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCalle.Location = new System.Drawing.Point(40, 123);
            this.LblCalle.Name = "LblCalle";
            this.LblCalle.Size = new System.Drawing.Size(61, 17);
            this.LblCalle.TabIndex = 7;
            this.LblCalle.Text = "Calle (*)";
            // 
            // LblBarrio
            // 
            this.LblBarrio.AutoSize = true;
            this.LblBarrio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBarrio.Location = new System.Drawing.Point(40, 88);
            this.LblBarrio.Name = "LblBarrio";
            this.LblBarrio.Size = new System.Drawing.Size(63, 17);
            this.LblBarrio.TabIndex = 8;
            this.LblBarrio.Text = "Barrio (*)";
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmail.Location = new System.Drawing.Point(40, 233);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(43, 17);
            this.LblEmail.TabIndex = 9;
            this.LblEmail.Text = "Email";
            // 
            // TxtNumero
            // 
            this.TxtNumero.Location = new System.Drawing.Point(165, 161);
            this.TxtNumero.Name = "TxtNumero";
            this.TxtNumero.Size = new System.Drawing.Size(198, 20);
            this.TxtNumero.TabIndex = 10;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(164, 232);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(199, 20);
            this.TxtEmail.TabIndex = 11;
            // 
            // TxtCalle
            // 
            this.TxtCalle.Location = new System.Drawing.Point(165, 123);
            this.TxtCalle.Name = "TxtCalle";
            this.TxtCalle.Size = new System.Drawing.Size(198, 20);
            this.TxtCalle.TabIndex = 13;
            // 
            // DtpFechaAlta
            // 
            this.DtpFechaAlta.CustomFormat = "dd-MM-yyyy";
            this.DtpFechaAlta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpFechaAlta.Location = new System.Drawing.Point(165, 195);
            this.DtpFechaAlta.Name = "DtpFechaAlta";
            this.DtpFechaAlta.Size = new System.Drawing.Size(198, 20);
            this.DtpFechaAlta.TabIndex = 14;
            // 
            // FrmRegistrarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.ClientSize = new System.Drawing.Size(391, 339);
            this.Controls.Add(this.DtpFechaAlta);
            this.Controls.Add(this.TxtCalle);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.TxtNumero);
            this.Controls.Add(this.LblEmail);
            this.Controls.Add(this.LblBarrio);
            this.Controls.Add(this.LblCalle);
            this.Controls.Add(this.LblNumero);
            this.Controls.Add(this.LblFechaAlta);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.CbBarrio);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnGuardar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRegistrarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRegistrarCliente";
            this.Load += new System.EventHandler(this.FrmRegistrarCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.ComboBox CbBarrio;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label LblFechaAlta;
        private System.Windows.Forms.Label LblNumero;
        private System.Windows.Forms.Label LblCalle;
        private System.Windows.Forms.Label LblBarrio;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.TextBox TxtNumero;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.TextBox TxtCalle;
        private System.Windows.Forms.DateTimePicker DtpFechaAlta;
    }
}