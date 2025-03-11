namespace Facturacion_Cliente_Servidor.Formularios.Seguridad
{
    partial class frmActualizarUsurio
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
            this.lblTitulo = new MaterialSkin.Controls.MaterialLabel();
            this.txtUsuario = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtClave = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnActualizar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtIdEmpleado = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnNuevo = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtIdSeguridad = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Depth = 0;
            this.lblTitulo.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitulo.Location = new System.Drawing.Point(359, 52);
            this.lblTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(345, 42);
            this.lblTitulo.TabIndex = 21;
            this.lblTitulo.Text = "ACTUALIZAR  USUARIOS SISTEMA";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Depth = 0;
            this.txtUsuario.Hint = "Usuario";
            this.txtUsuario.Location = new System.Drawing.Point(335, 217);
            this.txtUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PasswordChar = '\0';
            this.txtUsuario.SelectedText = "";
            this.txtUsuario.SelectionLength = 0;
            this.txtUsuario.SelectionStart = 0;
            this.txtUsuario.Size = new System.Drawing.Size(210, 23);
            this.txtUsuario.TabIndex = 22;
            this.txtUsuario.UseSystemPasswordChar = false;
            // 
            // txtClave
            // 
            this.txtClave.Depth = 0;
            this.txtClave.Hint = "Clave";
            this.txtClave.Location = new System.Drawing.Point(335, 255);
            this.txtClave.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtClave.Name = "txtClave";
            this.txtClave.PasswordChar = '\0';
            this.txtClave.SelectedText = "";
            this.txtClave.SelectionLength = 0;
            this.txtClave.SelectionStart = 0;
            this.txtClave.Size = new System.Drawing.Size(210, 23);
            this.txtClave.TabIndex = 23;
            this.txtClave.UseSystemPasswordChar = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Depth = 0;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(609, 357);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Primary = true;
            this.btnSalir.Size = new System.Drawing.Size(133, 47);
            this.btnSalir.TabIndex = 25;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Depth = 0;
            this.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizar.Location = new System.Drawing.Point(335, 357);
            this.btnActualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Primary = true;
            this.btnActualizar.Size = new System.Drawing.Size(133, 47);
            this.btnActualizar.TabIndex = 24;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // txtIdEmpleado
            // 
            this.txtIdEmpleado.Depth = 0;
            this.txtIdEmpleado.Hint = "Id Empleado";
            this.txtIdEmpleado.Location = new System.Drawing.Point(335, 188);
            this.txtIdEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtIdEmpleado.Name = "txtIdEmpleado";
            this.txtIdEmpleado.PasswordChar = '\0';
            this.txtIdEmpleado.SelectedText = "";
            this.txtIdEmpleado.SelectionLength = 0;
            this.txtIdEmpleado.SelectionStart = 0;
            this.txtIdEmpleado.Size = new System.Drawing.Size(210, 23);
            this.txtIdEmpleado.TabIndex = 26;
            this.txtIdEmpleado.UseSystemPasswordChar = false;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Depth = 0;
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(609, 152);
            this.btnNuevo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Primary = true;
            this.btnNuevo.Size = new System.Drawing.Size(133, 44);
            this.btnNuevo.TabIndex = 27;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // txtIdSeguridad
            // 
            this.txtIdSeguridad.Depth = 0;
            this.txtIdSeguridad.Hint = "Id Seguridad";
            this.txtIdSeguridad.Location = new System.Drawing.Point(335, 152);
            this.txtIdSeguridad.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtIdSeguridad.Name = "txtIdSeguridad";
            this.txtIdSeguridad.PasswordChar = '\0';
            this.txtIdSeguridad.SelectedText = "";
            this.txtIdSeguridad.SelectionLength = 0;
            this.txtIdSeguridad.SelectionStart = 0;
            this.txtIdSeguridad.Size = new System.Drawing.Size(210, 23);
            this.txtIdSeguridad.TabIndex = 28;
            this.txtIdSeguridad.UseSystemPasswordChar = false;
            this.txtIdSeguridad.Click += new System.EventHandler(this.materialSingleLineTextField1_Click);
            // 
            // frmActualizarUsurio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 549);
            this.Controls.Add(this.txtIdSeguridad);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.txtIdEmpleado);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmActualizarUsurio";
            this.Text = "frmActualizarUsuario";
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblTitulo;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtUsuario;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtClave;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalir;
        private MaterialSkin.Controls.MaterialRaisedButton btnActualizar;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtIdEmpleado;
        private MaterialSkin.Controls.MaterialRaisedButton btnNuevo;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtIdSeguridad;
    }
}