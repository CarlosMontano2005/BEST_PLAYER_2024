using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BEST_PLAYER_2024
{
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Crear una instancia de FrmHijo2
            FrmHijo2 child2 = new FrmHijo2();

            // Verificar si el panel está disponible
            if (PnlHijoContendraHijo2 != null)
            {
                // Limpiar el panel y agregar el nuevo formulario hijo
                PnlHijoContendraHijo2.Controls.Clear();

                child2.TopLevel = false;
                child2.FormBorderStyle = FormBorderStyle.None;
                child2.Dock = DockStyle.Fill;

                PnlHijoContendraHijo2.Controls.Add(child2);
                child2.Show();
            }
            else
            {
                MessageBox.Show("El panel no está disponible.");
            }
        }
    }
}
