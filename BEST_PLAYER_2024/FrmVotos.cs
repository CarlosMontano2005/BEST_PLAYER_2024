using Controlador;
using Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
                DataTable datos = ServVotacion.VerificarUsuarioVoto();

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
                // Primer ciclo: Limpiar los controles y bloquear/desaparecer los que no se usen
                for (int i = 0; i < 10; i++) // No se excede de 10 jugadores
                {
                    // Buscar los controles por nombre
                    Button button = this.Controls.Find($"btnVotar_{i + 1}", true).FirstOrDefault() as Button;
                    PictureBox pictureBox = this.Controls.Find($"PicJugador_{i + 1}", true).FirstOrDefault() as PictureBox;
                    Label lbl = this.Controls.Find($"LblJugador_{i + 1}", true).FirstOrDefault() as Label;

                    // Limpiar los textos de las etiquetas y desactivar botones si no se usan
                    if (lbl != null)
                    {
                        lbl.Text = "";
                    }
                    if (button != null)
                    {
                        button.Enabled = false; // Desactivar el botón
                    }
                    if (pictureBox != null)
                    {
                        pictureBox.Image = Properties.Resources.targeta_fifa_plantila; // Limpiar la imagen
                    }
                }

                // Segundo ciclo: Llenar los controles con los datos de los jugadores
                for (int i = 0; i < datos.Rows.Count && i < 10; i++) // No se excede de 10 jugadores
                {
                    // Buscar los controles dinámicos por nombre
                    Label lbl = this.Controls.Find($"LblJugador_{i + 1}", true).FirstOrDefault() as Label;
                    Button button = this.Controls.Find($"btnVotar_{i + 1}", true).FirstOrDefault() as Button;
                    PictureBox pictureBox = this.Controls.Find($"PicJugador_{i + 1}", true).FirstOrDefault() as PictureBox;

                    if (lbl != null)
                    {
                        // Asignar el nombre del jugador al Label
                        lbl.Text = datos.Rows[i]["nomJugador"].ToString();

                        // Almacenar el nombre y el ID del jugador votado en arrays
                        NombreJugadorVotado[i] = datos.Rows[i]["nomJugador"].ToString();
                        IDJugadorVotado[i] = Convert.ToInt32(datos.Rows[i]["IdJugador"]);
                    }

                    if (button != null)
                    {
                        button.Enabled = true; // Activar el botón
                    }

                    if (pictureBox != null)
                    {
                        byte[] imagenBytes = datos.Rows[i]["Foto"] as byte[];
                        if (imagenBytes != null && imagenBytes.Length > 0)
                        {
                            using (MemoryStream ms = new MemoryStream(imagenBytes))
                            {
                                pictureBox.Image = new Bitmap(ms); // Asignar la imagen al PictureBox
                            }
                        }
                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: "+ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        

        private void CmbEquipos_SelectedIndexChanged(object sender, EventArgs e)
        {
            topJugadores();
        }

        private void btnVotar_1_Click(object sender, EventArgs e)
        {
            //verificar que numero de voto del 1 al 10 esta botando
            //Boton de jugador 1 para votar, verificamos en el arreglo
            //pruebas
            MessageBox.Show("Jugador posicion 1: " + NombreJugadorVotado[0] + " Numero de ID: " + IDJugadorVotado[0]);

            votarJugador(IDJugadorVotado[0]);
            //Ok ya que se selecciono lo demas, harmos que el metodo de votarJugadores reciba dos parametros 
        }

        private void btnVotar_2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Jugador posicion 2: " + NombreJugadorVotado[1] + " Numero de ID: " + IDJugadorVotado[1]);

            votarJugador(IDJugadorVotado[1]);
        }

        private void btnVotar_3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Jugador posicion 3: " + NombreJugadorVotado[2] + " Numero de ID: " + IDJugadorVotado[2]);

            votarJugador(IDJugadorVotado[2]);
        }

        private void btnVotar_4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Jugador posicion 4: " + NombreJugadorVotado[3] + " Numero de ID: " + IDJugadorVotado[3]);

            votarJugador(IDJugadorVotado[3]);
        }

        private void btnVotar_5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Jugador posicion 5: " + NombreJugadorVotado[4] + " Numero de ID: " + IDJugadorVotado[4]);

            votarJugador(IDJugadorVotado[4]);
        }

        private void btnVotar_6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Jugador posicion 6: " + NombreJugadorVotado[5] + " Numero de ID: " + IDJugadorVotado[5]);

            votarJugador(IDJugadorVotado[5]);
        }

        private void btnVotar_7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Jugador posicion 7: " + NombreJugadorVotado[6] + " Numero de ID: " + IDJugadorVotado[6]);

            votarJugador(IDJugadorVotado[6]);
        }

        private void btnVotar_8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Jugador posicion 8: " + NombreJugadorVotado[7] + " Numero de ID: " + IDJugadorVotado[7]);

            votarJugador(IDJugadorVotado[7]);
        }

        private void btnVotar_9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Jugador posicion 9: " + NombreJugadorVotado[8] + " Numero de ID: " + IDJugadorVotado[8]);

            votarJugador(IDJugadorVotado[8]);
        }

        private void btnVotar_10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Jugador posicion 10: " + NombreJugadorVotado[9] + " Numero de ID: " + IDJugadorVotado[9]);

            votarJugador(IDJugadorVotado[9]);
        }
    }
}
