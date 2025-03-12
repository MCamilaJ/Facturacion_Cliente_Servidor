namespace Facturacion_Cliente_Servidor.Formularios.Productos
{
    partial class frmProductos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitulo = new MaterialSkin.Controls.MaterialLabel();
            this.btnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pnlClientes = new System.Windows.Forms.Panel();
            this.dgClientes = new System.Windows.Forms.DataGridView();
            this.idCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.first_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.street = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnActualizar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnNuevo = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnBuscar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtBuscar = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.pnlClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Depth = 0;
            this.lblTitulo.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitulo.Location = new System.Drawing.Point(358, 71);
            this.lblTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(345, 19);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "ADMINISTRACIÓN DE PRODUCTOS";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnSalir
            // 
            this.btnSalir.Depth = 0;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(796, 445);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Primary = true;
            this.btnSalir.Size = new System.Drawing.Size(103, 30);
            this.btnSalir.TabIndex = 20;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // pnlClientes
            // 
            this.pnlClientes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlClientes.Controls.Add(this.dgClientes);
            this.pnlClientes.Controls.Add(this.btnNuevo);
            this.pnlClientes.Controls.Add(this.btnBuscar);
            this.pnlClientes.Controls.Add(this.txtBuscar);
            this.pnlClientes.Location = new System.Drawing.Point(156, 120);
            this.pnlClientes.Name = "pnlClientes";
            this.pnlClientes.Size = new System.Drawing.Size(776, 310);
            this.pnlClientes.TabIndex = 19;
            // 
            // dgClientes
            // 
            this.dgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCliente,
            this.first_name,
            this.email,
            this.phone,
            this.street,
            this.btnActualizar,
            this.btnEliminar});
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgClientes.DefaultCellStyle = dataGridViewCellStyle27;
            this.dgClientes.Location = new System.Drawing.Point(12, 65);
            this.dgClientes.Name = "dgClientes";
            dataGridViewCellStyle28.ForeColor = System.Drawing.Color.Black;
            this.dgClientes.RowsDefaultCellStyle = dataGridViewCellStyle28;
            this.dgClientes.Size = new System.Drawing.Size(746, 229);
            this.dgClientes.TabIndex = 18;
            // 
            // idCliente
            // 
            this.idCliente.DataPropertyName = "IdCliente";
            this.idCliente.HeaderText = "ID Cliente";
            this.idCliente.Name = "idCliente";
            // 
            // first_name
            // 
            this.first_name.DataPropertyName = "Name";
            this.first_name.HeaderText = "Nombre";
            this.first_name.Name = "first_name";
            // 
            // email
            // 
            this.email.DataPropertyName = "Email";
            this.email.HeaderText = "Correo";
            this.email.Name = "email";
            // 
            // phone
            // 
            this.phone.DataPropertyName = "Telefono";
            this.phone.HeaderText = "Telefono";
            this.phone.Name = "phone";
            // 
            // street
            // 
            this.street.DataPropertyName = "Direccion";
            this.street.HeaderText = "Dirección";
            this.street.Name = "street";
            // 
            // btnActualizar
            // 
            this.btnActualizar.DataPropertyName = "actualizar";
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnActualizar.DefaultCellStyle = dataGridViewCellStyle25;
            this.btnActualizar.HeaderText = "Actualizar";
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseColumnTextForButtonValue = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.DataPropertyName = "eliminar";
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.Crimson;
            this.btnEliminar.DefaultCellStyle = dataGridViewCellStyle26;
            this.btnEliminar.HeaderText = "Eliminar";
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseColumnTextForButtonValue = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Depth = 0;
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(555, 18);
            this.btnNuevo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Primary = true;
            this.btnNuevo.Size = new System.Drawing.Size(149, 30);
            this.btnNuevo.TabIndex = 17;
            this.btnNuevo.Text = "Nuevo cliente";
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Depth = 0;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(332, 18);
            this.btnBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Primary = true;
            this.btnBuscar.Size = new System.Drawing.Size(103, 30);
            this.btnBuscar.TabIndex = 16;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Depth = 0;
            this.txtBuscar.Hint = "Buscar por cliente";
            this.txtBuscar.Location = new System.Drawing.Point(34, 25);
            this.txtBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.PasswordChar = '\0';
            this.txtBuscar.SelectedText = "";
            this.txtBuscar.SelectionLength = 0;
            this.txtBuscar.SelectionStart = 0;
            this.txtBuscar.Size = new System.Drawing.Size(277, 23);
            this.txtBuscar.TabIndex = 15;
            this.txtBuscar.UseSystemPasswordChar = false;
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 611);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.pnlClientes);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmProductos";
            this.Text = "frmProductos";
            this.pnlClientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblTitulo;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalir;
        private System.Windows.Forms.Panel pnlClientes;
        private System.Windows.Forms.DataGridView dgClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn first_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn street;
        private System.Windows.Forms.DataGridViewButtonColumn btnActualizar;
        private System.Windows.Forms.DataGridViewButtonColumn btnEliminar;
        private MaterialSkin.Controls.MaterialRaisedButton btnNuevo;
        private MaterialSkin.Controls.MaterialRaisedButton btnBuscar;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBuscar;
    }
}