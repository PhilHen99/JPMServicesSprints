namespace Formularios_H3
{
    partial class FrmMain
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
            materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            tablas = new TabPage();
            btnProductos = new Button();
            btnClientes = new Button();
            Facturas = new TabPage();
            btnInformes = new Button();
            Seguridad = new TabPage();
            btnSeguridad = new Button();
            btnRoles = new Button();
            btnEmpleados = new Button();
            Ayudas = new TabPage();
            btnAcercaDe = new Button();
            btnAyuda = new Button();
            pnlMenu = new Panel();
            pnlContenedor = new Panel();
            materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            pnlSuperior = new Panel();
            btnFacturas = new Button();
            panel1 = new Panel();
            materialTabSelector2 = new MaterialSkin.Controls.MaterialTabSelector();
            materialTabControl1.SuspendLayout();
            tablas.SuspendLayout();
            Facturas.SuspendLayout();
            Seguridad.SuspendLayout();
            Ayudas.SuspendLayout();
            pnlMenu.SuspendLayout();
            pnlSuperior.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // materialTabControl1
            // 
            materialTabControl1.Controls.Add(tablas);
            materialTabControl1.Controls.Add(Facturas);
            materialTabControl1.Controls.Add(Seguridad);
            materialTabControl1.Controls.Add(Ayudas);
            materialTabControl1.Depth = 0;
            materialTabControl1.Location = new Point(3, 100);
            materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            materialTabControl1.Name = "materialTabControl1";
            materialTabControl1.SelectedIndex = 0;
            materialTabControl1.Size = new Size(282, 471);
            materialTabControl1.TabIndex = 1;
            // 
            // tablas
            // 
            tablas.BackColor = Color.DarkOrange;
            tablas.Controls.Add(btnProductos);
            tablas.Controls.Add(btnClientes);
            tablas.Location = new Point(4, 24);
            tablas.Name = "tablas";
            tablas.Padding = new Padding(3);
            tablas.Size = new Size(274, 443);
            tablas.TabIndex = 0;
            tablas.Text = "Tablas";
            tablas.Click += tablas_Click;
            // 
            // btnProductos
            // 
            btnProductos.FlatAppearance.BorderSize = 0;
            btnProductos.FlatAppearance.MouseDownBackColor = Color.Purple;
            btnProductos.FlatAppearance.MouseOverBackColor = Color.Red;
            btnProductos.FlatStyle = FlatStyle.Flat;
            btnProductos.Font = new Font("Microsoft Sans Serif", 15F);
            btnProductos.ForeColor = SystemColors.ButtonHighlight;
            btnProductos.Location = new Point(27, 61);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(219, 34);
            btnProductos.TabIndex = 1;
            btnProductos.Text = "Productos";
            btnProductos.UseVisualStyleBackColor = true;
            btnProductos.Click += btnProductos_Click;
            // 
            // btnClientes
            // 
            btnClientes.FlatAppearance.BorderSize = 0;
            btnClientes.FlatAppearance.MouseDownBackColor = Color.Purple;
            btnClientes.FlatAppearance.MouseOverBackColor = Color.Red;
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.Font = new Font("Microsoft Sans Serif", 15F);
            btnClientes.ForeColor = SystemColors.ButtonHighlight;
            btnClientes.Location = new Point(27, 113);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(219, 34);
            btnClientes.TabIndex = 0;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.Click += btnClientes_Click;
            // 
            // Facturas
            // 
            Facturas.BackColor = Color.DarkOrange;
            Facturas.Controls.Add(btnInformes);
            Facturas.Controls.Add(btnFacturas);
            Facturas.Location = new Point(4, 24);
            Facturas.Name = "Facturas";
            Facturas.Padding = new Padding(3);
            Facturas.Size = new Size(274, 443);
            Facturas.TabIndex = 1;
            Facturas.Text = "Facturas";
            // 
            // btnInformes
            // 
            btnInformes.FlatAppearance.BorderSize = 0;
            btnInformes.FlatAppearance.MouseDownBackColor = Color.Purple;
            btnInformes.FlatAppearance.MouseOverBackColor = Color.Red;
            btnInformes.FlatStyle = FlatStyle.Flat;
            btnInformes.Font = new Font("Microsoft Sans Serif", 15F);
            btnInformes.ForeColor = SystemColors.ButtonHighlight;
            btnInformes.Location = new Point(15, 121);
            btnInformes.Name = "btnInformes";
            btnInformes.Size = new Size(219, 34);
            btnInformes.TabIndex = 3;
            btnInformes.Text = "Informes";
            btnInformes.UseVisualStyleBackColor = true;
            btnInformes.Click += btnInformes_Click;
            // 
            // Seguridad
            // 
            Seguridad.BackColor = Color.DarkOrange;
            Seguridad.Controls.Add(btnSeguridad);
            Seguridad.Controls.Add(btnRoles);
            Seguridad.Controls.Add(btnEmpleados);
            Seguridad.Location = new Point(4, 24);
            Seguridad.Name = "Seguridad";
            Seguridad.Size = new Size(274, 443);
            Seguridad.TabIndex = 2;
            Seguridad.Text = "Seguridad";
            // 
            // btnSeguridad
            // 
            btnSeguridad.FlatAppearance.BorderSize = 0;
            btnSeguridad.FlatAppearance.MouseDownBackColor = Color.Purple;
            btnSeguridad.FlatAppearance.MouseOverBackColor = Color.Red;
            btnSeguridad.FlatStyle = FlatStyle.Flat;
            btnSeguridad.Font = new Font("Microsoft Sans Serif", 15F);
            btnSeguridad.ForeColor = SystemColors.ButtonHighlight;
            btnSeguridad.Location = new Point(29, 267);
            btnSeguridad.Name = "btnSeguridad";
            btnSeguridad.Size = new Size(219, 34);
            btnSeguridad.TabIndex = 4;
            btnSeguridad.Text = "Seguridad";
            btnSeguridad.UseVisualStyleBackColor = true;
            btnSeguridad.Click += btnSeguridad_Click;
            // 
            // btnRoles
            // 
            btnRoles.FlatAppearance.BorderSize = 0;
            btnRoles.FlatAppearance.MouseDownBackColor = Color.Purple;
            btnRoles.FlatAppearance.MouseOverBackColor = Color.Red;
            btnRoles.FlatStyle = FlatStyle.Flat;
            btnRoles.Font = new Font("Microsoft Sans Serif", 15F);
            btnRoles.ForeColor = SystemColors.ButtonHighlight;
            btnRoles.Location = new Point(29, 172);
            btnRoles.Name = "btnRoles";
            btnRoles.Size = new Size(219, 34);
            btnRoles.TabIndex = 3;
            btnRoles.Text = "Roles";
            btnRoles.UseVisualStyleBackColor = true;
            btnRoles.Click += btnRoles_Click;
            // 
            // btnEmpleados
            // 
            btnEmpleados.FlatAppearance.BorderSize = 0;
            btnEmpleados.FlatAppearance.MouseDownBackColor = Color.Purple;
            btnEmpleados.FlatAppearance.MouseOverBackColor = Color.Red;
            btnEmpleados.FlatStyle = FlatStyle.Flat;
            btnEmpleados.Font = new Font("Microsoft Sans Serif", 15F);
            btnEmpleados.ForeColor = SystemColors.ButtonHighlight;
            btnEmpleados.Location = new Point(29, 78);
            btnEmpleados.Name = "btnEmpleados";
            btnEmpleados.Size = new Size(219, 34);
            btnEmpleados.TabIndex = 2;
            btnEmpleados.Text = "Empleados";
            btnEmpleados.UseVisualStyleBackColor = true;
            btnEmpleados.Click += btnEmpleados_Click;
            // 
            // Ayudas
            // 
            Ayudas.BackColor = Color.DarkOrange;
            Ayudas.Controls.Add(btnAcercaDe);
            Ayudas.Controls.Add(btnAyuda);
            Ayudas.Location = new Point(4, 24);
            Ayudas.Name = "Ayudas";
            Ayudas.Size = new Size(274, 443);
            Ayudas.TabIndex = 3;
            Ayudas.Text = "Ayudas";
            Ayudas.Click += Ayudas_Click;
            // 
            // btnAcercaDe
            // 
            btnAcercaDe.FlatAppearance.BorderSize = 0;
            btnAcercaDe.FlatAppearance.MouseDownBackColor = Color.Purple;
            btnAcercaDe.FlatAppearance.MouseOverBackColor = Color.Red;
            btnAcercaDe.FlatStyle = FlatStyle.Flat;
            btnAcercaDe.Font = new Font("Microsoft Sans Serif", 15F);
            btnAcercaDe.ForeColor = SystemColors.ButtonHighlight;
            btnAcercaDe.Location = new Point(29, 221);
            btnAcercaDe.Name = "btnAcercaDe";
            btnAcercaDe.Size = new Size(219, 34);
            btnAcercaDe.TabIndex = 2;
            btnAcercaDe.Text = "Acerca de...";
            btnAcercaDe.UseVisualStyleBackColor = true;
            btnAcercaDe.Click += btnAcercaDe_Click;
            // 
            // btnAyuda
            // 
            btnAyuda.FlatAppearance.BorderSize = 0;
            btnAyuda.FlatAppearance.MouseDownBackColor = Color.Purple;
            btnAyuda.FlatAppearance.MouseOverBackColor = Color.Red;
            btnAyuda.FlatStyle = FlatStyle.Flat;
            btnAyuda.Font = new Font("Microsoft Sans Serif", 15F);
            btnAyuda.ForeColor = SystemColors.ButtonHighlight;
            btnAyuda.Location = new Point(29, 130);
            btnAyuda.Name = "btnAyuda";
            btnAyuda.Size = new Size(219, 34);
            btnAyuda.TabIndex = 1;
            btnAyuda.Text = "Ayuda";
            btnAyuda.UseVisualStyleBackColor = true;
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.White;
            pnlMenu.Controls.Add(materialTabControl1);
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.ForeColor = SystemColors.ControlLight;
            pnlMenu.Location = new Point(0, 52);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(285, 617);
            pnlMenu.TabIndex = 1;
            // 
            // pnlContenedor
            // 
            pnlContenedor.ForeColor = Color.Red;
            pnlContenedor.Location = new Point(285, 52);
            pnlContenedor.Name = "pnlContenedor";
            pnlContenedor.Size = new Size(945, 618);
            pnlContenedor.TabIndex = 1;
            pnlContenedor.Paint += pnlContenedor_Paint;
            // 
            // materialTabSelector1
            // 
            materialTabSelector1.BackColor = Color.White;
            materialTabSelector1.BaseTabControl = materialTabControl1;
            materialTabSelector1.Depth = 0;
            materialTabSelector1.Dock = DockStyle.Right;
            materialTabSelector1.ForeColor = Color.Red;
            materialTabSelector1.Location = new Point(400, 0);
            materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            materialTabSelector1.Name = "materialTabSelector1";
            materialTabSelector1.Size = new Size(831, 52);
            materialTabSelector1.TabIndex = 0;
            materialTabSelector1.Text = "materialTabSelector1";
            materialTabSelector1.Click += materialTabSelector1_Click;
            // 
            // pnlSuperior
            // 
            pnlSuperior.BackColor = Color.White;
            pnlSuperior.Controls.Add(panel1);
            pnlSuperior.Controls.Add(materialTabSelector1);
            pnlSuperior.Dock = DockStyle.Top;
            pnlSuperior.ForeColor = Color.DarkOrange;
            pnlSuperior.Location = new Point(0, 0);
            pnlSuperior.Name = "pnlSuperior";
            pnlSuperior.Size = new Size(1231, 52);
            pnlSuperior.TabIndex = 0;
            // 
            // btnFacturas
            // 
            btnFacturas.FlatAppearance.BorderSize = 0;
            btnFacturas.FlatAppearance.MouseDownBackColor = Color.Purple;
            btnFacturas.FlatAppearance.MouseOverBackColor = Color.Red;
            btnFacturas.FlatStyle = FlatStyle.Flat;
            btnFacturas.Font = new Font("Microsoft Sans Serif", 15F);
            btnFacturas.ForeColor = SystemColors.ButtonHighlight;
            btnFacturas.Location = new Point(15, 67);
            btnFacturas.Name = "btnFacturas";
            btnFacturas.Size = new Size(219, 34);
            btnFacturas.TabIndex = 2;
            btnFacturas.Text = "Facturas";
            btnFacturas.UseVisualStyleBackColor = true;
            btnFacturas.Click += btnFacturas_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(materialTabSelector2);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = Color.DarkOrange;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 52);
            panel1.TabIndex = 1;
            // 
            // materialTabSelector2
            // 
            materialTabSelector2.BackColor = Color.White;
            materialTabSelector2.BaseTabControl = materialTabControl1;
            materialTabSelector2.Depth = 0;
            materialTabSelector2.Dock = DockStyle.Right;
            materialTabSelector2.ForeColor = Color.Red;
            materialTabSelector2.Location = new Point(-431, 0);
            materialTabSelector2.MouseState = MaterialSkin.MouseState.HOVER;
            materialTabSelector2.Name = "materialTabSelector2";
            materialTabSelector2.Size = new Size(831, 52);
            materialTabSelector2.TabIndex = 0;
            materialTabSelector2.Text = "materialTabSelector2";
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1231, 669);
            Controls.Add(pnlContenedor);
            Controls.Add(pnlMenu);
            Controls.Add(pnlSuperior);
            Name = "FrmMain";
            Text = "FrmMain";
            materialTabControl1.ResumeLayout(false);
            tablas.ResumeLayout(false);
            Facturas.ResumeLayout(false);
            Seguridad.ResumeLayout(false);
            Ayudas.ResumeLayout(false);
            pnlMenu.ResumeLayout(false);
            pnlSuperior.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private TabPage tablas;
        private Button btnProductos;
        private Button btnClientes;
        private TabPage Facturas;
        private Button btnInformes;
        private TabPage Seguridad;
        private Button btnSeguridad;
        private Button btnRoles;
        private Button btnEmpleados;
        private TabPage Ayudas;
        private Button btnAcercaDe;
        private Button btnAyuda;
        private Panel pnlMenu;
        private Panel pnlContenedor;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private Panel pnlSuperior;
        private Button btnFacturas;
        private PictureBox pictureBox1;
        private Panel panel1;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector2;
    }
}