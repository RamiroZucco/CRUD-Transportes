using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsCRUD
{
    /// <summary>
    /// Formulario de inicio de sesión que permite a los usuarios ingresar al sistema.
    /// </summary>
    public partial class FrmLogin : Form
    {
        private Usuario usuario;

        public Usuario UsuarioDelForm
        {
            get { return this.usuario; }
        }
        public FrmLogin()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Inicializa una nueva instancia de la clase FrmLogin con un usuario predefinido.
        /// </summary>
        /// <param name="usuario">Usuario predefinido para el formulario.</param>
        public FrmLogin(Usuario usuario) : this()
        {
            this.usuario = usuario;
            this.txtCorreo.Focus();

        }

        /// <summary>
        /// Evento que se ejecuta al hacer clic en el botón "Ingresar".
        /// Realiza la verificación de las credenciales ingresadas y asigna el usuario correspondiente.
        /// </summary>
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            this.usuario = this.Verificar();
            this.DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// Verifica las credenciales ingresadas comparándolas con los usuarios almacenados en un archivo JSON.
        /// </summary>
        /// <returns>Objeto de tipo Usuario si las credenciales son válidas; de lo contrario, null.</returns>
        private Usuario Verificar()
        {
            Usuario? rta = null;

            using (System.IO.StreamReader sr = new System.IO.StreamReader(@"..//..//..//MOCK_DATA.json"))
            {
                System.Text.Json.JsonSerializerOptions opciones = new System.Text.Json.JsonSerializerOptions();
                opciones.WriteIndented = true;

                string json_str = sr.ReadToEnd();

                List<Usuario> users = JsonSerializer.Deserialize<List<Usuario>>(json_str, opciones);

                foreach (Usuario item in users)
                {
                    if (item.correo == this.txtCorreo.Text && item.clave == this.txtContraseña.Text)
                    {
                        rta = item;
                        break;
                    }
                }
            }

            return rta;
        }

        /// <summary>
        /// Evento que se ejecuta al intentar cerrar el formulario.
        /// Pregunta al usuario si realmente desea cerrar la ventana.
        /// </summary>
        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult dg = MessageBox.Show("¿Desea cerrar la ventana?", "Cerrando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dg == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
