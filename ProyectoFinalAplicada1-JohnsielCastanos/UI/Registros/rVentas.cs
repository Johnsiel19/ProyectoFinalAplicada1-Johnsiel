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
    public partial class rVentas : Form
    {

        public List<VentasDetalle> Detalle;
        public rVentas()
        {
            InitializeComponent();
            LlenarComboBoxCliente();
            LlenarComboBoxProducto();
            Detalle = new List<VentasDetalle>();
            FuncionDeInicio();
          
        }

        private void FuncionDeInicio()
        {
            ProductocomboBox.Text = null;
            ClientecomboBox.Text = null;
            ExistenciatextBox.Text = 0.ToString();
            PrecionumericUpDown.Value = 0;
        }

        private void LlenarComboBoxCliente()
        {
            RepositorioBase<Clientes> db = new RepositorioBase<Clientes>();
            var listado2 = new List<Clientes>();
            listado2 = db.GetList(p => true);
            ClientecomboBox.DataSource = listado2;
            ClientecomboBox.DisplayMember = "Nombre";
            ClientecomboBox.ValueMember = "ClienteId";

        }

        private void LlenarComboBoxProducto()
        {
            RepositorioBase<Productos> db = new RepositorioBase<Productos>();
            var listado = new List<Productos>();
            listado = db.GetList(p => true);
            ProductocomboBox.DataSource = listado;
            ProductocomboBox.DisplayMember = "Descripcion";
            ProductocomboBox.ValueMember = "ProductoId";

        }




        private void Limpiar()
        {

            VentaIdnumericUpDown.Value = 0;
            ClientecomboBox.Text = null;
            ProductocomboBox.Text = null;
            FormaPagocomboBox.Text = null;
            CantidadnumericUpDown.Value = 0;
            ExistenciatextBox.Text = string.Empty;
            PrecionumericUpDown.Value = 0;
            SubTotalTextBox.Text = string.Empty;
            TotalTextBox.Text = string.Empty;
            ItbisTextBox.Text = string.Empty;
            errorProvider.Clear();

        }

        private Ventas LlenaClase()
        {

            Ventas venta = new Ventas();
            venta.VentasId = Convert.ToInt32(VentaIdnumericUpDown.Value);
            venta.ClienteId = (int)ClientecomboBox.SelectedValue;
            venta.Fecha = FechadateTimePicker.Value;
            venta.Modo = FormaPagocomboBox.Text;
            venta.Itbis = Convert.ToDouble(ItbisTextBox.Text);
            venta.SubTotal = Convert.ToDouble(SubTotalTextBox.Text);
            venta.Total = Convert.ToDouble(TotalTextBox.Text);
            venta.UsuarioId = 0;
            venta.Productos = this.Detalle;
            venta.Balance = Convert.ToDouble(TotalTextBox.Text);
            return venta;

        }

        private void LlenaCampo (Ventas v)
        {

            VentaIdnumericUpDown.Value = v.VentasId;
            ClientecomboBox.SelectedValue = v.ClienteId;
            FechadateTimePicker.Value = v.Fecha;
            FormaPagocomboBox.Text = v.Modo;
            ItbisTextBox.Text = v.Itbis.ToString();
            SubTotalTextBox.Text = v.SubTotal.ToString();
            TotalTextBox.Text = v.Total.ToString();
            this.Detalle = v.Productos;
            CargarGrid();
        }

        private void CargarGrid()
        {
            detalleDataGridView.DataSource = null;
            detalleDataGridView.DataSource = Detalle;
        }
        private bool ExisteEnLaBaseDeDatos()
        {
            RepositorioBase<Ventas> db = new RepositorioBase<Ventas>();
            Ventas venta = db.Buscar((int)VentaIdnumericUpDown.Value);
            return (venta != null);

        }

        private bool Validar()
        {
            RepositorioBase<Ventas> db = new RepositorioBase<Ventas>();
            bool paso = true;


            return paso;

        }



        private void Guardarbutton_Click(object sender, EventArgs e)
        {
           
            Ventas venta;
            bool paso = false;

            if (!Validar())
                return;

            venta = LlenaClase();


            if (VentaIdnumericUpDown.Value == 0)
            {
                paso = VentaBLL.Guardar(venta);
            }
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar una venta que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
               //paso = db.Modificar(venta);

            }

            if (paso)
                MessageBox.Show("Guardado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No fue posible guardar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Limpiar();
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Ventas> db = new RepositorioBase<Ventas>();
            try
            {
                if (VentaIdnumericUpDown.Value > 0)
                {
                    if (db.Eliminar((int)VentaIdnumericUpDown.Value))
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

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id;
            RepositorioBase<Ventas> db = new RepositorioBase<Ventas>();
            Ventas venta = new Ventas();

            int.TryParse(VentaIdnumericUpDown.Text, out id);
            Limpiar();

            venta = db.Buscar(id);

            if (venta != null)
            {

                LlenaCampo(venta);

            }
            else
            {
                MessageBox.Show("Usuario no existe");
            }
        }

      
        private void ProductocomboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            
            Productos p = ProductocomboBox.SelectedItem as Productos;
            if (p != null)
            {

                PrecionumericUpDown.Value = Convert.ToDecimal(p.Precio);
                ExistenciatextBox.Text = Convert.ToString(p.Existencia);

            }


        }

        public void CalcularItbis()
        {
            double itbis = 0;
            foreach (var item in Detalle)
            {
                itbis += item.Itbis;
            }
            ItbisTextBox.Text = itbis.ToString();
        }


        public void CalcularTotal()
        {
            double total = 0;
            foreach (var item in Detalle)
            {
                total += (item.Importe) + item.Itbis;
            }
            TotalTextBox.Text = total.ToString();
        }

        public void CalcularSubtotal()
        {
            double subtotal = 0;
            foreach (var item in Detalle)
            {
                subtotal +=  item.Importe;
            }
            SubTotalTextBox.Text = subtotal.ToString();
        }

        private void LimpiaProducto()
        {
            ProductocomboBox.Text = null;
            PrecionumericUpDown.Value = 0;
            ExistenciatextBox.Text = "";
            CantidadnumericUpDown.Value = 0;
            errorProvider.Clear();
        }
        private void AgragraAlGrid_Click(object sender, EventArgs e)
        {
            RepositorioBase<Productos> db = new RepositorioBase<Productos>();
            if (ProductocomboBox.Text == "")
            {
                errorProvider.SetError(ProductocomboBox, "Debe elegir una asignatura");
                ProductocomboBox.Focus();

            }
            else
            {

                Productos producto = db.Buscar((int)ProductocomboBox.SelectedValue);
                if (PrecionumericUpDown.Value < Convert.ToDecimal(producto.Costo)){

                    errorProvider.SetError(PrecionumericUpDown, "El precio de venta debe ser mayor al precio del costo");
                    PrecionumericUpDown.Focus();
                } 
                if(producto.Existencia - Convert.ToDouble( CantidadnumericUpDown.Value) < 0)
                {
                    errorProvider.SetError(CantidadnumericUpDown, "El almacen del producto no es suficiente ");
                    CantidadnumericUpDown.Focus();

                }
                else
                {

                    double import = Convert.ToDouble(PrecionumericUpDown.Value * CantidadnumericUpDown.Value);



                    if (detalleDataGridView.DataSource != null)
                        this.Detalle = (List<VentasDetalle>)detalleDataGridView.DataSource;

                    this.Detalle.Add(new VentasDetalle()
                    {
                        VentaId = Convert.ToInt32(VentaIdnumericUpDown.Value),
                        ProductoId = Convert.ToInt32(ProductocomboBox.SelectedValue),
                        Cantidad = Convert.ToDouble(CantidadnumericUpDown.Value),
                        Precio = Convert.ToDouble(PrecionumericUpDown.Value),
                        Importe = import,
                        Itbis = (producto.ProductoItbis * import) / 100

                    });

                    LimpiaProducto();
                    CargarGrid();
                    CalcularItbis();
                    CalcularSubtotal();
                    CalcularTotal();



                }

            }
  
        }
    }
}
