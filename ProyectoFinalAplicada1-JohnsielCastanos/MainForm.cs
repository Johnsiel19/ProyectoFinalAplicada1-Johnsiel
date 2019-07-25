﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoFinalAplicada1_JohnsielCastanos.Registros;
using ProyectoFinalAplicada1_JohnsielCastanos.Consultas;
using ProyectoFinalAplicada1_JohnsielCastanos.UI.Registros;
using ProyectoFinalAplicada1_JohnsielCastanos.UI.Consultas;

namespace ProyectoFinalAplicada1_JohnsielCastanos
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void UsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rUsuario frm = new rUsuario();
            frm.Show();

        }

        private void UsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cUsuario frm = new cUsuario();
            frm.Show();
        }

        private void ClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rCliente frm = new rCliente();
            frm.Show();
        }

        private void ProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rProducto frm = new rProducto();
            frm.Show();
            
        }

        private void ProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rProveedor frm = new rProveedor();
            frm.Show();
            
        }

        private void VentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rVentas frm = new rVentas();
            frm.Show();
        }

        private void CobroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rCobro frm = new rCobro();
            frm.Show();
        }

        private void ClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cCliente frm = new cCliente();
            frm.Show();
        }

        private void UsuariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cProductos frm = new cProductos(0);
            frm.Show();
        }

        private void VentasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cVentas frm = new cVentas();
            frm.Show();
        }

        private void ProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cProveedores frm = new cProveedores();
            frm.Show();
        }
    }
}
