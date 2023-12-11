using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsCRUD
{
    /// <summary>
    /// Formulario para la creación o modificación de objetos de tipo Auto.
    /// Implementa la interfaz IValidadora para validar la entrada de datos.
    /// </summary>
    public partial class FrmAuto : Form, IValidadora
    {
        public Auto auto;
        EVelocidad velocidad;
        ECarga carga;
        public FrmAuto()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Inicializa una nueva instancia de la clase FrmAuto para la modificación de un objeto existente.
        /// </summary>
        /// <param name="auto">Objeto de tipo Transporte que se utilizará para prellenar los campos del formulario.</param>
        public FrmAuto(Transporte auto) : this()
        {
            this.txtCantPasajeros.Text = auto.CantidadPasajeros.ToString();
            this.cmBoxVelocidad.Text = auto.VelocidadMaxima.ToString();
            this.cmBoxCarga.Text = auto.Carga.ToString();
            if (auto is Auto autoEspecifico)
            {
                this.txtPatente.Text = autoEspecifico.NumerosPatente.ToString();
                this.txtPuertas.Text = autoEspecifico.CantidadDePuertas.ToString();
                this.txtPatente.Enabled = false;
            }
        }

        /// <summary>
        /// Evento que se ejecuta al hacer clic en el botón "Aceptar".
        /// Valida la entrada de datos y crea un nuevo objeto de tipo Auto.
        /// </summary>
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(this.txtCantPasajeros.Text, out int cantidadPasajeros) || cantidadPasajeros < 1 || cantidadPasajeros > 4)
            {
                MessageBox.Show("La cantidad de pasajeros debe ser un número entero válido entre 1 y 4.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string patente = this.txtPatente.Text;

            if (!((IValidadora)this).ValidarTexto(patente))
            {
                MessageBox.Show("Deben ser unicamente los ultimos 3 numeros de la patente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(this.txtPuertas.Text, out int cantidadDePuertas) || cantidadDePuertas < 2 || cantidadDePuertas > 5)
            {
                MessageBox.Show("La cantidad de puertas debe ser un número entero válido entre 2 y 5.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

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
            this.auto = new Auto(cantidadPasajeros, velocidad, cantidadDePuertas, carga, patente);
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
        /// Verifica que el texto tenga el formato esperado para una patente.
        /// </summary>
        /// <param name="texto">Texto a validar.</param>
        /// <returns>True si el texto es válido; de lo contrario, false.</returns>
        bool IValidadora.ValidarTexto(string texto)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(texto, @"^[0-9]{3}$");
        }
    }
}
