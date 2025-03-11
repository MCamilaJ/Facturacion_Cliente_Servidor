using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facturacion_Cliente_Servidor.Utilidades
{
    public static class AbrirForm
    {
        public static void AbrirFormulario(Form form, Panel panel)
        {
            // Cierra y elimina formularios previos dentro del panel
            foreach (Control ctrl in panel.Controls.OfType<Form>().ToList())
            {
                ctrl.Dispose(); // Libera recursos del formulario
                panel.Controls.Remove(ctrl);
            }

            // Configura el nuevo formulario dentro del panel
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            form.FormBorderStyle = FormBorderStyle.None;
            panel.Controls.Add(form);
            form.Show();
        }
    }

}
