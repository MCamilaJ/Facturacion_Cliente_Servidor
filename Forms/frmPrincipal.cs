using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Facturacion_Cliente_Servidor.Utilidades;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Facturacion_Cliente_Servidor.Forms
{
    public partial class frmPrincipal : MaterialForm
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void pnlPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            AbrirForm.AbrirFormulario(new Forms.Clientes.frmClientes(), pnlPrincipal);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }        
    }
}
