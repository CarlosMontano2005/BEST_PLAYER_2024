namespace BEST_PLAYER_2024
{
    partial class FrmPrueba
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
            this.TxtNombreUsuario = new System.Windows.Forms.TextBox();
            this.TxtCorreo = new System.Windows.Forms.TextBox();
            this.TxtClave = new System.Windows.Forms.TextBox();
            this.TxtPasaporte = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.dtNacimiento = new System.Windows.Forms.DateTimePicker();
            this.CmbNiveles = new System.Windows.Forms.ComboBox();
            this.CmbAgencias = new System.Windows.Forms.ComboBox();
            this.DgvUsuarios = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtNombreUsuario
            // 
            this.TxtNombreUsuario.Location = new System.Drawing.Point(117, 96);
            this.TxtNombreUsuario.Name = "TxtNombreUsuario";
            this.TxtNombreUsuario.Size = new System.Drawing.Size(100, 20);
            this.TxtNombreUsuario.TabIndex = 0;
            this.TxtNombreUsuario.Text = "Prueba Usuario";
            // 
            // TxtCorreo
            // 
            this.TxtCorreo.Location = new System.Drawing.Point(281, 95);
            this.TxtCorreo.Name = "TxtCorreo";
            this.TxtCorreo.Size = new System.Drawing.Size(100, 20);
            this.TxtCorreo.TabIndex = 1;
            this.TxtCorreo.Text = "correo@prueba.com";
            // 
            // TxtClave
            // 
            this.TxtClave.Location = new System.Drawing.Point(465, 95);
            this.TxtClave.Name = "TxtClave";
            this.TxtClave.Size = new System.Drawing.Size(100, 20);
            this.TxtClave.TabIndex = 2;
            this.TxtClave.Text = "Clave1234";
            // 
            // TxtPasaporte
            // 
            this.TxtPasaporte.Location = new System.Drawing.Point(117, 170);
            this.TxtPasaporte.Name = "TxtPasaporte";
            this.TxtPasaporte.Size = new System.Drawing.Size(100, 20);
            this.TxtPasaporte.TabIndex = 3;
            this.TxtPasaporte.Text = "A1B2C3D4E";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(282, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Correo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(462, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Clave";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(114, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Pasaporte";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(282, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Nivel Usuario";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(462, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Agencia";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(117, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Fecha Nacimiento";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(621, 136);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(127, 49);
            this.BtnGuardar.TabIndex = 14;
            this.BtnGuardar.Text = "Gurdar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // dtNacimiento
            // 
            this.dtNacimiento.CustomFormat = "yyyy-MM-dd";
            this.dtNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNacimiento.Location = new System.Drawing.Point(219, 223);
            this.dtNacimiento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtNacimiento.Name = "dtNacimiento";
            this.dtNacimiento.Size = new System.Drawing.Size(260, 20);
            this.dtNacimiento.TabIndex = 15;
            this.dtNacimiento.Value = new System.DateTime(2005, 2, 22, 0, 0, 0, 0);
            // 
            // CmbNiveles
            // 
            this.CmbNiveles.FormattingEnabled = true;
            this.CmbNiveles.Location = new System.Drawing.Point(285, 168);
            this.CmbNiveles.Name = "CmbNiveles";
            this.CmbNiveles.Size = new System.Drawing.Size(121, 21);
            this.CmbNiveles.TabIndex = 16;
            // 
            // CmbAgencias
            // 
            this.CmbAgencias.FormattingEnabled = true;
            this.CmbAgencias.Location = new System.Drawing.Point(465, 168);
            this.CmbAgencias.Name = "CmbAgencias";
            this.CmbAgencias.Size = new System.Drawing.Size(121, 21);
            this.CmbAgencias.TabIndex = 17;
            this.CmbAgencias.DropDown += new System.EventHandler(this.CmbAgencias_DropDown);
            // 
            // DgvUsuarios
            // 
            this.DgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DgvUsuarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvUsuarios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.DgvUsuarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DgvUsuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(113)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(232)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvUsuarios.EnableHeadersVisualStyles = false;
            this.DgvUsuarios.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(113)))), ((int)(((byte)(62)))));
            this.DgvUsuarios.Location = new System.Drawing.Point(12, 288);
            this.DgvUsuarios.Name = "DgvUsuarios";
            this.DgvUsuarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(232)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvUsuarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(232)))), ((int)(((byte)(120)))));
            this.DgvUsuarios.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvUsuarios.Size = new System.Drawing.Size(997, 270);
            this.DgvUsuarios.TabIndex = 18;
            // 
            // FrmPrueba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 570);
            this.Controls.Add(this.DgvUsuarios);
            this.Controls.Add(this.CmbAgencias);
            this.Controls.Add(this.CmbNiveles);
            this.Controls.Add(this.dtNacimiento);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtPasaporte);
            this.Controls.Add(this.TxtClave);
            this.Controls.Add(this.TxtCorreo);
            this.Controls.Add(this.TxtNombreUsuario);
            this.Name = "FrmPrueba";
            this.Text = "FrmPrueba";
            this.Load += new System.EventHandler(this.FrmPrueba_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtNombreUsuario;
        private System.Windows.Forms.TextBox TxtCorreo;
        private System.Windows.Forms.TextBox TxtClave;
        private System.Windows.Forms.TextBox TxtPasaporte;
        private System.Windows.Forms.ComboBox CmbAgencia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.DateTimePicker dtNacimiento;
        private System.Windows.Forms.ComboBox CmbNiveles;
        private System.Windows.Forms.ComboBox CmbAgencias;
        private System.Windows.Forms.DataGridView DgvUsuarios;
    }
}