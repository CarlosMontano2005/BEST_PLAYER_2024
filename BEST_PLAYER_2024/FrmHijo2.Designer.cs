namespace BEST_PLAYER_2024
{
    partial class FrmHijo2
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRegrasarAlFrmHijo1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(151, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(525, 73);
            this.label1.TabIndex = 0;
            this.label1.Text = "Formulario hijo 2";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnRegrasarAlFrmHijo1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 1;
            // 
            // btnRegrasarAlFrmHijo1
            // 
            this.btnRegrasarAlFrmHijo1.Location = new System.Drawing.Point(316, 299);
            this.btnRegrasarAlFrmHijo1.Name = "btnRegrasarAlFrmHijo1";
            this.btnRegrasarAlFrmHijo1.Size = new System.Drawing.Size(75, 23);
            this.btnRegrasarAlFrmHijo1.TabIndex = 1;
            this.btnRegrasarAlFrmHijo1.Text = "button1";
            this.btnRegrasarAlFrmHijo1.UseVisualStyleBackColor = true;
            this.btnRegrasarAlFrmHijo1.Click += new System.EventHandler(this.btnRegrasarAlFrmHijo1_Click);
            // 
            // FrmHijo2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmHijo2";
            this.Text = "FrmHijo2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRegrasarAlFrmHijo1;
    }
}