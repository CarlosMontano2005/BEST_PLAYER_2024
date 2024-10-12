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
    public partial class FrmFormularioJugadores : Form
    {
        public FrmFormularioJugadores()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
