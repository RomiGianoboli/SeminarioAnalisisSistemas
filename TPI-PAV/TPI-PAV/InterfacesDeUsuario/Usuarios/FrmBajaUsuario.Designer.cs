
namespace TPI_PAV.InterfacesDeUsuario.Usuarios
{
    partial class FrmBajaUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBajaUsuario));
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.CbPerfil = new System.Windows.Forms.ComboBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.GbEstado = new System.Windows.Forms.GroupBox();
            this.LblNombre = new System.Windows.Forms.Label();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.LblEmail = new System.Windows.Forms.Label();
            this.LblPerfil = new System.Windows.Forms.Label();
            this.RbActivo = new System.Windows.Forms.RadioButton();
            this.RbInactivo = new System.Windows.Forms.RadioButton();
            this.GbEstado.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(189, 39);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(138, 20);
            this.TxtNombre.TabIndex = 0;
            // 
            // CbPerfil
            // 
            this.CbPerfil.FormattingEnabled = true;
            this.CbPerfil.Location = new System.Drawing.Point(189, 83);
            this.CbPerfil.Name = "CbPerfil";
            this.CbPerfil.Size = new System.Drawing.Size(138, 21);
            this.CbPerfil.TabIndex = 1;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(189, 130);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(138, 20);
            this.TxtEmail.TabIndex = 2;
            // 
            // GbEstado
            // 
            this.GbEstado.Controls.Add(this.RbInactivo);
            this.GbEstado.Controls.Add(this.RbActivo);
            this.GbEstado.Location = new System.Drawing.Point(29, 167);
            this.GbEstado.Name = "GbEstado";
            this.GbEstado.Size = new System.Drawing.Size(200, 100);
            this.GbEstado.TabIndex = 3;
            this.GbEstado.TabStop = false;
            this.GbEstado.Text = "Estado";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.Location = new System.Drawing.Point(26, 39);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(80, 17);
            this.LblNombre.TabIndex = 4;
            this.LblNombre.Text = "Nombre (*)";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.FlatAppearance.BorderSize = 0;
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuardar.Image")));
            this.BtnGuardar.Location = new System.Drawing.Point(212, 273);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(75, 39);
            this.BtnGuardar.TabIndex = 5;
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.FlatAppearance.BorderSize = 0;
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Image = ((System.Drawing.Image)(resources.GetObject("BtnSalir.Image")));
            this.BtnSalir.Location = new System.Drawing.Point(265, 273);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(75, 39);
            this.BtnSalir.TabIndex = 6;
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmail.Location = new System.Drawing.Point(26, 130);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(43, 17);
            this.LblEmail.TabIndex = 7;
            this.LblEmail.Text = "Email";
            // 
            // LblPerfil
            // 
            this.LblPerfil.AutoSize = true;
            this.LblPerfil.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPerfil.Location = new System.Drawing.Point(26, 83);
            this.LblPerfil.Name = "LblPerfil";
            this.LblPerfil.Size = new System.Drawing.Size(57, 17);
            this.LblPerfil.TabIndex = 8;
            this.LblPerfil.Text = "Perfil (*)";
            // 
            // RbActivo
            // 
            this.RbActivo.AutoSize = true;
            this.RbActivo.Location = new System.Drawing.Point(7, 45);
            this.RbActivo.Name = "RbActivo";
            this.RbActivo.Size = new System.Drawing.Size(55, 17);
            this.RbActivo.TabIndex = 0;
            this.RbActivo.TabStop = true;
            this.RbActivo.Text = "Activo";
            this.RbActivo.UseVisualStyleBackColor = true;
            // 
            // RbInactivo
            // 
            this.RbInactivo.AutoSize = true;
            this.RbInactivo.Location = new System.Drawing.Point(98, 45);
            this.RbInactivo.Name = "RbInactivo";
            this.RbInactivo.Size = new System.Drawing.Size(63, 17);
            this.RbInactivo.TabIndex = 1;
            this.RbInactivo.TabStop = true;
            this.RbInactivo.Text = "Inactivo";
            this.RbInactivo.UseVisualStyleBackColor = true;
            // 
            // FrmBajaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.ClientSize = new System.Drawing.Size(362, 324);
            this.Controls.Add(this.LblPerfil);
            this.Controls.Add(this.LblEmail);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.GbEstado);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.CbPerfil);
            this.Controls.Add(this.TxtNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBajaUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBajaUsuario";
            this.Load += new System.EventHandler(this.FrmBajaUsuario_Load);
            this.GbEstado.ResumeLayout(false);
            this.GbEstado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.ComboBox CbPerfil;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.GroupBox GbEstado;
        private System.Windows.Forms.RadioButton RbInactivo;
        private System.Windows.Forms.RadioButton RbActivo;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.Label LblPerfil;
    }
}