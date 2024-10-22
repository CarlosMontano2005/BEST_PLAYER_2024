using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controlador;
using Servicios;

namespace BEST_PLAYER_2024
{
    public partial class FrmTablaAgencia : Form
    {
        public FrmTablaAgencia()
        {
            InitializeComponent();
        }

        private void FrmTablaAgencia_Load(object sender, EventArgs e)
        {
            CargarGridDatos();
            CargarTipoAgenciaEnComboBox();
        }

        void CargarTipoAgenciaEnComboBox()
        {
            try
            {
                DataTable datos = ServUsuario.CargarAgencias();
                var equipos = datos.AsEnumerable()
                                   .Select(fila => fila.Field<string>("TipoAgencia"))
                                   .Distinct()
                                   .ToList();
                cmbTipoAgencia.Items.Clear();
                cmbTipoAgencia.Items.Add("Filtrar");
                // Agregar los equipos al ComboBox
                foreach (var equipo in equipos)
                {
                    cmbTipoAgencia.Items.Add(equipo);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los equipos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //método para cargar los datos en el DataGridView
        void CargarGridDatos()
        {
            try
            {
                DataTable datos = ServUsuario.CargarAgencias(); //cargar los datos de la base de datos
                DgvAgencia.Rows.Clear();

                //asignar los valores a las columnas predefinidas
                foreach (DataRow fila in datos.Rows)
                {
                    int index = DgvAgencia.Rows.Add();
                    DgvAgencia.Rows[index].Cells["Column1"].Value = fila["IdAgencia"];
                    DgvAgencia.Rows[index].Cells["Column2"].Value = fila["NombreAgencia"];
                    DgvAgencia.Rows[index].Cells["Column3"].Value = fila["TipoAgencia"];
                    DgvAgencia.Rows[index].Cells["Column4"].Value = fila["Telefono"];
                    DgvAgencia.Rows[index].Cells["Column5"].Value = fila["EmailContacto"];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnExel_Click(object sender, EventArgs e)
        {
            try
            {
                string mess;
                ExcelUtilities excel = new ExcelUtilities();
                excel.ExportDataGridViewToExcel(DgvAgencia, "Tabla de Agencias", out mess);
                // Mostrar mensaje de éxito o error
                MessageBox.Show(mess);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "ERROR ARCHIVO", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
        private void FiltrarPorNombreAgencia(string nombreAgencia)
        {
            // Limpia el DataGridView antes de aplicar el filtro
            DgvAgencia.Rows.Clear();

            // Cargar todos los datos nuevamente desde la base de datos
            DataTable datos = ServUsuario.CargarAgencias();

            // Recorrer todas las filas de datos
            foreach (DataRow fila in datos.Rows)
            {
                // Verificar si el nombre de la agencia contiene el texto buscado (sin importar mayúsculas/minúsculas)
                if (fila["NombreAgencia"].ToString().IndexOf(nombreAgencia, StringComparison.OrdinalIgnoreCase) >= 0|| fila["TipoAgencia"].ToString().IndexOf(nombreAgencia, StringComparison.OrdinalIgnoreCase) >= 0|| fila["EmailContacto"].ToString().IndexOf(nombreAgencia, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    // Agregar la fila filtrada al DataGridView
                    int index = DgvAgencia.Rows.Add();
                    DgvAgencia.Rows[index].Cells["Column1"].Value = fila["IdAgencia"];
                    DgvAgencia.Rows[index].Cells["Column2"].Value = fila["NombreAgencia"];
                    DgvAgencia.Rows[index].Cells["Column3"].Value = fila["TipoAgencia"];
                    DgvAgencia.Rows[index].Cells["Column4"].Value = fila["Telefono"];
                    DgvAgencia.Rows[index].Cells["Column5"].Value = fila["EmailContacto"];
                }
            }
        }
        private void TxtBuscarEnGriw__TextChanged(object sender, EventArgs e)
        {
            // Limpia el DataGridView antes de aplicar el filtro
            DgvAgencia.Rows.Clear();

            // Cargar todos los datos nuevamente desde la base de datos
            DataTable datos = ServUsuario.CargarAgencias();

            // Recorrer todas las filas de datos
            foreach (DataRow fila in datos.Rows)    
            {
                // Verificar si el nombre de la agencia contiene el texto buscado (sin importar mayúsculas/minúsculas)
                if (fila["NombreAgencia"].ToString().IndexOf(TxtBuscarEnGriw.Texts, StringComparison.OrdinalIgnoreCase) >= 0 || fila["TipoAgencia"].ToString().IndexOf(TxtBuscarEnGriw.Texts, StringComparison.OrdinalIgnoreCase) >= 0 || fila["EmailContacto"].ToString().IndexOf(TxtBuscarEnGriw.Texts, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    // Agregar la fila filtrada al DataGridView
                    int index = DgvAgencia.Rows.Add();
                    DgvAgencia.Rows[index].Cells["Column1"].Value = fila["IdAgencia"];
                    DgvAgencia.Rows[index].Cells["Column2"].Value = fila["NombreAgencia"];
                    DgvAgencia.Rows[index].Cells["Column3"].Value = fila["TipoAgencia"];
                    DgvAgencia.Rows[index].Cells["Column4"].Value = fila["Telefono"];
                    DgvAgencia.Rows[index].Cells["Column5"].Value = fila["EmailContacto"];
                }
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            string nombreAgenciaBuscada = TxtBuscarEnGriw.Texts.Trim();
            FiltrarPorNombreAgencia(nombreAgenciaBuscada);
        }

        private void cmbTipoAgencia_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipoAgencia.SelectedItem != "Filtrar")
            {
                string equipoSeleccionado = cmbTipoAgencia.SelectedItem.ToString();
                FiltrarPorNombreAgencia(equipoSeleccionado);
            }
            else
            {
                CargarGridDatos();
            }
        }
    }
}




