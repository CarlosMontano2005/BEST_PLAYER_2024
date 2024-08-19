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
    public partial class FrmVerificarConexion : Form
    {
        public FrmVerificarConexion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string serverName = TxtServer.Text;
            string database = TxtDb.Text;

            DatabaseConnection dbConnection = new DatabaseConnection(TxtServer.Text, TxtDb.Text);
            string result = dbConnection.TestConnection();
            MessageBox.Show(result);

        }

    }
}
