using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Entidades;
using ProyectoFinalAplicada1_JohnsielCastanos.Reportes;

namespace ProyectoFinalAplicada1_JohnsielCastanos.Consultas
{
    public partial class cUsuario : Form
    {
        public List<Usuarios> ListaUsuarios;
        public cUsuario()
        {
            InitializeComponent();
        }

        private void Consultarbutton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Usuarios> db = new RepositorioBase<Usuarios>();
            var listado = new List<Usuarios>();

            if (CriteriotextBox.Text.Trim().Length > 0)
            {
                switch (FiltrocomboBox.Text)
                {
                    case "Todo":
                        listado = db.GetList(p => true);
                        break;

                    case "Id":
                        int id = Convert.ToInt32(CriteriotextBox.Text);
                        listado = db.GetList(p => p.UsuarioId == id);
                        break;

                    case "Nombre":
                        listado = db.GetList(p => p.Nombre.Contains(CriteriotextBox.Text));
                        break;

                    case "Usuario":
                        listado = db.GetList(p => p.Usuario.Contains(CriteriotextBox.Text));
                        break;
                    default:
                        break;
                }
                listado = listado.Where(c => c.FechaIngreso.Date >= DesdedateTimePicker.Value.Date && c.FechaIngreso.Date <= HastadateTimePicker.Value.Date).ToList();
            }
            else
            {
                listado = db.GetList(p => true);
            }

            ListaUsuarios = listado;
            ConsultadataGridView.DataSource = ListaUsuarios;

            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (ListaUsuarios.Count == 0)
            {
                MessageBox.Show("No hay Datos Para Imprimir");
                return;
            }
            Reporte reporte = new Reporte(ListaUsuarios);
            reporte.ShowDialog();
            
        }
    }
}
