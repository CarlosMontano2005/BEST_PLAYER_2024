namespace BEST_PLAYER_2024
{
    partial class FrmTablaAgencia
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DgvAgencia = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbTipoAgencia = new RJCodeAdvance.RJControls.RJComboBox();
            this.TxtBuscarEnGriw = new RJCodeAdvance.RJControls.RJTextBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.BtnExel = new RJCodeAdvance.RJControls.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAgencia)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvAgencia
            // 
            this.DgvAgencia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvAgencia.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.DgvAgencia.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.DgvAgencia.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DgvAgencia.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(113)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(232)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvAgencia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DgvAgencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAgencia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.DgvAgencia.EnableHeadersVisualStyles = false;
            this.DgvAgencia.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(113)))), ((int)(((byte)(62)))));
            this.DgvAgencia.Location = new System.Drawing.Point(24, 135);
            this.DgvAgencia.Margin = new System.Windows.Forms.Padding(5);
            this.DgvAgencia.Name = "DgvAgencia";
            this.DgvAgencia.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(232)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvAgencia.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(232)))), ((int)(((byte)(120)))));
            this.DgvAgencia.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.DgvAgencia.Size = new System.Drawing.Size(831, 489);
            this.DgvAgencia.TabIndex = 36;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "#";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombres";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Tipo";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Telefono";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Email";
            this.Column5.Name = "Column5";
            // 
            // cmbTipoAgencia
            // 
            this.cmbTipoAgencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.cmbTipoAgencia.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(113)))), ((int)(((byte)(62)))));
            this.cmbTipoAgencia.BorderSize = 0;
            this.cmbTipoAgencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbTipoAgencia.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoAgencia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.cmbTipoAgencia.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(113)))), ((int)(((byte)(62)))));
            this.cmbTipoAgencia.Items.AddRange(new object[] {
            "Filtrar por equipo",
            "Barcelona",
            "Real Madrid",
            "Manchester"});
            this.cmbTipoAgencia.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.cmbTipoAgencia.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(232)))), ((int)(((byte)(120)))));
            this.cmbTipoAgencia.Location = new System.Drawing.Point(28, 60);
            this.cmbTipoAgencia.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbTipoAgencia.Name = "cmbTipoAgencia";
            this.cmbTipoAgencia.Size = new System.Drawing.Size(200, 36);
            this.cmbTipoAgencia.TabIndex = 37;
            this.cmbTipoAgencia.Texts = "Filtrar por Agencia";
            this.cmbTipoAgencia.OnSelectedIndexChanged += new System.EventHandler(this.cmbTipoAgencia_OnSelectedIndexChanged);
            // 
            // TxtBuscarEnGriw
            // 
            this.TxtBuscarEnGriw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.TxtBuscarEnGriw.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(28)))));
            this.TxtBuscarEnGriw.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(232)))), ((int)(((byte)(120)))));
            this.TxtBuscarEnGriw.BorderRadius = 0;
            this.TxtBuscarEnGriw.BorderSize = 2;
            this.TxtBuscarEnGriw.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBuscarEnGriw.ForeColor = System.Drawing.Color.White;
            this.TxtBuscarEnGriw.Location = new System.Drawing.Point(250, 60);
            this.TxtBuscarEnGriw.Margin = new System.Windows.Forms.Padding(4);
            this.TxtBuscarEnGriw.Multiline = false;
            this.TxtBuscarEnGriw.Name = "TxtBuscarEnGriw";
            this.TxtBuscarEnGriw.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.TxtBuscarEnGriw.PasswordChar = false;
            this.TxtBuscarEnGriw.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.TxtBuscarEnGriw.PlaceholderText = "Buscar Agencia";
            this.TxtBuscarEnGriw.Size = new System.Drawing.Size(313, 36);
            this.TxtBuscarEnGriw.TabIndex = 38;
            this.TxtBuscarEnGriw.Texts = "";
            this.TxtBuscarEnGriw.UnderlinedStyle = true;
            this.TxtBuscarEnGriw._TextChanged += new System.EventHandler(this.TxtBuscarEnGriw__TextChanged);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(232)))), ((int)(((byte)(120)))));
            this.BtnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(28)))));
            this.BtnBuscar.Location = new System.Drawing.Point(570, 60);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(103, 36);
            this.BtnBuscar.TabIndex = 39;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // BtnExel
            // 
            this.BtnExel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(111)))), ((int)(((byte)(66)))));
            this.BtnExel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(111)))), ((int)(((byte)(66)))));
            this.BtnExel.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnExel.BorderRadius = 0;
            this.BtnExel.BorderSize = 0;
            this.BtnExel.FlatAppearance.BorderSize = 0;
            this.BtnExel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExel.ForeColor = System.Drawing.Color.White;
            this.BtnExel.Image = global::BEST_PLAYER_2024.Properties.Resources.icons8_ms_excel_24;
            this.BtnExel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnExel.Location = new System.Drawing.Point(740, 63);
            this.BtnExel.Name = "BtnExel";
            this.BtnExel.Size = new System.Drawing.Size(115, 33);
            this.BtnExel.TabIndex = 75;
            this.BtnExel.Text = "Excel";
            this.BtnExel.TextColor = System.Drawing.Color.White;
            this.BtnExel.UseVisualStyleBackColor = false;
            this.BtnExel.Click += new System.EventHandler(this.BtnExel_Click);
            // 
            // FrmTablaAgencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(888, 650);
            this.Controls.Add(this.BtnExel);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.TxtBuscarEnGriw);
            this.Controls.Add(this.cmbTipoAgencia);
            this.Controls.Add(this.DgvAgencia);
            this.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmTablaAgencia";
            this.Text = "FtmJugadores";
            this.Load += new System.EventHandler(this.FrmTablaAgencia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvAgencia)).EndInit();
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.DataGridView DgvAgencia;
        private RJCodeAdvance.RJControls.RJComboBox cmbTipoAgencia;
        private RJCodeAdvance.RJControls.RJTextBox TxtBuscarEnGriw;
        private System.Windows.Forms.Button BtnBuscar;
        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private RJCodeAdvance.RJControls.RJButton BtnExel;
    }
}