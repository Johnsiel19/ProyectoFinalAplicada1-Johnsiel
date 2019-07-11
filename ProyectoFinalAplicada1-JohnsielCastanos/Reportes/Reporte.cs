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

namespace ProyectoFinalAplicada1_JohnsielCastanos.Reportes
{
    public partial class Reporte : Form
    {
        private List<Usuarios> ListaUsuarios;
        public Reporte(List<Usuarios> usuarios)
        {
            this.ListaUsuarios = usuarios;
            InitializeComponent();
        }

        private void CrystalReportViewer1_Load(object sender, EventArgs e)
        {
            Lista
        }
    }
}
