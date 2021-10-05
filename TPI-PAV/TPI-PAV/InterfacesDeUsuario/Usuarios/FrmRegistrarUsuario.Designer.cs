
namespace TPI_PAV.InterfacesDeUsuario.Usuarios
{
    partial class FrmRegistrarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistrarUsuario));
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblEmail = new System.Windows.Forms.Label();
            this.LblContrasenia2 = new System.Windows.Forms.Label();
            this.LblContrasenia = new System.Windows.Forms.Label();
            this.LblPerfil = new System.Windows.Forms.Label();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtRePassword = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.CbPerfil = new System.Windows.Forms.ComboBox();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.Location = new System.Drawing.Point(42, 53);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(80, 17);
            this.LblNombre.TabIndex = 6;
            this.LblNombre.Text = "Nombre (*)";
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmail.Location = new System.Drawing.Point(42, 194);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(51, 17);
            this.LblEmail.TabIndex = 13;
            this.LblEmail.Text = "Email: ";
            // 
            // LblContrasenia2
            // 
            this.LblContrasenia2.AutoSize = true;
            this.LblContrasenia2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblContrasenia2.Location = new System.Drawing.Point(42, 159);
            this.LblContrasenia2.Name = "LblContrasenia2";
            this.LblContrasenia2.Size = new System.Drawing.Size(149, 17);
            this.LblContrasenia2.TabIndex = 12;
            this.LblContrasenia2.Text = "Repetir contraseña (*)";
            // 
            // LblContrasenia
            // 
            this.LblContrasenia.AutoSize = true;
            this.LblContrasenia.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblContrasenia.Location = new System.Drawing.Point(42, 124);
            this.LblContrasenia.Name = "LblContrasenia";
            this.LblContrasenia.Size = new System.Drawing.Size(94, 17);
            this.LblContrasenia.TabIndex = 11;
            this.LblContrasenia.Text = "Contrseña (*)";
            // 
            // LblPerfil
            // 
            this.LblPerfil.AutoSize = true;
            this.LblPerfil.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPerfil.Location = new System.Drawing.Point(42, 87);
            this.LblPerfil.Name = "LblPerfil";
            this.LblPerfil.Size = new System.Drawing.Size(57, 17);
            this.LblPerfil.TabIndex = 10;
            this.LblPerfil.Text = "Perfil (*)";
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(209, 126);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.PasswordChar = '*';
            this.TxtPassword.Size = new System.Drawing.Size(218, 20);
            this.TxtPassword.TabIndex = 18;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(209, 196);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(218, 20);
            this.TxtEmail.TabIndex = 17;
            // 
            // TxtRePassword
            // 
            this.TxtRePassword.Location = new System.Drawing.Point(209, 161);
            this.TxtRePassword.Name = "TxtRePassword";
            this.TxtRePassword.PasswordChar = '*';
            this.TxtRePassword.Size = new System.Drawing.Size(218, 20);
            this.TxtRePassword.TabIndex = 16;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(209, 53);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(218, 20);
            this.TxtNombre.TabIndex = 15;
            // 
            // CbPerfil
            // 
            this.CbPerfil.FormattingEnabled = true;
            this.CbPerfil.Location = new System.Drawing.Point(209, 87);
            this.CbPerfil.Name = "CbPerfil";
            this.CbPerfil.Size = new System.Drawing.Size(218, 21);
            this.CbPerfil.TabIndex = 22;
            this.CbPerfil.SelectedIndexChanged += new System.EventHandler(this.CbPerfil_SelectedIndexChanged);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.FlatAppearance.BorderSize = 0;
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuardar.Image")));
            this.BtnGuardar.Location = new System.Drawing.Point(254, 275);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(75, 23);
            this.BtnGuardar.TabIndex = 23;
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.FlatAppearance.BorderSize = 0;
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Image = ((System.Drawing.Image)(resources.GetObject("BtnSalir.Image")));
            this.BtnSalir.Location = new System.Drawing.Point(324, 275);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(75, 23);
            this.BtnSalir.TabIndex = 24;
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // FrmRegistrarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.ClientSize = new System.Drawing.Size(439, 320);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.CbPerfil);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.TxtRePassword);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.LblEmail);
            this.Controls.Add(this.LblContrasenia2);
            this.Controls.Add(this.LblContrasenia);
            this.Controls.Add(this.LblPerfil);
            this.Controls.Add(this.LblNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRegistrarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRegistrarUsuario";
            this.Load += new System.EventHandler(this.FrmRegistrarUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.Label LblContrasenia2;
        private System.Windows.Forms.Label LblContrasenia;
        private System.Windows.Forms.Label LblPerfil;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.TextBox TxtRePassword;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.ComboBox CbPerfil;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnSalir;
    }
}