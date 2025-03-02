﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facturacion_Cliente_Servidor.Utilidades
{
    internal class AbrirForm
    {
        public static void AbrirFormulario(Form formHijo, Panel panelContenedor)
        {
            // Si hay controles en el panel
            if (panelContenedor.Controls.Count > 0)
            {
                // Verifica si el primer control es un Form
                if (panelContenedor.Controls[0] is Form formActivo)
                {
                    formActivo.Close(); // Cierra el formulario activo
                    panelContenedor.Controls.Remove(formActivo); // Lo elimina del panel
                }
            }

            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(formHijo);
            panelContenedor.Tag = formHijo;
            formHijo.Show();
        }
    }
}
