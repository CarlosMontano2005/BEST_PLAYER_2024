using Controlador;
using Servicios;
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
    public partial class FrmCambiarClave : Form
    {
        private int _id;
        public FrmCambiarClave(string id)
        {
           InitializeComponent();
            _id = Convert.ToInt32(id);
        }
        
        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChBxVerClave_CheckedChanged(object sender, EventArgs e)
        {
            if (ChBxVerClave.Checked)
            {
                TxtClave.PasswordChar = false; //ver contraseña
            }
            else
            {
                TxtClave.PasswordChar = true; //Ocultar contraseña

            }
        }

        private void ChBxVerClaveRepetir_CheckedChanged(object sender, EventArgs e)
        {
            if (ChBxVerClaveRepetir.Checked)
            {
                TxtRepetirClave.PasswordChar = false; //ver contraseña
            }
            else
            {
                TxtRepetirClave.PasswordChar = true; //Ocultar contraseña

            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                CtrUsuario ctrUsuario = new CtrUsuario();
                ctrUsuario.IdUsuario = _id;
                if (TxtClave.Texts == TxtRepetirClave.Texts)
                {
                    ctrUsuario.Clave = TxtClave.Texts; 
                    string message;
                    bool isSuccess = ServUsuario.ActualizarClave(ctrUsuario, out message); // Llama al servicio para actualizar la clave

                    if (isSuccess)
                    {
                        MessageBox.Show("Clave Modificada Correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(message, "Error al registrar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Las claves no coinciden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
