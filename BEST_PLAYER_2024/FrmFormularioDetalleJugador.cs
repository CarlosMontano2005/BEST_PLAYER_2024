using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using Servicios;
using System.Text;
using Controlador;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BEST_PLAYER_2024
{
    public partial class FrmFormularioDetalleJugador : Form
    {
        public int idJugador;
        public FrmFormularioDetalleJugador(string nombre_jugador,string apellido_jugador)
        {
            InitializeComponent();
            DataTable cargarId = ServDetalleJugador.searchId(nombre_jugador,apellido_jugador);
            idJugador = Convert.ToInt32(cargarId.Rows[0]["IdJugador"].ToString());
        }

        private void rjTextBox6__TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                CtrDetalleJugador detallejugador = new CtrDetalleJugador();
                detallejugador.IdJugador = idJugador;
                detallejugador.Posicion = TxtPosicion.Texts;
                detallejugador.NumeroCamisa = Convert.ToInt32(TxtNumCamisa.Texts);
                detallejugador.PartidosJugados = Convert.ToInt32(TxtPartidos.Texts);
                detallejugador.Goles = Convert.ToInt32(TxtGoles.Texts);
                detallejugador.PorcentajeGoles = float.Parse((detallejugador.Goles / detallejugador.PartidosJugados).ToString());
                detallejugador.Aistencias = Convert.ToInt32(txtAsistencia.Texts);
                detallejugador.TarjetasAmarrilas = Convert.ToInt32(TxtAmarillas.Texts);
                detallejugador.TarjetasRojas = Convert.ToInt32(TxtRojas.Texts);
                string message;
                bool isSuccess = ServDetalleJugador.RegistrarDetalle(detallejugador, out message);
                if (isSuccess)
                {
                    MessageBox.Show("Informacion completa");
                    this.Close();
                }
                else
                {
                    MessageBox.Show(message, " Error al registrar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
