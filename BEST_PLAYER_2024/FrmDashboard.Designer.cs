namespace BEST_PLAYER_2024
{
    partial class FrmDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label label1;
            this.PnlNav = new System.Windows.Forms.Panel();
            this.BtnCerrarSecion = new System.Windows.Forms.Button();
            this.LblNivelUsuario = new System.Windows.Forms.Label();
            this.LblCorreo = new System.Windows.Forms.Label();
            this.PnlImagenFondo = new System.Windows.Forms.Panel();
            this.PanelOpciones = new System.Windows.Forms.Panel();
            this.PtbClose = new System.Windows.Forms.PictureBox();
            this.PnlContenedor = new System.Windows.Forms.Panel();
            this.LblBestPlayerContenedor = new System.Windows.Forms.Label();
            this.lblFiFaContendor = new System.Windows.Forms.Label();
            this.CirBoxPictorLogo = new RJCodeAdvance.RJControls.RJCircularPictureBox();
            this.LblJugadores = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LblAjuste = new System.Windows.Forms.Label();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.LblAgencias = new System.Windows.Forms.Label();
            this.LblTopJagadores = new System.Windows.Forms.Label();
            this.LblEquipos = new System.Windows.Forms.Label();
            this.LblVotar = new System.Windows.Forms.Label();
            this.lblInicio = new System.Windows.Forms.Label();
            this.rjCircularPictureBox1 = new RJCodeAdvance.RJControls.RJCircularPictureBox();
            label1 = new System.Windows.Forms.Label();
            this.PnlNav.SuspendLayout();
            this.PnlImagenFondo.SuspendLayout();
            this.PanelOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PtbClose)).BeginInit();
            this.PnlContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CirBoxPictorLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            label1.AutoSize = true;
            label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(232)))), ((int)(((byte)(120)))));
            label1.Location = new System.Drawing.Point(31, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(149, 25);
            label1.TabIndex = 0;
            label1.Text = "DASHBOARD";
            label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            label1.UseWaitCursor = true;
            // 
            // PnlNav
            // 
            this.PnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.PnlNav.Controls.Add(this.LblJugadores);
            this.PnlNav.Controls.Add(this.pictureBox1);
            this.PnlNav.Controls.Add(this.BtnCerrarSecion);
            this.PnlNav.Controls.Add(this.LblAjuste);
            this.PnlNav.Controls.Add(this.LblUsuario);
            this.PnlNav.Controls.Add(this.LblAgencias);
            this.PnlNav.Controls.Add(this.LblTopJagadores);
            this.PnlNav.Controls.Add(this.LblEquipos);
            this.PnlNav.Controls.Add(this.LblVotar);
            this.PnlNav.Controls.Add(this.lblInicio);
            this.PnlNav.Controls.Add(this.LblNivelUsuario);
            this.PnlNav.Controls.Add(this.LblCorreo);
            this.PnlNav.Controls.Add(this.rjCircularPictureBox1);
            this.PnlNav.Controls.Add(label1);
            this.PnlNav.Cursor = System.Windows.Forms.Cursors.Default;
            this.PnlNav.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlNav.Location = new System.Drawing.Point(0, 0);
            this.PnlNav.Margin = new System.Windows.Forms.Padding(5);
            this.PnlNav.Name = "PnlNav";
            this.PnlNav.Size = new System.Drawing.Size(212, 650);
            this.PnlNav.TabIndex = 0;
            this.PnlNav.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlNav_MouseDown);
            this.PnlNav.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PnlNav_MouseMove);
            this.PnlNav.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PnlNav_MouseUp);
            // 
            // BtnCerrarSecion
            // 
            this.BtnCerrarSecion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(232)))), ((int)(((byte)(120)))));
            this.BtnCerrarSecion.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnCerrarSecion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrarSecion.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrarSecion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(28)))));
            this.BtnCerrarSecion.Location = new System.Drawing.Point(0, 440);
            this.BtnCerrarSecion.Name = "BtnCerrarSecion";
            this.BtnCerrarSecion.Size = new System.Drawing.Size(212, 35);
            this.BtnCerrarSecion.TabIndex = 12;
            this.BtnCerrarSecion.Text = "Cerrar Sesion";
            this.BtnCerrarSecion.UseVisualStyleBackColor = false;
            this.BtnCerrarSecion.Click += new System.EventHandler(this.BtnCerrarSecion_Click);
            // 
            // LblNivelUsuario
            // 
            this.LblNivelUsuario.AutoSize = true;
            this.LblNivelUsuario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNivelUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.LblNivelUsuario.Location = new System.Drawing.Point(43, 79);
            this.LblNivelUsuario.Name = "LblNivelUsuario";
            this.LblNivelUsuario.Size = new System.Drawing.Size(125, 21);
            this.LblNivelUsuario.TabIndex = 3;
            this.LblNivelUsuario.Text = "Administrador";
            this.LblNivelUsuario.UseWaitCursor = true;
            // 
            // LblCorreo
            // 
            this.LblCorreo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCorreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.LblCorreo.Location = new System.Drawing.Point(32, 49);
            this.LblCorreo.Name = "LblCorreo";
            this.LblCorreo.Size = new System.Drawing.Size(161, 20);
            this.LblCorreo.TabIndex = 2;
            this.LblCorreo.Text = "correo@example.com";
            this.LblCorreo.UseWaitCursor = true;
            // 
            // PnlImagenFondo
            // 
            this.PnlImagenFondo.BackColor = System.Drawing.Color.Black;
            this.PnlImagenFondo.BackgroundImage = global::BEST_PLAYER_2024.Properties.Resources.bcdcc833ef5e93053f701eef185d9113;
            this.PnlImagenFondo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PnlImagenFondo.Controls.Add(this.PanelOpciones);
            this.PnlImagenFondo.Controls.Add(this.PnlContenedor);
            this.PnlImagenFondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlImagenFondo.Location = new System.Drawing.Point(212, 0);
            this.PnlImagenFondo.Margin = new System.Windows.Forms.Padding(5);
            this.PnlImagenFondo.Name = "PnlImagenFondo";
            this.PnlImagenFondo.Size = new System.Drawing.Size(888, 650);
            this.PnlImagenFondo.TabIndex = 3;
            // 
            // PanelOpciones
            // 
            this.PanelOpciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.PanelOpciones.Controls.Add(this.PtbClose);
            this.PanelOpciones.Cursor = System.Windows.Forms.Cursors.Default;
            this.PanelOpciones.Location = new System.Drawing.Point(0, 0);
            this.PanelOpciones.Name = "PanelOpciones";
            this.PanelOpciones.Size = new System.Drawing.Size(888, 28);
            this.PanelOpciones.TabIndex = 1;
            this.PanelOpciones.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelOpciones_MouseDown);
            this.PanelOpciones.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelOpciones_MouseMove);
            this.PanelOpciones.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PanelOpciones_MouseUp);
            // 
            // PtbClose
            // 
            this.PtbClose.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.PtbClose.Image = global::BEST_PLAYER_2024.Properties.Resources.x_regular_24__2_;
            this.PtbClose.Location = new System.Drawing.Point(857, 0);
            this.PtbClose.Name = "PtbClose";
            this.PtbClose.Size = new System.Drawing.Size(31, 28);
            this.PtbClose.TabIndex = 0;
            this.PtbClose.TabStop = false;
            this.PtbClose.Click += new System.EventHandler(this.PtbClose_Click);
            // 
            // PnlContenedor
            // 
            this.PnlContenedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PnlContenedor.Controls.Add(this.LblBestPlayerContenedor);
            this.PnlContenedor.Controls.Add(this.lblFiFaContendor);
            this.PnlContenedor.Controls.Add(this.CirBoxPictorLogo);
            this.PnlContenedor.Cursor = System.Windows.Forms.Cursors.Default;
            this.PnlContenedor.Location = new System.Drawing.Point(0, 28);
            this.PnlContenedor.MaximumSize = new System.Drawing.Size(900, 620);
            this.PnlContenedor.Name = "PnlContenedor";
            this.PnlContenedor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.PnlContenedor.Size = new System.Drawing.Size(888, 620);
            this.PnlContenedor.TabIndex = 0;
            // 
            // LblBestPlayerContenedor
            // 
            this.LblBestPlayerContenedor.AutoSize = true;
            this.LblBestPlayerContenedor.BackColor = System.Drawing.Color.Transparent;
            this.LblBestPlayerContenedor.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBestPlayerContenedor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblBestPlayerContenedor.Location = new System.Drawing.Point(278, 349);
            this.LblBestPlayerContenedor.Name = "LblBestPlayerContenedor";
            this.LblBestPlayerContenedor.Size = new System.Drawing.Size(382, 54);
            this.LblBestPlayerContenedor.TabIndex = 11;
            this.LblBestPlayerContenedor.Text = "BEST  PLAYER 2024";
            this.LblBestPlayerContenedor.UseWaitCursor = true;
            // 
            // lblFiFaContendor
            // 
            this.lblFiFaContendor.AutoSize = true;
            this.lblFiFaContendor.BackColor = System.Drawing.Color.Transparent;
            this.lblFiFaContendor.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblFiFaContendor.Font = new System.Drawing.Font("Segoe UI", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiFaContendor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFiFaContendor.Location = new System.Drawing.Point(375, 271);
            this.lblFiFaContendor.Name = "lblFiFaContendor";
            this.lblFiFaContendor.Size = new System.Drawing.Size(172, 89);
            this.lblFiFaContendor.TabIndex = 10;
            this.lblFiFaContendor.Text = "FIFA";
            // 
            // CirBoxPictorLogo
            // 
            this.CirBoxPictorLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(232)))), ((int)(((byte)(120)))));
            this.CirBoxPictorLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CirBoxPictorLogo.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Round;
            this.CirBoxPictorLogo.BorderColor = System.Drawing.Color.RoyalBlue;
            this.CirBoxPictorLogo.BorderColor2 = System.Drawing.Color.HotPink;
            this.CirBoxPictorLogo.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.CirBoxPictorLogo.BorderSize = 0;
            this.CirBoxPictorLogo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.CirBoxPictorLogo.GradientAngle = 50F;
            this.CirBoxPictorLogo.Image = global::BEST_PLAYER_2024.Properties.Resources.ea_sports_fc_logo_freelogovectors_net_;
            this.CirBoxPictorLogo.Location = new System.Drawing.Point(375, 118);
            this.CirBoxPictorLogo.Name = "CirBoxPictorLogo";
            this.CirBoxPictorLogo.Size = new System.Drawing.Size(138, 138);
            this.CirBoxPictorLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CirBoxPictorLogo.TabIndex = 2;
            this.CirBoxPictorLogo.TabStop = false;
            // 
            // LblJugadores
            // 
            this.LblJugadores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblJugadores.Cursor = System.Windows.Forms.Cursors.Default;
            this.LblJugadores.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblJugadores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.LblJugadores.Image = global::BEST_PLAYER_2024.Properties.Resources.futbol_regular__1_;
            this.LblJugadores.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LblJugadores.Location = new System.Drawing.Point(25, 298);
            this.LblJugadores.Name = "LblJugadores";
            this.LblJugadores.Size = new System.Drawing.Size(162, 21);
            this.LblJugadores.TabIndex = 14;
            this.LblJugadores.Text = "Jugadores";
            this.LblJugadores.Click += new System.EventHandler(this.LblJugadores_Click);
            this.LblJugadores.MouseLeave += new System.EventHandler(this.LblJugadores_MouseLeave);
            this.LblJugadores.MouseHover += new System.EventHandler(this.LblJugadores_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::BEST_PLAYER_2024.Properties.Resources.ea_sports_fc_logo_freelogovectors_net_;
            this.pictureBox1.Location = new System.Drawing.Point(73, 538);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            // 
            // LblAjuste
            // 
            this.LblAjuste.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblAjuste.Cursor = System.Windows.Forms.Cursors.Default;
            this.LblAjuste.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAjuste.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.LblAjuste.Image = global::BEST_PLAYER_2024.Properties.Resources.gear_fill;
            this.LblAjuste.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LblAjuste.Location = new System.Drawing.Point(25, 403);
            this.LblAjuste.Name = "LblAjuste";
            this.LblAjuste.Size = new System.Drawing.Size(162, 21);
            this.LblAjuste.TabIndex = 11;
            this.LblAjuste.Text = "Ajustes";
            this.LblAjuste.Click += new System.EventHandler(this.LblAjuste_Click);
            this.LblAjuste.MouseLeave += new System.EventHandler(this.LblAjuste_MouseLeave);
            this.LblAjuste.MouseHover += new System.EventHandler(this.LblAjuste_MouseHover);
            // 
            // LblUsuario
            // 
            this.LblUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblUsuario.Cursor = System.Windows.Forms.Cursors.Default;
            this.LblUsuario.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.LblUsuario.Image = global::BEST_PLAYER_2024.Properties.Resources.person_fill;
            this.LblUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LblUsuario.Location = new System.Drawing.Point(25, 368);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(162, 21);
            this.LblUsuario.TabIndex = 9;
            this.LblUsuario.Text = "Usuario";
            this.LblUsuario.Click += new System.EventHandler(this.LblUsuario_Click);
            this.LblUsuario.MouseLeave += new System.EventHandler(this.LblUsuario_MouseLeave);
            this.LblUsuario.MouseHover += new System.EventHandler(this.LblUsuario_MouseHover);
            // 
            // LblAgencias
            // 
            this.LblAgencias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblAgencias.Cursor = System.Windows.Forms.Cursors.Default;
            this.LblAgencias.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAgencias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.LblAgencias.Image = global::BEST_PLAYER_2024.Properties.Resources.globe_americas;
            this.LblAgencias.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LblAgencias.Location = new System.Drawing.Point(25, 333);
            this.LblAgencias.Name = "LblAgencias";
            this.LblAgencias.Size = new System.Drawing.Size(162, 21);
            this.LblAgencias.TabIndex = 8;
            this.LblAgencias.Text = "Agencias";
            this.LblAgencias.Click += new System.EventHandler(this.LblAgencias_Click);
            this.LblAgencias.MouseLeave += new System.EventHandler(this.LblAgencias_MouseLeave);
            this.LblAgencias.MouseHover += new System.EventHandler(this.LblAgencias_MouseHover);
            // 
            // LblTopJagadores
            // 
            this.LblTopJagadores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblTopJagadores.Cursor = System.Windows.Forms.Cursors.Default;
            this.LblTopJagadores.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTopJagadores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.LblTopJagadores.Image = global::BEST_PLAYER_2024.Properties.Resources.star_fill;
            this.LblTopJagadores.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LblTopJagadores.Location = new System.Drawing.Point(25, 228);
            this.LblTopJagadores.Name = "LblTopJagadores";
            this.LblTopJagadores.Size = new System.Drawing.Size(162, 21);
            this.LblTopJagadores.TabIndex = 7;
            this.LblTopJagadores.Text = "Top Jugadores";
            this.LblTopJagadores.Click += new System.EventHandler(this.LblTopJagadores_Click);
            this.LblTopJagadores.MouseLeave += new System.EventHandler(this.LblTopJagadores_MouseLeave);
            this.LblTopJagadores.MouseHover += new System.EventHandler(this.LblTopJagadores_MouseHover);
            // 
            // LblEquipos
            // 
            this.LblEquipos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblEquipos.Cursor = System.Windows.Forms.Cursors.Default;
            this.LblEquipos.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEquipos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.LblEquipos.Image = global::BEST_PLAYER_2024.Properties.Resources.people_fill;
            this.LblEquipos.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LblEquipos.Location = new System.Drawing.Point(25, 263);
            this.LblEquipos.Name = "LblEquipos";
            this.LblEquipos.Size = new System.Drawing.Size(162, 21);
            this.LblEquipos.TabIndex = 6;
            this.LblEquipos.Text = "Equipos";
            this.LblEquipos.Click += new System.EventHandler(this.LblEquipos_Click);
            this.LblEquipos.MouseLeave += new System.EventHandler(this.LblEquipos_MouseLeave);
            this.LblEquipos.MouseHover += new System.EventHandler(this.LblEquipos_MouseHover);
            // 
            // LblVotar
            // 
            this.LblVotar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblVotar.Cursor = System.Windows.Forms.Cursors.Default;
            this.LblVotar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVotar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.LblVotar.Image = global::BEST_PLAYER_2024.Properties.Resources.trophy_solid;
            this.LblVotar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LblVotar.Location = new System.Drawing.Point(25, 193);
            this.LblVotar.Name = "LblVotar";
            this.LblVotar.Size = new System.Drawing.Size(162, 21);
            this.LblVotar.TabIndex = 5;
            this.LblVotar.Text = "Votaciones";
            this.LblVotar.Click += new System.EventHandler(this.LblVotar_Click);
            this.LblVotar.MouseLeave += new System.EventHandler(this.LblVotar_MouseLeave);
            this.LblVotar.MouseHover += new System.EventHandler(this.LblVotar_MouseHover);
            // 
            // lblInicio
            // 
            this.lblInicio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInicio.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblInicio.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.lblInicio.Image = global::BEST_PLAYER_2024.Properties.Resources.house_door_fill;
            this.lblInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblInicio.Location = new System.Drawing.Point(25, 158);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(162, 21);
            this.lblInicio.TabIndex = 4;
            this.lblInicio.Text = "Inicio";
            this.lblInicio.Click += new System.EventHandler(this.lblInicio_Click);
            this.lblInicio.MouseLeave += new System.EventHandler(this.lblInicio_MouseLeave);
            this.lblInicio.MouseHover += new System.EventHandler(this.lblInicio_MouseHover);
            // 
            // rjCircularPictureBox1
            // 
            this.rjCircularPictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rjCircularPictureBox1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.rjCircularPictureBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(232)))), ((int)(((byte)(120)))));
            this.rjCircularPictureBox1.BorderColor2 = System.Drawing.Color.DarkGreen;
            this.rjCircularPictureBox1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.rjCircularPictureBox1.BorderSize = 2;
            this.rjCircularPictureBox1.GradientAngle = 50F;
            this.rjCircularPictureBox1.Image = global::BEST_PLAYER_2024.Properties.Resources._default;
            this.rjCircularPictureBox1.Location = new System.Drawing.Point(12, 55);
            this.rjCircularPictureBox1.Name = "rjCircularPictureBox1";
            this.rjCircularPictureBox1.Size = new System.Drawing.Size(14, 14);
            this.rjCircularPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.rjCircularPictureBox1.TabIndex = 1;
            this.rjCircularPictureBox1.TabStop = false;
            this.rjCircularPictureBox1.UseWaitCursor = true;
            // 
            // FrmDashboard
            // 
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1100, 650);
            this.Controls.Add(this.PnlImagenFondo);
            this.Controls.Add(this.PnlNav);
            this.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximumSize = new System.Drawing.Size(1100, 650);
            this.MinimumSize = new System.Drawing.Size(1000, 650);
            this.Name = "FrmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDashboard";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmDashboard_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmDashboard_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FrmDashboard_MouseUp);
            this.PnlNav.ResumeLayout(false);
            this.PnlNav.PerformLayout();
            this.PnlImagenFondo.ResumeLayout(false);
            this.PanelOpciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PtbClose)).EndInit();
            this.PnlContenedor.ResumeLayout(false);
            this.PnlContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CirBoxPictorLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlNav;
        private System.Windows.Forms.Panel PnlImagenFondo;
        private System.Windows.Forms.Panel PnlContenedor;
        private System.Windows.Forms.Label LblNivelUsuario;
        private System.Windows.Forms.Label LblCorreo;
        private RJCodeAdvance.RJControls.RJCircularPictureBox rjCircularPictureBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnCerrarSecion;
        private System.Windows.Forms.Label LblAjuste;
        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.Label LblAgencias;
        private System.Windows.Forms.Label LblTopJagadores;
        private System.Windows.Forms.Label LblEquipos;
        private System.Windows.Forms.Label LblVotar;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.Label LblJugadores;
        private RJCodeAdvance.RJControls.RJCircularPictureBox CirBoxPictorLogo;
        private System.Windows.Forms.Label LblBestPlayerContenedor;
        private System.Windows.Forms.Label lblFiFaContendor;
        private System.Windows.Forms.Panel PanelOpciones;
        private System.Windows.Forms.PictureBox PtbClose;
    }
}