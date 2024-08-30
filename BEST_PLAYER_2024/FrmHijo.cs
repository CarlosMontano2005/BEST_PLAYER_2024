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
    public partial class FrmHijo : Form
    {
        public FrmHijo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmHijo2 child2 = new FrmHijo2();

            DialogResult result = MessageBox.Show(
                "¿Desea cambiar al formulario subhijo y cerrar el formulario hijo?",
                "Confirmar cierre",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                // Cerrar el formulario abierto
                // Limpiar el panel y abrir el nuevo formulario
                PnlHijoContendraHijo_1.Controls.Clear();
                child2.TopLevel = false;
                child2.FormBorderStyle = FormBorderStyle.None;
                child2.Dock = DockStyle.Fill;
                PnlHijoContendraHijo_1.Controls.Add(child2);
                child2.Show();
            }
            else
            {
                return;
            }

        }
    }
}
