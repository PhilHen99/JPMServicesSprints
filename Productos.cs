using MySql.Data.MySqlClient;
using System;
using System.Collections;
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
    public partial class Productos : Form
    {

        private MySqlConnection connection;
        Acceso_Datos AccesoDatos = new Acceso_Datos();  
        public Productos()
        {
            InitializeComponent();
            string connectionString = "server=asidi.xyz;user=DBFACTURAS;database=dbfacturas;port=3306;password=facturas2024;";
            connection = new MySqlConnection(connectionString);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmProductos productos = new FrmProductos();
            productos.ShowDialog();
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            string sentencia = "SELECT IdProducto, StrNombre, StrCodigo, NumPrecioVenta, NumStock FROM TBLPRODUCTO";
            MySqlDataAdapter adapter = new MySqlDataAdapter(sentencia, connection);
            DataTable dt = new DataTable();

            AccesoDatos.AbrirBd();
            adapter.Fill(dt);
            AccesoDatos.CerrarBd();
            
            foreach (DataRow row in dt.Rows)
            {
                try
                {
                    dgClientes.Rows.Add(row[0], row[1], row[2], row[3], row[4]);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al leer la tabla: {ex.Message}");
                }
                


            }


        }

        private void dgClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgClientes.Columns["btnEditar"].Index && e.RowIndex >= 0)
            {
                MessageBox.Show("Editar Producto " + dgClientes[1, e.RowIndex].Value.ToString());
                FrmProductos frm = new FrmProductos();
                frm.IDProducto = e.RowIndex;
                frm.IDProducto = int.Parse(dgClientes[0, e.RowIndex].Value.ToString());
                frm.NombreProducto = dgClientes[1, e.RowIndex].Value.ToString();
                frm.CategoriaProducto = dgClientes[2, e.RowIndex].Value.ToString();
                frm.PrecioProducto = dgClientes[3, e.RowIndex].Value.ToString();
                frm.StockProducto = dgClientes[4, e.RowIndex].Value.ToString();
                frm.ShowDialog();
            }
            if (e.ColumnIndex == dgClientes.Columns["btnBorrar"].Index && e.RowIndex >= 0)
            {
                // Mostrar un MessageBox con botones Confirmar y Cancelar
                DialogResult result = MessageBox.Show("¿Deseas Borrar?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                //MessageBoxButton.YesNo <-Muestra botones de si o no para presionar// //MessageBoxIcon <-Agrega un icono al cuadro para dar informacion de lo que se trate//
                // Verificar qué botón se presionó
                if (result == DialogResult.Yes)
                {
                    // Acciones a tomar si se presionó el botón "Confirmar"
                    MessageBox.Show("Confirmado", "Borrando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (result == DialogResult.No)
                {
                    // Acciones a tomar si se presionó el botón "Cancelar"
                    MessageBox.Show("Cancelado", "Cancelar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
