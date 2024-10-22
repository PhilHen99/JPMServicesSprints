using System;
using System.Windows.Forms;

namespace Formularios_H3
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Aquí es donde decides qué formulario abrir primero
            Application.Run(new FrmValidar()); // Cambia FrmMain o cualquier otro por FrmValidar
        }
    }
}
