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

namespace ProyectoFinalAplicada1_JohnsielCastanos.UI.Registros
{
    public partial class rCobro : Form
    {
        public rCobro()
        {
            InitializeComponent();
            LlenarComboBoxCliente();
            ClientecomboBox.Text = null;
        
        }

        private void LlenarComboBoxCliente()
        {
            RepositorioBase<Clientes> db = new RepositorioBase<Clientes>();
            var listado = new List<Clientes>();
            listado = db.GetList(p => true);
            ClientecomboBox.DataSource = listado;
            ClientecomboBox.DisplayMember = "Nombre";
            ClientecomboBox.ValueMember = "ClienteId";
        }

        private void LlenarComboBoxVenta()
        {
            RepositorioBase<Ventas> db = new RepositorioBase<Ventas>();
            var listado = new List<Ventas>();
            
          
            if (ClientecomboBox.SelectedValue != null)
            {
                string cliente = ClientecomboBox.SelectedValue.ToString();
                listado = db.GetList(p => p.ClienteId.ToString().Contains(cliente));
                VentacomboBox.DataSource = listado;
                VentacomboBox.DisplayMember = "VentasId";
                VentacomboBox.ValueMember = "VentasId";


            }
     
           

        }

        private void ClientecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            LlenarComboBoxVenta();
            
        }



        private void VentacomboBox_TextChanged(object sender, EventArgs e)
        {
            RepositorioBase<Ventas> db = new RepositorioBase<Ventas>();
            Ventas venta;
            if (db.Buscar(Convert.ToInt32(VentacomboBox.SelectedValue)) != null)
            {
                venta = db.Buscar(Convert.ToInt32(VentacomboBox.SelectedValue));
                MontoFacturatextBox.Text = venta.Balance.ToString();


            }
        }




        private void Limpiar()
        {

            CobroIdnumericUpDown.Value = 0;
            ClientecomboBox.Text = string.Empty;
            VentacomboBox.Text = string.Empty;
            MontoPagarnumericUpDown.Value = 0;
            MontoFacturatextBox.Text = string.Empty;
            BalancetextBox.Text = string.Empty;
            FechadateTimePicker.Value = DateTime.Now;
            VentaFechadateTimePicker.Value = DateTime.Now;

        }

        private Cobros LlenaClase()
        {
            Cobros cobro = new Cobros();
            cobro.CobroId = Convert.ToInt32(CobroIdnumericUpDown.Value);
            cobro.ClienteId = Convert.ToInt32(ClientecomboBox.SelectedValue);
            cobro.VentaId = Convert.ToInt32(VentacomboBox.SelectedValue);
            cobro.MontoPagado = Convert.ToDouble(MontoPagarnumericUpDown.Value);
            cobro.Observacion = ObservaciontextBox.Text;
            cobro.UsuarioId = 0;
            cobro.Fecha = FechadateTimePicker.Value;
            return cobro;

        }

        private void LlenaCampo(Cobros cobro)
        {
            CobroIdnumericUpDown.Value = cobro.CobroId;
            ClientecomboBox.SelectedValue = cobro.ClienteId;
            VentacomboBox.SelectedValue = cobro.VentaId;
            MontoPagarnumericUpDown.Value = Convert.ToDecimal( cobro.MontoPagado);
            ObservaciontextBox.Text = cobro.Observacion;
            FechadateTimePicker.Value = cobro.Fecha;
            RepositorioBase<Ventas> db = new RepositorioBase<Ventas>();
            Ventas venta;
            if(db.Buscar(cobro.VentaId) != null)
            {
                venta = db.Buscar(cobro.VentaId);
                MontoFacturatextBox.Text = venta.Balance.ToString();
            }

        }
        private bool ExisteEnLaBaseDeDatos()
        {
            RepositorioBase<Cobros> db = new RepositorioBase<Cobros>();
            Cobros producto = db.Buscar((int)CobroIdnumericUpDown.Value);
            return (producto != null);

        }

        private bool Validar()
        {
            RepositorioBase<Productos> db = new RepositorioBase<Productos>();

            bool paso = true;

            return paso;

        }



        private void DescripciontextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }


        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

 
        private void Guardarbutton_Click_1(object sender, EventArgs e)
        {
            
            Cobros cobro;
            bool paso = false;

            if (!Validar())
                return;

            cobro = LlenaClase();


            if (CobroIdnumericUpDown.Value == 0)
            {
                paso = CobroBLL.Guardar(cobro);
            }
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar un Cobro que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //paso = db.Modificar(cobro);

            }

            if (paso)
                MessageBox.Show("Guardado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No fue posible guardar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Limpiar();
        }

        private void Buscarbutton_Click_1(object sender, EventArgs e)
        {
            int id;
            RepositorioBase<Cobros> db = new RepositorioBase<Cobros>();
            Cobros cobro = new Cobros();

            int.TryParse(CobroIdnumericUpDown.Text, out id);
            Limpiar();

            cobro = db.Buscar(id);

            if (cobro != null)
            {

                LlenaCampo(cobro);

            }
            else
            {
                MessageBox.Show("Usuario no existe");
            }
        }

        private void Nuevobutton_Click_1(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Eliminarbutton_Click_1(object sender, EventArgs e)
        {
         
            try
            {
                if (CobroIdnumericUpDown.Value > 0)
                {
                    if (CobroBLL.Eliminar((int)CobroIdnumericUpDown.Value))
                    {
                        MessageBox.Show("Eliminado", "Atencion!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show("No se puede eliminar", "Atencion!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }

                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo eliminar", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
