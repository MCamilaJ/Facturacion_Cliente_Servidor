using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Facturacion_Cliente_Servidor.Formularios;
using Facturacion_Cliente_Servidor.Utilidades;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Facturacion_Cliente_Servidor.Formularios
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

            AbrirForm.AbrirFormulario(new Formularios.Clientes.frmClientes(), pnlPrincipal);


            
            AbrirForm.AbrirFormulario(new Formularios.Clientes.frmClientes(), pnlPrincipal);

            AbrirForm.AbrirFormulario(new Formularios.Clientes.frmClientes(), pnlPrincipal);
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            AbrirForm.AbrirFormulario(new Formularios.Productos.frmProductos(), pnlPrincipal);


        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            AbrirForm.AbrirFormulario(new Formularios.Empleados.frmEmpleados(), pnlPrincipal);

        }

      


        private void tabOpcionesMenu_Click(object sender, EventArgs e)
        {
            
        }
        

        private void btnSeguridad_Click(object sender, EventArgs e)
        {
            AbrirForm.AbrirFormulario(new Formularios.Seguridad.frmActualizarUsurio(), pnlPrincipal);
        }

    }

}
