namespace Formularios_H3
{
    partial class Productos
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
            dgClientes = new DataGridView();
            groupBox1 = new GroupBox();
            btnNuevo = new Button();
            txtBuscar = new TextBox();
            btnBuscar = new Button();
            label1 = new Label();
            ID = new DataGridViewTextBoxColumn();
            PRODUCTO = new DataGridViewTextBoxColumn();
            CATEGORIA = new DataGridViewTextBoxColumn();
            PRECIO = new DataGridViewTextBoxColumn();
            STOCK = new DataGridViewTextBoxColumn();
            btnEDITAR = new DataGridViewButtonColumn();
            btnBORRAR = new DataGridViewButtonColumn();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgClientes).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button1);
            groupBox3.Location = new Point(101, 463);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(595, 57);
            groupBox3.TabIndex = 10;
            groupBox3.TabStop = false;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 14F);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(450, 14);
            button1.Name = "button1";
            button1.Size = new Size(139, 37);
            button1.TabIndex = 5;
            button1.Text = "Salir";
            button1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgClientes);
            groupBox2.Location = new Point(27, 187);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(758, 270);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            // 
            // dgClientes
            // 
            dgClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgClientes.Columns.AddRange(new DataGridViewColumn[] { ID, PRODUCTO, CATEGORIA, PRECIO, STOCK, btnEDITAR, btnBORRAR });
            dgClientes.Location = new Point(6, 12);
            dgClientes.Name = "dgClientes";
            dgClientes.Size = new Size(746, 252);
            dgClientes.TabIndex = 0;
            dgClientes.CellContentClick += dgClientes_CellContentClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnNuevo);
            groupBox1.Controls.Add(txtBuscar);
            groupBox1.Controls.Add(btnBuscar);
            groupBox1.Location = new Point(95, 73);
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
            label1.Location = new Point(288, 31);
            label1.Name = "label1";
            label1.Size = new Size(236, 39);
            label1.TabIndex = 7;
            label1.Text = "PRODUCTOS";
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // PRODUCTO
            // 
            PRODUCTO.HeaderText = "PRODUCTO";
            PRODUCTO.Name = "PRODUCTO";
            PRODUCTO.ReadOnly = true;
            // 
            // CATEGORIA
            // 
            CATEGORIA.HeaderText = "CODIGO";
            CATEGORIA.Name = "CATEGORIA";
            CATEGORIA.ReadOnly = true;
            // 
            // PRECIO
            // 
            PRECIO.HeaderText = "PRECIO";
            PRECIO.Name = "PRECIO";
            PRECIO.ReadOnly = true;
            // 
            // STOCK
            // 
            STOCK.HeaderText = "STOCK";
            STOCK.Name = "STOCK";
            STOCK.ReadOnly = true;
            // 
            // btnEDITAR
            // 
            btnEDITAR.HeaderText = "EDITAR";
            btnEDITAR.Name = "btnEDITAR";
            btnEDITAR.ReadOnly = true;
            btnEDITAR.Text = "EDITAR";
            btnEDITAR.UseColumnTextForButtonValue = true;
            // 
            // btnBORRAR
            // 
            btnBORRAR.HeaderText = "BORRAR";
            btnBORRAR.Name = "btnBORRAR";
            btnBORRAR.ReadOnly = true;
            btnBORRAR.Text = "BORRAR";
            btnBORRAR.UseColumnTextForButtonValue = true;
            // 
            // Productos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(815, 532);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Productos";
            Text = "Productos";
            Load += Productos_Load;
            groupBox3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgClientes).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private DataGridView dgClientes;
        private GroupBox groupBox1;
        private Button btnNuevo;
        private TextBox txtBuscar;
        private Button btnBuscar;
        private Label label1;
        private Button button1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn PRODUCTO;
        private DataGridViewTextBoxColumn CATEGORIA;
        private DataGridViewTextBoxColumn PRECIO;
        private DataGridViewTextBoxColumn STOCK;
        private DataGridViewButtonColumn btnEDITAR;
        private DataGridViewButtonColumn btnBORRAR;
    }
}