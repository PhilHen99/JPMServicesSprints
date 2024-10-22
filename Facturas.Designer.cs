namespace Formularios_H3
{
    partial class Facturas
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
            groupBox2 = new GroupBox();
            dgFacturas = new DataGridView();
            NroFactura = new DataGridViewTextBoxColumn();
            Cliente = new DataGridViewTextBoxColumn();
            Emision = new DataGridViewTextBoxColumn();
            Valor = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            btnEditar = new DataGridViewButtonColumn();
            btnBorrar = new DataGridViewButtonColumn();
            groupBox1 = new GroupBox();
            btnNuevo = new Button();
            txtBuscar = new TextBox();
            btnBuscar = new Button();
            label1 = new Label();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgFacturas).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button1);
            groupBox3.Location = new Point(39, 510);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(858, 57);
            groupBox3.TabIndex = 10;
            groupBox3.TabStop = false;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 14F);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(713, 14);
            button1.Name = "button1";
            button1.Size = new Size(139, 37);
            button1.TabIndex = 5;
            button1.Text = "Salir";
            button1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgFacturas);
            groupBox2.Location = new Point(37, 183);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(866, 321);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            // 
            // dgFacturas
            // 
            dgFacturas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgFacturas.Columns.AddRange(new DataGridViewColumn[] { NroFactura, Cliente, Emision, Valor, Estado, btnEditar, btnBorrar });
            dgFacturas.Location = new Point(12, 18);
            dgFacturas.Name = "dgFacturas";
            dgFacturas.Size = new Size(848, 297);
            dgFacturas.TabIndex = 1;
            dgFacturas.CellContentClick += dgFacturas_CellContentClick;
            // 
            // NroFactura
            // 
            NroFactura.HeaderText = "NRO FACTURA";
            NroFactura.Name = "NroFactura";
            NroFactura.ReadOnly = true;
            NroFactura.Width = 70;
            // 
            // Cliente
            // 
            Cliente.HeaderText = "CLIENTE";
            Cliente.Name = "Cliente";
            Cliente.ReadOnly = true;
            Cliente.Width = 220;
            // 
            // Emision
            // 
            Emision.HeaderText = "EMISION";
            Emision.Name = "Emision";
            Emision.ReadOnly = true;
            Emision.Width = 110;
            // 
            // Valor
            // 
            Valor.HeaderText = "VALOR";
            Valor.Name = "Valor";
            Valor.ReadOnly = true;
            Valor.Width = 110;
            // 
            // Estado
            // 
            Estado.HeaderText = "ESTADO";
            Estado.Name = "Estado";
            Estado.ReadOnly = true;
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
            // groupBox1
            // 
            groupBox1.Controls.Add(btnNuevo);
            groupBox1.Controls.Add(txtBuscar);
            groupBox1.Controls.Add(btnBuscar);
            groupBox1.Location = new Point(164, 93);
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
            label1.Location = new Point(396, 39);
            label1.Name = "label1";
            label1.Size = new Size(203, 39);
            label1.TabIndex = 7;
            label1.Text = "FACTURAS";
            // 
            // Facturas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(929, 579);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Facturas";
            Text = "Facturas";
            Load += Facturas_Load;
            groupBox3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgFacturas).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private Button btnNuevo;
        private TextBox txtBuscar;
        private Button btnBuscar;
        private Label label1;
        private Button button1;
        private DataGridView dgFacturas;
        private DataGridViewTextBoxColumn NroFactura;
        private DataGridViewTextBoxColumn Cliente;
        private DataGridViewTextBoxColumn Emision;
        private DataGridViewTextBoxColumn Valor;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewButtonColumn btnEditar;
        private DataGridViewButtonColumn btnBorrar;
    }
}