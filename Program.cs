using System;
using System.Windows.Forms;

namespace Formularios_H3
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicaci�n.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Aqu� es donde decides qu� formulario abrir primero
            Application.Run(new FrmValidar()); // Cambia FrmMain o cualquier otro por FrmValidar
        }
    }
}
