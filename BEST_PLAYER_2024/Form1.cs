﻿using BEST_PLAYER_2024.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BEST_PLAYER_2024
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

           
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Crea una instancia de Form2
            FrmLogin frmlogin = new FrmLogin();

            // Muestra Form2
            frmlogin.ShowDialog();

            // Cierra el formulario actual (Form1)
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
