using Controlador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BEST_PLAYER_2024
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
            if (SesionUsuario.SesionActiva)
            {
                MessageBox.Show("La sesión está activa");
                Application.Run(new FrmDashboard()); //FrmInicio
            }
            else
            {
                //MessageBox.Show("La sesión ha expirado o no está activa. Inicia sesión nuevamente.");
                Application.Run(new FrmInicio()); //FrmInicio
            }
        }
    }
}
