using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using Servicios;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controlador;
using System.Windows.Forms;

namespace BEST_PLAYER_2024
{
    public partial class FrmDataJugadores : Form
    {
        public FrmDataJugadores()
        {
            InitializeComponent();
            CargarForm(CtrJugador._idJugador);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            FrmTablaJugadores frmHijo1Regresar = new FrmTablaJugadores(); // 

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
        private int id;
        void CargarForm(int id)
        {
            try
            {
                DataTable datos = ServJugador.cargarDatos(id);
                if (datos.Rows.Count > 0) {
                    DataRow row = datos.Rows[0];
                    lblAsistencias.Text = row["Asistencias"].ToString();
                    lblDescripcion.Text = row["DescripcionJugador"].ToString();
                    lblGoles.Text = row["Goles"].ToString();
                    txtTAmarilla.Text = row["TargetasAmarillas"].ToString();
                    txtTRoja.Text = row["TargetasRojas"].ToString();
                    lblNacional.Text = row["Nacionalidad"].ToString();
                    lblNCamisa.Text = row["NumeroCamisa"].ToString();
                    lblNombreJugador.Text = row["NombreJugador"].ToString();
                    lblPosicion.Text = row["Posicion"].ToString();
                    lblPJugados.Text = row["PartidosJugados"].ToString();
                    if (lblPosicion.Text.Equals("Centrocampista")) lblPosicion.BackColor = Color.FromArgb(226, 127, 43);
                    else if (lblPosicion.Text.Equals("Portero")) lblPosicion.BackColor = Color.FromArgb(61, 76, 165);
                    else if (lblPosicion.Text.Equals("Delantero")) {
                        lblPosicion.ForeColor = Color.Black;
                        lblPosicion.BackColor = Color.FromArgb(233, 229, 22);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("¿ELiminar el jugador?","Confirmar",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    /*CtrJugador jugador = new CtrJugador();
                    jugador.IdJugador = CtrJugador._idJugador;*/
                    string message;
                    bool isSuccess = ServJugador.EliminarJugador(out message);
                    if (isSuccess)
                    {
                        MessageBox.Show("Informacion completa");
                        FrmTablaJugadores frmtablaj = new FrmTablaJugadores();
                        this.Controls.Clear();
                        frmtablaj.TopLevel = false;
                        frmtablaj.FormBorderStyle = FormBorderStyle.None;
                        frmtablaj.Dock = DockStyle.Fill;
                        this.Controls.Add(frmtablaj);
                        frmtablaj.Show();
                    }
                    else
                    {
                        MessageBox.Show(message, " Error al registrar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
