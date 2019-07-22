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
using BLL;

namespace ProyectoFinalAplicada1_JohnsielCastanos.UI.Consultas
{
    public partial class cProductos : Form
    {
        public List<Productos> ListaClientes;
        public cProductos()
        {
            InitializeComponent();
            CriteriotextBox.Text = null;
        }

        private void Consultarbutton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Productos> db = new RepositorioBase<Productos>();
            var listado = new List<Productos>();
            if (FiltroFecha.Checked == true)
            {
                try
                {
                    if (CriteriotextBox.Text.Trim().Length > 0)
                    {
                        int Criterio= 0;
                        switch (FiltrocomboBox.Text)
                        {
                            
                            case "Todo":
                                listado = db.GetList(p => true);
                                break;

                            case "Id":
                                Criterio= Convert.ToInt32(CriteriotextBox.Text);
                                listado = db.GetList(p => p.ProductoId == Criterio);
                                break;

                            case "UsuarioId":
                                Criterio = Convert.ToInt32(CriteriotextBox.Text);
                                listado = db.GetList(p => p.UsuarioId == Criterio);
                                break;

                            case "Descripcion":
                                listado = db.GetList(p => p.Descripcion.Contains(CriteriotextBox.Text));
                                break;
                    
                            case "ProveesorId":
                                Criterio = Convert.ToInt32(CriteriotextBox.Text);
                                listado = db.GetList(p => p.ProveedorId == Criterio);
                                break;

                            case "Costo":
                                Criterio = Convert.ToInt32(CriteriotextBox.Text);
                                listado = db.GetList(p => p.Costo == Criterio);
                                break;

                            case "Precio":
                                Criterio = Convert.ToInt32(CriteriotextBox.Text);
                                listado = db.GetList(p => p.Precio == Criterio);
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

                    ListaClientes = listado;
                    ConsultadataGridView.DataSource = ListaClientes;

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
                            listado = db.GetList(p => p.ProductoId == Criterio);
                            break;

                        case "UsuarioId":
                            Criterio = Convert.ToInt32(CriteriotextBox.Text);
                            listado = db.GetList(p => p.UsuarioId == Criterio);
                            break;

                        case "Descripcion":
                            listado = db.GetList(p => p.Descripcion.Contains(CriteriotextBox.Text));
                            break;

                        case "ProveesorId":
                            Criterio = Convert.ToInt32(CriteriotextBox.Text);
                            listado = db.GetList(p => p.ProveedorId == Criterio);
                            break;

                        case "Costo":
                            Criterio = Convert.ToInt32(CriteriotextBox.Text);
                            listado = db.GetList(p => p.Costo == Criterio);
                            break;

                        case "Precio":
                            Criterio = Convert.ToInt32(CriteriotextBox.Text);
                            listado = db.GetList(p => p.Precio == Criterio);
                            break;

                        default:
                            break;
                    }
                    listado = listado.Where(c => c.Fecha.Date >= DesdedateTimePicker.Value.Date && c.Fecha.Date <= HastadateTimePicker.Value.Date).ToList();
                }
                else
                {
                    listado = db.GetList(p => true);
                }

                ListaClientes = listado;
                ConsultadataGridView.DataSource = ListaClientes;
            }
        }

        private void Consultarbutton_TextChanged(object sender, EventArgs e)
        {
            Consultarbutton_Click(sender, e);
        }
    }
}
