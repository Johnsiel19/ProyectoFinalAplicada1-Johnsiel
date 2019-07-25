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

namespace ProyectoFinalAplicada1_JohnsielCastanos.UI.Registros
{
    public partial class rCobro : Form
    {
        public rCobro()
        {
            InitializeComponent();
            LlenarComboBoxCliente();
        
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
            string cliente = ClientecomboBox.SelectedValue.ToString();
          

            listado = db.GetList(p => p.ClienteId.ToString().Contains(cliente));
            VentacomboBox.DataSource = listado;
            VentacomboBox.DisplayMember = "VentasId";
            VentacomboBox.ValueMember = "VentasId";

        }

        private void ClientecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            LlenarComboBoxVenta();
        }

 

        /*
        private void Limpiar()
        {

            ProductoIdnumericUpDown.Value = 0;
            DescripciontextBox.Text = string.Empty;
            ProveedorcomboBox.Text = string.Empty;
            PrecionumericUpDown.Value = 0;
            CostonumericUpDown.Value = 0;
            ExistenciatextBox.Text = string.Empty;
            ProductoItbisnumericUpDown.Value = 0;
            FechadateTimePicker.Value = DateTime.Now;

        }

        private Productos LlenaClase()
        {
            Productos producto = new Productos();
            producto.ProductoId = Convert.ToInt32(ProductoIdnumericUpDown.Value);
            producto.Descripcion = DescripciontextBox.Text;
            producto.Existencia = Convert.ToDouble(ExistenciatextBox.Text);
            producto.Precio = Convert.ToDouble(PrecionumericUpDown.Value);
            producto.Costo = Convert.ToDouble(CostonumericUpDown.Value);
            producto.ProductoItbis = Convert.ToInt32(ProductoItbisnumericUpDown.Value);
            producto.ProveedorId = Convert.ToInt32(ProveedorcomboBox.SelectedValue);
            producto.UsuarioId = 0;
            producto.Fecha = FechadateTimePicker.Value;
            return producto;

        }

        private void LlenaCampo(Productos producto)
        {
            ProductoIdnumericUpDown.Value = producto.UsuarioId;
            DescripciontextBox.Text = producto.Descripcion;
            ExistenciatextBox.Text = producto.Existencia.ToString();
            PrecionumericUpDown.Value = Convert.ToDecimal(producto.Precio);
            CostonumericUpDown.Value = Convert.ToDecimal(producto.Costo);
            ProductoItbisnumericUpDown.Value = Convert.ToDecimal(producto.ProductoItbis);
            FechadateTimePicker.Value = producto.Fecha;
            ProveedorcomboBox.Text = producto.ProveedorId.ToString();


        }
        private bool ExisteEnLaBaseDeDatos()
        {
            RepositorioBase<Productos> db = new RepositorioBase<Productos>();
            Productos producto = db.Buscar((int)ProductoIdnumericUpDown.Value);
            return (producto != null);

        }

        private bool Validar()
        {
            RepositorioBase<Productos> db = new RepositorioBase<Productos>();

            bool paso = true;



            if (DescripciontextBox.Text == string.Empty)
            {
                errorProvider.SetError(DescripciontextBox, "El campo Nombre no puede estar vacio");
                DescripciontextBox.Focus();
                paso = false;
            }

            if (ProveedorcomboBox.Text == string.Empty)
            {
                errorProvider.SetError(ProveedorcomboBox, "El proveedor no puede estra vacio");
                ProveedorcomboBox.Focus();
                paso = false;
            }

            return paso;

        }


        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Productos> db = new RepositorioBase<Productos>();
            Productos producto;
            bool paso = false;

            if (!Validar())
                return;

            producto = LlenaClase();


            if (ProductoIdnumericUpDown.Value == 0)
            {
                paso = db.Guardar(producto);
            }
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar un Producto que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = db.Modificar(producto);

            }

            if (paso)
                MessageBox.Show("Guardado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No fue posible guardar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Limpiar();
        }

        private void DescripciontextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id;
            RepositorioBase<Productos> db = new RepositorioBase<Productos>();
            Productos producto = new Productos();

            int.TryParse(ProductoIdnumericUpDown.Text, out id);
            Limpiar();

            producto = db.Buscar(id);

            if (producto != null)
            {

                LlenaCampo(producto);

            }
            else
            {
                MessageBox.Show("Usuario no existe");
            }
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Productos> db = new RepositorioBase<Productos>();
            try
            {
                if (ProductoIdnumericUpDown.Value > 0)
                {
                    if (db.Eliminar((int)ProductoIdnumericUpDown.Value))
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
        }*/
    }
}
