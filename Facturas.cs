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
    public partial class Facturas : Form
    {
        public Facturas()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmFacturas1 facturas1 = new FrmFacturas1();
            facturas1.ShowDialog();
        }

        private void Facturas_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            int numAleatorio;

            for (int i = 1; i < 10; i++)
            {
                numAleatorio = random.Next(1, 4595);
                dgFacturas.Rows.Add(i + "000", $"Nombre {i} Apellido1 Apellido2", i + "/01/2022", $"{i * 2}", "pendiente");


            }
        }

        private void dgFacturas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgFacturas.Columns["btnEditar"].Index && e.RowIndex >= 0)
            {
                MessageBox.Show("Editar Factura" + dgFacturas[1, e.RowIndex].Value.ToString());
                FrmFacturas1 frm = new FrmFacturas1();
                frm.NroFactura = e.RowIndex;
                frm.NroFactura = int.Parse(dgFacturas[0, e.RowIndex].Value.ToString());
                
                frm.ShowDialog();
            }
            if (e.ColumnIndex == dgFacturas.Columns["btnBorrar"].Index && e.RowIndex >= 0)
            {
                
                DialogResult result = MessageBox.Show("¿Deseas Borrar?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("Confirmado", "Borrando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (result == DialogResult.No)
                {
                    MessageBox.Show("Cancelado", "Cancelar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
