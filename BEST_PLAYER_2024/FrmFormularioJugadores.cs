using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Servicios;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Controlador;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace BEST_PLAYER_2024
{
    public partial class FrmFormularioJugadores : Form
    {
        private int codigo_accion;
        public FrmFormularioJugadores(int codigo)
        {
            InitializeComponent();
            codigo_accion = codigo;
            LlenarEquipo();
            LlenarNacionalida();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void IngresarDatos() {
            try {
                
            } catch (Exception ex) {
                MessageBox.Show($"Se produjo un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void LlenarEquipo()
        {
            try
            {
                DataTable equipos = ServJugador.cargarEquipo();

                // Crea una nueva fila para "Escoja una opción"
                DataRow newRow = equipos.NewRow();
                newRow["IdEquipo"] = DBNull.Value; // Valor nulo para el IdAgencia
                newRow["Nombre"] = "Escoja una opción";
                equipos.Rows.InsertAt(newRow, 0); // 
                // Asigna el DataTable al ComboBox de la libreria
                CmbEquipo.DataSource = equipos;
                CmbEquipo.DisplayMember = "Nombre";
                CmbEquipo.ValueMember = "IdEquipo";
                CmbEquipo.SelectedIndex = 0;
                //Asignamos el DataTable al ComboBox normal, para hacer un tipo de efecto espejo
                CmbEquipoO.DataSource = equipos;
                CmbEquipoO.DisplayMember = "Nombre";
                CmbEquipoO.ValueMember = "IdEquipo";
                CmbEquipoO.SelectedIndex = 0;
            }
            catch (Exception ) {
                MessageBox.Show("Error al cargar las agencias, verifique su conexión a internet o que el cable de red está conectado.", "Error de carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        void LlenarNacionalida() {
            try
            {
                DataTable nacionalidad = ServJugador.cargarNacionalidad();

                // Crea una nueva fila para "Escoja una opción"
               DataRow newRow = nacionalidad.NewRow();
                newRow["IdPais"] = DBNull.Value; // Valor nulo para el IdAgencia
                newRow["Nacionalidad"] = "Escoja una opción";
                nacionalidad.Rows.InsertAt(newRow, 0); // 
                // Asigna el DataTable al ComboBox de la libreria
                CmbNacionalidad.DataSource = nacionalidad;
                CmbNacionalidad.DisplayMember = "Nacionalidad";
                CmbNacionalidad.ValueMember = "IdPais";
                CmbNacionalidad.SelectedIndex = 0;
                //Asignamos el DataTable al ComboBox normal, para hacer un tipo de efecto espejo
                CmbNacionalidadO.DataSource = nacionalidad;
                CmbNacionalidadO.DisplayMember = "Nacionalidad";
                CmbNacionalidadO.ValueMember = "IdPais";
                CmbNacionalidadO.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error de carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (codigo_accion == 1)
            {
                try
                {
                    CtrJugador ctrJugador = new CtrJugador();

                    ctrJugador.NombreJugador = TxtNombre.Texts;
                    ctrJugador.ApellidoJugador = TxtApellido.Texts;
                    ctrJugador.DescripcionJugador = TxtDescripcion.Texts;
                    ctrJugador.IdEquipo = Convert.ToInt32(CmbEquipoO.SelectedValue);
                    ctrJugador.IdPais = Convert.ToInt32(CmbNacionalidadO.SelectedValue);
                    ctrJugador.FechaNacimiento = DtNacimiento.Text;
                    ctrJugador.Altura = float.Parse(TxtAltura.Texts);
                    //Aun no funciona con la imagen, da un pequeño problema
                    if (imageBytes != null)
                    {
                        ctrJugador.Foto = imageBytes;
                    }

                    string message;
                    bool isSuccess = ServJugador.RegistrarJugador(ctrJugador, out message);
                    if (isSuccess)
                    {
                        MessageBox.Show("Jugador registrado exitosamente.");
                        FrmFormularioDetalleJugador frmdetalle = new FrmFormularioDetalleJugador(TxtNombre.Texts,TxtApellido.Texts);
                        frmdetalle.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(message, " Error al registrar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.ToString());
                }


            }
            else if (codigo_accion == 0) {

            }
        }
        public byte[] imageBytes;

        private void BtnExaminar_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFolderSelec = new OpenFileDialog
                {
                    Filter = "Imagen|*.jpg;*.png",
                    InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures),
                    Title = "Seleccionar Imagen"
                };

                if (openFolderSelec.ShowDialog() == DialogResult.OK)
                {
                    using (var stream = new FileStream(openFolderSelec.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using (var img = Image.FromStream(stream))
                        {
                            if (img.Width > 500 || img.Height > 500)
                            {
                                MessageBox.Show("La imagen es demasiado grande. Las dimensiones máximas permitidas son 250x250 píxeles.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            PtJugador.Image = new Bitmap(img);
                            using (var memoryStream = new MemoryStream())
                            {
                                PtJugador.Image.Save(memoryStream, ImageFormat.Png);
                                imageBytes = memoryStream.ToArray();
                            }
                        }
                    }
                }
            }
            catch (FileNotFoundException fnfEx)
            {
                MessageBox.Show("No se pudo encontrar el archivo: " + fnfEx.Message, "Archivo no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (OutOfMemoryException oomEx)
            {
                MessageBox.Show("La imagen seleccionada no es válida o está corrupta: " + oomEx.Message, "Imagen no válida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ExternalException ex)
            {
                MessageBox.Show("Error de GDI+ al procesar la imagen: " + ex.Message, "Error de imagen", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex);
            }
        }
    }
}
