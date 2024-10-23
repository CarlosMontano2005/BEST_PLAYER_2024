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
        private int id_jugador;
        public FrmFormularioJugadores(int codigo)
        {
            InitializeComponent();
            codigo_accion = codigo;
            LlenarEquipo();
            LlenarNacionalida();
            validarMayorEdad();
            if (codigo == 0)
            {
                DataTable datos = ServJugador.cargarDatos(CtrJugador._idJugador);
                DataRow row = datos.Rows[0];
                TxtNombre.Texts = row["Nombre"].ToString();
                TxtApellido.Texts = row["Apellido"].ToString();
                id_jugador = Convert.ToInt32(row["IdJugador"].ToString());
                TxtAltura.Texts = row["Altura"].ToString();
                DtNacimiento.Text = row["Edad"].ToString();
                TxtDescripcion.Texts = row["DescripcionJugador"].ToString();
                CmbEquipo.Texts = row["Equipo"].ToString();
                CmbNacionalidad.Texts = row["Nacionalidad"].ToString();
                CmbEquipoO.Text= row["Equipo"].ToString();
                CmbNacionalidadO.Text = row["Nacionalidad"].ToString();
                CmbEquipoO.Visible = false;
                CmbNacionalidadO.Visible = false;
                if (row["Foto"]!=DBNull.Value) {
                    byte[] imageBytes = (byte[])row["Foto"];
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        Bitmap bm = new Bitmap(ms);
                        PtJugador.Image = bm;
                    }
                }
                else
                {
                    PtJugador.Image = null;
                }
            }
        }
        void validarMayorEdad()
        {
            DtNacimiento.MaxDate = DateTime.Now.AddYears(-18);
            DtNacimiento.MinDate = new DateTime(1900, 1, 1);
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
                CmbEquipo.ValueMember = "Nombre";
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
                    //ctrJugador.IdJugador = id_jugador;
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
                        MessageBox.Show("Jugador ingresado exitosamente.");
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
                try
                {
                    int id=id_jugador;
                    CtrJugador ctrJugador = new CtrJugador();
                    ctrJugador.IdJugador = id_jugador;
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
                    bool isSuccess = ServJugador.ActualizarJugador(ctrJugador, out message);
                    FrmFormularioDetalleJugador frmdetalle = new FrmFormularioDetalleJugador(id);
                    if (isSuccess)
                    {
                        MessageBox.Show("Jugador Actualizado exitosamente.");
                        frmdetalle.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(message, " Error al Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
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
