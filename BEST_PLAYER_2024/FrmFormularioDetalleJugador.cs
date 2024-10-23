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
        private int idDetalle;
        public int codigop;
        public FrmFormularioDetalleJugador(string nombre_jugador,string apellido_jugador)
        {
            InitializeComponent();
            DataTable cargarId = ServDetalleJugador.searchId(nombre_jugador,apellido_jugador);
            idJugador = Convert.ToInt32(cargarId.Rows[0]["IdJugador"].ToString());
            codigop = 0;
            TxtPosicion.Visible = false;
            llenarPosicionJugador();
        }

        void llenarPosicionJugador()
        {
            // Limpiar los elementos del ComboBox antes de agregar nuevos
            CmbPosicion.Items.Clear();
            // Agregar las posiciones de los jugadores
            CmbPosicion.Items.Add("Portero");
            CmbPosicion.Items.Add("Centrocampista");
            CmbPosicion.Items.Add("Delantero");
            CmbPosicion.Items.Add("Defensa");
        }

        public FrmFormularioDetalleJugador(int id_jugador) {
            InitializeComponent();
            DataTable detalle = ServDetalleJugador.buscarDetalle(id_jugador);
            DataRow row = detalle.Rows[0];
            txtAsistencia.Texts = row["Asistencias"].ToString();
            idJugador = Convert.ToInt32(row["IdJugador"].ToString());
            TxtNumCamisa.Texts = row["NumeroCamisa"].ToString();
            TxtAmarillas.Texts = row["TargetasAmarillas"].ToString();
            TxtRojas.Texts = row["TargetasRojas"].ToString();
            TxtPosicion.Texts = row["Posicion"].ToString();
            TxtGoles.Texts = row["Goles"].ToString();
            idDetalle = Convert.ToInt32(row["IdEstadisticaJugador"].ToString());
            TxtPartidos.Texts = row["PartidosJugados"].ToString();
            codigop = 1;
        }

        private void rjTextBox6__TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (codigop == 0)
                {
                    if (TxtAmarillas.Texts != "" || txtAsistencia.Texts != "" || TxtGoles.Texts != "" || TxtNumCamisa.Texts != "" || TxtPartidos.Texts != "" || TxtRojas.Texts != "")//TxtPosicion.Texts != "" ||
                    {
                        CtrDetalleJugador detallejugador = new CtrDetalleJugador();
                        detallejugador.IdJugador = idJugador;
                        // detallejugador.Posicion = TxtPosicion.Texts;
                        detallejugador.Posicion = CmbPosicion.SelectedItem.ToString();
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
                    else {
                        MessageBox.Show("Por favor llenar todos los campos","Campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else if (codigop == 1) {
                    if (TxtAmarillas.Texts != "" || txtAsistencia.Texts != "" || TxtGoles.Texts != "" || TxtNumCamisa.Texts != "" || TxtPartidos.Texts != "" || TxtRojas.Texts != "")//TxtPosicion.Texts != "" || 
                    {
                        CtrDetalleJugador detallejugador = new CtrDetalleJugador();
                        detallejugador.idDetalle = idDetalle;
                        detallejugador.IdJugador = idJugador;
                        //detallejugador.Posicion = TxtPosicion.Texts;
                        detallejugador.Posicion = CmbPosicion.SelectedItem.ToString();
                        detallejugador.NumeroCamisa = Convert.ToInt32(TxtNumCamisa.Texts);
                        detallejugador.PartidosJugados = Convert.ToInt32(TxtPartidos.Texts);
                        detallejugador.Goles = Convert.ToInt32(TxtGoles.Texts);
                        detallejugador.PorcentajeGoles = float.Parse((detallejugador.Goles / detallejugador.PartidosJugados).ToString());
                        detallejugador.Aistencias = Convert.ToInt32(txtAsistencia.Texts);
                        detallejugador.TarjetasAmarrilas = Convert.ToInt32(TxtAmarillas.Texts);
                        detallejugador.TarjetasRojas = Convert.ToInt32(TxtRojas.Texts);
                        string message;
                        bool isSuccess = ServDetalleJugador.ActualizarDetalle(detallejugador, out message);
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
                    else
                    {
                        MessageBox.Show("Por favor llenar todos los campos", "Campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
