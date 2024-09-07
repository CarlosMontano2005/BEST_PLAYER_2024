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
        //VARIABLES
        private String ID;
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
        void LlenarAgenciaCmbOriginal()
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
                cmbBoxOrigianl.DataSource = agencias;
                cmbBoxOrigianl.DisplayMember = "NombreAgencia";
                cmbBoxOrigianl.ValueMember = "IdAgencia";

                // Establece "Escoja una opción" como el ítem seleccionado por defecto
                cmbBoxOrigianl.SelectedIndex = 0;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar las agencias, verifique su conexión a internet o que el cable de red está conectado.", "Error de carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
        private void actualizarDatos()
        {
            try
            {
                // Crear una instancia usando el constructor vacío
                CtrUsuario ctrUsuario = new CtrUsuario();
                //Enviar el ID Del usuario a actualizar 
                ctrUsuario.IdUsuario = Convert.ToInt32(ID);
                // Asignar propiedades una por una
                Console.WriteLine(TxtNombreUsuario.Texts);
                ctrUsuario.NombreUsuario = TxtNombreUsuario.Texts;
                ctrUsuario.Correo = TxtCorreo.Texts;
                ctrUsuario.FechaNacimiento = dtNacimiento.Value.ToString("yyyy-MM-dd"); 
                ctrUsuario.Pasaporte = TxtPasaporte.Texts;
                //ctrUsuario.IdAgencia = Convert.ToInt32(CmbAgencias.SelectedValue);
                ctrUsuario.IdAgencia = Convert.ToInt32(cmbBoxOrigianl.SelectedValue);
                ctrUsuario.NivelUsuario = CmbNiveles.SelectedItem.ToString();
                Console.WriteLine(Convert.ToInt32(ID));
                string message;
                bool isSuccess = ServUsuario.ActualizarUsuario(ctrUsuario, out message);

                if (isSuccess)
                {
                    MessageBox.Show("Usuario actualizado exitosamente.");
                }
                else
                {
                    MessageBox.Show(message, " Error al actualizado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    CargarGridDatos();
                }
            }
            catch (Exception ex)
            {
                // Manejo de excepciones general
                MessageBox.Show($"Se produjo un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void guardarDatos()
        {
            try
            {
                // Crear una instancia usando el constructor vacío
                CtrUsuario ctrUsuario = new CtrUsuario();
                // Asignar propiedades una por una
                ctrUsuario.NombreUsuario = TxtNombreUsuario.Texts;
                ctrUsuario.Correo = TxtCorreo.Texts;
                ctrUsuario.Clave = TxtClave.Texts;
                ctrUsuario.FechaNacimiento = dtNacimiento.Value.ToString("yyyy-MM-dd"); // Asegúrate de que el formato sea correcto
                ctrUsuario.Pasaporte = TxtPasaporte.Texts;
               // ctrUsuario.IdAgencia = Convert.ToInt32(CmbAgencias.SelectedValue);
                ctrUsuario.IdAgencia = Convert.ToInt32(cmbBoxOrigianl.SelectedValue);
                //ctrUsuario.IdAgencia = Convert.ToInt32(CmbAgencias.SelectedItem);
                ctrUsuario.NivelUsuario = CmbNiveles.SelectedItem.ToString();
                string message;
                bool isSuccess = ServUsuario.RegistrarUsuario(ctrUsuario, out message);

                if (isSuccess)
                {
                    MessageBox.Show("Usuario registrado exitosamente.");
                    CargarGridDatos();
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
            LlenarAgenciaCmbOriginal();
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
        private void DgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
            try
            {
                //REINICIAR CONTROLES DE TEXTO
                TxtNombreUsuario.ResetText();
                TxtCorreo.ResetText();
                //CAPTURAR EL NUMERO DE LA FILA EN LA QUE SE HACE CLIC
                int posicion = DgvUsuarios.CurrentRow.Index;
                //ENVIAR DATOS A LOS CONTROLES RESPECTIVOS
                ID = DgvUsuarios[0, posicion].Value.ToString();
                TxtId.Texts = DgvUsuarios[0, posicion].Value.ToString();

                TxtNombreUsuario.Texts = DgvUsuarios[1, posicion].Value.ToString();
                TxtCorreo.Texts = DgvUsuarios[2, posicion].Value.ToString();
                dtNacimiento.Text = DgvUsuarios[3, posicion].Value.ToString();
                //La foto es la posicion 4 pero aun no se hace proceso
                TxtPasaporte.Texts = DgvUsuarios[5, posicion].Value.ToString();

                //INTERPRETAR LOS IDS DE LAS LLAVES FORÁNEAS foiewjfowefoiewn
                string Nivel_Usuario = DgvUsuarios[6, posicion].Value.ToString();
                string NombreAgencia = DgvUsuarios[7, posicion].Value.ToString();
                //COMBOBOX
                CmbNiveles.SelectedItem = Nivel_Usuario;
                //COMBOBOX ID Cargar el combobox con los datos 
                CmbAgencias.DataSource = ServUsuario.CargarAgencias();
                CmbAgencias.DisplayMember = "NombreAgencia";
                CmbAgencias.ValueMember = "IdAgencia";
                //COMBOBOX ID Cargar el combobox con los datos 
                cmbBoxOrigianl.DataSource = ServUsuario.CargarAgencias();
                cmbBoxOrigianl.DisplayMember = "NombreAgencia";
                cmbBoxOrigianl.ValueMember = "IdAgencia";                //Seleccionar el elemento seleccionado en el dgvUsuario de la tabla
                foreach (DataRowView item in CmbAgencias.Items)
                {
                    if (item["NombreAgencia"].ToString() == NombreAgencia)
                    {
                        CmbAgencias.SelectedItem = item;
                        break;
                    }
                }
                foreach (DataRowView item in cmbBoxOrigianl.Items)
                {
                    if (item["NombreAgencia"].ToString() == NombreAgencia)
                    {
                        cmbBoxOrigianl.SelectedItem = item;
                        break;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar los datos.", "Error de carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            actualizarDatos();
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
    }
}
