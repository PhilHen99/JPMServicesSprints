namespace Formularios_H3
{
    partial class FrmListasClientes
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
            label1 = new Label();
            txtBuscar = new TextBox();
            btnBuscar = new Button();
            groupBox1 = new GroupBox();
            btnNuevo = new Button();
            groupBox2 = new GroupBox();
            dgClientes = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Cliente = new DataGridViewTextBoxColumn();
            Documento = new DataGridViewTextBoxColumn();
            Direccion = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            btnEditar = new DataGridViewButtonColumn();
            btnBorrar = new DataGridViewButtonColumn();
            groupBox3 = new GroupBox();
            button1 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgClientes).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 25F);
            label1.Location = new Point(398, 9);
            label1.Name = "label1";
            label1.Size = new Size(186, 39);
            label1.TabIndex = 0;
            label1.Text = "CLIENTES";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(6, 32);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(253, 23);
            txtBuscar.TabIndex = 1;
            // 
            // btnBuscar
            // 
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Microsoft Sans Serif", 14F);
            btnBuscar.ForeColor = Color.Black;
            btnBuscar.Location = new Point(326, 23);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(103, 37);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnNuevo);
            groupBox1.Controls.Add(txtBuscar);
            groupBox1.Controls.Add(btnBuscar);
            groupBox1.Location = new Point(166, 63);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(601, 84);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Buscar";
            // 
            // btnNuevo
            // 
            btnNuevo.FlatAppearance.BorderSize = 0;
            btnNuevo.FlatStyle = FlatStyle.Flat;
            btnNuevo.Font = new Font("Microsoft Sans Serif", 14F);
            btnNuevo.ForeColor = Color.Black;
            btnNuevo.Location = new Point(476, 22);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(103, 37);
            btnNuevo.TabIndex = 3;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgClientes);
            groupBox2.Location = new Point(12, 183);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(905, 306);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            // 
            // dgClientes
            // 
            dgClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgClientes.Columns.AddRange(new DataGridViewColumn[] { ID, Cliente, Documento, Direccion, Telefono, Email, btnEditar, btnBorrar });
            dgClientes.Location = new Point(6, 22);
            dgClientes.Name = "dgClientes";
            dgClientes.Size = new Size(893, 278);
            dgClientes.TabIndex = 0;
            dgClientes.CellContentClick += dgClientes_CellContentClick;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Width = 30;
            // 
            // Cliente
            // 
            Cliente.HeaderText = "CLIENTE";
            Cliente.Name = "Cliente";
            Cliente.ReadOnly = true;
            Cliente.Width = 180;
            // 
            // Documento
            // 
            Documento.HeaderText = "DOCUMENTO";
            Documento.Name = "Documento";
            Documento.ReadOnly = true;
            Documento.Width = 110;
            // 
            // Direccion
            // 
            Direccion.HeaderText = "DIRECCION";
            Direccion.Name = "Direccion";
            Direccion.ReadOnly = true;
            Direccion.Width = 110;
            // 
            // Telefono
            // 
            Telefono.HeaderText = "TELEFONO";
            Telefono.Name = "Telefono";
            Telefono.ReadOnly = true;
            // 
            // Email
            // 
            Email.HeaderText = "EMAIL";
            Email.Name = "Email";
            Email.ReadOnly = true;
            Email.Width = 120;
            // 
            // btnEditar
            // 
            btnEditar.HeaderText = "EDITAR";
            btnEditar.Name = "btnEditar";
            btnEditar.ReadOnly = true;
            btnEditar.Text = "EDITAR";
            btnEditar.UseColumnTextForButtonValue = true;
            btnEditar.Width = 90;
            // 
            // btnBorrar
            // 
            btnBorrar.HeaderText = "BORRAR";
            btnBorrar.Name = "btnBorrar";
            btnBorrar.ReadOnly = true;
            btnBorrar.Text = "BORRAR";
            btnBorrar.UseColumnTextForButtonValue = true;
            btnBorrar.Width = 90;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button1);
            groupBox3.Location = new Point(723, 495);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(143, 57);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 14F);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(3, 14);
            button1.Name = "button1";
            button1.Size = new Size(139, 37);
            button1.TabIndex = 4;
            button1.Text = "Salir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FrmListasClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(929, 579);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "FrmListasClientes";
            Text = "FrmListasClientes";
            Load += FrmListasClientes_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgClientes).EndInit();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtBuscar;
        private Button btnBuscar;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView dgClientes;
        private GroupBox groupBox3;
        private Button btnNuevo;
        private Button button1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Cliente;
        private DataGridViewTextBoxColumn Documento;
        private DataGridViewTextBoxColumn Direccion;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewButtonColumn btnEditar;
        private DataGridViewButtonColumn btnBorrar;
    }
}