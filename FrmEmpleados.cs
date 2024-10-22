using MaterialSkin;
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
    public partial class FrmEmpleados : Form
    {
        DataTable dt = new DataTable();
        Acceso_Datos accesoDatos = new Acceso_Datos();
        public FrmEmpleados()
        {
            InitializeComponent();
        }

        public int idEmpleado { get; set; }//propiedad que viene del formulario anterior//


        private void FrmEmpleados_Load(object sender, EventArgs e)
        {

            txtId.Text = idEmpleado.ToString();
            if (idEmpleado != 0)
            {
                lblTitulo.Text = "Actualizar Informacion";
                btnGuardar.Text = "Actualizar";
                llenar_combo();
                llenar_Datos();
            }
            else
            {
                lblTitulo.Text = "Ingreso Empleado Nuevo";
                btnGuardar.Text = "Guardar";
                llenar_combo();
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (idEmpleado == 0)
            {
                nuevo();
            }
            else
            {
                guardar();

            }
            this.Hide();
        }


        public void llenar_combo()
        {
            string column = "IdRolEmpleado, StrDescripcion ";
            string table = "TBLROLES";
            dt = accesoDatos.EjecutarComandoTabla(column, table, "");
            cboRol.DataSource = dt;
            cboRol.DisplayMember = "StrDescripcion";
            cboRol.ValueMember = "IdRolEmpleado";
        }

        public void llenar_Datos()
        {
            string filtro = $"IdEmpleado={idEmpleado}";
            dt = accesoDatos.Leertabla("TBLEMPLEADO", filtro);  // invocamos el metodo Leertabla
                                                                // recorremos los datos consultados para llenar el grid
            foreach (DataRow row in dt.Rows)
            {
                try
                {
                    txtNombre.Text = row["StrNombre"].ToString();
                    txtDocumento.Text = row["NumDocumento"].ToString();
                    txtDireccion.Text = row["StrDireccion"].ToString();
                    txtTelefono.Text = row["StrTelefono"].ToString();
                    txtEmail.Text = row["StrEmail"].ToString();
                    txtDatosAdicionales.Text = row["StrDatosAdicionales"].ToString();



                    // -------- manejo de fechas --------------
                    dtmIngreso.Value = Convert.ToDateTime(row["DtmIngreso"].ToString());
                    dtmRetiro.Value = row["DtmRetiro"].ToString() == "" ? Convert.ToDateTime("01/01/2100") : Convert.ToDateTime(row["DtmRetiro"].ToString());



                    // -------- manejo del combo --------------
                    int valorCombo = Convert.ToInt16(row["IdRolEmpleado"].ToString());
                    cboRol.SelectedValue = valorCombo;

                }
                catch (Exception)
                {
                    MessageBox.Show("faltan algunos datos en la base de datos");
                }

            }
        }

        private void nuevo()
        {

            string nombre = txtNombre.Text;
            string documento = txtDocumento.Text;
            string direccion = txtDireccion.Text;
            string telefono = txtTelefono.Text;
            string email = txtEmail.Text;
            string strDatosAdicionales = txtDatosAdicionales.Text;

            int rolEmpleado = (int)cboRol.SelectedValue;

            string FechaIngreso = dtmIngreso.Value.ToString("yyyy/MM/dd HH:mm");
            string FechaRetiro = dtmRetiro.Value.ToString("yyyy/MM/dd HH:mm");
            string DtmFechaModifica = DateTime.Now.ToString("yyyy/MM/dd HH:mm");
            string StrUsuarioModifico = "Admin";

            string Sentencia = $"INSERT INTO TBLEMPLEADO (IdEmpleado, strNombre, NumDocumento, StrDireccion, StrTelefono, StrEmail, IdRolEmpleado, DtmIngreso, DtmRetiro, DtmFechaModifica, StrUsuarioModifico) " +
                   $"VALUES (NULL, '{nombre}', '{documento}', '{direccion}', '{telefono}', '{email}', {rolEmpleado}, '{FechaIngreso}', '{FechaRetiro}', '{DtmFechaModifica}', '{StrUsuarioModifico}')";
            string resultado = accesoDatos.EjecutarComando(Sentencia);

            MessageBox.Show(resultado);
            llenar_Datos();

        }




        private void guardar()
        {

            string nombre = txtNombre.Text;
            string documento = txtDocumento.Text;
            string direccion = txtDireccion.Text;
            string telefono = txtTelefono.Text;
            string email = txtEmail.Text;
            string strDatosAdicionales = txtDatosAdicionales.Text;

            int rolEmpleado = (int)cboRol.SelectedValue;

            string FechaIngreso = dtmIngreso.Value.ToString("yyyy/MM/dd HH:mm");
            string FechaRetiro = dtmRetiro.Value.ToString("yyyy/MM/dd HH:mm");
            string DtmFechaModifica = DateTime.Now.ToString("yyyy/MM/dd HH:mm");
            string StrUsuarioModifico = "Admin";

            string Sentencia = $"UPDATE TBLEMPLEADO SET " +
             $"strNombre = '{nombre}', " + $"NumDocumento = '{documento}', " + $"StrDireccion = '{direccion}', " + $"StrTelefono = '{telefono}', " +
             $"StrEmail = '{email}', " + $"IdRolEmpleado = {rolEmpleado}, " + $"DtmIngreso = '{FechaIngreso}', " + $"DtmRetiro = '{FechaRetiro}', " + $"DtmFechaModifica = '{DtmFechaModifica}', " + $"StrUsuarioModifico = '{StrUsuarioModifico}' " +
             $"WHERE IdEmpleado = {idEmpleado}";

            string resultado = accesoDatos.EjecutarComando(Sentencia);

            MessageBox.Show(resultado);
            llenar_Datos();

        }

        private void txtDatosAdicionales_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
