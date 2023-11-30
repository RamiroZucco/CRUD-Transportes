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
    public partial class FrmCaballo : Form, IValidadora
    {
        public Caballo caballo;

        public FrmCaballo()
        {
            InitializeComponent();

        }
        public FrmCaballo(Transporte caballo) : this()
        {
            this.txtCantPasajeros.Text = caballo.CantidadPasajeros.ToString();
            this.txtVelocidad.Text = caballo.VelocidadMaxima.ToString();
            this.txtCarga.Text = caballo.Carga.ToString();
            if (caballo is Caballo caballoEspecifico)
            {
                this.txtNombre.Text = caballoEspecifico.Nombre.ToString();
                this.txtColor.Text = caballoEspecifico.Color.ToString();
            }
        }

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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        bool IValidadora.ValidarTexto(string texto)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(texto, @"^[a-zA-Z]+$");
        }
    }
}
