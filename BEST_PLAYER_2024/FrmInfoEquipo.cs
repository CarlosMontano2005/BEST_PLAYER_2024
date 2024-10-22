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
    public partial class FrmInfoEquipo : Form
    {
        private string _IdEquipo;
        public FrmInfoEquipo(string[] DatoEquipo )
        {
            InitializeComponent();
            try
            {
                //string[] DatosEquipo = { idEquipo, nombreEquipo, pais, CantidadJugadores, DT, FotoLogoEquipo, Foto_DT };

                //traigo datos que se enviaron
                _IdEquipo = DatoEquipo[0];
                LblNombreEquipo.Text = DatoEquipo[1];
                lblPais.Text = DatoEquipo[2];
                lblCantidadEquipo.Text = $"Jugadores: {DatoEquipo[3]}";
                lblNombreDT.Text = DatoEquipo[4];
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            FrmTablaEquipos frmHijo1Regresar = new FrmTablaEquipos(); // 

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
    }
}
