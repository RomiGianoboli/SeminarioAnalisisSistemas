﻿
namespace TPI_PAV
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.FrmReportes = new System.Windows.Forms.Button();
            this.BtnUsuario = new System.Windows.Forms.Button();
            this.BtnClientes = new System.Windows.Forms.Button();
            this.BtnFacturacion = new System.Windows.Forms.Button();
            this.BtnProductos = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.IconoMinimizar = new System.Windows.Forms.PictureBox();
            this.IconoRestaurar = new System.Windows.Forms.PictureBox();
            this.IconoMaximizar = new System.Windows.Forms.PictureBox();
            this.IconoCerrar = new System.Windows.Forms.PictureBox();
            this.txtHora = new System.Windows.Forms.Timer(this.components);
            this.txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconoMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconoRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconoMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconoCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Olive;
            this.panel1.Controls.Add(this.FrmReportes);
            this.panel1.Controls.Add(this.BtnUsuario);
            this.panel1.Controls.Add(this.BtnClientes);
            this.panel1.Controls.Add(this.BtnFacturacion);
            this.panel1.Controls.Add(this.BtnProductos);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 748);
            this.panel1.TabIndex = 0;
            // 
            // FrmReportes
            // 
            this.FrmReportes.FlatAppearance.BorderSize = 0;
            this.FrmReportes.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FrmReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FrmReportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FrmReportes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FrmReportes.Image = ((System.Drawing.Image)(resources.GetObject("FrmReportes.Image")));
            this.FrmReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FrmReportes.Location = new System.Drawing.Point(-2, 528);
            this.FrmReportes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FrmReportes.Name = "FrmReportes";
            this.FrmReportes.Size = new System.Drawing.Size(260, 54);
            this.FrmReportes.TabIndex = 7;
            this.FrmReportes.Text = "     Reporte Productos";
            this.FrmReportes.UseVisualStyleBackColor = true;
            this.FrmReportes.Click += new System.EventHandler(this.FrmReportes_Click);
            // 
            // BtnUsuario
            // 
            this.BtnUsuario.FlatAppearance.BorderSize = 0;
            this.BtnUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnUsuario.Image = ((System.Drawing.Image)(resources.GetObject("BtnUsuario.Image")));
            this.BtnUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnUsuario.Location = new System.Drawing.Point(0, 275);
            this.BtnUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnUsuario.Name = "BtnUsuario";
            this.BtnUsuario.Size = new System.Drawing.Size(258, 54);
            this.BtnUsuario.TabIndex = 6;
            this.BtnUsuario.Text = "     Usuarios";
            this.BtnUsuario.UseVisualStyleBackColor = true;
            this.BtnUsuario.Click += new System.EventHandler(this.BtnUsuario_Click);
            // 
            // BtnClientes
            // 
            this.BtnClientes.FlatAppearance.BorderSize = 0;
            this.BtnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClientes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnClientes.Image = ((System.Drawing.Image)(resources.GetObject("BtnClientes.Image")));
            this.BtnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnClientes.Location = new System.Drawing.Point(-2, 402);
            this.BtnClientes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnClientes.Name = "BtnClientes";
            this.BtnClientes.Size = new System.Drawing.Size(260, 54);
            this.BtnClientes.TabIndex = 3;
            this.BtnClientes.Text = "Clientes";
            this.BtnClientes.UseVisualStyleBackColor = true;
            this.BtnClientes.Click += new System.EventHandler(this.BtnClientes_Click);
            // 
            // BtnFacturacion
            // 
            this.BtnFacturacion.FlatAppearance.BorderSize = 0;
            this.BtnFacturacion.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnFacturacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFacturacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFacturacion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnFacturacion.Image = ((System.Drawing.Image)(resources.GetObject("BtnFacturacion.Image")));
            this.BtnFacturacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnFacturacion.Location = new System.Drawing.Point(4, 338);
            this.BtnFacturacion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnFacturacion.Name = "BtnFacturacion";
            this.BtnFacturacion.Size = new System.Drawing.Size(254, 54);
            this.BtnFacturacion.TabIndex = 2;
            this.BtnFacturacion.Text = "        Facturación";
            this.BtnFacturacion.UseVisualStyleBackColor = true;
            this.BtnFacturacion.Click += new System.EventHandler(this.BtnFacturacion_Click);
            // 
            // BtnProductos
            // 
            this.BtnProductos.FlatAppearance.BorderSize = 0;
            this.BtnProductos.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProductos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnProductos.Image = ((System.Drawing.Image)(resources.GetObject("BtnProductos.Image")));
            this.BtnProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnProductos.Location = new System.Drawing.Point(-2, 465);
            this.BtnProductos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnProductos.Name = "BtnProductos";
            this.BtnProductos.Size = new System.Drawing.Size(252, 54);
            this.BtnProductos.TabIndex = 1;
            this.BtnProductos.Text = "      Productos";
            this.BtnProductos.UseVisualStyleBackColor = true;
            this.BtnProductos.Click += new System.EventHandler(this.BtnProductos_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(63, 89);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.IconoMinimizar);
            this.panel2.Controls.Add(this.IconoRestaurar);
            this.panel2.Controls.Add(this.IconoMaximizar);
            this.panel2.Controls.Add(this.IconoCerrar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(258, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(690, 89);
            this.panel2.TabIndex = 1;
            // 
            // IconoMinimizar
            // 
            this.IconoMinimizar.AccessibleName = "IconoMinimizar";
            this.IconoMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IconoMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IconoMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("IconoMinimizar.Image")));
            this.IconoMinimizar.Location = new System.Drawing.Point(554, 0);
            this.IconoMinimizar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.IconoMinimizar.Name = "IconoMinimizar";
            this.IconoMinimizar.Size = new System.Drawing.Size(48, 49);
            this.IconoMinimizar.TabIndex = 2;
            this.IconoMinimizar.TabStop = false;
            this.IconoMinimizar.Click += new System.EventHandler(this.IconoMinimizar_Click);
            // 
            // IconoRestaurar
            // 
            this.IconoRestaurar.AccessibleName = "IconoRestaurar";
            this.IconoRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IconoRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("IconoRestaurar.Image")));
            this.IconoRestaurar.Location = new System.Drawing.Point(598, 0);
            this.IconoRestaurar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.IconoRestaurar.Name = "IconoRestaurar";
            this.IconoRestaurar.Size = new System.Drawing.Size(48, 49);
            this.IconoRestaurar.TabIndex = 3;
            this.IconoRestaurar.TabStop = false;
            this.IconoRestaurar.Click += new System.EventHandler(this.IconoRestaurar_Click);
            // 
            // IconoMaximizar
            // 
            this.IconoMaximizar.AccessibleName = "IconoMaximizar";
            this.IconoMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IconoMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IconoMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("IconoMaximizar.Image")));
            this.IconoMaximizar.Location = new System.Drawing.Point(598, 0);
            this.IconoMaximizar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.IconoMaximizar.Name = "IconoMaximizar";
            this.IconoMaximizar.Size = new System.Drawing.Size(32, 32);
            this.IconoMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.IconoMaximizar.TabIndex = 1;
            this.IconoMaximizar.TabStop = false;
            this.IconoMaximizar.Click += new System.EventHandler(this.IconoMaximizar_Click);
            // 
            // IconoCerrar
            // 
            this.IconoCerrar.AccessibleName = "IconoCerrar";
            this.IconoCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IconoCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IconoCerrar.Image = ((System.Drawing.Image)(resources.GetObject("IconoCerrar.Image")));
            this.IconoCerrar.Location = new System.Drawing.Point(642, 0);
            this.IconoCerrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.IconoCerrar.Name = "IconoCerrar";
            this.IconoCerrar.Size = new System.Drawing.Size(48, 49);
            this.IconoCerrar.TabIndex = 0;
            this.IconoCerrar.TabStop = false;
            this.IconoCerrar.Click += new System.EventHandler(this.IconoCerrar_Click);
            // 
            // txtHora
            // 
            this.txtHora.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txt
            // 
            this.txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt.BackColor = System.Drawing.Color.Olive;
            this.txt.Location = new System.Drawing.Point(798, 98);
            this.txt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(148, 26);
            this.txt.TabIndex = 2;
            this.txt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(717, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hora:";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 748);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Principal_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconoMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconoRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconoMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconoCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox IconoMinimizar;
        private System.Windows.Forms.PictureBox IconoMaximizar;
        private System.Windows.Forms.PictureBox IconoCerrar;
        private System.Windows.Forms.PictureBox IconoRestaurar;
        private System.Windows.Forms.Button BtnProductos;
        private System.Windows.Forms.Button BtnUsuario;
        private System.Windows.Forms.Button BtnClientes;
        private System.Windows.Forms.Button BtnFacturacion;
        private System.Windows.Forms.Button FrmReportes;
        private System.Windows.Forms.Timer txtHora;
        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.Label label1;
    }
}

