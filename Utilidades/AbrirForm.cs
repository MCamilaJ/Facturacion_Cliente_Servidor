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
        public static void AbrirFormulario(Form formHijo, Panel panelContenedor)
        {


            // Si hay controles en el panel
            if (panelContenedor.Controls.Count > 0)
            {
                // Verifica si el primer control es un Form
                if (panelContenedor.Controls[0] is Form formActivo)
                {
                    Console.WriteLine("Cerrando formulario activo: " + formActivo.Name);
                    formActivo.Hide(); // Oculta el formulario activo
                    formActivo.Close(); // Cierra el formulario activo
                    formActivo.Dispose(); // Libera los recursos del formulario
                    panelContenedor.Controls.Remove(formActivo); // Lo elimina del panel
                }
            }


            Console.WriteLine("Abriendo nuevo formulario: " + formHijo.Name);
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(formHijo);
            panelContenedor.Tag = formHijo;
            formHijo.BringToFront(); // Trae el nuevo formulario al frente
            formHijo.Show();

        }
    }

}
