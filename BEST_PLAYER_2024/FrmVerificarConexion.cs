using Configuracion;
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
        //Gracias a https://youtu.be/DJicjGLR2pk?si=fMdmZMJG7E4iV7HM 
        //https://youtu.be/6yq4O1GisXI?si=OA4Sa4S4lkXd85EI
        // Y esta scrid :) https://youtu.be/ZqSCvl9G0kA?si=wV35LJetpmYm8kmh
        private void button1_Click(object sender, EventArgs e)
        {

            string serverName = TxtServer.Text.Trim();
            string database = TxtDb.Text.Trim();

            if (string.IsNullOrEmpty(serverName))
            {
                MessageBox.Show("Por favor, ingrese el nombre del servidor.");
                return;
            }
            if (string.IsNullOrEmpty(database))
            {
                MessageBox.Show("Por favor, ingrese el nombre de la base de datos.");
                return;
            }
            DatabaseConnection dbConnection = new DatabaseConnection(serverName, database);
            GetSetConexion result = dbConnection.TestConnection();
            bool isSuccess = result.IsSuccess;
            if (isSuccess)
            {
                MessageBox.Show(result.Message);
            }
            else
            {
                MessageBox.Show(result.Message);

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DatabaseConnection defaultDbConnection = new DatabaseConnection();
            // Llama al método TestConnection y recibe un ConnectionResult
            GetSetConexion result = defaultDbConnection.TestConnection();
            MessageBox.Show(result.Message);
            // Opcionalmente, puedes usar el valor booleano IsSuccess https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.identity.test.identityresultassert.issuccess?view=aspnetcore-2.2
            bool isSuccess = result.IsSuccess;
        }
    }
}
