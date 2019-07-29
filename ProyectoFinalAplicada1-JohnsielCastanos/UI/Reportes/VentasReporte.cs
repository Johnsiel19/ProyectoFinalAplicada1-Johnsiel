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
    public partial class VentasReporte : Form
    {
        public List<Ventas> ListaVentas;
        public VentasReporte(List<Ventas> venta)
        {
            this.ListaVentas = venta;
            InitializeComponent();
        }

        private void VentaReporte_Load(object sender, EventArgs e)
        {
            ListadoVentas ListadoVentas = new ListadoVentas();
            ListadoVentas.SetDataSource(ListaVentas);

            crystalReportViewer1.ReportSource = ListadoVentas;
            crystalReportViewer1.Refresh();
        }
    }
}
