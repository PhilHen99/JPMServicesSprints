namespace Formularios_H3
{
    partial class FrmRoles
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
            groupBox1 = new GroupBox();
            btnActualizar = new Button();
            txtBuscar = new TextBox();
            btnSalir = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F);
            label1.Location = new Point(204, 29);
            label1.Name = "label1";
            label1.Size = new Size(292, 41);
            label1.TabIndex = 1;
            label1.Text = "ROL DE EMPLEADOS";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnActualizar);
            groupBox1.Controls.Add(txtBuscar);
            groupBox1.Controls.Add(btnSalir);
            groupBox1.Location = new Point(53, 91);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(601, 192);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Descripcion Rol";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btnActualizar
            // 
            btnActualizar.FlatAppearance.BorderSize = 0;
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.Font = new Font("Microsoft Sans Serif", 14F);
            btnActualizar.ForeColor = Color.Black;
            btnActualizar.Location = new Point(444, 42);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(141, 37);
            btnActualizar.TabIndex = 3;
            btnActualizar.Text = "ACTUALIZAR";
            btnActualizar.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(20, 52);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(342, 23);
            txtBuscar.TabIndex = 1;
            // 
            // btnSalir
            // 
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Microsoft Sans Serif", 14F);
            btnSalir.ForeColor = Color.Black;
            btnSalir.Location = new Point(460, 116);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(103, 37);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // FrmRoles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(707, 334);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "FrmRoles";
            Text = "FrmRoles";
            Load += FrmRoles_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Button btnActualizar;
        private TextBox txtBuscar;
        private Button btnSalir;
    }
}