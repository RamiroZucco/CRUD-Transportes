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
    /// Formulario para la creación o modificación de objetos de tipo Avión.
    /// </summary>
    public partial class FrmAvion : Form
    {
        public Avion avion;
        public FrmAvion()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Inicializa una nueva instancia de la clase FrmAvion para la modificación de un objeto existente.
        /// </summary>
        /// <param name="avion">Objeto de tipo Transporte que se utilizará para prellenar los campos del formulario.</param>
        public FrmAvion(Transporte avion) : this()
        {
            this.txtCantPasajeros.Text = avion.CantidadPasajeros.ToString();
            this.txtVelocidad.Text = avion.VelocidadMaxima.ToString();
            this.txtCarga.Text = avion.Carga.ToString();
            if (avion is Avion avionEspecifico)
            {
                this.txtModelo.Text = avionEspecifico.Modelo.ToString();
                this.txtCantVentanas.Text = avionEspecifico.CantidadDeVentanas.ToString();
                this.txtModelo.Enabled = false;
            }
        }

        /// <summary>
        /// Evento que se ejecuta al hacer clic en el botón "Aceptar".
        /// Valida la entrada de datos y crea un nuevo objeto de tipo Avion.
        /// </summary>
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(this.txtCantPasajeros.Text, out int cantidadPasajeros))
            {
                MessageBox.Show("La cantidad de pasajeros debe ser un número entero válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cantidadPasajeros < 1 || cantidadPasajeros > 850)
            {
                MessageBox.Show("La cantidad maxima de pasajeros es de 850 en aviones.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string modelo = this.txtModelo.Text;

            if (int.TryParse(this.txtCantVentanas.Text, out int cantidadDeVentanas) && cantidadDeVentanas >= 12 && cantidadDeVentanas <= 40)
            {
                if (Enum.TryParse(this.txtVelocidad.Text, out EVelocidad velocidad) &&
                    Enum.TryParse(this.txtCarga.Text, out ECarga carga))
                {
                    this.avion = new Avion(cantidadPasajeros, velocidad, modelo, cantidadDeVentanas, carga);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Carga o velocidad incorrectos. Presta atención a las mayúsculas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("La cantidad de ventanas debe estar entre 12 y 40.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
