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
          

            listado = db.GetList(p => p.ClienteId.ToString().Contains(cliente) );
            VentacomboBox.DataSource = listado;
            VentacomboBox.DisplayMember = "VentasId";
            VentacomboBox.ValueMember = "VentasId";

        }

        private void ClientecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            LlenarComboBoxVenta();


        }
    }
}
