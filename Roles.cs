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
    public partial class Roles : Form
    {
        public Roles()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmRoles roles = new FrmRoles();
            roles.ShowDialog();
        }

        private void Roles_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            int numAleatorio;

            for (int i = 1; i < 10; i++)
            {
                numAleatorio = random.Next(1, 4595);
                dgRoles.Rows.Add(i, $"Nombre Rol Nro {i}");


            }
        }
    }
}
