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
    public partial class rEntradas : Form
    {
        public rEntradas()
        {
            InitializeComponent();
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

            EntradaIdnumericUpDown.Value = 0;
  
            ProductocomboBox.Text = null;
         
            ProductoEntradanumericUpDown.Value = 0;
            FechadateTimePicker.Value = DateTime.Now;
        
            errorProvider.Clear();

        }

        private Entradas LlenaClase()
        {

            Entradas entrada = new Entradas();
            entrada.EntradaId = Convert.ToInt32(EntradaIdnumericUpDown.Value);
            entrada.Fecha = FechadateTimePicker.Value;
            entrada.Entrada = Convert.ToDouble(ProductoEntradanumericUpDown.Value);
            entrada.UsuarioId = 0;
            entrada.ProductoId = Convert.ToInt32( ProductocomboBox.SelectedValue );
            return entrada;

        }

        private void LlenaCampo(Entradas entrada)
        {

            EntradaIdnumericUpDown.Value = entrada.EntradaId;
            ProductocomboBox.SelectedValue = entrada.ProductoId;
            FechadateTimePicker.Value = entrada.Fecha;
            ProductoEntradanumericUpDown.Text = entrada.Entrada.ToString();
       
           
   
        }


        private bool ExisteEnLaBaseDeDatos()
        {
            RepositorioBase<Entradas> db = new RepositorioBase<Entradas>();
            Entradas entrada = db.Buscar((int)EntradaIdnumericUpDown.Value);
            return (entrada != null);

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
    }
}
