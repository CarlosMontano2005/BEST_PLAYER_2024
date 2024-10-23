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
using System.IO;

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
                for (int i = 0; i < datos.Rows.Count && i < 5; i++)
                {
                    Label lblCantVotos = this.Controls.Find($"lblCantVotos_{i + 1}", true).FirstOrDefault() as Label;
                    Label lblNombreTop = this.Controls.Find($"lblNombreTop{i + 1}", true).FirstOrDefault() as Label;
                    Label lblEquipoTop = this.Controls.Find($"lblEquipoTop{i + 1}", true).FirstOrDefault() as Label;
                    if (lblCantVotos != null)
                        lblCantVotos.Text = datos.Rows[i]["cantidadVotos"].ToString();
                    if (lblNombreTop != null && lblEquipoTop != null)
                    {
                        string nombre = datos.Rows[i]["Nombre"].ToString();
                        string apellido = datos.Rows[i]["Apellido"].ToString();
                        lblNombreTop.Text = $"{nombre} {apellido}";
                        lblEquipoTop.Text = datos.Rows[i]["NombreEquipo"].ToString();
                    }
                    PictureBox pxFotoJugador = this.Controls.Find($"PxFotoJugador_{i + 1}", true).FirstOrDefault() as PictureBox;
                    PictureBox pxbLogoEq = this.Controls.Find($"PxbLogoEq_{i + 1}", true).FirstOrDefault() as PictureBox;

                    if (pxFotoJugador != null)
                    {
                        byte[] imagenBytesJugador = datos.Rows[i]["Foto"] as byte[];
                        if (imagenBytesJugador != null && imagenBytesJugador.Length > 0)
                        {
                            using (MemoryStream ms = new MemoryStream(imagenBytesJugador))
                            {
                                pxFotoJugador.Image = new Bitmap(ms);
                            }
                        }
                    }

                    if (pxbLogoEq != null)
                    {
                        byte[] imagenBytesLogo = datos.Rows[i]["FotoLogo"] as byte[];
                        if (imagenBytesLogo != null && imagenBytesLogo.Length > 0)
                        {
                            using (MemoryStream ms = new MemoryStream(imagenBytesLogo))
                            {
                                pxbLogoEq.Image = new Bitmap(ms);
                            }
                        }
                    }
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
