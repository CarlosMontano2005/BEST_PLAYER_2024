using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using Servicios;
using Controlador;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BEST_PLAYER_2024
{
    public partial class FrmTablaJugadores : Form
    {
        public FrmTablaJugadores()
        {
            InitializeComponent();
            CargarGridDatos();
            CargarEquiposEnComboBox();
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            /*
            FrmDataJugadores child2 = new FrmDataJugadores();

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
            */
            //
            Form existingForm = Application.OpenForms.OfType<FrmFormularioJugadores>().FirstOrDefault();

           
            if (existingForm==null) {
                FrmFormularioJugadores frmjugadorfuncion = new FrmFormularioJugadores(1);
                frmjugadorfuncion.Show();

            }
            else MessageBox.Show("El formulario ya esta abierto","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            
        }
        void CargarEquiposEnComboBox()
        {
            try
            {
                DataTable datos = ServJugador.CargarJugadores();
                var equipos = datos.AsEnumerable()
                                   .Select(fila => fila.Field<string>("NombreEquipo"))
                                   .Distinct()
                                   .ToList();
                cmbEquipos.Items.Clear();
                cmbEquipos.Items.Add("Todos los equipos");
                // Agregar los equipos al ComboBox
                foreach (var equipo in equipos)
                {
                    cmbEquipos.Items.Add(equipo);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los equipos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ActualizarTabla()
        {
            //recargar los datos de la tabla
            DgvJugador.DataSource = null;
            DgvJugador.DataSource = ServJugador.CargarJugadores();
        }

        private void CargarGridDatos()
        {
            try
            {
                DataTable datos = ServJugador.CargarJugadores();
                DgvJugador.DataSource = datos;
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
            DgvJugador.Columns["IdJugador"].HeaderText = "#";
            DgvJugador.Columns["Nombre"].HeaderText = "Nombre";
            DgvJugador.Columns["Altura"].HeaderText = "Altura";
            DgvJugador.Columns["Nacionalidad"].HeaderText = "Nacionalidad";
            DgvJugador.Columns["NombreEquipo"].HeaderText = "Equipo";
        }
 
        private void FiltrarDeBusqueda(string buscador)
        {
            // Llamar al método cargar tabla 
            CargarGridDatos();
            DataTable datos = ServJugador.CargarJugadores();

            // Crear un nuevo DataTable para almacenar las filas filtradas
            DataTable datosFiltrados = datos.Clone();

            // Recorrer todas las filas de datos
            foreach (DataRow fila in datos.Rows)
            {
                // Verificar si el nombre o la nacionalidad o cualquier otro dato que busca contienen el texto buscado (sin importar mayúsculas/minúsculas)
                if (fila["Nombre"].ToString().IndexOf(buscador, StringComparison.OrdinalIgnoreCase) >= 0 ||
                    fila["Nacionalidad"].ToString().IndexOf(buscador, StringComparison.OrdinalIgnoreCase) >= 0 ||
                    fila["NombreEquipo"].ToString().IndexOf(buscador, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    datosFiltrados.ImportRow(fila);
                }
            }

            // Asignar el DataTable filtrado al DataGridView
            DgvJugador.DataSource = datosFiltrados;
            // Configurar columnas del DataGridView
            ConfigurarColumnasDgv();
        }


        private void DgvJugador_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = DgvJugador.Rows[e.RowIndex];
            CtrJugador._idJugador = int.Parse(row.Cells[0].Value.ToString());

            FrmDataJugadores frmjugador = new FrmDataJugadores();
            this.Controls.Clear();
            frmjugador.TopLevel = false;
            frmjugador.FormBorderStyle = FormBorderStyle.None;
            frmjugador.Dock = DockStyle.Fill;
            this.Controls.Add(frmjugador);
            frmjugador.Show();
        }

        private void BtnExel_Click(object sender, EventArgs e)
        {
            try
            {
                string mess;
                ExcelUtilities excel = new ExcelUtilities();
                excel.ExportDataGridViewToExcel(DgvJugador, "Tabla de Jugadores", out mess);
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
            FiltrarDeBusqueda(txtBuscar.Texts);
        }
       
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            
        }

        private void cmbEquipos_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEquipos.SelectedItem != "Todos los equipos")
            {
                string equipoSeleccionado = cmbEquipos.SelectedItem.ToString();
                FiltrarDeBusqueda(equipoSeleccionado);
            }
            else
            {
                CargarGridDatos();
            }
        }
    }
}
