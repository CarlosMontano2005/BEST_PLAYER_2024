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
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario hijo
            FrmUsuarios formUsuarios = new FrmUsuarios();
            // Llamar al método para abrir el formulario en el panel
            OpenChildForm(formUsuarios);
        }
        private void OpenChildForm(Form childForm)
        {
            // Verificar si hay un formulario hijo abierto en el panel
            foreach (Control control in PnlContenedor.Controls)
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
                        // Limpiar el panel y cerrar el formulario actual
                        PnlContenedor.Controls.Clear();
                    }
                    else
                    {
                        // No cerrar el formulario actual, salir del método
                        return;
                    }
                }
            }
            // Configurar el nuevo formulario hijo
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            // Agregar el nuevo formulario hijo al panel
            PnlContenedor.Controls.Add(childForm);
            // Mostrar el nuevo formulario hijo
            childForm.Show();
        }

    }
}
