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

namespace ProyectoFinalAplicada1_JohnsielCastanos.Registros
{
    public partial class rUsuario : Form
    {
        public rUsuario()
        {
            InitializeComponent();
        }


        private void Limpiar()
        {
            UsuarioIdnumericUpDown.Value = 0;
            NombretextBox.Text = string.Empty;
            EmailtextBox.Text = string.Empty;
            NivelUsuariocomboBox.Text = string.Empty;
            ClavetextBox.Text = string.Empty;
            UsuariotextBox.Text = string.Empty;
            ConfirmarClavetextBox.Text = string.Empty;
            errorProvider.Clear();


        }

        private Usuarios LlenaClase()
        {
            Usuarios usuario = new Usuarios();
            usuario.UsuarioId = Convert.ToInt32(UsuarioIdnumericUpDown.Value);
            usuario.Nombre = NombretextBox.Text;
            usuario.Email = EmailtextBox.Text;
            usuario.NivelUsuario = NivelUsuariocomboBox.Text;
            usuario.Clave = ClavetextBox.Text;
            usuario.Usuario = UsuariotextBox.Text;
            usuario.FechaIngreso = FechaIngresodateTimePicker.Value;
            return usuario;

        }

        private void LlenaCampo(Usuarios usuario)
        {
            UsuarioIdnumericUpDown.Value = usuario.UsuarioId;
            NombretextBox.Text = usuario.Nombre;
            EmailtextBox.Text = usuario.Email;
            NivelUsuariocomboBox.Text = usuario.NivelUsuario;
            ClavetextBox.Text = usuario.Clave;
            ConfirmarClavetextBox.Text = usuario.Clave;
            UsuariotextBox.Text = usuario.Usuario;
            FechaIngresodateTimePicker.Value = usuario.FechaIngreso;


        }
        private bool ExisteEnLaBaseDeDatos()
        {
            RepositorioBase<Usuarios> db = new RepositorioBase<Usuarios>();
            Usuarios usuario = db.Buscar((int)UsuarioIdnumericUpDown.Value);
            return (usuario != null);

        }

        private bool Validar()
        {
            RepositorioBase<Usuarios> db = new RepositorioBase<Usuarios>();

            bool paso = true;
            errorProvider.Clear();

            string Clave = ClavetextBox.Text;
            string Confirmar = ConfirmarClavetextBox.Text;

            int Resultado = 0;

            Resultado = string.Compare(Clave, Confirmar);

            if (Resultado != 0)
            {
                errorProvider.SetError(ConfirmarClavetextBox, "Clave no coincide!");
                ConfirmarClavetextBox.Focus();
                paso = false;
            }


            if (NombretextBox.Text == string.Empty)
            {
                errorProvider.SetError(NombretextBox, "El campo Nombre no puede estar vacio");
                NombretextBox.Focus();
                paso = false;
            }

            if (EmailtextBox.Text == string.Empty)
            {
                errorProvider.SetError(EmailtextBox, "El campo Email no puede estar vacio");
                EmailtextBox.Focus();
                paso = false;

            }
      
            if (FechaIngresodateTimePicker.Value > DateTime.Now)
            {
                errorProvider.SetError(FechaIngresodateTimePicker, "La fecha Debe ser igual a hoy");
                EmailtextBox.Focus();
                paso = false;

            }

        


            if (NivelUsuariocomboBox.Text == string.Empty)
            {
                errorProvider.SetError(NivelUsuariocomboBox, "El campo Nivel de Usuario no puede estar vacio");
                NivelUsuariocomboBox.Focus();
                paso = false;

            }

            if (UsuariotextBox.Text == string.Empty)
            {
                errorProvider.SetError(UsuariotextBox, "El campo Usuario no puede estar vacio");
                UsuariotextBox.Focus();
                paso = false;

            }

            if (ClavetextBox.Text == string.Empty)
            {
                errorProvider.SetError(ClavetextBox, "El campo Clave no puede estar vacio");
                ClavetextBox.Focus();
                paso = false;

            }

            if (ConfirmarClavetextBox.Text == string.Empty)
            {
                errorProvider.SetError(ConfirmarClavetextBox, "El campo Confirmar no puede estar vacio");
                ConfirmarClavetextBox.Focus();
                paso = false;

            }
            if (UsuarioIdnumericUpDown.Value == 0)
            {
                if (db.NoDuplicadoUsuario(UsuariotextBox.Text))
                {
                    errorProvider.SetError(UsuariotextBox, "El nombre del usuario no debe ser igual a ningun otro");
                    paso = false;

                }
            }
            

            return paso;

        }


        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Usuarios> db = new RepositorioBase<Usuarios>();
            Usuarios usuario;
            bool paso = false;

            if (!Validar())
                return;

            usuario = LlenaClase();


            if (UsuarioIdnumericUpDown.Value == 0)
            {
                paso = db.Guardar(usuario);
            }
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar una Usuario que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = db.Modificar(usuario);

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

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Usuarios> db = new RepositorioBase<Usuarios>();
            try
            {
                if (UsuarioIdnumericUpDown.Value > 0)
                {
                    if (db.Eliminar((int)UsuarioIdnumericUpDown.Value))
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
                MessageBox.Show("NO se pudo eliminar", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id;
            RepositorioBase<Usuarios> db = new RepositorioBase<Usuarios>();
            Usuarios usuario = new Usuarios();

            int.TryParse(UsuarioIdnumericUpDown.Text, out id);
            Limpiar();

            usuario = db.Buscar(id);

            if (usuario != null)
            {

                LlenaCampo(usuario);

            }
            else
            {
                MessageBox.Show("El Usuario no existe");
            }
        }

        private void NombretextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }
    }
}
