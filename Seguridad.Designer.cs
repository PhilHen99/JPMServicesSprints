namespace Formularios_H3
{
    partial class Seguridad
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
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            comboBox1 = new ComboBox();
            label1 = new Label();
            txtClave = new TextBox();
            txtUsuario = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 11F);
            materialLabel1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialLabel1.Location = new Point(234, 73);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(329, 19);
            materialLabel1.TabIndex = 0;
            materialLabel1.Text = "ADMINISTRACION DE USUARIOS DEL SISTEMA";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(158, 21);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(280, 23);
            comboBox1.TabIndex = 10;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(73, 19);
            label1.Name = "label1";
            label1.Size = new Size(79, 21);
            label1.TabIndex = 9;
            label1.Text = "Empleado";
            // 
            // txtClave
            // 
            txtClave.Location = new Point(173, 166);
            txtClave.Name = "txtClave";
            txtClave.PlaceholderText = "Clave";
            txtClave.Size = new Size(182, 23);
            txtClave.TabIndex = 8;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(173, 128);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Usuario";
            txtUsuario.Size = new Size(265, 23);
            txtUsuario.TabIndex = 7;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 14F);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(1, 10);
            button1.Name = "button1";
            button1.Size = new Size(139, 37);
            button1.TabIndex = 5;
            button1.Text = "Salir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft Sans Serif", 14F);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(32, 167);
            button2.Name = "button2";
            button2.Size = new Size(139, 37);
            button2.TabIndex = 6;
            button2.Text = "ELIMINAR";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Microsoft Sans Serif", 14F);
            button3.ForeColor = Color.Black;
            button3.Location = new Point(32, 102);
            button3.Name = "button3";
            button3.Size = new Size(139, 37);
            button3.TabIndex = 7;
            button3.Text = "ACTUALIZAR";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Microsoft Sans Serif", 14F);
            button4.ForeColor = Color.Black;
            button4.Location = new Point(27, 37);
            button4.Name = "button4";
            button4.Size = new Size(139, 37);
            button4.TabIndex = 8;
            button4.Text = "CONSULTAR";
            button4.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtUsuario);
            groupBox1.Controls.Add(txtClave);
            groupBox1.Location = new Point(35, 143);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(613, 248);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(button3);
            groupBox2.Location = new Point(703, 143);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 248);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button1);
            groupBox3.Location = new Point(703, 472);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(141, 56);
            groupBox3.TabIndex = 11;
            groupBox3.TabStop = false;
            // 
            // Seguridad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(929, 579);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(materialLabel1);
            Name = "Seguridad";
            Text = "Seguridad";
            Load += Seguridad_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private ComboBox comboBox1;
        private Label label1;
        private TextBox txtClave;
        private TextBox txtUsuario;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
    }
}