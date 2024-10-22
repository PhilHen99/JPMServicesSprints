namespace Formularios_H3
{
    partial class Empleados
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
            groupBox3 = new GroupBox();
            button1 = new Button();
            groupBox1 = new GroupBox();
            btnNuevo = new Button();
            txtBuscar = new TextBox();
            btnBuscar = new Button();
            label1 = new Label();
            dgEmpleados = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Empleado = new DataGridViewTextBoxColumn();
            Documento = new DataGridViewTextBoxColumn();
            Direccion = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            btnEditar = new DataGridViewButtonColumn();
            btnBorrar = new DataGridViewButtonColumn();
            groupBox2 = new GroupBox();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgEmpleados).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button1);
            groupBox3.Location = new Point(753, 500);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(149, 57);
            groupBox3.TabIndex = 10;
            groupBox3.TabStop = false;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 14F);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(4, 14);
            button1.Name = "button1";
            button1.Size = new Size(139, 37);
            button1.TabIndex = 5;
            button1.Text = "Salir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnNuevo);
            groupBox1.Controls.Add(txtBuscar);
            groupBox1.Controls.Add(btnBuscar);
            groupBox1.Location = new Point(125, 63);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(688, 84);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Buscar";
            // 
            // btnNuevo
            // 
            btnNuevo.FlatAppearance.BorderSize = 0;
            btnNuevo.FlatStyle = FlatStyle.Flat;
            btnNuevo.Font = new Font("Microsoft Sans Serif", 14F);
            btnNuevo.ForeColor = Color.Black;
            btnNuevo.Location = new Point(561, 22);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(103, 37);
            btnNuevo.TabIndex = 3;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(40, 32);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(304, 23);
            txtBuscar.TabIndex = 1;
            // 
            // btnBuscar
            // 
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Microsoft Sans Serif", 14F);
            btnBuscar.ForeColor = Color.Black;
            btnBuscar.Location = new Point(414, 22);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(103, 37);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 25F);
            label1.Location = new Point(367, 9);
            label1.Name = "label1";
            label1.Size = new Size(230, 39);
            label1.TabIndex = 7;
            label1.Text = "EMPLEADOS";
            // 
            // dgEmpleados
            // 
            dgEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgEmpleados.Columns.AddRange(new DataGridViewColumn[] { ID, Empleado, Documento, Direccion, Telefono, Email, btnEditar, btnBorrar });
            dgEmpleados.Location = new Point(6, 22);
            dgEmpleados.Name = "dgEmpleados";
            dgEmpleados.Size = new Size(893, 289);
            dgEmpleados.TabIndex = 0;
            dgEmpleados.CellContentClick += dgEmpleados_CellContentClick;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Width = 40;
            // 
            // Empleado
            // 
            Empleado.HeaderText = "EMPLEADO";
            Empleado.Name = "Empleado";
            Empleado.ReadOnly = true;
            Empleado.Width = 200;
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
            // 
            // Telefono
            // 
            Telefono.HeaderText = "TELEFONO";
            Telefono.Name = "Telefono";
            Telefono.ReadOnly = true;
            Telefono.Width = 110;
            // 
            // Email
            // 
            Email.HeaderText = "EMAIL";
            Email.Name = "Email";
            Email.ReadOnly = true;
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
            // groupBox2
            // 
            groupBox2.Controls.Add(dgEmpleados);
            groupBox2.Location = new Point(12, 177);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(905, 317);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            // 
            // Empleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(929, 579);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Empleados";
            Text = "Empleados";
            Load += Empleados_Load;
            groupBox3.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgEmpleados).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox3;
        private GroupBox groupBox1;
        private Button btnNuevo;
        private TextBox txtBuscar;
        private Button btnBuscar;
        private Label label1;
        private Button button1;
        private DataGridView dgEmpleados;
        private GroupBox groupBox2;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Empleado;
        private DataGridViewTextBoxColumn Documento;
        private DataGridViewTextBoxColumn Direccion;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewButtonColumn btnEditar;
        private DataGridViewButtonColumn btnBorrar;
    }
}