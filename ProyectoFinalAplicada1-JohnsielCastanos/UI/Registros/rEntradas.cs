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
using ProyectoFinalAplicada1_JohnsielCastanos.UI.Consultas;

namespace ProyectoFinalAplicada1_JohnsielCastanos.UI.Registros
{
    public partial class rEntradas : Form
    {
        public rEntradas()
        {
            InitializeComponent();
            LlenarComboBoxProducto();
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
     
            bool paso = true;



            errorProvider.Clear();

            if (ProductocomboBox.Text =="")
            {
                errorProvider.SetError(ProductocomboBox, "Elija el producto");
                ProductocomboBox.Focus();
                paso = false;
            }

            if (ProductoEntradanumericUpDown.Value < 1)
            {
                errorProvider.SetError(ProductoEntradanumericUpDown, "La entrada debe ser mayor a 1");
                ProductoEntradanumericUpDown.Focus();
                paso = false;

            }

    


            return paso;

        }



     
        private void Guardarbutton_Click_1(object sender, EventArgs e)
        {

            Entradas entrada;
            bool paso = false;

            if (!Validar())
                return;

            entrada = LlenaClase();


            if (EntradaIdnumericUpDown.Value == 0)
            {
                paso = EntradaBLL.Guardar(entrada);
            }
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar una Entrada que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = EntradaBLL.Modificar(entrada);

            }

            if (paso)
                MessageBox.Show("Guardado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No fue posible guardar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Limpiar();
        }

        private void Eliminarbutton_Click_1(object sender, EventArgs e)
        {
            RepositorioBase<Entradas> db = new RepositorioBase<Entradas>();
            try
            {
                if (EntradaIdnumericUpDown.Value > 0)
                {
                    if (EntradaBLL.Eliminar((int)EntradaIdnumericUpDown.Value))
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
            RepositorioBase<Entradas> db = new RepositorioBase<Entradas>();
            Entradas entrada = new Entradas();

            int.TryParse(EntradaIdnumericUpDown.Text, out id);
            Limpiar();

            entrada = db.Buscar(id);

            if (id == 0)
            {

                cEntradas frm = new cEntradas(1);
                frm.ShowDialog();

                if (frm.CodigoEntrada > 0)
                {
                    entrada = db.Buscar(frm.CodigoEntrada);



                    LlenaCampo(entrada);



                }


            }
            else
            {

                if (entrada != null)
                {

                    LlenaCampo(entrada);

                }
                else
                {
                    MessageBox.Show("Entrada no encontrada");
                }

            }
          
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
