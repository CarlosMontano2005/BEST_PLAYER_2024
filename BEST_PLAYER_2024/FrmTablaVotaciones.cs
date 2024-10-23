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
    public partial class FrmTablaVotaciones : Form
    {
        public FrmTablaVotaciones()
        {
            InitializeComponent();
            CargarTablaVotos();
        }
        void CargarTablaVotos()
        {
            try
            {
                DataTable datos = ServTopJugadores.CargarJugadoresVotados();
                DgvVotaciones.DataSource = null;
                DgvVotaciones.DataSource = datos;
                DgvVotaciones.Columns["cantidadVotos"].HeaderText = "Cantidad Votos";
                DgvVotaciones.Columns["Nombre"].HeaderText = "Nombre de Jugador";
                DgvVotaciones.Columns["Apellido"].HeaderText = "Apellido de Jugador";
                DgvVotaciones.Columns["NombreEquipo"].HeaderText = "Equipo";
                DgvVotaciones.Columns["NombrePais"].HeaderText = "Pais";
                // Ajustar el ancho de la columna que contiene la foto
                //DgvVotaciones.Columns["Foto"].Width = 100;
                DgvVotaciones.Columns["Foto"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {
            FrmTopJugadores frmHijo1Regresar = new FrmTopJugadores(); // 

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

        private void FrmTablaVotaciones_Load(object sender, EventArgs e)
        {

        }

        private void BtnGrafica_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnDescargar_Click(object sender, EventArgs e)
        {
           
        }

        private void BtnExel_Click(object sender, EventArgs e)
        {
            // Llamar al método para exportar y aplicar diseño
            try
            {
                string mess;
                ExcelUtilities excel = new ExcelUtilities();
                excel.ExportDataGridViewToExcel(DgvVotaciones, "Tabla Mejores Jugadores", out mess);
                // Mostrar mensaje de éxito o error
                MessageBox.Show(mess);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al exportar los datos: " + ex.Message);
            }
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            string mess = string.Empty;
            ExcelUtilities excel = new ExcelUtilities();

            // Definir qué columnas usar
            string columnaEjeX = "Nombre"; // Eje X
            string columnaValorY = "cantidadVotos"; // Eje Y
            string nombreGrafica = "Grafica Mejores Jugadores Votados Excel";

            // Llamar al método para crear la gráfica
            try
            {
                excel.CreateExcelChart(DgvVotaciones, columnaValorY, columnaEjeX, nombreGrafica, out mess);
                MessageBox.Show("Éxitoso: " + mess);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al graficar los datos: " + ex.Message);
            }
        }
    }
}
