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
    public partial class FrmFacturas1 : Form
    {
        public FrmFacturas1()
        {
            InitializeComponent();
        }

        public int NroFactura { get; set; }

        private void FrmFacturas1_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            int numAleatorio;

            if (NroFactura != 0)
            {
                lblTitulo.Text = "Actualizar Informacion";
                btnGuardar.Text = "Actualizar";
                txtNroFactura.Text = NroFactura.ToString();
                for (int i = 1; i < 10; i++)
                {
                    numAleatorio = random.Next(1, 4595);
                    dgDetallesFactura.Rows.Add(i, "Producto", $"{i * 100}", numAleatorio, $"{(i * 100) * numAleatorio}");


                }

            }
            else
            {
                lblTitulo.Text = "Ingreso Cliente Nuevo";
                btnGuardar.Text = "Guardar";
            }








        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
