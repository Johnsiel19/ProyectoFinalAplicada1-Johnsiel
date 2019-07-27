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
using System.Text.RegularExpressions;
using ProyectoFinalAplicada1_JohnsielCastanos.UI.Consultas;

namespace ProyectoFinalAplicada1_JohnsielCastanos.UI.Registros
{
    public partial class rProveedor : Form
    {
        public rProveedor()
        {
            InitializeComponent();
        }


        private void Limpiar()
        {

            ProveedorIdnumericUpDown.Value = 0;
            NombrestextBox.Text = string.Empty;
            EmailtextBox.Text = string.Empty;
            TelefonomaskedTextBox.Text = string.Empty;
            CelularmaskedTextBox.Text = string.Empty;
            errorProvider.Clear();



        }

        private Proveedores LlenaClase()
        {
            Proveedores proveedor = new Proveedores();
            proveedor.ProveedorId = Convert.ToInt32(ProveedorIdnumericUpDown.Value);
            proveedor.Nombre = NombrestextBox.Text.Trim();
            proveedor.Email = EmailtextBox.Text;
            proveedor.Celular = CelularmaskedTextBox.Text;
            proveedor.Telefono = TelefonomaskedTextBox.Text;
            proveedor.UsuarioId = 0;
            proveedor.Fecha = FechadateTimePicker.Value;
            return proveedor;

        }

        private void LlenaCampo(Proveedores proveedor)
        {
            ProveedorIdnumericUpDown.Value = proveedor.ProveedorId;
            NombrestextBox.Text = proveedor.Nombre;
            EmailtextBox.Text = proveedor.Email;
            TelefonomaskedTextBox.Text = proveedor.Telefono;
            CelularmaskedTextBox.Text = proveedor.Celular;
            FechadateTimePicker.Value = proveedor.Fecha;

        }
        private bool ExisteEnLaBaseDeDatos()
        {
            RepositorioBase<Proveedores> db = new RepositorioBase<Proveedores>();
            Proveedores proveedor = db.Buscar((int)ProveedorIdnumericUpDown.Value);
            return (proveedor != null);

        }

        private bool Validar()
        {
            RepositorioBase<Proveedores> db = new RepositorioBase<Proveedores>();

            bool paso = true;



            if (NombrestextBox.Text == string.Empty)
            {
                errorProvider.SetError(NombrestextBox, "El campo Nombre no puede estar vacio");
                NombrestextBox.Focus();
                paso = false;
            }

            if (EmailtextBox.Text == string.Empty)
            {
                errorProvider.SetError(EmailtextBox, "El campo Email no puede estar vacio");
                EmailtextBox.Focus();
                paso = false;

            }


            if (TelefonomaskedTextBox.Text == string.Empty)
            {
                errorProvider.SetError(TelefonomaskedTextBox, "El campo telefono no debe estar vacio");
                TelefonomaskedTextBox.Focus();
                paso = false;

            }
            if (CelularmaskedTextBox.Text == string.Empty)
            {
                errorProvider.SetError(CelularmaskedTextBox, "El campo Celufar no debe estar vacio");
                CelularmaskedTextBox.Focus();
                paso = false;

            }

            if (CelularmaskedTextBox.Text.Length < 11)
            {
                errorProvider.SetError(CelularmaskedTextBox, "El numero de celular esta incompleto");
                CelularmaskedTextBox.Focus();
                paso = false;

            }


            if (FechadateTimePicker.Value > DateTime.Now)
            {
                errorProvider.SetError(FechadateTimePicker, "La fecha Debe ser igual a hoy");
                EmailtextBox.Focus();
                paso = false;

            }
            if (ValidarEmail(EmailtextBox.Text) == false)
            {
                errorProvider.SetError(EmailtextBox, "Correo invalido");
                EmailtextBox.Focus();
                paso = false;
            }


            return paso;

        }

        private Boolean ValidarEmail(String email)
        {
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }


        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Proveedores> db = new RepositorioBase<Proveedores>();
            Proveedores proveedor;
            bool paso = false;

            if (!Validar())
                return;

            proveedor = LlenaClase();


            if (ProveedorIdnumericUpDown.Value == 0)
            {
                paso = db.Guardar(proveedor);
            }
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar un Proveedor que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = db.Modificar(proveedor);

            }

            if (paso)
                MessageBox.Show("Guardado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No fue posible guardar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Limpiar();
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id;
            RepositorioBase<Proveedores> db = new RepositorioBase<Proveedores>();
            Proveedores proveedor = new Proveedores();

            int.TryParse(ProveedorIdnumericUpDown.Text, out id);
            Limpiar();

            if (ProveedorIdnumericUpDown.Value == 0)
            {

                cProveedores frm = new cProveedores();
                frm.ShowDialog();

               /* cliente = db.Buscar(frm.codigoCliente);



                LlenaCampo(cliente);*/



            }
            else
            {

                proveedor = db.Buscar(id);

                if (proveedor != null)
                {

                    LlenaCampo(proveedor);

                }
                else
                {
                    MessageBox.Show("El Proveesor no existe");
                }
            }

          
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Proveedores> db = new RepositorioBase<Proveedores>();
            try
            {
                if (ProveedorIdnumericUpDown.Value > 0)
                {
                    if (db.Eliminar((int)ProveedorIdnumericUpDown.Value))
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

        private void NombrestextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void TelefonomaskedTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void CelularmaskedTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
