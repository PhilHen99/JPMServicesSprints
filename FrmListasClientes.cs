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
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Formularios_H3
{
    public partial class FrmListasClientes : Form
    {

        DataTable dt = new DataTable();
        Acceso_Datos AccesoDatos = new Acceso_Datos();
        private MySqlConnection connection;

        public FrmListasClientes()
        {
            InitializeComponent();
        }

        private void llenar_grid()
        {
            dgClientes.Rows.Clear();  // limpiamos contenido del datagrid
            dt = AccesoDatos.Leertabla("TBLCLIENTES", "");  // invocamos el metodo Leertabla
                                                            // recorremos los datos consultados para llenar el grid
            foreach (DataRow row in dt.Rows)
            {
                dgClientes.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5]);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgClientes.Rows.Clear();  // limpiamos contenido del datagrid
            string filtro = $"strNombre like '%{txtBuscar.Text}%'";
            dt = AccesoDatos.Leertabla("TBLCLIENTES", filtro);  // invocamos la lectura de la tabla
                                                                // recorremos los datos consultados para llenar el grid
            foreach (DataRow row in dt.Rows)
            {
                dgClientes.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5]);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmCliente cliente = new FrmCliente();
            cliente.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmListasClientes_Load(object sender, EventArgs e)
        {
            dgClientes.Rows.Clear();
            string filtro = $"strNombre like '%{txtBuscar.Text}%'";

            
            dt = AccesoDatos.Leertabla("TBLCLIENTES", filtro);


            foreach (DataRow row in dt.Rows)
            {

                try
                {
                    dgClientes.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5]);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al leer la tabla: {ex.Message}");
                }

            }

        }






        private void dgClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //e.ColumnIndex <- indica la columna en donde se clickeo
            if (e.ColumnIndex == dgClientes.Columns["btnEditar"].Index && e.RowIndex >= 0)
            {

                int posActual = dgClientes.CurrentRow.Index;
                FrmCliente cliente = new FrmCliente();
                cliente.idCliente = int.Parse(dgClientes[0, posActual].Value.ToString());
                cliente.ShowDialog();
                llenar_grid();


            }
            if (e.ColumnIndex == dgClientes.Columns["btnBorrar"].Index && e.RowIndex >= 0)
            {
                int posActual = dgClientes.CurrentRow.Index;
                if (MessageBox.Show("Seguro de borrar", "CONFIRMACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int IdEmpleado = int.Parse(dgClientes[0, posActual].Value.ToString());
                    string Sentencia = $"Delete from TBLCLIENTES WHERE IdCliente={IdEmpleado}";
                    MessageBox.Show($"BORRANDO índice {e.RowIndex} ID {dgClientes[0, posActual].Value.ToString()}");
                    string resultado = AccesoDatos.EjecutarComando(Sentencia);
                    
                    llenar_grid();
                }
            }
        }
    }
}
