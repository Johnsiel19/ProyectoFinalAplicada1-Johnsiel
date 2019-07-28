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
using ProyectoFinalAplicada1_JohnsielCastanos.UI.Consultas;
using ProyectoFinalAplicada1_JohnsielCastanos.Consultas;
using System.Text.RegularExpressions;
using DAL;

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
            usuario.Nombre = NombretextBox.Text.Trim();
            usuario.Email = EmailtextBox.Text;
            usuario.NivelUsuario = NivelUsuariocomboBox.Text;
            usuario.Clave = Eramake.eCryptography.Encrypt(ClavetextBox.Text.Trim());;
            usuario.Usuario = UsuariotextBox.Text.Trim();
            usuario.FechaIngreso = FechaIngresodateTimePicker.Value;
            return usuario;

        }

        private void LlenaCampo(Usuarios usuario)
        {
            UsuarioIdnumericUpDown.Value = usuario.UsuarioId;
            NombretextBox.Text = usuario.Nombre;
            EmailtextBox.Text = usuario.Email;
            NivelUsuariocomboBox.Text = usuario.NivelUsuario;
            ClavetextBox.Text = Eramake.eCryptography.Decrypt(usuario.Clave);
            ConfirmarClavetextBox.Text = Eramake.eCryptography.Decrypt(usuario.Clave); 
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

            if (string.IsNullOrWhiteSpace(NombretextBox.Text))
            {
                errorProvider.SetError(NombretextBox, "La direccion no puede esta vacia");
                NombretextBox.Focus();
                paso = false;
            }

            if (Resultado != 0)
            {
                errorProvider.SetError(ConfirmarClavetextBox, "Clave no coincide!");
                ConfirmarClavetextBox.Focus();
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
            if (string.IsNullOrWhiteSpace(UsuariotextBox.Text))
            {
                errorProvider.SetError(UsuariotextBox, "La direccion no puede esta vacia");
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
            if (ValidarEmail(EmailtextBox.Text) == false)
            {
                errorProvider.SetError(EmailtextBox, "Correo invalido");
                EmailtextBox.Focus();
                paso = false;
            }
            if (NoDuplicadoCorreo(EmailtextBox.Text) == false)
            {
                errorProvider.SetError(EmailtextBox, "Correo invalido");
                EmailtextBox.Focus();
                paso = false;
            }

            if (NoDuplicadoUsuario(UsuariotextBox.Text) == false)
            {
                errorProvider.SetError(UsuariotextBox, "Correo invalido");
                UsuariotextBox.Focus();
                paso = false;
            }



            return paso;

        }

        public static bool NoDuplicadoCorreo(string descripcion)
        {
            RepositorioBase<Proveedores> db = new RepositorioBase<Proveedores>();
            bool paso = false;
            Contexto db2 = new Contexto();

            try
            {
                if (db2.Usuarios.Any(p => p.Email.Equals(descripcion)))
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
        public static bool NoDuplicadoUsuario(string descripcion)
        {
            RepositorioBase<Usuarios> db = new RepositorioBase<Usuarios>();
            bool paso = false;
            Contexto db2 = new Contexto();

            try
            {
                if (db2.Usuarios.Any(p => p.Usuario.Equals(descripcion)))
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

            if (id== 0)
            {

                cUsuario frm = new cUsuario(1);
                frm.ShowDialog();
                usuario = db.Buscar(frm.idElegido);

                 LlenaCampo(usuario);



            }
            else
            {


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

        }

        private void NombretextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void EmailtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void UsuariotextBox_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void UsuariotextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
            if (char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
