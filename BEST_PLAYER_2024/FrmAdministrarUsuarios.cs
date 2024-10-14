using Controlador;
using Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BEST_PLAYER_2024
{
    public partial class FrmAdministrarUsuarios : Form
    {
        private String ID;
        public FrmAdministrarUsuarios()
        {
            InitializeComponent();
            TxtId.Visible = false;
        }
        private void FrmPrueba_Load(object sender, EventArgs e)
        {
            //Llenar Combobox 
            LlenarNiveles();
            LlenarAgencia();
            LlenarAgenciaCmbOriginal();
            CargarGridDatos();
            validarMayorEdad();
        }
        //validar fecha
        void validarMayorEdad()
        {
            dtNacimiento.MaxDate = DateTime.Now.AddYears(-18);
            dtNacimiento.MinDate = new DateTime(1900, 1, 1);
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
                // Ajustar el ancho de la columna que contiene la foto
                DgvUsuarios.Columns["Foto"].Width = 100;
                DgvUsuarios.Columns["Foto"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                //
                DgvUsuarios.Columns["Pasaporte"].HeaderText = "Número de Pasaporte";
                DgvUsuarios.Columns["Nivel_Usuario"].HeaderText = "Nivel de Usuario";
                DgvUsuarios.Columns["NombreAgencia"].HeaderText = "Agencia";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
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
                if (imageBytes != null)
                {
                    ctrUsuario.Foto = imageBytes;
                }

                string message;
                bool isSuccess = ServUsuario.ActualizarUsuario(ctrUsuario, out message);
                if (isSuccess)
                {
                    MessageBox.Show("Usuario actualizado exitosamente.");
                    CargarGridDatos();
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
                ctrUsuario.Clave = TxtClave.Texts;
                ctrUsuario.NombreUsuario = TxtNombreUsuario.Texts;
                ctrUsuario.Correo = TxtCorreo.Texts;
                ctrUsuario.Clave = TxtClave.Texts;
                ctrUsuario.FechaNacimiento = dtNacimiento.Value.ToString("yyyy-MM-dd"); 
                ctrUsuario.Pasaporte = TxtPasaporte.Texts;
                //ctrUsuario.IdAgencia = Convert.ToInt32(CmbAgencias.SelectedValue);
                ctrUsuario.IdAgencia = Convert.ToInt32(cmbBoxOrigianl.SelectedValue);
                ctrUsuario.Pasaporte = TxtPasaporte.Texts;
                //ctrUsuario.IdAgencia = Convert.ToInt32(CmbAgencias.SelectedValue);
                //ctrUsuario.IdAgencia = Convert.ToInt32(CmbAgencias.SelectedItem);
                ctrUsuario.NivelUsuario = CmbNiveles.SelectedItem.ToString();
             
                if (imageBytes != null)
                {
                    ctrUsuario.Foto = imageBytes;
                }

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
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
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
                //Tratando de hacer la foto
                if (DgvUsuarios[4, posicion].Value != null && DgvUsuarios[4, posicion].Value is byte[])
                {
                    // Convertir el valor de la base de datos (byte[]) en una imagen
                    byte[] imageBytes = (byte[])DgvUsuarios[4, posicion].Value;
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        Bitmap bm = new Bitmap(ms);
                        pxbImg.Image = bm;
                    }
                }
                else
                {
                    // Si no hay imagen o no es válida, limpiar el PictureBox
                    pxbImg.Image = null;
                }
                //
                TxtPasaporte.Texts = DgvUsuarios[5, posicion].Value.ToString();

                //INTERPRETAR LOS IDS DE LAS LLAVES FORÁNEAS
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
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //verificar si existe un id seleccionado  para eliminar verificando si hay espacion en blanco o esta vacia
            if (string.IsNullOrWhiteSpace(TxtId.Texts))
            {
                MessageBox.Show("Seleccionar un usuario antes de eliminar","CAMPO VACIO",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (true)
                {

                }
                try
                {
                    DialogResult res = MessageBox.Show("¿Decea eliminar al usuario " + TxtNombreUsuario.Texts + "?", "¿Eliminar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (res == DialogResult.Yes)
                    {
                        CtrUsuario ctrUsuario = new CtrUsuario();
                        ctrUsuario.IdUsuario = Convert.ToInt32(TxtId.Texts);
                        string message;
                        //bool isSuccess = ServUsuario.RegistrarUsuario(ctrUsuario, out message);
                        bool isSuccess = ServUsuario.EliminarUsuario(ctrUsuario, out message);
                        if (isSuccess)
                        {
                            MessageBox.Show("Usuario eliminado exitosamente.");
                            CargarGridDatos();
                            
                        }
                        else
                        {
                            MessageBox.Show(message, " Error al eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    
                 
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error al eliminar: "+ex, "ERROR DE ELIMINACION", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
        }
        #region examinar imagen
        public byte[] imageBytes;
        private void btExaminarImg_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFolderSelec = new OpenFileDialog
                {
                    Filter = "Imagen|*.jpg;*.png",
                    InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures),
                    Title = "Seleccionar Imagen"
                };

                if (openFolderSelec.ShowDialog() == DialogResult.OK)
                {
                    using (var stream = new FileStream(openFolderSelec.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using (var img = Image.FromStream(stream))
                        {
                            if (img.Width > 250 || img.Height > 250)
                            {
                                MessageBox.Show("La imagen es demasiado grande. Las dimensiones máximas permitidas son 250x250 píxeles.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            pxbImg.Image = new Bitmap(img);
                            using (var memoryStream = new MemoryStream())
                            {
                                pxbImg.Image.Save(memoryStream, ImageFormat.Png);
                                imageBytes = memoryStream.ToArray();
                            }
                        }
                    }
                }
            }
            catch (FileNotFoundException fnfEx)
            {
                MessageBox.Show("No se pudo encontrar el archivo: " + fnfEx.Message, "Archivo no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (OutOfMemoryException oomEx)
            {
                MessageBox.Show("La imagen seleccionada no es válida o está corrupta: " + oomEx.Message, "Imagen no válida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ExternalException ex)
            {
                MessageBox.Show("Error de GDI+ al procesar la imagen: " + ex.Message, "Error de imagen", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex);
            }
        }
        #endregion
        private void btnEnviarDatosOtraTabla_Click(object sender, EventArgs e)
        {
            FrmTablaUsuariosDestino destino = new FrmTablaUsuariosDestino();
            DataTable datosExportados = (DataTable)DgvUsuarios.DataSource;
            destino.CargarDatos(datosExportados);
            destino.Show();
        }
    }
}
