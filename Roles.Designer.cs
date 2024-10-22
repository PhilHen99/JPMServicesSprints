namespace Formularios_H3
{
    partial class Roles
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
            groupBox1 = new GroupBox();
            btnNuevo = new Button();
            txtBuscar = new TextBox();
            btnBuscar = new Button();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dgRoles = new DataGridView();
            CODIGO = new DataGridViewTextBoxColumn();
            DESCRIPCION_ROLES = new DataGridViewTextBoxColumn();
            btnEditar = new DataGridViewButtonColumn();
            btnBorrar = new DataGridViewButtonColumn();
            groupBox3 = new GroupBox();
            button1 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgRoles).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnNuevo);
            groupBox1.Controls.Add(txtBuscar);
            groupBox1.Controls.Add(btnBuscar);
            groupBox1.Location = new Point(139, 62);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(601, 84);
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
            btnNuevo.Location = new Point(473, 23);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(103, 37);
            btnNuevo.TabIndex = 3;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
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
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 25F);
            label1.Location = new Point(371, 8);
            label1.Name = "label1";
            label1.Size = new Size(133, 39);
            label1.TabIndex = 7;
            label1.Text = "ROLES";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgRoles);
            groupBox2.Location = new Point(139, 176);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(601, 270);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            // 
            // dgRoles
            // 
            dgRoles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgRoles.Columns.AddRange(new DataGridViewColumn[] { CODIGO, DESCRIPCION_ROLES, btnEditar, btnBorrar });
            dgRoles.Location = new Point(6, 22);
            dgRoles.Name = "dgRoles";
            dgRoles.Size = new Size(589, 235);
            dgRoles.TabIndex = 0;
            // 
            // CODIGO
            // 
            CODIGO.HeaderText = "CODIGO";
            CODIGO.Name = "CODIGO";
            CODIGO.ReadOnly = true;
            CODIGO.Width = 70;
            // 
            // DESCRIPCION_ROLES
            // 
            DESCRIPCION_ROLES.HeaderText = "DESCRIPCION ROLES";
            DESCRIPCION_ROLES.Name = "DESCRIPCION_ROLES";
            DESCRIPCION_ROLES.ReadOnly = true;
            DESCRIPCION_ROLES.Width = 200;
            // 
            // btnEditar
            // 
            btnEditar.HeaderText = "EDITAR";
            btnEditar.Name = "btnEditar";
            btnEditar.ReadOnly = true;
            btnEditar.Text = "EDITAR";
            btnEditar.UseColumnTextForButtonValue = true;
            btnEditar.Width = 120;
            // 
            // btnBorrar
            // 
            btnBorrar.HeaderText = "BORRAR";
            btnBorrar.Name = "btnBorrar";
            btnBorrar.ReadOnly = true;
            btnBorrar.Text = "BORRAR";
            btnBorrar.UseColumnTextForButtonValue = true;
            btnBorrar.Width = 120;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button1);
            groupBox3.Location = new Point(139, 452);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(601, 57);
            groupBox3.TabIndex = 12;
            groupBox3.TabStop = false;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 14F);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(456, 15);
            button1.Name = "button1";
            button1.Size = new Size(139, 37);
            button1.TabIndex = 4;
            button1.Text = "Salir";
            button1.UseVisualStyleBackColor = true;
            // 
            // Roles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(878, 516);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Roles";
            Text = "Roles";
            Load += Roles_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgRoles).EndInit();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox groupBox1;
        private Button btnNuevo;
        private TextBox txtBuscar;
        private Button btnBuscar;
        private Label label1;
        private GroupBox groupBox2;
        private DataGridView dgRoles;
        private DataGridViewTextBoxColumn CODIGO;
        private DataGridViewTextBoxColumn DESCRIPCION_ROLES;
        private DataGridViewButtonColumn btnEditar;
        private DataGridViewButtonColumn btnBorrar;
        private GroupBox groupBox3;
        private Button button1;
    }
}