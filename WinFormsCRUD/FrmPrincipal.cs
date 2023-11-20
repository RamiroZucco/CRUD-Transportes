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
using System.Xml.Serialization;
using System.Xml;
using System.Text.Json;
using Newtonsoft.Json;
using System.IO;
using System.Runtime.CompilerServices;
using System.Linq.Expressions;

namespace WinFormsCRUD
{
    public partial class FrmPrincipal : Form
    {
        private ColeccionTransportes caballos;
        private ColeccionTransportes autos;
        private ColeccionTransportes aviones;
        private ToolStripStatusLabel toolStripStatusLabelNombreOperador;
        private StatusStrip statusStrip;


        public FrmPrincipal(Usuario usuario)
        {
            InitializeComponent();

            this.caballos = new ColeccionTransportes();
            this.autos = new ColeccionTransportes();
            this.aviones = new ColeccionTransportes();
            statusStrip = new StatusStrip();
            statusStrip.Dock = DockStyle.Top;
            toolStripStatusLabelNombreOperador = new ToolStripStatusLabel();
            toolStripStatusLabelNombreOperador.Text = "Usuario: " + usuario.nombre + " Fecha: " + DateTime.Now.ToString("dd/MM/yyyy");
            statusStrip.Items.Add(toolStripStatusLabelNombreOperador);
            Controls.Add(statusStrip);

            string rutaArchivoLog = "usuarios.log";
            try
            {
                using (StreamWriter sw = File.AppendText(rutaArchivoLog))
                {
                    sw.WriteLine($"Nombre: {usuario.nombre} - Apellido: {usuario.apellido} - Horario de entrada: {DateTime.Now}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("No se pudo crear el archivo .log" + ex.Message);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmTransporte frmTpt = new FrmTransporte();
            frmTpt.StartPosition = FormStartPosition.CenterScreen;
            frmTpt.ShowDialog();
            if (frmTpt.esAuto)
            {
                if (frmTpt.DialogResult == DialogResult.OK)
                {
                    if (this.autos + frmTpt.nuevoAuto)
                    {
                        this.ActualizarVisorAutos();
                    }
                    else
                    {
                        MessageBox.Show("El auto ya está disponible", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }


                }
            }
            else if (frmTpt.esCaballo)
            {
                if (frmTpt.DialogResult == DialogResult.OK)
                {
                    if (this.caballos + frmTpt.nuevoCaballo)
                    {
                        this.ActualizarVisorCaballos();
                    }
                    else
                    {
                        MessageBox.Show("El caballo ya está disponible", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }


                }
            }
            else if (frmTpt.esAvion)
            {
                if (frmTpt.DialogResult == DialogResult.OK)
                {
                    if (this.aviones + frmTpt.nuevoAvion)
                    {
                        this.ActualizarVisorAviones();
                    }
                    else
                    {
                        MessageBox.Show("El avión ya está disponible", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }


                }
            }
        }



        public void ActualizarVisorCaballos()
        {
            this.lstVisorCaballos.Items.Clear();
            foreach (Transporte caballo in this.caballos.ListaTransportes)
            {
                lstVisorCaballos.Items.Add(caballo.ToString());
            }

        }

        public void ActualizarVisorAutos()
        {
            this.lstVisorAutos.Items.Clear();
            foreach (Transporte auto in this.autos.ListaTransportes)
            {
                lstVisorAutos.Items.Add(auto.ToString());
            }

        }

        public void ActualizarVisorAviones()
        {
            this.lstVisorAviones.Items.Clear();
            foreach (Transporte avion in this.aviones.ListaTransportes)
            {
                lstVisorAviones.Items.Add(avion.ToString());
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int indiceCaballos = this.lstVisorCaballos.SelectedIndex;
            int indiceAutos = this.lstVisorAutos.SelectedIndex;
            int indiceAviones = this.lstVisorAviones.SelectedIndex;

            if (indiceCaballos >= 0)
            {
                Transporte transporte = this.caballos.ListaTransportes[indiceCaballos];
                if (transporte is Caballo c)
                {
                    FrmCaballo frm1 = new FrmCaballo(c);
                    frm1.ShowDialog();
                    if (frm1.DialogResult == DialogResult.OK)
                    {
                        this.caballos.ListaTransportes[indiceCaballos] = frm1.caballo;
                        this.ActualizarVisorCaballos();
                    }
                }
            }
            else if (indiceAutos >= 0)
            {
                Transporte transporte = this.autos.ListaTransportes[indiceAutos];
                if (transporte is Auto a)
                {
                    FrmAuto frm2 = new FrmAuto(a);
                    frm2.ShowDialog();
                    if (frm2.DialogResult == DialogResult.OK)
                    {
                        this.autos.ListaTransportes[indiceAutos] = frm2.auto;
                        this.ActualizarVisorAutos();
                    }
                }
            }
            else if (indiceAviones >= 0)
            {
                Transporte transporte = this.aviones.ListaTransportes[indiceAviones];
                if (transporte is Avion a)
                {
                    FrmAvion frm3 = new FrmAvion(a);
                    frm3.ShowDialog();
                    if (frm3.DialogResult == DialogResult.OK)
                    {
                        this.aviones.ListaTransportes[indiceAviones] = frm3.avion;
                        this.ActualizarVisorAviones();
                    }
                }
            }
            else
            {
                return;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int indiceCaballos = this.lstVisorCaballos.SelectedIndex;
            int indiceAutos = this.lstVisorAutos.SelectedIndex;
            int indiceAviones = this.lstVisorAviones.SelectedIndex;


            if (indiceAutos >= 0)
            {
                Transporte auto = this.autos.ListaTransportes[indiceAutos];
                DialogResult result = MessageBox.Show("¿Deseas eliminar este transporte?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes && this.autos - auto)
                {
                    this.ActualizarVisorAutos();
                }
            }
            else if (indiceAviones >= 0)
            {
                Transporte avion = this.aviones.ListaTransportes[indiceAviones];
                DialogResult result = MessageBox.Show("¿Deseas eliminar este transporte?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes && this.aviones - avion)
                {
                    this.ActualizarVisorAviones();
                }
            }
            else if (indiceCaballos >= 0)
            {
                Transporte caballo = this.caballos.ListaTransportes[indiceCaballos];
                DialogResult result = MessageBox.Show("¿Deseas eliminar este transporte?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes && this.caballos - caballo)
                {
                    this.ActualizarVisorCaballos();
                }
            }
            else
            {
                MessageBox.Show("No se pudo eliminar el transporte", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMasPasajeros_Click(object sender, EventArgs e)
        {
            this.aviones.OrdenarPorCantidadPasajerosDescendente();
            this.autos.OrdenarPorCantidadPasajerosDescendente();
            this.caballos.OrdenarPorCantidadPasajerosDescendente();
            this.ActualizarVisorAviones();
            this.ActualizarVisorAutos();
            this.ActualizarVisorCaballos();
        }

        private void btnMenosPasajeros_Click(object sender, EventArgs e)
        {
            this.aviones.OrdenarPorCantidadPasajerosAscendente();
            this.autos.OrdenarPorCantidadPasajerosAscendente();
            this.caballos.OrdenarPorCantidadPasajerosAscendente();
            this.ActualizarVisorAviones();
            this.ActualizarVisorAutos();
            this.ActualizarVisorCaballos();

        }

        private void btnMasVeloz_Click(object sender, EventArgs e)
        {
            this.aviones.OrdenarPorVelocidadMaximaDescendente();
            this.autos.OrdenarPorVelocidadMaximaDescendente();
            this.caballos.OrdenarPorVelocidadMaximaDescendente();
            this.ActualizarVisorAviones();
            this.ActualizarVisorAutos();
            this.ActualizarVisorCaballos();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.aviones.OrdenarPorVelocidadMaximaAscendente();
            this.autos.OrdenarPorVelocidadMaximaAscendente();
            this.caballos.OrdenarPorVelocidadMaximaAscendente();
            this.ActualizarVisorAviones();
            this.ActualizarVisorAutos();
            this.ActualizarVisorCaballos();

        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }
        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
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

        private void SerializarAutos()
        {
            try
            {
                SaveFileDialog guardarDatos = new SaveFileDialog();
                if (guardarDatos.ShowDialog() == DialogResult.OK)
                {
                    string filePath = guardarDatos.FileName;
                    using (XmlTextWriter writer = new XmlTextWriter(filePath, Encoding.UTF8))
                    {
                        XmlSerializer ser = new XmlSerializer(typeof(List<Transporte>));
                        ser.Serialize(writer, this.autos.ListaTransportes);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al deserializar el archivo XML: " + ex.Message);
            }
        }
        private void DeserializarAutos()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                try
                {
                    using (XmlTextReader reader = new XmlTextReader(filePath))
                    {
                        XmlSerializer ser = new XmlSerializer(typeof(List<Transporte>));
                        this.autos.ListaTransportes = (List<Transporte>)ser.Deserialize(reader);
                    }
                    ActualizarVisorAutos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al serializar el archivo XML: " + ex.Message);
                }
            }
        }
        private void SerializarCaballos()
        {
            try
            {
                SaveFileDialog guardarDatos = new SaveFileDialog();
                if (guardarDatos.ShowDialog() == DialogResult.OK)
                {
                    string filePath = guardarDatos.FileName;
                    using (XmlTextWriter writer = new XmlTextWriter(filePath, Encoding.UTF8))
                    {
                        XmlSerializer ser = new XmlSerializer(typeof(List<Transporte>));
                        ser.Serialize(writer, this.caballos.ListaTransportes);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al deserializar el archivo XML: " + ex.Message);
            }
        }
        private void DeserializarCaballos()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                try
                {
                    using (XmlTextReader reader = new XmlTextReader(filePath))
                    {
                        XmlSerializer ser = new XmlSerializer(typeof(List<Transporte>));
                        this.caballos.ListaTransportes = (List<Transporte>)ser.Deserialize(reader);
                    }
                    ActualizarVisorCaballos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al serializar el archivo XML: " + ex.Message);
                }
            }
        }

        private void SerializarAviones()
        {
            try
            {
                SaveFileDialog guardarDatos = new SaveFileDialog();
                if (guardarDatos.ShowDialog() == DialogResult.OK)
                {
                    string filePath = guardarDatos.FileName;
                    using (XmlTextWriter writer = new XmlTextWriter(filePath, Encoding.UTF8))
                    {
                        XmlSerializer ser = new XmlSerializer(typeof(List<Transporte>));
                        ser.Serialize(writer, this.aviones.ListaTransportes);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al deserializar el archivo XML: " + ex.Message);
            }
        }
        private void DeserializarAviones()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                try
                {
                    using (XmlTextReader reader = new XmlTextReader(filePath))
                    {
                        XmlSerializer ser = new XmlSerializer(typeof(List<Transporte>));
                        this.aviones.ListaTransportes = (List<Transporte>)ser.Deserialize(reader);
                    }
                    ActualizarVisorAviones();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al serializar el archivo XML: " + ex.Message);
                }
            }
        }

        private void btnUsuariosRegistrados_Click(object sender, EventArgs e)
        {
            FrmUsuariosRegistrados frmUsuarios = new FrmUsuariosRegistrados();
            frmUsuarios.ShowDialog();
        }

        private void btnCargarCaballos_Click(object sender, EventArgs e)
        {
            DeserializarCaballos();
        }

        private void btnGuardarCaballos_Click(object sender, EventArgs e)
        {
            SerializarCaballos();
        }

        private void btnCargarAutos_Click(object sender, EventArgs e)
        {
            DeserializarAutos();
        }

        private void btnGuardarAutos_Click(object sender, EventArgs e)
        {
            SerializarAutos();
        }

        private void btnCargarAviones_Click(object sender, EventArgs e)
        {
            DeserializarAviones();
        }

        private void btnGuardarAviones_Click(object sender, EventArgs e)
        {
            SerializarAviones();
        }
    }
}

