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

namespace ProyectoFinalAplicada1_JohnsielCastanos.UI.Consultas
{
    public partial class cProveedores : Form
    {
        public List<Proveedores> ListaProveedores;
        public cProveedores()
        {
            InitializeComponent();
        }

        private void Consultarbutton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Proveedores> db = new RepositorioBase<Proveedores>();
            var listado = new List<Proveedores>();
            if (FiltroFecha.Checked == true)
            {
                int criterio;
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
                                criterio = Convert.ToInt32(CriteriotextBox.Text);
                                listado = db.GetList(p => p.ProveedorId == criterio);
                                break;

                            case "UsuarioId":
                                criterio = Convert.ToInt32(CriteriotextBox.Text);
                                listado = db.GetList(p => p.UsuarioId == criterio);
                                break;

                            case "Nombre":
                                listado = db.GetList(p => p.Nombre.Contains(CriteriotextBox.Text));
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

                    ListaProveedores = listado;
                    ConsultadataGridView.DataSource = ListaProveedores;

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
                    int criterio;
                    switch (FiltrocomboBox.Text)
                    {
                        case "Todo":
                            listado = db.GetList(p => true);
                            break;

                        case "Id":
                            criterio = Convert.ToInt32(CriteriotextBox.Text);
                            listado = db.GetList(p => p.ProveedorId == criterio);
                            break;

                        case "UsuarioId":
                            criterio = Convert.ToInt32(CriteriotextBox.Text);
                            listado = db.GetList(p => p.UsuarioId == criterio);
                            break;

                        case "Nombre":
                            listado = db.GetList(p => p.Nombre.Contains(CriteriotextBox.Text));
                            break;

                        default:
                            break;
                    }

                }
                else
                {
                    listado = db.GetList(p => true);
                }

                ListaProveedores = listado;
                ConsultadataGridView.DataSource = ListaProveedores;
            }
        }

        private void Consultarbutton_TextChanged(object sender, EventArgs e)
        {
            Consultarbutton_Click(sender, e);
        }
    }
}