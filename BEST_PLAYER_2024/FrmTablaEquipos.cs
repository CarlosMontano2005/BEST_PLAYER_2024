using Controlador;
using Servicios;
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
            CargarGridDatos();
        }
        public void ActualizarTabla()
        {
            //recargar los datos de la tabla
            DgvEquipo.DataSource = null;
            DgvEquipo.DataSource = ServJugador.CargarDatosEquipos();
        }

        private void CargarGridDatos()
        {
            try
            {
                DataTable datos = ServJugador.CargarDatosEquipos();
                DgvEquipo.DataSource = datos;
                ConfigurarColumnasDgv();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigurarColumnasDgv()
        {
            // Renombrar las columnas en el DataGridView
            DgvEquipo.Columns["IdEquipo"].HeaderText = "#";
            DgvEquipo.Columns["Nombre"].HeaderText = "Nombre";
            DgvEquipo.Columns["Pais"].HeaderText = "Pais";
            DgvEquipo.Columns["CantidadJugadores"].HeaderText = "Cantidad";
            DgvEquipo.Columns["DT"].HeaderText = "DT";
            DgvEquipo.Columns["FotoLogoEquipo"].HeaderText = "Logo";
            DgvEquipo.Columns["Foto_DT"].HeaderText = "DT";
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnExel_Click(object sender, EventArgs e)
        {
            try
            {
                string mess;
                ExcelUtilities excel = new ExcelUtilities();
                excel.ExportDataGridViewToExcel(DgvEquipo, "Tabla de Equipo", out mess);
                // Mostrar mensaje de éxito o error
                MessageBox.Show(mess);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "ERROR ARCHIVO", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void DgvEquipo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    DataGridViewRow filaSeleccionada = DgvEquipo.Rows[e.RowIndex];

                    string idEquipo = filaSeleccionada.Cells["IdEquipo"].Value.ToString();
                    string nombreEquipo = filaSeleccionada.Cells["Nombre"].Value.ToString();
                    string pais = filaSeleccionada.Cells["Pais"].Value.ToString();
                    string CantidadJugadores = filaSeleccionada.Cells["CantidadJugadores"].Value.ToString();
                    string DT = filaSeleccionada.Cells["DT"].Value.ToString();
                    string FotoLogoEquipo = filaSeleccionada.Cells["FotoLogoEquipo"].Value.ToString();
                    string Foto_DT = filaSeleccionada.Cells["Foto_DT"].Value.ToString();
                    string[] DatosEquipo = { idEquipo, nombreEquipo, pais, CantidadJugadores, DT, FotoLogoEquipo, Foto_DT };
                    // MÉTODO PARA ENVIAR DATOS AL FORMULARIO
                    FrmInfoEquipo child2 = new FrmInfoEquipo(DatosEquipo);

                    DialogResult result = MessageBox.Show(
                        "¿Desea ver informacion del equipo?",
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
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
