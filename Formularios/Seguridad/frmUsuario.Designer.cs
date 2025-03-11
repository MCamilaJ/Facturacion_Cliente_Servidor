namespace Facturacion_Cliente_Servidor.Formularios.Seguridad
{
    partial class frmUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtIdSeguridad = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblTitulo = new MaterialSkin.Controls.MaterialLabel();
            this.btnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnActualizar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtUsuarioModifico = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtFechaModificacion = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtClave = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtUsuario = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtIdEmpleado = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SuspendLayout();
            // 
            // txtIdSeguridad
            // 
            this.txtIdSeguridad.Depth = 0;
            this.txtIdSeguridad.Hint = "Id Seguridad";
            this.txtIdSeguridad.Location = new System.Drawing.Point(59, 58);
            this.txtIdSeguridad.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtIdSeguridad.Name = "txtIdSeguridad";
            this.txtIdSeguridad.PasswordChar = '\0';
            this.txtIdSeguridad.SelectedText = "";
            this.txtIdSeguridad.SelectionLength = 0;
            this.txtIdSeguridad.SelectionStart = 0;
            this.txtIdSeguridad.Size = new System.Drawing.Size(277, 23);
            this.txtIdSeguridad.TabIndex = 54;
            this.txtIdSeguridad.UseSystemPasswordChar = false;
            this.txtIdSeguridad.Click += new System.EventHandler(this.txtIdEmpleado_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Depth = 0;
            this.lblTitulo.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitulo.Location = new System.Drawing.Point(207, 7);
            this.lblTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(345, 19);
            this.lblTitulo.TabIndex = 45;
            this.lblTitulo.Text = "NUEVO USUARIO";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Depth = 0;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(257, 345);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Primary = true;
            this.btnSalir.Size = new System.Drawing.Size(133, 44);
            this.btnSalir.TabIndex = 44;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Depth = 0;
            this.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizar.Location = new System.Drawing.Point(59, 345);
            this.btnActualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Primary = true;
            this.btnActualizar.Size = new System.Drawing.Size(133, 44);
            this.btnActualizar.TabIndex = 43;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // txtUsuarioModifico
            // 
            this.txtUsuarioModifico.Depth = 0;
            this.txtUsuarioModifico.Hint = "Usuario Modifico";
            this.txtUsuarioModifico.Location = new System.Drawing.Point(59, 262);
            this.txtUsuarioModifico.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtUsuarioModifico.Name = "txtUsuarioModifico";
            this.txtUsuarioModifico.PasswordChar = '\0';
            this.txtUsuarioModifico.SelectedText = "";
            this.txtUsuarioModifico.SelectionLength = 0;
            this.txtUsuarioModifico.SelectionStart = 0;
            this.txtUsuarioModifico.Size = new System.Drawing.Size(277, 23);
            this.txtUsuarioModifico.TabIndex = 41;
            this.txtUsuarioModifico.UseSystemPasswordChar = false;
            this.txtUsuarioModifico.Click += new System.EventHandler(this.txtTelefono_Click);
            // 
            // txtFechaModificacion
            // 
            this.txtFechaModificacion.Depth = 0;
            this.txtFechaModificacion.Hint = "FechaModificacion";
            this.txtFechaModificacion.Location = new System.Drawing.Point(59, 221);
            this.txtFechaModificacion.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtFechaModificacion.Name = "txtFechaModificacion";
            this.txtFechaModificacion.PasswordChar = '\0';
            this.txtFechaModificacion.SelectedText = "";
            this.txtFechaModificacion.SelectionLength = 0;
            this.txtFechaModificacion.SelectionStart = 0;
            this.txtFechaModificacion.Size = new System.Drawing.Size(277, 23);
            this.txtFechaModificacion.TabIndex = 40;
            this.txtFechaModificacion.UseSystemPasswordChar = false;
            this.txtFechaModificacion.Click += new System.EventHandler(this.txtDireccion_Click);
            // 
            // txtClave
            // 
            this.txtClave.Depth = 0;
            this.txtClave.Hint = "Clave";
            this.txtClave.Location = new System.Drawing.Point(59, 180);
            this.txtClave.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtClave.Name = "txtClave";
            this.txtClave.PasswordChar = '\0';
            this.txtClave.SelectedText = "";
            this.txtClave.SelectionLength = 0;
            this.txtClave.SelectionStart = 0;
            this.txtClave.Size = new System.Drawing.Size(277, 23);
            this.txtClave.TabIndex = 39;
            this.txtClave.UseSystemPasswordChar = false;
            this.txtClave.Click += new System.EventHandler(this.txtDocumento_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Depth = 0;
            this.txtUsuario.Hint = "Usuario";
            this.txtUsuario.Location = new System.Drawing.Point(59, 142);
            this.txtUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PasswordChar = '\0';
            this.txtUsuario.SelectedText = "";
            this.txtUsuario.SelectionLength = 0;
            this.txtUsuario.SelectionStart = 0;
            this.txtUsuario.Size = new System.Drawing.Size(277, 23);
            this.txtUsuario.TabIndex = 38;
            this.txtUsuario.UseSystemPasswordChar = false;
            this.txtUsuario.Click += new System.EventHandler(this.txtNombre_Click);
            // 
            // txtIdEmpleado
            // 
            this.txtIdEmpleado.Depth = 0;
            this.txtIdEmpleado.Hint = "Id Empleado";
            this.txtIdEmpleado.Location = new System.Drawing.Point(59, 97);
            this.txtIdEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtIdEmpleado.Name = "txtIdEmpleado";
            this.txtIdEmpleado.PasswordChar = '\0';
            this.txtIdEmpleado.SelectedText = "";
            this.txtIdEmpleado.SelectionLength = 0;
            this.txtIdEmpleado.SelectionStart = 0;
            this.txtIdEmpleado.Size = new System.Drawing.Size(277, 23);
            this.txtIdEmpleado.TabIndex = 55;
            this.txtIdEmpleado.UseSystemPasswordChar = false;
            // 
            // frmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 495);
            this.Controls.Add(this.txtIdEmpleado);
            this.Controls.Add(this.txtIdSeguridad);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.txtUsuarioModifico);
            this.Controls.Add(this.txtFechaModificacion);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.txtUsuario);
            this.Name = "frmUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmNuevoUsuario";
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField txtIdSeguridad;
        private MaterialSkin.Controls.MaterialLabel lblTitulo;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalir;
        private MaterialSkin.Controls.MaterialRaisedButton btnActualizar;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtUsuarioModifico;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtFechaModificacion;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtClave;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtUsuario;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtIdEmpleado;
    }
}