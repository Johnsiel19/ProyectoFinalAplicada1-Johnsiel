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
using ProyectoFinalAplicada1_JohnsielCastanos.Consultas;
using ProyectoFinalAplicada1_JohnsielCastanos.UI.Reportes;

namespace ProyectoFinalAplicada1_JohnsielCastanos.Reportes
{
    public partial class UsuarioReport : Form
    {
        private List<Usuarios> ListaUsuarios;
        public UsuarioReport(List<Usuarios> usuarios)
        {
            this.ListaUsuarios = usuarios;
            InitializeComponent();
        }


        private void Reporte_Load(object sender, EventArgs e)
        {
            ListadoUsuarios listadoUsuarios = new ListadoUsuarios();
            listadoUsuarios.SetDataSource(ListaUsuarios);

            crystalReportViewer1.ReportSource = listadoUsuarios;
            crystalReportViewer1.Refresh();
        }
    }
}
