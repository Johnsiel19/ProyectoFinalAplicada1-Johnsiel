using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace ProyectoFinalAplicada1_JohnsielCastanos.UI.Reportes
{
    public partial class CobrosReporte : Form
    {
        public List<Cobros> ListaCobros;
        public CobrosReporte(List<Cobros> cobro)
        {
            this.ListaCobros = cobro;
            InitializeComponent();
        }

        private void CobrosReporte_Load(object sender, EventArgs e)
        {

            ListadoCobros ListadoCobros = new ListadoCobros();
            ListadoCobros.SetDataSource(ListaCobros);

            crystalReportViewer1.ReportSource = ListadoCobros;
            crystalReportViewer1.Refresh();

        }
    }
}
