using BLL;
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
using ProyectoFinalAplicada1_JohnsielCastanos.UI.Reportes;

namespace ProyectoFinalAplicada1_JohnsielCastanos.UI.Consultas
{
    public partial class cEntradas : Form
    {
        public List<Entradas> ListaEntradas;
        public cEntradas(int valor)
        {
            InitializeComponent();
            FiltrocomboBox.Text = "Todo";

            if (valor == 1)
            {

                Elegirbutton.Visible = true;
                Imprimirbutton.Visible = false;

            }


        }

        private void Consultarbutton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Entradas> db = new RepositorioBase<Entradas>();
            var listado = new List<Entradas>();
            if (FiltroFecha.Checked == true)
            {
                try
                {
                    if (CriteriotextBox.Text.Trim().Length > 0)
                    {
                        switch (FiltrocomboBox.Text)
                        {
                            case "Todo":
                                listado = db.GetList(p => true);
                                break;

                            case "Id":
                                int id = Convert.ToInt32(CriteriotextBox.Text);
                                listado = db.GetList(p => p.EntradaId == id);
                                break;

                            case "UsuarioId":
                                int UsuarioId = Convert.ToInt32(CriteriotextBox.Text);
                                listado = db.GetList(p => p.UsuarioId == UsuarioId);
                                break;

                            case "ProductoId":
                                int ProductoId = Convert.ToInt32(CriteriotextBox.Text);
                                listado = db.GetList(p => p.ProductoId == ProductoId);
                                break;

                            case "Entrada":
                                int Entrada = Convert.ToInt32(CriteriotextBox.Text);
                                listado = db.GetList(p => p.Entrada == Entrada);
                                break;




                            default:
                                break;
                        }
                        listado = listado.Where(c => c.Fecha.Date >= DesdedateTimePicker.Value.Date && c.Fecha.Date <= HastadateTimePicker.Value.Date).ToList();
                    }
                    else
                    {

                        listado = db.GetList(p => true);
                        listado = listado.Where(c => c.Fecha.Date >= DesdedateTimePicker.Value.Date && c.Fecha.Date <= HastadateTimePicker.Value.Date).ToList();
                    }

                    ListaEntradas = listado;
                    ConsultadataGridView.DataSource = ListaEntradas;

                }
                catch (Exception)
                {
                    MessageBox.Show("Introdujo un dato incorrecto");

                }


            }
            else
            {
                if (CriteriotextBox.Text.Trim().Length > 0)
                {
                    switch (FiltrocomboBox.Text)
                    {
                        case "Todo":
                            listado = db.GetList(p => true);
                            break;

                        case "Id":
                            int id = Convert.ToInt32(CriteriotextBox.Text);
                            listado = db.GetList(p => p.EntradaId == id);
                            break;

                        case "UsuarioId":
                            int UsuarioId = Convert.ToInt32(CriteriotextBox.Text);
                            listado = db.GetList(p => p.UsuarioId == UsuarioId);
                            break;

                        case "ProductoId":
                            int ProductoId = Convert.ToInt32(CriteriotextBox.Text);
                            listado = db.GetList(p => p.ProductoId == ProductoId);
                            break;

                        case "Entrada":
                            int Entrada = Convert.ToInt32(CriteriotextBox.Text);
                            listado = db.GetList(p => p.Entrada == Entrada);
                            break;


                        default:
                            break;
                    }

                }
                else
                {
                    listado = db.GetList(p => true);
                }

                ListaEntradas = listado;
                ConsultadataGridView.DataSource = ListaEntradas;
            }
        }

        private void CEntradas_Load(object sender, EventArgs e)
        {
            Consultarbutton.PerformClick();
        }

        private void CriteriotextBox_TextChanged(object sender, EventArgs e)
        {
            Consultarbutton.PerformClick();
        }

        private void Elegirbutton_Click(object sender, EventArgs e)
        {
            
            if (ConsultadataGridView.CurrentRow.Cells["EntradaId"] != null)
            {
                CodigoEntrada = Convert.ToInt32(ConsultadataGridView.CurrentRow.Cells["EntradaId"].Value.ToString());
                Close();
            }
            else
            {

                MessageBox.Show("Elija una entrada");

            }
           
        }
        public int CodigoEntrada;

        private void Imprimirbutton_Click(object sender, EventArgs e)
        {
            if (ConsultadataGridView.RowCount == 0)
            {
                MessageBox.Show("No hay Datos Para Imprimir");
                return;
            }
            else
            {
                EntradasReporte reporte = new EntradasReporte(ListaEntradas);
                reporte.ShowDialog();
            }

        }
    }
}
