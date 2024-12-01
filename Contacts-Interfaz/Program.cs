using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    static class Program
    {
        // El punto de entrada principal para la aplicación
        [STAThread]
        static void Main()
        {
            // Configura para que los formularios usen el tema adecuado
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Muestra el formulario principal (Form1)
            Application.Run(new Form1());
        }
    }
}