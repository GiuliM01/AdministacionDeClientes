using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaNegocio;

namespace Vista
{
    public partial class DetalleCliente : Form
    {

        Negocio negocio;
        public DetalleCliente()
        {
            InitializeComponent();
        }
        public DetalleCliente(Negocio negocio):this()
        {
            this.negocio = negocio;
        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DetalleCliente_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente(txtNombre.Text,txtApellido.Text,int.Parse(txtTelefono.Text),txtDireccion.Text );
            negocio.Agregar(cliente);

            LimpiarFormulario();


            
        }
        private void LimpiarFormulario()
        {
            txtApellido.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtDireccion.Text = string.Empty;
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
