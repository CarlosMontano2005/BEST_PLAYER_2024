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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DgvTabla = new System.Windows.Forms.DataGridView();
            this.rjComboBox1 = new RJCodeAdvance.RJControls.RJComboBox();
            this.rjTextBox1 = new RJCodeAdvance.RJControls.RJTextBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.BtnRegresar = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTabla)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvTabla
            // 
            this.DgvTabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvTabla.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvTabla.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.DgvTabla.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DgvTabla.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(113)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(232)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvTabla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvTabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.DgvTabla.EnableHeadersVisualStyles = false;
            this.DgvTabla.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(113)))), ((int)(((byte)(62)))));
            this.DgvTabla.Location = new System.Drawing.Point(24, 135);
            this.DgvTabla.Margin = new System.Windows.Forms.Padding(5);
            this.DgvTabla.Name = "DgvTabla";
            this.DgvTabla.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(232)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvTabla.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(232)))), ((int)(((byte)(120)))));
            this.DgvTabla.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvTabla.Size = new System.Drawing.Size(831, 489);
            this.DgvTabla.TabIndex = 36;
            // 
            // rjComboBox1
            // 
            this.rjComboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.rjComboBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(113)))), ((int)(((byte)(62)))));
            this.rjComboBox1.BorderSize = 0;
            this.rjComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.rjComboBox1.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.rjComboBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(113)))), ((int)(((byte)(62)))));
            this.rjComboBox1.Items.AddRange(new object[] {
            "Filtrar por equipo",
            "Barcelona",
            "Real Madrid",
            "Manchester"});
            this.rjComboBox1.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.rjComboBox1.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(232)))), ((int)(((byte)(120)))));
            this.rjComboBox1.Location = new System.Drawing.Point(28, 60);
            this.rjComboBox1.MinimumSize = new System.Drawing.Size(200, 30);
            this.rjComboBox1.Name = "rjComboBox1";
            this.rjComboBox1.Size = new System.Drawing.Size(200, 36);
            this.rjComboBox1.TabIndex = 37;
            this.rjComboBox1.Texts = "Filtrar por equipo";
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
            this.rjTextBox1.Location = new System.Drawing.Point(250, 60);
            this.rjTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox1.Multiline = false;
            this.rjTextBox1.Name = "rjTextBox1";
            this.rjTextBox1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBox1.PasswordChar = false;
            this.rjTextBox1.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.rjTextBox1.PlaceholderText = "Buscar Jugador";
            this.rjTextBox1.Size = new System.Drawing.Size(313, 36);
            this.rjTextBox1.TabIndex = 38;
            this.rjTextBox1.Texts = "";
            this.rjTextBox1.UnderlinedStyle = true;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(232)))), ((int)(((byte)(120)))));
            this.BtnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(28)))));
            this.BtnBuscar.Location = new System.Drawing.Point(570, 60);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(76, 36);
            this.BtnBuscar.TabIndex = 39;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = false;
            // 
            // BtnRegresar
            // 
            this.BtnRegresar.AutoSize = true;
            this.BtnRegresar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(232)))), ((int)(((byte)(120)))));
            this.BtnRegresar.Location = new System.Drawing.Point(777, 68);
            this.BtnRegresar.Name = "BtnRegresar";
            this.BtnRegresar.Size = new System.Drawing.Size(82, 21);
            this.BtnRegresar.TabIndex = 40;
            this.BtnRegresar.Text = "Regresar";
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
            // FrmTablaAgencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(888, 650);
            this.Controls.Add(this.BtnRegresar);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.rjTextBox1);
            this.Controls.Add(this.rjComboBox1);
            this.Controls.Add(this.DgvTabla);
            this.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmTablaAgencia";
            this.Text = "FtmJugadores";
            ((System.ComponentModel.ISupportInitialize)(this.DgvTabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.DataGridView DgvTabla;
        private RJCodeAdvance.RJControls.RJComboBox rjComboBox1;
        private RJCodeAdvance.RJControls.RJTextBox rjTextBox1;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Label BtnRegresar;
        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}