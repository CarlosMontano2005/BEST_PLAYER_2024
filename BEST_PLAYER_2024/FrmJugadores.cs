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
    public partial class FrmJugadores : Form
    {
        public FrmJugadores()
        {
            InitializeComponent();
        }
         private void OpenChildForm(Form childForm)
        {
            // Verificar si hay un formulario hijo abierto en el panel
            foreach (Control control in panel1.Controls)
            {
                if (control is Form openForm)
                {
                    // Verificar si el formulario abierto es el mismo que el que se quiere abrir
                    if (openForm.GetType() == childForm.GetType())
                    {
                        MessageBox.Show("El formulario ya está abierto.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    // Confirmar con el usuario si desea cerrar el formulario actual
                    DialogResult result = MessageBox.Show(
                        "Ya hay un formulario abierto. ¿Desea cerrarlo?",
                        "Confirmar cierre",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );
                    if (result == DialogResult.Yes)
                    {
                        panel1.Controls.Clear();
                    }
                    else
                    {
                        return;
                    }
                }
            }
            panel1.Controls.Clear();
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel1.Controls.Add(childForm);
            childForm.Show();
        }
        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            FrmDataJugadores dataJugadores = new FrmDataJugadores();
            OpenChildForm(dataJugadores);
        }
    }
}
