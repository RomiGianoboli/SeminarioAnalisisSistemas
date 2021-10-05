﻿
namespace TPI_PAV.InterfacesDeUsuario.Clientes
{
    partial class FrmBajaCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBajaCliente));
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.CbBarrio = new System.Windows.Forms.ComboBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.GbEstado = new System.Windows.Forms.GroupBox();
            this.RbInactivo = new System.Windows.Forms.RadioButton();
            this.RbActivo = new System.Windows.Forms.RadioButton();
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblEmail = new System.Windows.Forms.Label();
            this.LblBarrio = new System.Windows.Forms.Label();
            this.GbEstado.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.FlatAppearance.BorderSize = 0;
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuardar.Image")));
            this.BtnGuardar.Location = new System.Drawing.Point(232, 260);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(75, 35);
            this.BtnGuardar.TabIndex = 0;
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.FlatAppearance.BorderSize = 0;
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Image = ((System.Drawing.Image)(resources.GetObject("BtnSalir.Image")));
            this.BtnSalir.Location = new System.Drawing.Point(284, 259);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(75, 35);
            this.BtnSalir.TabIndex = 1;
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(192, 53);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(167, 20);
            this.TxtNombre.TabIndex = 2;
            // 
            // CbBarrio
            // 
            this.CbBarrio.FormattingEnabled = true;
            this.CbBarrio.Location = new System.Drawing.Point(192, 91);
            this.CbBarrio.Name = "CbBarrio";
            this.CbBarrio.Size = new System.Drawing.Size(167, 21);
            this.CbBarrio.TabIndex = 3;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(192, 128);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(167, 20);
            this.TxtEmail.TabIndex = 4;
            // 
            // GbEstado
            // 
            this.GbEstado.Controls.Add(this.RbInactivo);
            this.GbEstado.Controls.Add(this.RbActivo);
            this.GbEstado.Location = new System.Drawing.Point(37, 154);
            this.GbEstado.Name = "GbEstado";
            this.GbEstado.Size = new System.Drawing.Size(200, 100);
            this.GbEstado.TabIndex = 5;
            this.GbEstado.TabStop = false;
            this.GbEstado.Text = "Estado";
            // 
            // RbInactivo
            // 
            this.RbInactivo.AutoSize = true;
            this.RbInactivo.Location = new System.Drawing.Point(97, 49);
            this.RbInactivo.Name = "RbInactivo";
            this.RbInactivo.Size = new System.Drawing.Size(63, 17);
            this.RbInactivo.TabIndex = 1;
            this.RbInactivo.TabStop = true;
            this.RbInactivo.Text = "Inactivo";
            this.RbInactivo.UseVisualStyleBackColor = true;
            // 
            // RbActivo
            // 
            this.RbActivo.AutoSize = true;
            this.RbActivo.Location = new System.Drawing.Point(22, 49);
            this.RbActivo.Name = "RbActivo";
            this.RbActivo.Size = new System.Drawing.Size(55, 17);
            this.RbActivo.TabIndex = 0;
            this.RbActivo.TabStop = true;
            this.RbActivo.Text = "Activo";
            this.RbActivo.UseVisualStyleBackColor = true;
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.Location = new System.Drawing.Point(34, 53);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(80, 17);
            this.LblNombre.TabIndex = 6;
            this.LblNombre.Text = "Nombre (*)";
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmail.Location = new System.Drawing.Point(34, 128);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(43, 17);
            this.LblEmail.TabIndex = 7;
            this.LblEmail.Text = "Email";
            // 
            // LblBarrio
            // 
            this.LblBarrio.AutoSize = true;
            this.LblBarrio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBarrio.Location = new System.Drawing.Point(34, 91);
            this.LblBarrio.Name = "LblBarrio";
            this.LblBarrio.Size = new System.Drawing.Size(63, 17);
            this.LblBarrio.TabIndex = 8;
            this.LblBarrio.Text = "Barrio (*)";
            // 
            // FrmBajaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.ClientSize = new System.Drawing.Size(394, 306);
            this.Controls.Add(this.LblBarrio);
            this.Controls.Add(this.LblEmail);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.GbEstado);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.CbBarrio);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnGuardar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBajaCliente";
            this.Text = "FrmBajaCliente";
            this.Load += new System.EventHandler(this.FrmBajaCliente_Load);
            this.GbEstado.ResumeLayout(false);
            this.GbEstado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.ComboBox CbBarrio;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.GroupBox GbEstado;
        private System.Windows.Forms.RadioButton RbInactivo;
        private System.Windows.Forms.RadioButton RbActivo;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.Label LblBarrio;
    }
}