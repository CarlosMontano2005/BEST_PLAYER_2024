using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using Servicios;

namespace BEST_PLAYER_2024
{
    public partial class FrmTopJugadores : Form
    {
        public FrmTopJugadores()
        {
            InitializeComponent();
            cargarTopJugadores();
        }
        void cargarTopJugadores()
        {
            DataTable datos = ServTopJugadores.CargarTopFiveJugadores();
            try
            {
                if (datos.Rows.Count > 0)
                {
                    lblCantVotos_1.Text = datos.Rows[0]["cantidadVotos"].ToString();
                    string nombre = datos.Rows[0]["Nombre"].ToString();
                    string apellido = datos.Rows[0]["Apellido"].ToString();
                    lblNombreTop1.Text = nombre + " " + apellido;
                    lblEquipoTop1.Text = datos.Rows[0]["NombreEquipo"].ToString();
                }
                if (datos.Rows.Count > 1)
                {
                    lblCantVotos_2.Text = datos.Rows[1]["cantidadVotos"].ToString();
                    string nombre = datos.Rows[1]["Nombre"].ToString();
                    string apellido = datos.Rows[1]["Apellido"].ToString();
                    lblNombreTop2.Text = nombre + " " + apellido; lblEquipoTop2.Text = datos.Rows[1]["NombreEquipo"].ToString();
                }

                if (datos.Rows.Count > 2)
                {
                    lblCantVotos_3.Text = datos.Rows[2]["cantidadVotos"].ToString();
                    string nombre = datos.Rows[2]["Nombre"].ToString();
                    string apellido = datos.Rows[2]["Apellido"].ToString();
                    lblNombreTop3.Text = nombre + " " + apellido;
                    lblEquipoTop3.Text = datos.Rows[2]["NombreEquipo"].ToString();
                }

                if (datos.Rows.Count > 3)
                {
                    lblCantVotos_4.Text = datos.Rows[3]["cantidadVotos"].ToString();
                    string nombre = datos.Rows[3]["Nombre"].ToString();
                    string apellido = datos.Rows[3]["Apellido"].ToString();
                    lblNombreTop4.Text = nombre + " " + apellido; lblEquipoTop4.Text = datos.Rows[3]["NombreEquipo"].ToString();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error al cargar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            FrmTablaVotaciones child2 = new FrmTablaVotaciones();

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
    }
}
