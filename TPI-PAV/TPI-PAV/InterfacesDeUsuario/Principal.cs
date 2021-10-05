﻿using System;
using System.Windows.Forms;
using TPI_PAV.Entidades;
using TPI_PAV.InterfacesDeUsuario;
using TPI_PAV.InterfacesDeUsuario.Productos;
using TPI_PAV.InterfacesDeUsuario.Proveedores;
using TPI_PAV.InterfacesDeUsuario.Usuarios;
using TPI_PAV.Servicios;

namespace TPI_PAV
{
    public partial class Principal : Form
    {
        private Usuario usuarioLogueado;
        public Principal()
        {
            var frmLogin = new FrmLogin();
            frmLogin.ShowDialog();
            usuarioLogueado = UsuariosServicio.UsuarioLogueado;
            InitializeComponent();
        }
        private void Principal_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnUsuario_Click(object sender, EventArgs e)
        {
            var frmUsuarios = new FrmUsuarios();
            frmUsuarios.Show();
            
        }

        private void BtnProductos_Click(object sender, EventArgs e)
        {
            var frmProductos = new FrmProductos();
            frmProductos.Show();
        }
        private void BtnProveedores_Click(object sender, EventArgs e)
        {
            var frmProveedores = new FrmProveedores(this);
            frmProveedores.Show();
        }


        private void BtnClientes_Click(object sender, EventArgs e)
        {
            var frmCliente = new FrmCliente(this);
            frmCliente.Show();
        }


        private void IconoCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void IconoMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            IconoRestaurar.Visible = true;
            IconoMaximizar.Visible = false;
            
        }

        private void IconoMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void IconoRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            IconoRestaurar.Visible = false;
            IconoMaximizar.Visible = true;

        }

        private void BtnCompras_Click(object sender, EventArgs e)
        {

        }

        private void BtnFacturacion_Click(object sender, EventArgs e)
        {
            var frmFactura = new VistaFactura();
            frmFactura.ShowDialog();
        }
    }
}
