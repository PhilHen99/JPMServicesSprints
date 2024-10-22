namespace Formularios_H3
{
    partial class FrmFacturas1
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
            label9 = new Label();
            CBoxFechaRegistro = new ComboBox();
            label8 = new Label();
            CBoxEstadoFactura = new ComboBox();
            comboBox2 = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label4 = new Label();
            label3 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            txtNroFactura = new TextBox();
            panel2 = new Panel();
            dgDetallesFactura = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Producto = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Valor = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            btnEditar = new DataGridViewButtonColumn();
            btnBorrar = new DataGridViewButtonColumn();
            label10 = new Label();
            btnGuardar = new Button();
            btnEliminar = new Button();
            btnSalir = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgDetallesFactura).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 22F);
            lblTitulo.Location = new Point(395, 19);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(158, 41);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "FACTURAS";
            // 
            // panel1
            // 
            panel1.Controls.Add(label9);
            panel1.Controls.Add(CBoxFechaRegistro);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(CBoxEstadoFactura);
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtNroFactura);
            panel1.Location = new Point(92, 79);
            panel1.Name = "panel1";
            panel1.Size = new Size(685, 240);
            panel1.TabIndex = 2;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F, FontStyle.Underline);
            label9.Location = new Point(505, 32);
            label9.Name = "label9";
            label9.Size = new Size(138, 19);
            label9.TabIndex = 11;
            label9.Text = "FECHA DE REGISTRO";
            // 
            // CBoxFechaRegistro
            // 
            CBoxFechaRegistro.FormattingEnabled = true;
            CBoxFechaRegistro.Location = new Point(505, 57);
            CBoxFechaRegistro.Name = "CBoxFechaRegistro";
            CBoxFechaRegistro.Size = new Size(150, 23);
            CBoxFechaRegistro.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F, FontStyle.Underline);
            label8.Location = new Point(505, 109);
            label8.Name = "label8";
            label8.Size = new Size(121, 19);
            label8.TabIndex = 9;
            label8.Text = "ESTADO FACTURA";
            // 
            // CBoxEstadoFactura
            // 
            CBoxEstadoFactura.FormattingEnabled = true;
            CBoxEstadoFactura.Location = new Point(505, 134);
            CBoxEstadoFactura.Name = "CBoxEstadoFactura";
            CBoxEstadoFactura.Size = new Size(150, 23);
            CBoxEstadoFactura.TabIndex = 10;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(166, 95);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(233, 23);
            comboBox2.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Underline);
            label5.Location = new Point(29, 196);
            label5.Name = "label5";
            label5.Size = new Size(109, 19);
            label5.TabIndex = 7;
            label5.Text = "TOTAL FACTURA";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Underline);
            label6.Location = new Point(28, 165);
            label6.Name = "label6";
            label6.Size = new Size(72, 19);
            label6.TabIndex = 6;
            label6.Text = "TOTAL IVA";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Underline);
            label7.Location = new Point(29, 129);
            label7.Name = "label7";
            label7.Size = new Size(86, 19);
            label7.TabIndex = 5;
            label7.Text = "DESCUENTO";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Underline);
            label4.Location = new Point(28, 95);
            label4.Name = "label4";
            label4.Size = new Size(81, 19);
            label4.TabIndex = 4;
            label4.Text = "EMPLEADO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Underline);
            label3.Location = new Point(28, 54);
            label3.Name = "label3";
            label3.Size = new Size(60, 19);
            label3.TabIndex = 3;
            label3.Text = "CLIENTE";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(166, 54);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(233, 23);
            comboBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Underline);
            label2.Location = new Point(28, 17);
            label2.Name = "label2";
            label2.Size = new Size(100, 19);
            label2.TabIndex = 1;
            label2.Text = "NRO FACTURA";
            // 
            // txtNroFactura
            // 
            txtNroFactura.Location = new Point(166, 14);
            txtNroFactura.Name = "txtNroFactura";
            txtNroFactura.Size = new Size(93, 23);
            txtNroFactura.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(dgDetallesFactura);
            panel2.Location = new Point(92, 338);
            panel2.Name = "panel2";
            panel2.Size = new Size(849, 135);
            panel2.TabIndex = 3;
            // 
            // dgDetallesFactura
            // 
            dgDetallesFactura.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgDetallesFactura.Columns.AddRange(new DataGridViewColumn[] { ID, Producto, Cantidad, Valor, Total, btnEditar, btnBorrar });
            dgDetallesFactura.Location = new Point(11, 12);
            dgDetallesFactura.Name = "dgDetallesFactura";
            dgDetallesFactura.Size = new Size(826, 120);
            dgDetallesFactura.TabIndex = 1;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Width = 60;
            // 
            // Producto
            // 
            Producto.HeaderText = "PRODUCTO";
            Producto.Name = "Producto";
            Producto.ReadOnly = true;
            Producto.Width = 200;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "CANTIDAD";
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            Cantidad.Width = 110;
            // 
            // Valor
            // 
            Valor.HeaderText = "VALOR";
            Valor.Name = "Valor";
            Valor.ReadOnly = true;
            Valor.Width = 110;
            // 
            // Total
            // 
            Total.HeaderText = "TOTAL";
            Total.Name = "Total";
            Total.ReadOnly = true;
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
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10F, FontStyle.Underline);
            label10.Location = new Point(105, 328);
            label10.Name = "label10";
            label10.Size = new Size(131, 19);
            label10.TabIndex = 13;
            label10.Text = "DETALLES FACTURA";
            // 
            // btnGuardar
            // 
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Microsoft Sans Serif", 14F);
            btnGuardar.ForeColor = Color.Black;
            btnGuardar.Location = new Point(828, 85);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(122, 31);
            btnGuardar.TabIndex = 14;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Microsoft Sans Serif", 14F);
            btnEliminar.ForeColor = Color.Black;
            btnEliminar.Location = new Point(828, 148);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(122, 31);
            btnEliminar.TabIndex = 15;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnSalir
            // 
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Microsoft Sans Serif", 14F);
            btnSalir.ForeColor = Color.Black;
            btnSalir.Location = new Point(828, 263);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(122, 31);
            btnSalir.TabIndex = 16;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // FrmFacturas1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(990, 494);
            Controls.Add(btnSalir);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(label10);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(lblTitulo);
            Name = "FrmFacturas1";
            Text = "FrmFacturas1";
            Load += FrmFacturas1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgDetallesFactura).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Panel panel1;
        private ComboBox comboBox1;
        private Label label2;
        private TextBox txtNroFactura;
        private Panel panel2;
        private Label label8;
        private ComboBox CBoxEstadoFactura;
        private ComboBox comboBox2;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label4;
        private Label label3;
        private Label label9;
        private ComboBox CBoxFechaRegistro;
        private Label label10;
        private DataGridView dgDetallesFactura;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Valor;
        private DataGridViewTextBoxColumn Total;
        private DataGridViewButtonColumn btnEditar;
        private DataGridViewButtonColumn btnBorrar;
        private Button btnGuardar;
        private Button btnEliminar;
        private Button btnSalir;
    }
}