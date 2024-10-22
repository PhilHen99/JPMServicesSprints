using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios_H3
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        public void abrirform(Form formhijo)
        {
            if (this.pnlContenedor.Controls.Count > 0)
                this.pnlContenedor.Controls.RemoveAt(0);
            formhijo.TopLevel = false;
            formhijo.FormBorderStyle = FormBorderStyle.None;
            formhijo.Dock = DockStyle.Fill;
            this.pnlContenedor.Controls.Add(formhijo);
            formhijo.Show();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            FrmListasClientes listacliente = new FrmListasClientes();

            abrirform(listacliente);
        }

        private void Ayudas_Click(object sender, EventArgs e)
        {

        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            Productos productos = new Productos();
            abrirform(productos);
        }

        private void btnFacturas_Click(object sender, EventArgs e)
        {
            Facturas facturas = new Facturas();
            abrirform(facturas);
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            Empleados empleados = new Empleados();
            abrirform(empleados);
        }

        private void btnRoles_Click(object sender, EventArgs e)
        {
            Roles roles = new Roles();
            abrirform(roles);
        }

        private void tablas_Click(object sender, EventArgs e)
        {

        }

        private void btnInformes_Click(object sender, EventArgs e)
        {
            Informes informs = new Informes();
            abrirform(informs);
        }

        private void btnSeguridad_Click(object sender, EventArgs e)
        {
            Seguridad seguridad = new Seguridad();
            abrirform(seguridad);
        }

        private void btnAcercaDe_Click(object sender, EventArgs e)
        {
            AcercaDe acercaDe = new AcercaDe();
            abrirform(acercaDe);
        }

        private void materialTabSelector1_Click(object sender, EventArgs e)
        {

        }

        private void pnlContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
