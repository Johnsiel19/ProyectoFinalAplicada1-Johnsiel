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
using System.Text.RegularExpressions;
using DAL;

namespace ProyectoFinalAplicada1_JohnsielCastanos.UI.Registros
{
    public partial class rCliente : Form
    {
        public rCliente(int id )
        {
            this.IdUsario = id;
            InitializeComponent();
        }
        public int IdUsario { get; set; }


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
            cliente.Nombre = NombrestextBox.Text.Trim();
            cliente.Email = EmailtextBox.Text;
            cliente.Direccion = DirecciontextBox.Text.Trim();
            cliente.Telefono = TelefonomaskedTextBox.Text;
            cliente.Cedula = CedulamaskedTextBox.Text;
            cliente.Celular = CelularmaskedTextBox.Text;
            cliente.UsuarioId = IdUsario;
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

        public static bool NoDuplicadoCorreo(string descripcion)
        {
            RepositorioBase<Clientes> db = new RepositorioBase<Clientes>();
            bool paso = false;
            Contexto db2 = new Contexto();

            try
            {
                if (db2.Clientes.Any(p => p.Email.Equals(descripcion)))
                {
                    paso = true;
                }
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        public static bool NoDuplicadoCedula(string descripcion)
        {
            RepositorioBase<Clientes> db = new RepositorioBase<Clientes>();
            bool paso = false;
            Contexto db2 = new Contexto();

            try
            {
                if (db2.Clientes.Any(p => p.Cedula.Equals(descripcion)))
                {
                    paso = true;
                }
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
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


            errorProvider.Clear();
            if (string.IsNullOrWhiteSpace(NombrestextBox.Text))
            {
                errorProvider.SetError(NombrestextBox, "El nombre no puede estar vacio");
                NombrestextBox.Focus();
                paso = false;
            }
  
            if (!CedulamaskedTextBox.MaskCompleted)
            {
                errorProvider.SetError(CedulamaskedTextBox, "No puede estar vacio");
                CedulamaskedTextBox.Focus();
                paso = false;
            }


            if (!CelularmaskedTextBox.MaskCompleted)
            {
                errorProvider.SetError(CelularmaskedTextBox, "No puede estar vacio");
                CelularmaskedTextBox.Focus();
                paso = false;
            }


            if (!TelefonomaskedTextBox.MaskCompleted)
            {
                errorProvider.SetError(TelefonomaskedTextBox, "No puede estar vacio");
                TelefonomaskedTextBox.Focus();
                paso = false;
            }
            if (NoDuplicadoCorreo(EmailtextBox.Text))
            {
                errorProvider.SetError(EmailtextBox, "El Email ya existe");
                EmailtextBox.Focus();
                paso = false;

            }
            if (NoDuplicadoCedula(CedulamaskedTextBox.Text))
            {
                errorProvider.SetError(CedulamaskedTextBox, "El Cedula ya existe");
                CedulamaskedTextBox.Focus();
                paso = false;

            }



            if (FechadateTimePicker.Value > DateTime.Now)
            {
                errorProvider.SetError(FechadateTimePicker, "La fecha Debe ser igual a hoy");
                EmailtextBox.Focus();
                paso = false;

            }


            if (string.IsNullOrWhiteSpace(DirecciontextBox.Text))
            {
                errorProvider.SetError(DirecciontextBox, "No puede haber espacios en blanco");
                DirecciontextBox.Focus();
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
        //Expresion regural para validar el Email
  

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
            if (ClientenumericUpDown.Value == 0)
            {

                cCliente frm = new cCliente(1);
                frm.ShowDialog();

                if (frm.idElegido > 0)
                {
                    cliente = db.Buscar(frm.idElegido);



                    LlenaCampo(cliente);



                }


            }
            else
            {
                int.TryParse(ClientenumericUpDown.Text, out id);
                Limpiar();

                cliente = db.Buscar(id);

                if (cliente != null)
                {

                    LlenaCampo(cliente);

                }
                else
                {
                    MessageBox.Show("El Cliente no existe");
                }
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
