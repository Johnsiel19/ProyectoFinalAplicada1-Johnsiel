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

namespace ProyectoFinalAplicada1_JohnsielCastanos.UI.Consultas
{
    public partial class cVentas : Form
    {
        public List<Ventas> ListaVentas;
        public cVentas(int valor)
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
            RepositorioBase<Ventas> db = new RepositorioBase<Ventas>();
            var listado = new List<Ventas>();
            if (FiltroFecha.Checked == true)
            {
                try
                {
                    int Criterio=0;
                    if (CriteriotextBox.Text.Trim().Length > 0)
                    {
                        switch (FiltrocomboBox.Text)
                        {
                            case "Todo":
                                listado = db.GetList(p => true);
                                break;

                            case "Id":
                                Criterio = Convert.ToInt32(CriteriotextBox.Text);
                                listado = db.GetList(p => p.VentaId == Criterio);
                                break;
                            case "UsuarioId":
                                Criterio = Convert.ToInt32(CriteriotextBox.Text);
                                listado = db.GetList(p => p.UsuarioId == Criterio);
                                break;
                            case "Cliente":
                                Criterio = Convert.ToInt32(CriteriotextBox.Text);
                                listado = db.GetList(p => p.ClienteId == Criterio);
                                break;
                           
                            case "Balance":
                                Criterio = Convert.ToInt32(CriteriotextBox.Text);
                                listado = db.GetList(p => p.Balance == Criterio);
                                break;
                            case "Monto":
                                Criterio = Convert.ToInt32(CriteriotextBox.Text);
                                listado = db.GetList(p => p.Total == Criterio);
                                break;

                            case "Modo":
                                listado = db.GetList(p => p.Modo.Contains(CriteriotextBox.Text));
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

                    ListaVentas = listado;
                    ConsultadataGridView.DataSource = ListaVentas;

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
                    int Criterio = 0;
                    switch (FiltrocomboBox.Text)
                    {
                        case "Todo":
                            listado = db.GetList(p => true);
                            break;

                        case "Id":
                            Criterio = Convert.ToInt32(CriteriotextBox.Text);
                            listado = db.GetList(p => p.VentaId == Criterio);
                            break;
                        case "UsuarioId":
                            Criterio = Convert.ToInt32(CriteriotextBox.Text);
                            listado = db.GetList(p => p.UsuarioId == Criterio);
                            break;
                        case "Cliente":
                            Criterio = Convert.ToInt32(CriteriotextBox.Text);
                            listado = db.GetList(p => p.ClienteId == Criterio);
                            break;

                        case "Balance":
                            Criterio = Convert.ToInt32(CriteriotextBox.Text);
                            listado = db.GetList(p => p.Balance == Criterio);
                            break;
                        case "Monto":
                            Criterio = Convert.ToInt32(CriteriotextBox.Text);
                            listado = db.GetList(p => p.Total == Criterio);
                            break;

                        case "Modo":
                            listado = db.GetList(p => p.Modo.Contains(CriteriotextBox.Text));
                            break;

                        default:
                            break;
                    }
                   
                }
                else
                {
                    listado = db.GetList(p => true);
                }

                ListaVentas = listado;
                ConsultadataGridView.DataSource = ListaVentas;
            }

        }

  
        private void CriteriotextBox_TextChanged(object sender, EventArgs e)
        {
            Consultarbutton_Click(sender, e);
        }

        private void CVentas_Load(object sender, EventArgs e)
        {
            Consultarbutton.PerformClick();
        }

        private void Imprimirbutton_Click(object sender, EventArgs e)
        {

        }

        private void Elegirbutton_Click(object sender, EventArgs e)
        {
            
            if (ConsultadataGridView.CurrentRow.Cells["VentasId"] != null)
            {
                idElegido = Convert.ToInt32(ConsultadataGridView.CurrentRow.Cells["VentaId"].Value.ToString());
                Close();
            }
            else
            {

                MessageBox.Show("Elija una Venta");

            }
        }
        public int idElegido;
    }
}
