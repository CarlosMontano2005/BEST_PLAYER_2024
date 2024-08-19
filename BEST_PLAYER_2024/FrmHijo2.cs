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
    public partial class FrmHijo2 : Form
    {
        private FrmUsuarios parentForm;

        public FrmHijo2()
        {
            InitializeComponent();
        }

        private void btnRegrasarAlFrmHijo1_Click(object sender, EventArgs e)
        {
            // Cerrar el formulario actual
            this.Close();

            // Regresar al formulario hijo 1
            if (parentForm != null)
            {
                parentForm.BringToFront(); // Asegurarse de que el formulario padre está al frente
            }
        }
    }
}
