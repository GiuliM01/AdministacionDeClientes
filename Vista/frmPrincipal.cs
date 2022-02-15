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
    public partial class frmPrincipal : Form
    {
        Negocio negocio;
        public frmPrincipal()
        {
            InitializeComponent();
            negocio = new Negocio();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ActualizarListaClientes();
        }

        private void txt2_Click(object sender, EventArgs e)
        {

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            DetalleCliente detalleCliente = new DetalleCliente(negocio);
            detalleCliente.ShowDialog();

            ActualizarListaClientes();
        }

        public void ActualizarListaClientes()
        {
            this.dgvClientes.DataSource = null;
            this.dgvClientes.DataSource = negocio.LeerClientes();

        }

    }
}
