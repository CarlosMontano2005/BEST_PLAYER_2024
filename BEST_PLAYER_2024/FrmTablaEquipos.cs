using Controlador;
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
    public partial class FrmTablaEquipos : Form
    {
        public FrmTablaEquipos()
        {
            InitializeComponent();
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            FrmInfoEquipo child2 = new FrmInfoEquipo();

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
                this.Controls.Clear();
                child2.TopLevel = false;
                child2.FormBorderStyle = FormBorderStyle.None;
                child2.Dock = DockStyle.Fill;
                this.Controls.Add(child2);
                child2.Show();
            }
            else
            {
                return;
            }
        }

        private void BtnExel_Click(object sender, EventArgs e)
        {
            try
            {
                string mess;
                ExcelUtilities excel = new ExcelUtilities();
                excel.ExportDataGridViewToExcel(DgvTabla, "Tabla de Equipo", out mess);
                // Mostrar mensaje de éxito o error
                MessageBox.Show(mess);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "ERROR ARCHIVO", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
    }
}
