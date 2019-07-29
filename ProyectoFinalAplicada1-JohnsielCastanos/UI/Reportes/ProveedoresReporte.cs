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
    public partial class ProveedoresReporte : Form
    {
        public List<Proveedores> ListaProveesores;
        public ProveedoresReporte(List<Proveedores> proveedor) 
        {
            this.ListaProveesores = proveedor;
            InitializeComponent();
        }

        private void ProveedoresReporte_Load(object sender, EventArgs e)
        {
            ListadoProveesores listadoProveedores = new ListadoProveesores();
            listadoProveedores.SetDataSource(ListaProveesores);

            crystalReportViewer1.ReportSource = listadoProveedores;
            crystalReportViewer1.Refresh();
        }
    }
    
}
