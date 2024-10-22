using MySql.Data.MySqlClient;
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
    public partial class Empleados : Form
    {
        DataTable dt = new DataTable();
        Acceso_Datos AccesoDatos = new Acceso_Datos();
        private MySqlConnection connection;
        public Empleados()
        {
            InitializeComponent();
        }

        private void llenar_grid()
        {
            dgEmpleados.Rows.Clear();  // limpiamos contenido del datagrid
            dt = AccesoDatos.Leertabla("TBLEMPLEADO", "");  // invocamos el metodo Leertabla
                                                            // recorremos los datos consultados para llenar el grid
            foreach (DataRow row in dt.Rows)
            {
                dgEmpleados.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5]);
            }
        }


        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmEmpleados empleados = new FrmEmpleados();
            empleados.ShowDialog();
        }

        private void Empleados_Load(object sender, EventArgs e)
        {
            dgEmpleados.Rows.Clear();
            llenar_grid();
        }

        private void dgEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgEmpleados.Columns["btnEditar"].Index && e.RowIndex >= 0)
            {
                MessageBox.Show("Editar Datos de: " + dgEmpleados[1, e.RowIndex].Value.ToString());
                FrmEmpleados frm = new FrmEmpleados();
                frm.idEmpleado = e.RowIndex;
                frm.idEmpleado = int.Parse(dgEmpleados[0, e.RowIndex].Value.ToString());
                frm.ShowDialog();
            }
            if (e.ColumnIndex == dgEmpleados.Columns["btnBorrar"].Index && e.RowIndex >= 0)
            {

                int posActual = dgEmpleados.CurrentRow.Index;
                if (MessageBox.Show("Seguro de borrar", "CONFIRMACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int IdEmpleado = int.Parse(dgEmpleados[0, posActual].Value.ToString());
                    string Sentencia = $"DELETE FROM TBLEMPLEADO WHERE IdEmpleado={IdEmpleado}";
                    string resultado = AccesoDatos.EjecutarComando(Sentencia);
                    MessageBox.Show($"BORRANDO índice {e.RowIndex} ID {dgEmpleados[0, posActual].Value.ToString()}");
                    llenar_grid();
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgEmpleados.Rows.Clear();  // limpiamos contenido del datagrid
            string filtro = $"strNombre like '%{txtBuscar.Text}%'";
            dt = AccesoDatos.Leertabla("TBLEMPLEADO", filtro);  // invocamos la lectura de la tabla
                                                                // recorremos los datos consultados para llenar el grid
            foreach (DataRow row in dt.Rows)
            {
                dgEmpleados.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
