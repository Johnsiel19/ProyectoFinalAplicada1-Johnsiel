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
    public partial class ProductosReporte : Form
    {
        public List<Productos> ListaProducto;
        public ProductosReporte(List<Productos> producto)
        {
            this.ListaProducto = producto;
            InitializeComponent();
        }

        private void ProductosReporte_Load(object sender, EventArgs e)
        {
            ListadoProductos listadoProductos = new ListadoProductos();
            listadoProductos.SetDataSource(ListaProducto);

            crystalReportProductos.ReportSource = listadoProductos;
            crystalReportProductos.Refresh();
        }
    }
}
