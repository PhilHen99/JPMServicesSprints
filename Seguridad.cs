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
    public partial class Seguridad : Form
    {
        public Seguridad()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Seguridad_Load(object sender, EventArgs e)
        {
            // Añadir los elementos al ComboBox
            comboBox1.Items.Add("Empleado");
            comboBox1.Items.Add("Cliente");
            comboBox1.Items.Add("Seguridad");
            comboBox1.Items.Add("Admin");

            // Seleccionar el primer elemento por defecto (opcional)
            comboBox1.SelectedIndex = 0;
        }
    }
}
