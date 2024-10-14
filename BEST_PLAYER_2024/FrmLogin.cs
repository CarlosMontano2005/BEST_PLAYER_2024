using System;
using System.Drawing;
using System.Windows.Forms;

namespace BEST_PLAYER_2024.Resources
{
    public partial class FrmLogin : Form
    {
        // Declarar variables para el movimiento del formulario
        private bool isDragging = false;
        private Point lastCursor;
        private Point lastForm;

        public FrmLogin()
        {
            InitializeComponent();

            this.MouseDown += new MouseEventHandler(FrmLogin_MouseDown);
            this.MouseMove += new MouseEventHandler(FrmLogin_MouseMove);
            this.MouseUp += new MouseEventHandler(FrmLogin_MouseUp);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Crear una instancia de FrmDashboard
            FrmDashboard frmDashboard = new FrmDashboard();

            // Mostrar FrmDashboard
            frmDashboard.Show();

            // Ocultar el formulario actual
            this.Hide();
        }

        private void FrmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            // Iniciar el movimiento cuando el botón izquierdo del mouse se presiona
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                lastCursor = Cursor.Position;
                lastForm = this.Location;
            }
        }

        private void FrmLogin_MouseMove(object sender, MouseEventArgs e)
        {
            // Mover el formulario cuando se está arrastrando
            if (isDragging)
            {
                Point delta = Point.Subtract(Cursor.Position, new Size(lastCursor));
                this.Location = Point.Add(lastForm, new Size(delta));
            }
        }

        private void FrmLogin_MouseUp(object sender, MouseEventArgs e)
        {
            // Detener el movimiento cuando el botón del mouse se suelta
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmCrearCuentaUsuario frmCrearCuenta = new FrmCrearCuentaUsuario();
            frmCrearCuenta.Show();
            this.Hide();
        }
    }
}
