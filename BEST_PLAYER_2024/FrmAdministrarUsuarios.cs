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
    public partial class FrmAdministrarUsuarios : Form
    {
        //Metodos Llenar CMB
        void LlenarNiveles()
        {
            // Limpia cualquier ítem previo
            CmbNiveles.Items.Clear();

            // Añade el ítem "Escoja una opción" como primer ítem
            CmbNiveles.Items.Add("Escoja una opción");

            // Añade los ítems de niveles
            CmbNiveles.Items.Add("Administrador");
            CmbNiveles.Items.Add("Comentarista");

            // Establece "Escoja una opción" como el ítem seleccionado por defecto
            CmbNiveles.SelectedIndex = 0;
        }
      
        void LlenarAgencia()
        {
            try
            {
                //antes 
                /*CmbAgencias.DataSource = ServUsuario.CargarAgencias();
                CmbAgencias.DisplayMember = "NombreAgencia";
                CmbAgencias.ValueMember = "IdAgencia";*/
                // Obtén las agencias desde el servicio
                DataTable agencias = ServUsuario.CargarAgencias();

                // Crea una nueva fila para "Escoja una opción"
                DataRow newRow = agencias.NewRow();
                newRow["IdAgencia"] = DBNull.Value; // Valor nulo para el IdAgencia
                newRow["NombreAgencia"] = "Escoja una opción";
                agencias.Rows.InsertAt(newRow, 0); // Inserta al inicio del DataTable

                // Asigna el DataTable al ComboBox
                CmbAgencias.DataSource = agencias;
                CmbAgencias.DisplayMember = "NombreAgencia";
                CmbAgencias.ValueMember = "IdAgencia";

                // Establece "Escoja una opción" como el ítem seleccionado por defecto
                CmbAgencias.SelectedIndex = 0;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar las agencias, verifique su conexión a internet o que el cable de red está conectado.", "Error de carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Guardar Datos
        private void guardarDatos()
        {
            try
            {
                // Crear una instancia usando el constructor vacío
                CtrUsuario ctrUsuario = new CtrUsuario();
                // Asignar propiedades una por una
                ctrUsuario.NombreUsuario = TxtNombreUsuario.Text;
                ctrUsuario.Correo = TxtNombreUsuario.Text;
                ctrUsuario.Clave = TxtClave.Text;
                ctrUsuario.FechaNacimiento = dtNacimiento.Value.ToString("yyyy-MM-dd"); // Asegúrate de que el formato sea correcto
                ctrUsuario.Pasaporte = TxtPasaporte.Text;
                //ctrUsuario.IdAgencia = Convert.ToInt32(CmbAgencias.SelectedValue);
                ctrUsuario.IdAgencia = Convert.ToInt32(CmbAgencias.SelectedItem);
                ctrUsuario.NivelUsuario = CmbNiveles.SelectedItem.ToString();
                string message;
                bool isSuccess = ServUsuario.RegistrarUsuario(ctrUsuario, out message);

                if (isSuccess)
                {
                    MessageBox.Show("Usuario registrado exitosamente.");
                }
                else
                {
                    MessageBox.Show(message, " Error al registrar", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception ex)
            {
                // Manejo de excepciones general
                MessageBox.Show($"Se produjo un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        //Cargar Datos
        void CargarGridDatos()
        {
            try
            {
                DataTable datos = ServUsuario.CargarUsuarios();
                DgvUsuarios.DataSource = datos;

                // Renombrar las columnas en el DataGridView
                DgvUsuarios.Columns["IdUsuario"].HeaderText = "ID";
                DgvUsuarios.Columns["NombreUsuario"].HeaderText = "Nombre de Usuario";
                DgvUsuarios.Columns["Correo"].HeaderText = "Correo Electrónico";
                DgvUsuarios.Columns["FechaNacimiento"].HeaderText = "Fecha de Nacimiento";
                DgvUsuarios.Columns["Foto"].HeaderText = "Foto";
                DgvUsuarios.Columns["Pasaporte"].HeaderText = "Número de Pasaporte";
                DgvUsuarios.Columns["Nivel_Usuario"].HeaderText = "Nivel de Usuario";
                DgvUsuarios.Columns["NombreAgencia"].HeaderText = "Agencia";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmPrueba_Load(object sender, EventArgs e)
        {
            //Llenar Combobox 
            LlenarNiveles();
            LlenarAgencia();
            CargarGridDatos();
        }
        public FrmAdministrarUsuarios()
        {
            InitializeComponent();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            guardarDatos();
        }

       

        private void CmbNivel_Click(object sender, EventArgs e)
        {
            LlenarAgencia();
        }
        
        private void CmbAgencias_DropDown(object sender, EventArgs e)
        {
            LlenarAgencia();
        }

        private void TxtNombreUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnGuardar_Click_1(object sender, EventArgs e)
        {
            guardarDatos();
        }
    }
}
