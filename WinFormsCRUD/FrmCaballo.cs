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
        EVelocidad velocidad;
        ECarga carga;
        EColor color;

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
            this.cmBoxVelocidad.Text = caballo.VelocidadMaxima.ToString();
            this.cmBoxCarga.Text = caballo.Carga.ToString();
            if (caballo is Caballo caballoEspecifico)
            {
                this.txtNombre.Text = caballoEspecifico.Nombre.ToString();
                this.cmBoxColor.Text = caballoEspecifico.Color.ToString();
                this.txtNombre.Enabled = false;
            }
        }

        /// <summary>
        /// Evento que se ejecuta al hacer clic en el botón "Aceptar".
        /// Valida la entrada de datos y crea un nuevo objeto de tipo Caballo.
        /// </summary>
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(this.txtCantPasajeros.Text, out int cantidadPasajeros) || cantidadPasajeros < 1 || cantidadPasajeros > 3)
            {
                MessageBox.Show("La cantidad de pasajeros debe ser un número entero válido entre 1 y 3.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string nombre = this.txtNombre.Text;

            if (!((IValidadora)this).ValidarTexto(nombre))
            {
                MessageBox.Show("El nombre solo puede contener letras.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            nombre = Capitalize(nombre);

            if (cmBoxVelocidad.Text != string.Empty)
            {
                switch (cmBoxVelocidad.Text)
                {
                    case "BAJA":
                        velocidad = EVelocidad.Baja;
                        break;
                    case "MINIMA":
                        velocidad = EVelocidad.Minima;
                        break;
                    case "MEDIA":
                        velocidad = EVelocidad.Media;
                        break;
                    case "ALTA":
                        velocidad = EVelocidad.Alta;
                        break;
                    case "HIPER":
                        velocidad = EVelocidad.Hiper;
                        break;
                }
            }
            else
            {
                MessageBox.Show("Elija una velocidad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cmBoxCarga.Text != string.Empty)
            {
                switch (cmBoxCarga.Text)
                {
                    case "LIVIANA":
                        carga = ECarga.Liviana;
                        break;
                    case "PESADA":
                        carga = ECarga.Pesada;
                        break;
                    case "MEDIA":
                        carga = ECarga.Media;
                        break;
                    case "MUYPESADA":
                        carga = ECarga.MuyPesada;
                        break;
                }
            }
            else
            {
                MessageBox.Show("Elija una carga.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cmBoxColor.Text != string.Empty)
            {
                switch (cmBoxColor.Text)
                {
                    case "BLANCO":
                        color = EColor.Blanco;
                        break;
                    case "GRIS":
                        color = EColor.Gris;
                        break;
                    case "MARRON":
                        color = EColor.Marron;
                        break;
                    case "NEGRO":
                        color = EColor.Negro;
                        break;
                    case "PINTO":
                        color = EColor.Pinto;
                        break;
                }
            }
            else
            {
                MessageBox.Show("Elija un color.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.caballo = new Caballo(nombre, cantidadPasajeros, velocidad, color, carga);
            this.DialogResult = DialogResult.OK;
            this.Close();

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
