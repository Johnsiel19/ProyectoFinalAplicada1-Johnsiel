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

namespace ProyectoFinalAplicada1_JohnsielCastanos.UI.Consultas
{
    public partial class cCobros : Form
    {
        public List<Cobros> ListaCobros;
        public cCobros()
        {
            InitializeComponent();
            CriteriotextBox.Text = "Todo";
        }

        private void Consultarbutton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Cobros> db = new RepositorioBase<Cobros>();
            var listado = new List<Cobros>();
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
                                listado = db.GetList(p => p.CobroId == id);
                                break;

                            case "UsuarioId":
                                int UsuarioId = Convert.ToInt32(CriteriotextBox.Text);
                                listado = db.GetList(p => p.UsuarioId == UsuarioId);
                                break;

                            case "VentaId":
                                int VentaId = Convert.ToInt32(CriteriotextBox.Text);
                                listado = db.GetList(p => p.VentaId == VentaId);
                                break;

                            case "Monto Pagado":
                                int MontoPagado = Convert.ToInt32(CriteriotextBox.Text);
                                listado = db.GetList(p => p.MontoPagado == MontoPagado);
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

                    ListaCobros = listado;
                    ConsultadataGridView.DataSource = ListaCobros;

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
                            listado = db.GetList(p => p.ClienteId == id);
                            break;

                        case "UsuarioId":
                            int UsuarioId = Convert.ToInt32(CriteriotextBox.Text);
                            listado = db.GetList(p => p.UsuarioId == UsuarioId);
                            break;

                        case "VentaId":
                            int VentaId = Convert.ToInt32(CriteriotextBox.Text);
                            listado = db.GetList(p => p.VentaId == VentaId);
                            break;

                        case "Monto Pagado":
                            int MontoPagado = Convert.ToInt32(CriteriotextBox.Text);
                            listado = db.GetList(p => p.MontoPagado == MontoPagado);
                            break;


                        default:
                            break;
                    }

                }
                else
                {
                    listado = db.GetList(p => true);
                }

                ListaCobros = listado;
                ConsultadataGridView.DataSource = ListaCobros;
            }
        }
    }
}
