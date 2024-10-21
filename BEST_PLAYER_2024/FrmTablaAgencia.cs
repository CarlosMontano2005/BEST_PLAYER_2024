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
                    int index = DgvAgencia.Rows.Add(); //agregar una nueva fila al DataGridView
                    DgvAgencia.Rows[index].Cells["Column1"].Value = fila["IdAgencia"];         // asignar el valor de IdAgencia
                    DgvAgencia.Rows[index].Cells["Column2"].Value = fila["NombreAgencia"];     // asignar el valor de NombreAgencia
                    DgvAgencia.Rows[index].Cells["Column3"].Value = "Deportivo";               // asignar el valor "Deportivo" manualmente
                    DgvAgencia.Rows[index].Cells["Column4"].Value = fila["Telefono"];          // asignar el valor de Teléfono
                    DgvAgencia.Rows[index].Cells["Column5"].Value = fila["EmailContacto"];     // asignar el valor de EmailContacto         
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

        private void TxtBuscarEnGriw__TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}




