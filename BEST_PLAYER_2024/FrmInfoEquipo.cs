using Controlador;
using Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BEST_PLAYER_2024
{
    public partial class FrmInfoEquipo : Form
    {
        private string _IdEquipo;
        public FrmInfoEquipo(object[] DatoEquipo )
        {
            InitializeComponent();
            try
            {
                //object[] DatosEquipo = { idEquipo, nombreEquipo, pais, CantidadJugadores, DT, FotoLogoEquipo, Foto_DT };
                //traigo datos que se enviaron
                _IdEquipo = DatoEquipo[0].ToString();
                LblNombreEquipo.Text = DatoEquipo[1].ToString();
                lblPais.Text = DatoEquipo[2].ToString();
                lblCantidadEquipo.Text = $"Jugadores: {DatoEquipo[3].ToString()}";
                lblNombreDT.Text = DatoEquipo[4].ToString();
                // Cargar el logo del equipo si existe
                if (DatoEquipo[5] is byte[] logoEquipoBytes && logoEquipoBytes.Length > 0)
                {
                    using (MemoryStream ms = new MemoryStream(logoEquipoBytes))
                    {
                        Bitmap bm = new Bitmap(ms);
                        PxbLogoEquipo.Image = bm;
                    }
                }
                // Cargar la foto del DT si existe
                if (DatoEquipo[6] is byte[] fotoDTBytes && fotoDTBytes.Length > 0)
                {
                    using (MemoryStream ms = new MemoryStream(fotoDTBytes))
                    {
                        Bitmap bm = new Bitmap(ms);
                        PxbFotoDT.Image = bm;
                    }
                }
                buscarEquipo(Convert.ToInt32(_IdEquipo));
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        public void buscarEquipo(int id)
        {
            try
            {
                DataTable jugadores = ServDetalleJugador.buscarJugadoresEquipo(id);
                for (int i = 0; i < jugadores.Rows.Count && i < 10; i++) // No se excede de 10 jugadores
                {
                    DataRow datos = jugadores.Rows[i];

                    // Buscar los controles dinámicos por nombre
                    Label lblNombre = this.Controls.Find($"lblNombre_{i + 1}", true).FirstOrDefault() as Label;
                    Label lblApellido = this.Controls.Find($"lblApellido_{i + 1}", true).FirstOrDefault() as Label;
                    Label lblPosicion = this.Controls.Find($"lblPosicion_{i + 1}", true).FirstOrDefault() as Label;
                    PictureBox pictureBox = this.Controls.Find($"Foto_{i + 1}", true).FirstOrDefault() as PictureBox;
                    if (lblNombre != null)
                    {
                        // Asignar el nombre del jugador al Label
                        lblNombre.Text = datos["Nombre"].ToString();
                    }
                    if (lblApellido != null)
                    {
                        // Asignar el apellido del jugador al Label
                        lblApellido.Text = datos["Apellido"].ToString();
                    }
                    if (lblPosicion != null)
                    {
                        // Asignar el apellido del jugador al Label
                        lblPosicion.Text = datos["Posicion"].ToString();
                    }
                    if (pictureBox != null)
                    {
                        // Asignar la foto del jugador al PictureBox
                        byte[] imagenBytes = datos["Foto"] as byte[];
                        if (imagenBytes != null && imagenBytes.Length > 0)
                        {
                            using (MemoryStream ms = new MemoryStream(imagenBytes))
                            {
                                pictureBox.Image = new Bitmap(ms);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
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
        public void actualizarLogoEquipo()
        {
            try
            {
                if (string.IsNullOrEmpty(_IdEquipo) || !int.TryParse(_IdEquipo, out int idEquipo))
                {
                    MessageBox.Show("El ID del equipo no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (imageBytes == null || imageBytes.Length == 0)
                {
                    MessageBox.Show("El logo del equipo es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                CtrDetalleJugador ctrDetalle = new CtrDetalleJugador
                {
                    IdEquipo = idEquipo,
                    LogoEquipo = imageBytes 
                };
                string message;
                bool isSuccess = ServDetalleJugador.ActualizarLogoEquipo(ctrDetalle, out message);
                if (isSuccess)
                {
                    MessageBox.Show("El logo del equipo ha sido actualizado exitosamente.", "Actualización exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(message, "Error al actualizar el logo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Manejo general de excepciones
                MessageBox.Show($"Se produjo un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public byte[] imageBytes;

        private void PxbLogoEquipo_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFolderSelec = new OpenFileDialog
                {
                    Filter = "Imagen|*.jpg;*.png",
                    InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures),
                    Title = "Seleccionar Imagen Del Logo del Equipo"
                };

                if (openFolderSelec.ShowDialog() == DialogResult.OK)
                {
                    using (var stream = new FileStream(openFolderSelec.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using (var img = Image.FromStream(stream))
                        {
                            if (img.Width > 250 || img.Height > 250)
                            {
                                MessageBox.Show("La imagen es demasiado grande. Las dimensiones máximas permitidas son 250x250 píxeles.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            PxbLogoEquipo.Image = new Bitmap(img);
                            using (var memoryStream = new MemoryStream())
                            {
                                PxbLogoEquipo.Image.Save(memoryStream, ImageFormat.Png);
                                imageBytes = memoryStream.ToArray();
                            }

                            if (imageBytes != null && imageBytes.Length > 0)
                            {
                                actualizarLogoEquipo();
                            }
                            else
                            {
                                MessageBox.Show("Error al procesar la imagen seleccionada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Se produjo un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void actualizarFotoDT()
        {
            try
            {
                if (string.IsNullOrEmpty(_IdEquipo) || !int.TryParse(_IdEquipo, out int idEquipo))
                {
                    MessageBox.Show("El ID del director tecnico no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (imageBytes == null || imageBytes.Length == 0)
                {
                    MessageBox.Show("La foto del director tecnico es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                CtrDetalleJugador ctrDetalle = new CtrDetalleJugador{
                    IdEquipo = idEquipo,
                    FotoDT = imageBytes
                };
                string message;
                bool isSuccess = ServDetalleJugador.ActualizarFotoDT(ctrDetalle, out message);
                if (isSuccess)
                {
                    MessageBox.Show("La foto del director tecnico ha sido actualizado exitosamente.", "Actualización exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(message, "Error al actualizar la foto director tecnico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Se produjo un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void PxbFotoDT_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFolderSelec = new OpenFileDialog
                {
                    Filter = "Imagen|*.jpg;*.png",
                    InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures),
                    Title = "Seleccionar Foto del Director Tecnico"
                };

                if (openFolderSelec.ShowDialog() == DialogResult.OK)
                {
                    using (var stream = new FileStream(openFolderSelec.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using (var img = Image.FromStream(stream))
                        {
                            if (img.Width > 250 || img.Height > 250)
                            {
                                MessageBox.Show("La imagen es demasiado grande. Las dimensiones máximas permitidas son 250x250 píxeles.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            PxbFotoDT.Image = new Bitmap(img);
                            using (var memoryStream = new MemoryStream())
                            {
                                PxbFotoDT.Image.Save(memoryStream, ImageFormat.Png);
                                imageBytes = memoryStream.ToArray();
                            }

                            if (imageBytes != null && imageBytes.Length > 0)
                            {
                                actualizarFotoDT();
                            }
                            else
                            {
                                MessageBox.Show("Error al procesar la imagen seleccionada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Se produjo un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
