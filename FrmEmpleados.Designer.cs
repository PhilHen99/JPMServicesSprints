namespace Formularios_H3
{
    partial class FrmEmpleados
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
            dtmRetiro = new DateTimePicker();
            dtmIngreso = new DateTimePicker();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            cboRol = new ComboBox();
            label9 = new Label();
            label2 = new Label();
            txtEmail = new TextBox();
            txtTelefono = new TextBox();
            txtDireccion = new TextBox();
            txtDocumento = new TextBox();
            txtNombre = new TextBox();
            txtId = new TextBox();
            btnSalir = new Button();
            groupBox3 = new GroupBox();
            btnGuardar = new Button();
            txtDatosAdicionales = new TextBox();
            panel1.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 22F);
            lblTitulo.Location = new Point(303, 24);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(185, 41);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "EMPLEADOS";
            // 
            // panel1
            // 
            panel1.Controls.Add(txtDatosAdicionales);
            panel1.Controls.Add(dtmRetiro);
            panel1.Controls.Add(dtmIngreso);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(cboRol);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(txtTelefono);
            panel1.Controls.Add(txtDireccion);
            panel1.Controls.Add(txtDocumento);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(txtId);
            panel1.Location = new Point(57, 78);
            panel1.Name = "panel1";
            panel1.Size = new Size(689, 271);
            panel1.TabIndex = 2;
            // 
            // dtmRetiro
            // 
            dtmRetiro.Format = DateTimePickerFormat.Custom;
            dtmRetiro.Location = new Point(530, 97);
            dtmRetiro.Name = "dtmRetiro";
            dtmRetiro.Size = new Size(147, 23);
            dtmRetiro.TabIndex = 18;
            // 
            // dtmIngreso
            // 
            dtmIngreso.Format = DateTimePickerFormat.Custom;
            dtmIngreso.Location = new Point(530, 60);
            dtmIngreso.Name = "dtmIngreso";
            dtmIngreso.Size = new Size(147, 23);
            dtmIngreso.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Underline);
            label5.Location = new Point(382, 150);
            label5.Name = "label5";
            label5.Size = new Size(142, 19);
            label5.TabIndex = 16;
            label5.Text = "DATOS ADICIONALES";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Underline);
            label4.Location = new Point(403, 97);
            label4.Name = "label4";
            label4.Size = new Size(121, 19);
            label4.TabIndex = 15;
            label4.Text = "FECHA DE RETIRO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Underline);
            label3.Location = new Point(386, 62);
            label3.Name = "label3";
            label3.Size = new Size(138, 19);
            label3.TabIndex = 14;
            label3.Text = "FECHA DE REGISTRO";
            // 
            // cboRol
            // 
            cboRol.FormattingEnabled = true;
            cboRol.Location = new Point(530, 23);
            cboRol.Name = "cboRol";
            cboRol.Size = new Size(147, 23);
            cboRol.TabIndex = 13;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F, FontStyle.Underline);
            label9.Location = new Point(409, 27);
            label9.Name = "label9";
            label9.Size = new Size(111, 19);
            label9.TabIndex = 12;
            label9.Text = "ROL EMPLEADO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 23);
            label2.Name = "label2";
            label2.Size = new Size(18, 15);
            label2.TabIndex = 11;
            label2.Text = "ID";
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
            // txtNombre
            // 
            txtNombre.Location = new Point(32, 60);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Nombre Empleado";
            txtNombre.Size = new Size(265, 23);
            txtNombre.TabIndex = 6;
            // 
            // txtId
            // 
            txtId.Location = new Point(56, 20);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(37, 23);
            txtId.TabIndex = 5;
            // 
            // btnSalir
            // 
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Microsoft Sans Serif", 14F);
            btnSalir.ForeColor = Color.Black;
            btnSalir.Location = new Point(470, 14);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(139, 37);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnGuardar);
            groupBox3.Controls.Add(btnSalir);
            groupBox3.Location = new Point(57, 376);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(694, 57);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            // 
            // btnGuardar
            // 
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Microsoft Sans Serif", 14F);
            btnGuardar.ForeColor = Color.Black;
            btnGuardar.Location = new Point(171, 14);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(139, 37);
            btnGuardar.TabIndex = 5;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtDatosAdicionales
            // 
            txtDatosAdicionales.Location = new Point(386, 178);
            txtDatosAdicionales.Multiline = true;
            txtDatosAdicionales.Name = "txtDatosAdicionales";
            txtDatosAdicionales.Size = new Size(291, 84);
            txtDatosAdicionales.TabIndex = 19;
            txtDatosAdicionales.TextChanged += txtDatosAdicionales_TextChanged;
            // 
            // FrmEmpleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(807, 445);
            Controls.Add(groupBox3);
            Controls.Add(panel1);
            Controls.Add(lblTitulo);
            Name = "FrmEmpleados";
            Text = "FrmEmpleados";
            Load += FrmEmpleados_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Panel panel1;
        private Label label2;
        private TextBox txtEmail;
        private TextBox txtTelefono;
        private TextBox txtDireccion;
        private TextBox txtDocumento;
        private TextBox txtNombre;
        private TextBox txtId;
        private DateTimePicker dtmRetiro;
        private DateTimePicker dtmIngreso;
        private Label label5;
        private Label label4;
        private Label label3;
        private ComboBox cboRol;
        private Label label9;
        private Button btnSalir;
        private GroupBox groupBox3;
        private Button btnGuardar;
        private TextBox txtDatosAdicionales;
    }
}