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
    public partial class FrmProductos : Form
    {
        public FrmProductos()
        {
            InitializeComponent();
        }

        public int IDProducto { get; set; }
        public string NombreProducto { get; set; }
        public string CategoriaProducto { get; set; }
        public string PrecioProducto { get; set; }
        public string StockProducto { get; set; }
        private void txtPrecioVenta_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {

            if (IDProducto != 0)
            {
                lblTitulo.Text = "Actualizar Informacion";
                btnGuardar.Text = "Actualizar";
            }
            else
            {
                lblTitulo.Text = "Ingreso Producto Nuevo";
                btnGuardar.Text = "Guardar";
            }
            txtId.Text = IDProducto.ToString();
            txtNombreProducto.Text = NombreProducto;
            txtPrecioCompra.Text = PrecioProducto;

            txtCantidadStock.Text = StockProducto;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
