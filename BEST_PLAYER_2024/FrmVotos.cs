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
    public partial class FrmVotos : Form
    {
        public static bool YaVoto { get; set; } = false;

        public FrmVotos()
        {
            InitializeComponent();
            //topJugadores();
            LlenarEquipos();
            verificarVotoExistente();

        }

        // Método para llenar ComboBox con equipos
        void LlenarEquipos()
        {
            CmbEquipos.Items.Clear();
            CmbEquipos.Items.Add("Escoja una opción");
            CmbEquipos.Items.AddRange(new object[]
            {
            "Manchester United", "Real Madrid", "Barcelona", "Boca Juniors", "River Plate",
            "Paris Saint-Germain", "Juventus", "Bayern Munich", "AC Milan", "Chelsea"
            });
            CmbEquipos.SelectedIndex = 0;
        }

        // Verifica si el usuario ya ha votado
        void verificarVotoExistente()
        {
            try
            {
                // Verificamos si el usuario ya ha votado
                DataTable datos = ServVotacion.VerificarUsuarioVoto(1033);

                if (datos.Rows.Count > 0)
                {
                    // Obtenemos el número total de votos
                    String TotalVotos = datos.Rows[0]["TotalVotos"].ToString();

                    // Convertimos a entero y verificamos si ha votado
                    int totalVotos = Convert.ToInt32(TotalVotos);
                    YaVoto = totalVotos > 0;  // Si ya ha votado al menos una vez

                    if (YaVoto)
                    {
                        // Si ya ha votado, bloquear botones y evitar que vote de nuevo
                        metodoBloquearBotones();
                        MessageBox.Show("Ya has votado. No puedes votar nuevamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    // Si no se obtienen datos, manejar el caso
                    MessageBox.Show("No se encontraron voto del usuario.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para gestionar el voto y bloqueo de botones
        void metodoBloquearBotones()
        {
            // Aquí deshabilitas todos los botones relacionados con la votación
            List<Button> botones = new List<Button>
            {
                btnVotar_1,
                btnVotar_2,
                btnVotar_3,
                btnVotar_4,
                btnVotar_5,
                btnVotar_6,
                btnVotar_7,
                btnVotar_8,
                btnVotar_9,
                btnVotar_10
            };

            // Bloquear los botones después de haber votado
            foreach (Button boton in botones)
            {
                boton.Enabled = false; // Deshabilita el botón
            }
        }

        // Método para registrar el voto
        void votarJugador(int IdJugadorVotar)
        {
            // Verifica si el usuario ya ha votado
            if (!YaVoto)
            {
                // Confirmación de voto
                DialogResult result = MessageBox.Show(
                    "¿Está seguro de votar por este jugador?",
                    "Confirmación de voto",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                // Si el usuario confirma el voto
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        // Crear instancia de CrtVotacion para enviar los datos del voto
                        CrtVotacion crtVotacion = new CrtVotacion
                        {
                            IdUsuario = 1033, //Nota cambiar con el usuario que inicio secion
                            IdJugadore = IdJugadorVotar
                        };

                        // Intentar insertar el voto
                        string message;
                        bool isSuccess = ServVotacion.InsertarVotoUsuario(crtVotacion, out message);

                        if (isSuccess)
                        {
                            // Marca que ya votó y bloquea los botones
                            YaVoto = true;
                            metodoBloquearBotones();

                            // Mensaje de éxito
                            MessageBox.Show(
                                "Has votado exitosamente.",
                                "Voto registrado",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                            );
                        }
                        else
                        {
                            // Muestra el mensaje de error recibido desde la base de datos
                            MessageBox.Show(
                                message,
                                "Error al registrar el voto",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                            );
                        }
                    }
                    catch (Exception ex)
                    {
                        // Manejo de excepciones general
                        MessageBox.Show(
                            $"Se produjo un error: {ex.Message}",
                            "Error inesperado",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                    }
                }
            }
            else
            {
                // Si el usuario ya ha votado, mensaje informativo
                MessageBox.Show(
                    "Ya has votado y no puedes votar nuevamente.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }

        // Variable pública entera de arreglo para almacenar el id del jugador que seleccionó el usuario al votar
        public static int[] IDJugadorVotado { get; set; } = new int[10];
        // Varaibel publica string para tener el nombre del juador votado
        public static string[] NombreJugadorVotado { get; set; }= new string [10];
        //Metodo para cargar datos de los votantes 
        void topJugadores()
        {
            string EquipoSeleccionado = CmbEquipos.SelectedItem.ToString();
            //MessageBox.Show("Has seleccionado: " + valorSeleccionado);
            //Si es diferente 'Escoja una opción' significa que cargara datos de jugadores del equipo seleccionado, si no pues jugadores aleatorios
            //Entonces el DataTable datos seria igual dependiedo si escojio ono
            DataTable datos;
            if (EquipoSeleccionado != "Escoja una opción")
            {
               datos  = ServVotacion.CargarTopJugadoresEquipo(EquipoSeleccionado);
            }
            else
            {
                 datos = ServVotacion.CargarTopJugadorAleatorio();
            }
            try
            {
                //Primero limpiamos los label
                for (int i = 0; i < 10 && i < 10; i++) //no se exceda de 10 jugadores
                {
                    Label lbl = this.Controls.Find($"LblJugador_{i + 1}", true).FirstOrDefault() as Label;
                    if (lbl != null)
                    {
                        lbl.Text = "";
                    }
                }
                for (int i = 0; i < datos.Rows.Count && i < 10; i++) //no se exceda de 10 jugadores
                {
                    // Variable que contendrá los LblJugador_1 al 10
                    Label lbl = this.Controls.Find($"LblJugador_{i + 1}", true).FirstOrDefault() as Label;

                    if (lbl != null)
                    {
                        // Colocamos el nombre del jugador en cada etiqueta
                        lbl.Text = datos.Rows[i]["nomJugador"].ToString();
                        //Almacenamos el nombre del jugador votado
                        NombreJugadorVotado[i] = datos.Rows[i]["nomJugador"].ToString();
                        // Almacenamos el ID del jugador en el arreglo
                        IDJugadorVotado[i] = Convert.ToInt32(datos.Rows[i]["IdJugador"]);
                     
                    }
                }   
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: "+ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnVotar_1_Click(object sender, EventArgs e)
        {
            //verificar que numero de voto del 1 al 10 esta botando
            //Boton de jugador 1 para votar, verificamos en el arreglo

            //pruebas
            MessageBox.Show("Jugador posicion 1: " + NombreJugadorVotado[0] + " Numero de ID: "+ IDJugadorVotado[0]);

            votarJugador(IDJugadorVotado[0]);
            //Ok ya que se selecciono lo demas, harmos que el metodo de votarJugadores reciba dos parametros 
        }

        private void CmbEquipos_SelectedIndexChanged(object sender, EventArgs e)
        {
            topJugadores();
        }
    }
}
