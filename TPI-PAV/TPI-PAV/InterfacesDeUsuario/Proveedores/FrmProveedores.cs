﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPI_PAV.InterfacesDeUsuario.Proveedores
{
    public partial class FrmProveedores : Form
    {
        private Principal principal;
        public FrmProveedores(Principal _principal)
        {
            principal = _principal;
            InitializeComponent();
        }

        private void FrmProveedores_Load(object sender, EventArgs e)
        {

        }
    }
}
