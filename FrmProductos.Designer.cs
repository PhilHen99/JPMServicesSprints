namespace Formularios_H3
{
    partial class FrmProductos
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
            comboBox1 = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtCantidadStock = new TextBox();
            txtPrecioVenta = new TextBox();
            txtPrecioCompra = new TextBox();
            txtCodigoReferencia = new TextBox();
            txtNombreProducto = new TextBox();
            txtId = new TextBox();
            listBox1 = new ListBox();
            txtRutaImagen = new TextBox();
            btnCancelar = new Button();
            btnGuardar = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 22F);
            lblTitulo.Location = new Point(274, 23);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(191, 41);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "PRODUCTOS";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(508, 118);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(185, 23);
            comboBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(426, 121);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 3;
            label2.Text = "CATEGORIA";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(426, 233);
            label3.Name = "label3";
            label3.Size = new Size(139, 15);
            label3.TabIndex = 4;
            label3.Text = "DETALLES DE PRODUCTO";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(64, 88);
            label4.Name = "label4";
            label4.Size = new Size(18, 15);
            label4.TabIndex = 18;
            label4.Text = "ID";
            // 
            // txtCantidadStock
            // 
            txtCantidadStock.Location = new Point(64, 315);
            txtCantidadStock.Name = "txtCantidadStock";
            txtCantidadStock.PlaceholderText = "Cantidad en Stock";
            txtCantidadStock.Size = new Size(265, 23);
            txtCantidadStock.TabIndex = 17;
            // 
            // txtPrecioVenta
            // 
            txtPrecioVenta.Location = new Point(64, 260);
            txtPrecioVenta.Name = "txtPrecioVenta";
            txtPrecioVenta.PlaceholderText = "PrecioVenta";
            txtPrecioVenta.Size = new Size(265, 23);
            txtPrecioVenta.TabIndex = 16;
            txtPrecioVenta.TextChanged += txtPrecioVenta_TextChanged;
            // 
            // txtPrecioCompra
            // 
            txtPrecioCompra.Location = new Point(64, 215);
            txtPrecioCompra.Name = "txtPrecioCompra";
            txtPrecioCompra.PlaceholderText = "Precio Compra";
            txtPrecioCompra.Size = new Size(265, 23);
            txtPrecioCompra.TabIndex = 15;
            // 
            // txtCodigoReferencia
            // 
            txtCodigoReferencia.Location = new Point(64, 171);
            txtCodigoReferencia.Name = "txtCodigoReferencia";
            txtCodigoReferencia.PlaceholderText = "Codigo Referencia";
            txtCodigoReferencia.Size = new Size(265, 23);
            txtCodigoReferencia.TabIndex = 14;
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Location = new Point(64, 125);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.PlaceholderText = "Nombre Producto";
            txtNombreProducto.Size = new Size(265, 23);
            txtNombreProducto.TabIndex = 13;
            // 
            // txtId
            // 
            txtId.Location = new Point(88, 85);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(37, 23);
            txtId.TabIndex = 12;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(426, 260);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(267, 79);
            listBox1.TabIndex = 19;
            // 
            // txtRutaImagen
            // 
            txtRutaImagen.Location = new Point(428, 181);
            txtRutaImagen.Name = "txtRutaImagen";
            txtRutaImagen.PlaceholderText = "Ruta Imagen";
            txtRutaImagen.Size = new Size(265, 23);
            txtRutaImagen.TabIndex = 20;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(384, 386);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(130, 35);
            btnCancelar.TabIndex = 22;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(199, 386);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(130, 35);
            btnGuardar.TabIndex = 21;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // FrmProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(748, 455);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(txtRutaImagen);
            Controls.Add(listBox1);
            Controls.Add(label4);
            Controls.Add(txtCantidadStock);
            Controls.Add(txtPrecioVenta);
            Controls.Add(txtPrecioCompra);
            Controls.Add(txtCodigoReferencia);
            Controls.Add(txtNombreProducto);
            Controls.Add(txtId);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(lblTitulo);
            Name = "FrmProductos";
            Text = "FrmProductos";
            Load += FrmProductos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private ComboBox comboBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtCantidadStock;
        private TextBox txtPrecioVenta;
        private TextBox txtPrecioCompra;
        private TextBox txtCodigoReferencia;
        private TextBox txtNombreProducto;
        private TextBox txtId;
        private ListBox listBox1;
        private TextBox txtRutaImagen;
        private Button btnCancelar;
        private Button btnGuardar;
    }
}