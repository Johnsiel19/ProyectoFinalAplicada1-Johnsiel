using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalAplicada1_JohnsielCastanos.UI.Reportes
{
    public partial class ClientesReporte : Form
    {
        public List<Clientes> ListaClientes;
        public ClientesReporte(List<Clientes> cliente)
        {
            this.ListaClientes = cliente;
            InitializeComponent();
        }

        private void ClientesReporte_Load(object sender, EventArgs e)
        {
            ListadoClientes listadoCliente = new ListadoClientes();
            listadoCliente.SetDataSource(ListaClientes);

            crystalReportViewer1.ReportSource = listadoCliente;
            crystalReportViewer1.Refresh();
        }
    }
}
