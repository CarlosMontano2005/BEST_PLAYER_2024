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
    public partial class FrmInfoEquipo : Form
    {
        public FrmInfoEquipo()
        {
            InitializeComponent();
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            FrmTablaEquipos frmHijo1Regresar = new FrmTablaEquipos(); // 

            DialogResult result = MessageBox.Show(
               "¿Desea cambiar al formulario hijo y cerrar el formulario subhijo?",
               "Confirmar cierre",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question
           );

            if (result == DialogResult.Yes)
            {
                this.Controls.Clear();
                frmHijo1Regresar.TopLevel = false;
                frmHijo1Regresar.FormBorderStyle = FormBorderStyle.None;
                frmHijo1Regresar.Dock = DockStyle.Fill;
                this.Controls.Add(frmHijo1Regresar);
                frmHijo1Regresar.Show();
            }
            else
            {
                return;
            }
        }
    }
}
