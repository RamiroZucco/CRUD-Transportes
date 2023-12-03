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
    public partial class FrmAuto : Form, IValidadora
    {
        public Auto auto;
        public FrmAuto()
        {
            InitializeComponent();
        }
        public FrmAuto(Transporte auto) : this()
        {
            this.txtCantPasajeros.Text = auto.CantidadPasajeros.ToString();
            this.txtVelocidad.Text = auto.VelocidadMaxima.ToString();
            this.txtCarga.Text = auto.Carga.ToString();
            if (auto is Auto autoEspecifico)
            {
                this.txtPatente.Text = autoEspecifico.NumerosPatente.ToString();
                this.txtPuertas.Text = autoEspecifico.CantidadDePuertas.ToString();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(this.txtCantPasajeros.Text, out int cantidadPasajeros))
            {
                MessageBox.Show("La cantidad de pasajeros debe ser un número entero válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cantidadPasajeros < 1 || cantidadPasajeros > 4)
            {
                MessageBox.Show("La cantidad de pasajeros debe estar entre 1 y 4 en autos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string patente = this.txtPatente.Text;

            if (!((IValidadora)this).ValidarTexto(patente))
            {
                MessageBox.Show("Deben ser unicamente los ultimos 3 numeros de la patente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (int.TryParse(this.txtPuertas.Text, out int cantidadDePuertas) && cantidadDePuertas >= 2 && cantidadDePuertas <= 5)
            {
                if (Enum.TryParse(this.txtVelocidad.Text, out EVelocidad velocidad) &&
                    Enum.TryParse(this.txtCarga.Text, out ECarga carga))
                {
                    this.auto = new Auto(cantidadPasajeros, velocidad, cantidadDePuertas, carga, patente);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Carga o velocidad incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("La cantidad de puertas debe estar entre 2 y 5.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        bool IValidadora.ValidarTexto(string texto)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(texto, @"^[0-9]{3}$");
        }
    }
}
