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
    public partial class EntradasReporte : Form
    {
        public List<Entradas> ListaEntradas;
        public EntradasReporte(List<Entradas> entrada)
        {
            this.ListaEntradas = entrada;
            InitializeComponent();
        }

        private void EntradasReporte_Load(object sender, EventArgs e)
        {
            ListadoEntradas listadoEntradas = new ListadoEntradas();
            listadoEntradas.SetDataSource(ListaEntradas);

            crystalReportViewer1.ReportSource = listadoEntradas;
            crystalReportViewer1.Refresh();
        }
    }
}
