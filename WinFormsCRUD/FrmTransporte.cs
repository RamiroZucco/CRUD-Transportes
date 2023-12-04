using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsCRUD
{
    /// <summary>
    /// Clase que representa el formulario para elegir el tipo de transporte que quiero agregar.
    /// </summary>
    public partial class FrmTransporte : Form
    {
        public Caballo nuevoCaballo;
        public Auto nuevoAuto;
        public Avion nuevoAvion;
        public bool esCaballo;
        public bool esAuto;
        public bool esAvion;

        public FrmTransporte()
        {
            this.esAuto = false;
            this.esCaballo = false;
            this.esAvion = false;
            InitializeComponent();
        }

        private void btnAgregarCaballo_Click(object sender, EventArgs e)
        {
            FrmCaballo frmCaballo = new FrmCaballo();
            frmCaballo.StartPosition = FormStartPosition.CenterScreen;
            frmCaballo.ShowDialog();

            this.esCaballo = true;
            if (frmCaballo.DialogResult == DialogResult.OK)
            {
                nuevoCaballo = frmCaballo.caballo;
                this.DialogResult = DialogResult.OK;
            }
            
            
        }

        private void btnAgregarAuto_Click(object sender, EventArgs e)
        {
            FrmAuto frmAuto = new FrmAuto();
            frmAuto.StartPosition = FormStartPosition.CenterScreen;
            frmAuto.ShowDialog();

            this.esAuto = true;
            if (frmAuto.DialogResult == DialogResult.OK)
            {
                nuevoAuto = frmAuto.auto;
                this.DialogResult = DialogResult.OK;
            }

        }

        private void btnAgregarAvion_Click(object sender, EventArgs e)
        {
            FrmAvion frmAvion = new FrmAvion();
            frmAvion.StartPosition = FormStartPosition.CenterScreen;
            frmAvion.ShowDialog();

            this.esAvion = true;
            if (frmAvion.DialogResult == DialogResult.OK)
            {
                nuevoAvion = frmAvion.avion;
                this.DialogResult = DialogResult.OK;
            }

        }
    }
}
