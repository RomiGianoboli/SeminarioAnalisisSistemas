﻿
namespace TPI_PAV.InterfacesDeUsuario.Reportes
{
    partial class FrmProductosMasVendidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProductosMasVendidos));
            this.DtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.LblFechaDesde = new System.Windows.Forms.Label();
            this.DtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.LblFechaHasta = new System.Windows.Forms.Label();
            this.BtnConsultar = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.RwProducto = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // DtpFechaDesde
            // 
            this.DtpFechaDesde.CustomFormat = "dd-MM-yyyy";
            this.DtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpFechaDesde.Location = new System.Drawing.Point(108, 27);
            this.DtpFechaDesde.Name = "DtpFechaDesde";
            this.DtpFechaDesde.Size = new System.Drawing.Size(200, 20);
            this.DtpFechaDesde.TabIndex = 0;
            // 
            // LblFechaDesde
            // 
            this.LblFechaDesde.AutoSize = true;
            this.LblFechaDesde.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFechaDesde.Location = new System.Drawing.Point(13, 27);
            this.LblFechaDesde.Name = "LblFechaDesde";
            this.LblFechaDesde.Size = new System.Drawing.Size(98, 17);
            this.LblFechaDesde.TabIndex = 2;
            this.LblFechaDesde.Text = "Fecha desde: ";
            // 
            // DtpFechaHasta
            // 
            this.DtpFechaHasta.CustomFormat = "dd-MM-yyyy";
            this.DtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpFechaHasta.Location = new System.Drawing.Point(450, 26);
            this.DtpFechaHasta.Name = "DtpFechaHasta";
            this.DtpFechaHasta.Size = new System.Drawing.Size(200, 20);
            this.DtpFechaHasta.TabIndex = 3;
            // 
            // LblFechaHasta
            // 
            this.LblFechaHasta.AutoSize = true;
            this.LblFechaHasta.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFechaHasta.Location = new System.Drawing.Point(346, 27);
            this.LblFechaHasta.Name = "LblFechaHasta";
            this.LblFechaHasta.Size = new System.Drawing.Size(95, 17);
            this.LblFechaHasta.TabIndex = 4;
            this.LblFechaHasta.Text = "Fecha hasta: ";
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.BackColor = System.Drawing.Color.Silver;
            this.BtnConsultar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConsultar.Location = new System.Drawing.Point(564, 74);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Size = new System.Drawing.Size(86, 23);
            this.BtnConsultar.TabIndex = 5;
            this.BtnConsultar.Text = "Consultar";
            this.BtnConsultar.UseVisualStyleBackColor = false;
            this.BtnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.FlatAppearance.BorderSize = 0;
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Image = ((System.Drawing.Image)(resources.GetObject("BtnSalir.Image")));
            this.BtnSalir.Location = new System.Drawing.Point(712, 534);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(75, 38);
            this.BtnSalir.TabIndex = 7;
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // RwProducto
            // 
            this.RwProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.RwProducto.LocalReport.ReportEmbeddedResource = "TPI_PAV.InterfacesDeUsuario.Reportes.Productos.ReporteProducto.rdlc";
            this.RwProducto.Location = new System.Drawing.Point(16, 122);
            this.RwProducto.Name = "RwProducto";
            this.RwProducto.ServerReport.BearerToken = null;
            this.RwProducto.Size = new System.Drawing.Size(744, 406);
            this.RwProducto.TabIndex = 9;
            // 
            // FrmProductosMasVendidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.ClientSize = new System.Drawing.Size(808, 584);
            this.Controls.Add(this.RwProducto);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnConsultar);
            this.Controls.Add(this.LblFechaHasta);
            this.Controls.Add(this.DtpFechaHasta);
            this.Controls.Add(this.LblFechaDesde);
            this.Controls.Add(this.DtpFechaDesde);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmProductosMasVendidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmProductosMasVendidos";
            this.Load += new System.EventHandler(this.FrmProductosMasVendidos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DtpFechaDesde;
        private System.Windows.Forms.Label LblFechaDesde;
        private System.Windows.Forms.DateTimePicker DtpFechaHasta;
        private System.Windows.Forms.Label LblFechaHasta;
        private System.Windows.Forms.Button BtnConsultar;
        private System.Windows.Forms.Button BtnSalir;
        private Microsoft.Reporting.WinForms.ReportViewer RwProducto;
    }
}