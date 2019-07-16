using System;
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
    }
}
