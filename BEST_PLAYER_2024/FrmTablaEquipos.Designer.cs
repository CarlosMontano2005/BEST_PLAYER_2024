namespace BEST_PLAYER_2024
{
    partial class FrmTablaEquipos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnRegresar = new System.Windows.Forms.Label();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.rjTextBox1 = new RJCodeAdvance.RJControls.RJTextBox();
            this.CmbPaisFiltro = new RJCodeAdvance.RJControls.RJComboBox();
            this.BtnExel = new RJCodeAdvance.RJControls.RJButton();
            this.DgvEquipo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEquipo)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnRegresar
            // 
            this.BtnRegresar.AutoSize = true;
            this.BtnRegresar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(232)))), ((int)(((byte)(120)))));
            this.BtnRegresar.Location = new System.Drawing.Point(780, 51);
            this.BtnRegresar.Name = "BtnRegresar";
            this.BtnRegresar.Size = new System.Drawing.Size(82, 21);
            this.BtnRegresar.TabIndex = 45;
            this.BtnRegresar.Text = "Regresar";
            this.BtnRegresar.Click += new System.EventHandler(this.BtnRegresar_Click);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(232)))), ((int)(((byte)(120)))));
            this.BtnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(28)))));
            this.BtnBuscar.Location = new System.Drawing.Point(573, 43);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(103, 36);
            this.BtnBuscar.TabIndex = 44;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = false;
            // 
            // rjTextBox1
            // 
            this.rjTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.rjTextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(28)))));
            this.rjTextBox1.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(232)))), ((int)(((byte)(120)))));
            this.rjTextBox1.BorderRadius = 0;
            this.rjTextBox1.BorderSize = 2;
            this.rjTextBox1.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox1.ForeColor = System.Drawing.Color.White;
            this.rjTextBox1.Location = new System.Drawing.Point(253, 43);
            this.rjTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox1.Multiline = false;
            this.rjTextBox1.Name = "rjTextBox1";
            this.rjTextBox1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBox1.PasswordChar = false;
            this.rjTextBox1.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.rjTextBox1.PlaceholderText = "Buscar Equipo";
            this.rjTextBox1.Size = new System.Drawing.Size(313, 36);
            this.rjTextBox1.TabIndex = 43;
            this.rjTextBox1.Texts = "";
            this.rjTextBox1.UnderlinedStyle = true;
            this.rjTextBox1._TextChanged += new System.EventHandler(this.rjTextBox1__TextChanged);
            // 
            // CmbPaisFiltro
            // 
            this.CmbPaisFiltro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.CmbPaisFiltro.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(113)))), ((int)(((byte)(62)))));
            this.CmbPaisFiltro.BorderSize = 0;
            this.CmbPaisFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.CmbPaisFiltro.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbPaisFiltro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.CmbPaisFiltro.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(113)))), ((int)(((byte)(62)))));
            this.CmbPaisFiltro.Items.AddRange(new object[] {
            "Filtrar por equipo",
            "Barcelona",
            "Real Madrid",
            "Manchester"});
            this.CmbPaisFiltro.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.CmbPaisFiltro.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(232)))), ((int)(((byte)(120)))));
            this.CmbPaisFiltro.Location = new System.Drawing.Point(31, 43);
            this.CmbPaisFiltro.MinimumSize = new System.Drawing.Size(200, 30);
            this.CmbPaisFiltro.Name = "CmbPaisFiltro";
            this.CmbPaisFiltro.Size = new System.Drawing.Size(200, 36);
            this.CmbPaisFiltro.TabIndex = 42;
            this.CmbPaisFiltro.Texts = "Filtrar por Pais";
            this.CmbPaisFiltro.OnSelectedIndexChanged += new System.EventHandler(this.CmbPaisFiltro_OnSelectedIndexChanged);
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
            this.BtnExel.Location = new System.Drawing.Point(743, 77);
            this.BtnExel.Name = "BtnExel";
            this.BtnExel.Size = new System.Drawing.Size(115, 33);
            this.BtnExel.TabIndex = 76;
            this.BtnExel.Text = "Excel";
            this.BtnExel.TextColor = System.Drawing.Color.White;
            this.BtnExel.UseVisualStyleBackColor = false;
            this.BtnExel.Click += new System.EventHandler(this.BtnExel_Click);
            // 
            // DgvEquipo
            // 
            this.DgvEquipo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvEquipo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvEquipo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.DgvEquipo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DgvEquipo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(113)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(232)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvEquipo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DgvEquipo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvEquipo.EnableHeadersVisualStyles = false;
            this.DgvEquipo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(113)))), ((int)(((byte)(62)))));
            this.DgvEquipo.Location = new System.Drawing.Point(31, 118);
            this.DgvEquipo.Margin = new System.Windows.Forms.Padding(5);
            this.DgvEquipo.Name = "DgvEquipo";
            this.DgvEquipo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(232)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvEquipo.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(232)))), ((int)(((byte)(120)))));
            this.DgvEquipo.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.DgvEquipo.Size = new System.Drawing.Size(831, 489);
            this.DgvEquipo.TabIndex = 77;
            this.DgvEquipo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvEquipo_CellDoubleClick);
            // 
            // FrmTablaEquipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(888, 650);
            this.Controls.Add(this.DgvEquipo);
            this.Controls.Add(this.BtnExel);
            this.Controls.Add(this.BtnRegresar);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.rjTextBox1);
            this.Controls.Add(this.CmbPaisFiltro);
            this.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmTablaEquipos";
            this.Text = "FrmTablaEquipos";
            ((System.ComponentModel.ISupportInitialize)(this.DgvEquipo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BtnRegresar;
        private System.Windows.Forms.Button BtnBuscar;
        private RJCodeAdvance.RJControls.RJTextBox rjTextBox1;
        private RJCodeAdvance.RJControls.RJComboBox CmbPaisFiltro;
        private RJCodeAdvance.RJControls.RJButton BtnExel;
        private System.Windows.Forms.DataGridView DgvEquipo;
    }
}