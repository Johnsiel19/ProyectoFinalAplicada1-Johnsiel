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
    public partial class rCliente : Form
    {
        public rCliente()
        {
            InitializeComponent();
        }


        private void Limpiar()
        {

            ClientenumericUpDown.Value = 0;
            NombrestextBox.Text = string.Empty;
            CedulamaskedTextBox.Text = string.Empty;
            EmailtextBox.Text = string.Empty;
            TelefonomaskedTextBox.Text = string.Empty;
            CelularmaskedTextBox.Text = string.Empty;
            DirecciontextBox.Text = string.Empty;
            errorProvider.Clear();


        }

        private Clientes LlenaClase()
        {
            Clientes cliente = new Clientes();
            cliente.ClienteId = Convert.ToInt32(ClientenumericUpDown.Value);
            cliente.Nombre = NombrestextBox.Text;
            cliente.Email = EmailtextBox.Text;
            cliente.Direccion = DirecciontextBox.Text;
            cliente.Telefono = TelefonomaskedTextBox.Text;
            cliente.Cedula = CedulamaskedTextBox.Text;
            cliente.Celular = CelularmaskedTextBox.Text;
            cliente.UsuarioId = 0;
            cliente.Fecha = FechadateTimePicker.Value;
            return cliente;

        }

        private void LlenaCampo(Clientes cliente)
        {
            ClientenumericUpDown.Value = cliente.ClienteId;
            NombrestextBox.Text = cliente.Nombre;
            EmailtextBox.Text = cliente.Email;
            TelefonomaskedTextBox.Text = cliente.Telefono;
            CedulamaskedTextBox.Text = cliente.Cedula;
            CelularmaskedTextBox.Text = cliente.Celular;
            FechadateTimePicker.Value = cliente.Fecha;
            DirecciontextBox.Text = cliente.Direccion;
            BalancetextBox.Text = cliente.Balance.ToString();
       
        }
        private bool ExisteEnLaBaseDeDatos()
        {
            RepositorioBase<Clientes> db = new RepositorioBase<Clientes>();
            Clientes cliente = db.Buscar((int)ClientenumericUpDown.Value);
            return (cliente != null);

        }

        private bool Validar()
        {
            RepositorioBase<Clientes> db = new RepositorioBase<Clientes>();

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

            if (CedulamaskedTextBox.Text == string.Empty)
            {
                errorProvider.SetError(CedulamaskedTextBox, "El campo Cedula no puede estar vacio");
                CedulamaskedTextBox.Focus();
                paso = false;

            }

            if (CedulamaskedTextBox.Text.Length < 11)
            {
                errorProvider.SetError(CedulamaskedTextBox, "El campo Cedula  esta incompleto");
                CedulamaskedTextBox.Focus();
                paso = false;

            }

            if (TelefonomaskedTextBox.Text == string.Empty)
            {
                errorProvider.SetError(TelefonomaskedTextBox, "El campo telefono no puede estar vacio");
                TelefonomaskedTextBox.Focus();
                paso = false;

            }
            if (CelularmaskedTextBox.Text == string.Empty)
            {
                errorProvider.SetError(CelularmaskedTextBox, "El campo celular no puede estar vacio");
                CelularmaskedTextBox.Focus();
                paso = false;

            }

            if (CelularmaskedTextBox.Text.Length < 10)
            {
                errorProvider.SetError(CelularmaskedTextBox, "El celular esta incompleto");
                CelularmaskedTextBox.Focus();
                paso = false;

            }

            if (FechadateTimePicker.Value > DateTime.Now)
            {
                errorProvider.SetError(FechadateTimePicker, "La fecha Debe ser igual a hoy");
                EmailtextBox.Focus();
                paso = false;

            }
            return paso;

        }

        private void Guardarbutton_Click_1(object sender, EventArgs e)
        {
            RepositorioBase<Clientes> db = new RepositorioBase<Clientes>();
            Clientes cliente;
            bool paso = false;

            if (!Validar())
                return;

            cliente = LlenaClase();


            if (ClientenumericUpDown.Value == 0)
            {
                paso = db.Guardar(cliente);
            }
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar un Cliente que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = db.Modificar(cliente);

            }

            if (paso)
                MessageBox.Show("Guardado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No fue posible guardar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Limpiar();
        }

        private void Nuevobutton_Click_1(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Eliminarbutton_Click_1(object sender, EventArgs e)
        {
            RepositorioBase<Clientes> db = new RepositorioBase<Clientes>();
            try
            {
                if (ClientenumericUpDown.Value > 0)
                {
                    if (db.Eliminar((int)ClientenumericUpDown.Value))
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

        private void Buscarbutton_Click_1(object sender, EventArgs e)
        {
            int id;
            RepositorioBase<Clientes> db = new RepositorioBase<Clientes>();
            Clientes cliente = new Clientes();

            int.TryParse(ClientenumericUpDown.Text, out id);
            Limpiar();

            cliente = db.Buscar(id);

            if (cliente != null)
            {

                LlenaCampo(cliente);

            }
            else
            {
                MessageBox.Show("Usuario no existe");
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

        private void CedulamaskedTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
