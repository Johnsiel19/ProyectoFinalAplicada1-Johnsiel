﻿using System;
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
using ProyectoFinalAplicada1_JohnsielCastanos.Reportes;
using ProyectoFinalAplicada1_JohnsielCastanos.UI.Reportes;

namespace ProyectoFinalAplicada1_JohnsielCastanos.UI.Consultas
{
    public partial class cProductos : Form
    {
        public List<Productos> listaProductos;
        public cProductos(int valor)
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

                    listaProductos = listado;
                    ConsultadataGridView.DataSource = listaProductos;

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
                    
                }
                else
                {
                    listado = db.GetList(p => true);
                }

                listaProductos = listado;
                ConsultadataGridView.DataSource = listaProductos;
            }
        }

  

        private void Elegirbutton_Click(object sender, EventArgs e)
        {

         
               if (ConsultadataGridView.CurrentRow.Cells["ProductoId"] != null)
              {
                  codigoProducto = Convert.ToInt32(ConsultadataGridView.CurrentRow.Cells["ProductoId"].Value.ToString());
                  Close();
              }
              else
              {

                  MessageBox.Show("Elija un Producto");

              }
        }
        public int codigoProducto;

        private void CriteriotextBox_TextChanged(object sender, EventArgs e)
        {
            Consultarbutton_Click(sender, e);
        }

        private void Imprimirbutton_Click(object sender, EventArgs e)
        {
            if (ConsultadataGridView.RowCount == 0)
            {
                MessageBox.Show("No hay Datos Para Imprimir");
                return;
            }
            else
            {
                ProductosReporte reporte = new ProductosReporte(listaProductos);
                reporte.ShowDialog();
            }

             
    }

        private void CProductos_Load(object sender, EventArgs e)
        {
            Consultarbutton.PerformClick();
        }

        private void Consultarbutton_TextChanged(object sender, EventArgs e)
        {
            Consultarbutton.PerformClick();
        }
    }
}
