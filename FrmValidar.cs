using System;
using System.Windows.Forms;

namespace Formularios_H3
{
    public partial class FrmValidar : Form
    {
        public FrmValidar()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            string Respuesta = ""; // Variable para controlar si el usuario es encontrado.

            // Verificamos que el usuario y la clave no estén vacíos.
            if (txtUsuario.Text != "" && txtContraseña.Text != string.Empty)
            {
                // Validación simple de usuario y contraseña.
                if (txtUsuario.Text == "julian" && txtContraseña.Text == "123")
                {
                    Respuesta = "Admin";  // Nombre del usuario validado.
                }

                if (Respuesta != "")
                {
                    MessageBox.Show("Bienvenido: " + Respuesta);  // Mensaje de bienvenida.
                    FrmMain frmMain = new FrmMain();  // Creamos el formulario principal.
                    this.Hide();  // Ocultamos el formulario de login.
                    frmMain.Show();  // Mostramos el formulario principal.
                }
                else
                {
                    MessageBox.Show("Usuario o clave incorrectos");
                    txtUsuario.Clear();  // Limpiamos los campos.
                    txtContraseña.Clear();
                    txtUsuario.Focus();  // Enfocamos en el campo de usuario.
                }
            }
            else
            {
                MessageBox.Show("Debes ingresar un usuario y una clave");
            }
        }

        private void FrmValidar_Load(object sender, EventArgs e)
        {
            // Código que se ejecuta al cargar el formulario, si es necesario.
        }
    }
}
