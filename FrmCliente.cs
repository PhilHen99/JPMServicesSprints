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
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }
        public int idCliente { get; set; }//propiedad que viene del formulario anterior//
        public String NombreCliente { get; set; }
        public String DocumentoCliente { get; set; }
        public String TelefonoCliente { get; set; }

        DataTable dt = new DataTable();
        Acceso_Datos accesoDatos = new Acceso_Datos();
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            txtId.Text = idCliente.ToString();
            if (idCliente != 0)
            {
                lblTitulo.Text = "Actualizar Informacion";
                btnGuardar.Text = "Actualizar";
                llenar_Datos();
            }
            else
            {
                lblTitulo.Text = "Ingreso Cliente Nuevo";
                btnGuardar.Text = "Guardar";
            }
            txtNombreCliente.Text = NombreCliente;
            txtDocumento.Text = DocumentoCliente;
            txtTelefono.Text = TelefonoCliente;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }




        public void llenar_Datos()
        {
            string filtro = $"IdEmpleado={idCliente}";
            dt = accesoDatos.Leertabla("TBLCLIENTE", filtro);  // invocamos el metodo Leertabla
                                                                // recorremos los datos consultados para llenar el grid
            foreach (DataRow row in dt.Rows)
            {
                try
                {
                    txtNombreCliente.Text = row["StrNombre"].ToString();
                    txtDocumento.Text = row["NumDocumento"].ToString();
                    txtDireccion.Text = row["StrDireccion"].ToString();
                    txtTelefono.Text = row["StrTelefono"].ToString();
                    txtEmail.Text = row["StrEmail"].ToString();
                    



                    

                }
                catch (Exception)
                {
                    MessageBox.Show("faltan algunos datos en la base de datos");
                }

            }
        }
    }
}
