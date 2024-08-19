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
            this.BtnGuardar.Location = new System.Drawing.Point(120, 302);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(277, 49);
            this.BtnGuardar.TabIndex = 14;
            this.BtnGuardar.Text = "Gurdar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // dtNacimiento
            // 
            this.dtNacimiento.CustomFormat = "yyyy-MM-dd";
            this.dtNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNacimiento.Location = new System.Drawing.Point(120, 269);
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
            // FrmPrueba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}