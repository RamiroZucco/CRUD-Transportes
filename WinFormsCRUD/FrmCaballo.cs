using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsCRUD
{
    /// <summary>
    /// Formulario para la creación o modificación de objetos de tipo Caballo.
    /// Implementa las interfaces IValidadora e IModificadoraDeTexto para validar la entrada de datos y modificar texto, respectivamente.
    /// </summary>
    public partial class FrmCaballo : Form, IValidadora, IModificadoraDeTexto
    {
        public Caballo caballo;

        public FrmCaballo()
        {
            InitializeComponent();

        }

        /// <summary>
        /// Inicializa una nueva instancia de la clase FrmCaballo para la modificación de un objeto existente.
        /// </summary>
        /// <param name="caballo">Objeto de tipo Transporte que se utilizará para prellenar los campos del formulario.</param>
        public FrmCaballo(Transporte caballo) : this()
        {
            this.txtCantPasajeros.Text = caballo.CantidadPasajeros.ToString();
            this.txtVelocidad.Text = caballo.VelocidadMaxima.ToString();
            this.txtCarga.Text = caballo.Carga.ToString();
            if (caballo is Caballo caballoEspecifico)
            {
                this.txtNombre.Text = caballoEspecifico.Nombre.ToString();
                this.txtColor.Text = caballoEspecifico.Color.ToString();
                this.txtNombre.Enabled = false;
            }
        }

        /// <summary>
        /// Evento que se ejecuta al hacer clic en el botón "Aceptar".
        /// Valida la entrada de datos y crea un nuevo objeto de tipo Caballo.
        /// </summary>
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(this.txtCantPasajeros.Text, out int cantidadPasajeros))
            {
                MessageBox.Show("La cantidad de pasajeros debe ser un número entero válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cantidadPasajeros < 1 || cantidadPasajeros > 3)
            {
                MessageBox.Show("La cantidad de pasajeros debe estar entre 1 y 3 en caballos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string nombre = this.txtNombre.Text;

            if (!((IValidadora)this).ValidarTexto(nombre))
            {
                MessageBox.Show("El nombre solo puede contener letras.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            nombre = Capitalize(nombre);


            if (Enum.TryParse(this.txtVelocidad.Text, out EVelocidad velocidad) &&
                Enum.TryParse(this.txtCarga.Text, out ECarga carga) &&
                Enum.TryParse(this.txtColor.Text, out EColor color))
            {
                this.caballo = new Caballo(nombre, cantidadPasajeros, velocidad, color, carga);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Carga, velocidad o color incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /// <summary>
        /// Evento que se ejecuta al hacer clic en el botón "Cancelar".
        /// Cierra el formulario sin realizar ninguna acción.
        /// </summary>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        /// <summary>
        /// Implementación de la interfaz IValidadora para validar texto.
        /// Verifica que el texto tenga el formato esperado para un nombre (solo letras).
        /// </summary>
        /// <param name="texto">Texto a validar.</param>
        /// <returns>True si el texto es válido; de lo contrario, false.</returns>
        bool IValidadora.ValidarTexto(string texto)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(texto, @"^[a-zA-Z]+$");
        }

        /// <summary>
        /// Implementación de la interfaz IModificadoraDeTexto para capitalizar la primera letra de un texto.
        /// </summary>
        /// <param name="input">Texto a modificar.</param>
        /// <returns>Texto con la primera letra en mayúscula y las demás en minúscula.</returns>
        public string Capitalize(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }
            return char.ToUpper(input[0]) + input.Substring(1).ToLower();
        }
    }
}
