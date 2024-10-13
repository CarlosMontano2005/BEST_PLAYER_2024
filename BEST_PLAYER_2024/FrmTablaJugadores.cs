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
        void CargarGridDatos()
        {
            try
            {
                DataTable datos = ServJugador.CargarJugadores();
                DgvJugador.DataSource = datos;
                // Renombrar las columnas en el DataGridView
                DgvJugador.Columns["IdJugador"].HeaderText = "#";
                DgvJugador.Columns["Nombre"].HeaderText = "Nombre";
                DgvJugador.Columns["Altura"].HeaderText = "Altura";
                DgvJugador.Columns["Nacionalidad"].HeaderText = "Nacionalidad";
                //
                DgvJugador.Columns["NombreEquipo"].HeaderText = "Equipo";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
    }
}
