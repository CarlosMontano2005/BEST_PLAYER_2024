using System;
using System.Collections.Generic;
using System.ComponentModel;
using BEST_PLAYER_2024.Resources;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BEST_PLAYER_2024
{
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
        {
            InitializeComponent();
            PnlContenedor.BackColor = Color.FromArgb(150, Color.Black); //255 es full 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void OpenChildForm(Form childForm)
        {
            // Verificar si hay un formulario hijo abierto en el panel
            foreach (Control control in PnlContenedor.Controls)
            {
                if (control is Form openForm)
                {
                    // Verificar si el formulario abierto es el mismo que el que se quiere abrir
                    if (openForm.GetType() == childForm.GetType())
                    {
                        MessageBox.Show("El formulario ya está abierto.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    // Confirmar con el usuario si desea cerrar el formulario actual
                    DialogResult result = MessageBox.Show(
                        "Ya hay un formulario abierto. ¿Desea cerrarlo?",
                        "Confirmar cierre",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );
                    if (result == DialogResult.Yes)
                    {
                        PnlContenedor.Controls.Clear();
                    }
                    else
                    {
                        return;
                    }
                }
            }
            PnlContenedor.Controls.Clear();
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            PnlContenedor.Controls.Add(childForm);
            childForm.Show();
        }

        private void verifyLabel()
        {

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
           FrmHijo formUsuarios = new FrmHijo();
           OpenChildForm(formUsuarios);
        }
        #region Variables y Propiedades
        private bool isFormActive = false;
        private bool isDragging = false;
        private Point lastCursor;
        private Point lastForm;
        #endregion

        #region lblInicio
        private void lblInicio_Click(object sender, EventArgs e)
        {
            var lbl = lblFiFaContendor;
            var lbl_2 = LblBestPlayerContenedor;
            var pictureBoxToKeep = CirBoxPictorLogo;

            PnlContenedor.Controls.Clear();

            PnlContenedor.Controls.Add(lbl);
            PnlContenedor.Controls.Add(lbl_2);
            PnlContenedor.Controls.Add(pictureBoxToKeep);

            lblInicio.ForeColor = ColorTranslator.FromHtml("#09E878");
            lblInicio.Image = Properties.Resources.house_door_fill_green;
            isFormActive = true;
        }

        private void lblInicio_MouseHover(object sender, EventArgs e)
        {
            if (!isFormActive)
            {
                lblInicio.ForeColor = ColorTranslator.FromHtml("#09E878");
                lblInicio.Image = Properties.Resources.house_door_fill_green;
            }
        }

        private void lblInicio_MouseLeave(object sender, EventArgs e)
        {
            if (!isFormActive)
            {
                lblInicio.ForeColor = ColorTranslator.FromHtml("#B0B0B0");
                lblInicio.Image = Properties.Resources.house_door_fill;
            }
        }
        #endregion

        #region LblVotar
        private void LblVotar_Click(object sender, EventArgs e)
        {
            LblVotar.ForeColor = ColorTranslator.FromHtml("#09E878");
            LblVotar.Image = Properties.Resources.trophy_solid_green;
            isFormActive = true;
            FrmVotos frm = new FrmVotos();
            //  FrmPrueba frmPrueba = new FrmPrueba();
            OpenChildForm(frm);
        }

        private void LblVotar_MouseHover(object sender, EventArgs e)
        {
            if (!isFormActive)
            {
                LblVotar.ForeColor = ColorTranslator.FromHtml("#09E878");
                LblVotar.Image = Properties.Resources.trophy_solid_green;
            }
        }

        private void LblVotar_MouseLeave(object sender, EventArgs e)
        {
            if (!isFormActive)
            {
                LblVotar.ForeColor = ColorTranslator.FromHtml("#B0B0B0");
                LblVotar.Image = Properties.Resources.trophy_solid;
            }
        }
        #endregion

        #region LblTopJagadores
        private void LblTopJagadores_Click(object sender, EventArgs e)
        {
            LblTopJagadores.ForeColor = ColorTranslator.FromHtml("#09E878");
            isFormActive = true;
            LblTopJagadores.Image = Properties.Resources.star_fill_green;
            FrmTopJugadores frm = new FrmTopJugadores();
            //  FrmTablaVotaciones frm = new FrmTablaVotaciones();
            OpenChildForm(frm);
        }

        private void LblTopJagadores_MouseHover(object sender, EventArgs e)
        {
            if (!isFormActive)
            {
                LblTopJagadores.ForeColor = ColorTranslator.FromHtml("#09E878");
                LblTopJagadores.Image = Properties.Resources.star_fill_green;
            }
        }

        private void LblTopJagadores_MouseLeave(object sender, EventArgs e)
        {
            if (!isFormActive)
            {
                LblTopJagadores.ForeColor = ColorTranslator.FromHtml("#B0B0B0");
                LblTopJagadores.Image = Properties.Resources.star_fill;
            }
        }
        #endregion

        #region LblEquipos
        private void LblEquipos_Click(object sender, EventArgs e)
        {
            LblEquipos.ForeColor = ColorTranslator.FromHtml("#09E878");
            isFormActive = true;
            LblEquipos.Image = Properties.Resources.people_fill_green;
            FrmTablaEquipos frmEquipo = new FrmTablaEquipos();
            OpenChildForm(frmEquipo);
        }

        private void LblEquipos_MouseHover(object sender, EventArgs e)
        {
            if (!isFormActive)
            {
                LblEquipos.ForeColor = ColorTranslator.FromHtml("#09E878");
                LblEquipos.Image = Properties.Resources.people_fill_green;
            }
        }

        private void LblEquipos_MouseLeave(object sender, EventArgs e)
        {
            if (!isFormActive)
            {
                LblEquipos.ForeColor = ColorTranslator.FromHtml("#B0B0B0");
                LblEquipos.Image = Properties.Resources.people_fill;
            }
        }
        #endregion

        #region LblJugadores
        private void LblJugadores_Click(object sender, EventArgs e)
        {
            LblJugadores.ForeColor = ColorTranslator.FromHtml("#09E878");
            LblJugadores.Image = Properties.Resources.futbol_regular_green;
            isFormActive = true;
            FrmTablaJugadores frmJugadores = new FrmTablaJugadores();
            OpenChildForm(frmJugadores);
        }

        private void LblJugadores_MouseHover(object sender, EventArgs e)
        {
            if (!isFormActive)
            {
                LblJugadores.ForeColor = ColorTranslator.FromHtml("#09E878");
                LblJugadores.Image = Properties.Resources.futbol_regular_green;
            }
        }

        private void LblJugadores_MouseLeave(object sender, EventArgs e)
        {
            if (!isFormActive)
            {
                LblJugadores.ForeColor = ColorTranslator.FromHtml("#B0B0B0");
                LblJugadores.Image = Properties.Resources.futbol_regular__1_;
            }
        }
        #endregion

        #region LblAgencias
        private void LblAgencias_Click(object sender, EventArgs e)
        {
            LblAgencias.ForeColor = ColorTranslator.FromHtml("#09E878");
            LblAgencias.Image = Properties.Resources.globe_americas_green;
            isFormActive = true;
            FrmTablaAgencia frmAgencia = new FrmTablaAgencia();
            OpenChildForm(frmAgencia);
        }

        private void LblAgencias_MouseHover(object sender, EventArgs e)
        {
            if (!isFormActive)
            {
                LblAgencias.ForeColor = ColorTranslator.FromHtml("#09E878");
                LblAgencias.Image = Properties.Resources.globe_americas_green;
            }
        }

        private void LblAgencias_MouseLeave(object sender, EventArgs e)
        {
            if (!isFormActive)
            {
                LblAgencias.ForeColor = ColorTranslator.FromHtml("#B0B0B0");
                LblAgencias.Image = Properties.Resources.globe_americas;
            }
        }
        #endregion

        #region LblUsuario
        private void LblUsuario_Click(object sender, EventArgs e)
        {
            LblUsuario.ForeColor = ColorTranslator.FromHtml("#09E878");
            LblUsuario.Image = Properties.Resources.person_fill_green;
            FrmAdministrarUsuarios prueba = new FrmAdministrarUsuarios();
            OpenChildForm(prueba);
            isFormActive = true;
        }

        private void LblUsuario_MouseHover(object sender, EventArgs e)
        {
            if (!isFormActive)
            {
                LblUsuario.ForeColor = ColorTranslator.FromHtml("#09E878");
                LblUsuario.Image = Properties.Resources.person_fill_green;
            }
        }

        private void LblUsuario_MouseLeave(object sender, EventArgs e)
        {
            if (!isFormActive)
            {
                LblUsuario.ForeColor = ColorTranslator.FromHtml("#B0B0B0");
                LblUsuario.Image = Properties.Resources.person_fill;
            }
        }
        #endregion

        #region LblAjuste
        private void LblAjuste_Click(object sender, EventArgs e)
        {
            LblAjuste.ForeColor = ColorTranslator.FromHtml("#09E878");
            LblAjuste.Image = Properties.Resources.gear_fill_green;
            FrmAjustes ajustes = new FrmAjustes();//FrmAjustes ajustes = new FrmAjustes();
            OpenChildForm(ajustes);
            isFormActive = true;
        }

        private void LblAjuste_MouseHover(object sender, EventArgs e)
        {
            if (!isFormActive)
            {
                LblAjuste.ForeColor = ColorTranslator.FromHtml("#09E878");
                LblAjuste.Image = Properties.Resources.gear_fill_green;
            }
        }

        private void LblAjuste_MouseLeave(object sender, EventArgs e)
        {
            if (!isFormActive)
            {
                LblAjuste.ForeColor = ColorTranslator.FromHtml("#B0B0B0");
                LblAjuste.Image = Properties.Resources.gear_fill;
            }
        }
        #endregion

        #region PnlNav (Formulario Movible)
        private void PnlNav_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                lastCursor = Cursor.Position;
                lastForm = this.Location;
            }
        }

        private void PnlNav_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point delta = Point.Subtract(Cursor.Position, new Size(lastCursor));
                this.Location = Point.Add(lastForm, new Size(delta));
            }
        }

        private void PnlNav_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }
        #endregion

        #region BtnCerrarSesion
        private void BtnCerrarSecion_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro que desea salir del sistema?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                FrmLogin frmlogin = new FrmLogin();
                frmlogin.Show();
                this.Close();// Cierra la aplicación
            }
        }

        #endregion

        private void PtbClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro que desea salir del sistema?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                FrmLogin frmlogin = new FrmLogin();
                frmlogin.Show();
                this.Close();// Cierra la aplicación
                             //Application.Exit();

            }
        }

        private void FrmDashboard_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                lastCursor = Cursor.Position;
                lastForm = this.Location;
            }
        }

        private void FrmDashboard_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point delta = Point.Subtract(Cursor.Position, new Size(lastCursor));
                this.Location = Point.Add(lastForm, new Size(delta));
            }
        }

        private void FrmDashboard_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }

        private void PanelOpciones_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                lastCursor = Cursor.Position;
                lastForm = this.Location;
            }
        }

        private void PanelOpciones_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point delta = Point.Subtract(Cursor.Position, new Size(lastCursor));
                this.Location = Point.Add(lastForm, new Size(delta));
            }
        }

        private void PanelOpciones_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }
    }
}
