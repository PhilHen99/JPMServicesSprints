namespace Formularios_H3
{
    partial class FrmCliente
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
            lblTitulo = new Label();
            panel1 = new Panel();
            label1 = new Label();
            txtEmail = new TextBox();
            txtTelefono = new TextBox();
            txtDireccion = new TextBox();
            txtDocumento = new TextBox();
            txtNombreCliente = new TextBox();
            txtId = new TextBox();
            panel2 = new Panel();
            btnCancelar = new Button();
            btnGuardar = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 22F);
            lblTitulo.Location = new Point(66, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(313, 41);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Ingreso Cliente Nuevo";
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(txtTelefono);
            panel1.Controls.Add(txtDireccion);
            panel1.Controls.Add(txtDocumento);
            panel1.Controls.Add(txtNombreCliente);
            panel1.Controls.Add(txtId);
            panel1.Location = new Point(34, 53);
            panel1.Name = "panel1";
            panel1.Size = new Size(382, 265);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 23);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 11;
            label1.Text = "ID";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(32, 239);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(265, 23);
            txtEmail.TabIndex = 10;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(32, 195);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.PlaceholderText = "Telefono";
            txtTelefono.Size = new Size(265, 23);
            txtTelefono.TabIndex = 9;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(32, 150);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.PlaceholderText = "Direccion";
            txtDireccion.Size = new Size(265, 23);
            txtDireccion.TabIndex = 8;
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(32, 106);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.PlaceholderText = "Documento";
            txtDocumento.Size = new Size(265, 23);
            txtDocumento.TabIndex = 7;
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.Location = new Point(32, 60);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.PlaceholderText = "Nombre Cliente";
            txtNombreCliente.Size = new Size(265, 23);
            txtNombreCliente.TabIndex = 6;
            // 
            // txtId
            // 
            txtId.Location = new Point(56, 20);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(37, 23);
            txtId.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnCancelar);
            panel2.Controls.Add(btnGuardar);
            panel2.Location = new Point(40, 338);
            panel2.Name = "panel2";
            panel2.Size = new Size(376, 52);
            panel2.TabIndex = 2;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(211, 9);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(130, 35);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(26, 9);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(130, 35);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // FrmCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(456, 430);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(lblTitulo);
            Name = "FrmCliente";
            Text = "FrmCliente";
            Load += FrmCliente_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Panel panel1;
        private Panel panel2;
        private TextBox txtId;
        private Button btnCancelar;
        private Button btnGuardar;
        private TextBox txtTelefono;
        private TextBox txtDireccion;
        private TextBox txtDocumento;
        private TextBox txtNombreCliente;
        private TextBox txtEmail;
        private Label label1;
    }
}