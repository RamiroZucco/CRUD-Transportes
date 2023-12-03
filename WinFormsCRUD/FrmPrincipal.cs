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
    public partial class FrmPrincipal : Form, IPrincipal<Transporte>
    {
        private ColeccionTransportes<Transporte> caballos;
        private ColeccionTransportes<Transporte> autos;
        private ColeccionTransportes<Transporte> aviones;
        private ToolStripStatusLabel toolStripStatusLabelNombreOperador;
        private StatusStrip statusStrip;
        private Usuario usuario;
        private SQL sql;

        public FrmPrincipal(Usuario usuario)
        {
            InitializeComponent();

            this.caballos = new ColeccionTransportes<Transporte>();
            this.autos = new ColeccionTransportes<Transporte>();
            this.aviones = new ColeccionTransportes<Transporte>();
            statusStrip = new StatusStrip();
            statusStrip.Dock = DockStyle.Top;
            toolStripStatusLabelNombreOperador = new ToolStripStatusLabel();
            toolStripStatusLabelNombreOperador.Text = "Usuario: " + usuario.nombre + " Fecha: " + DateTime.Now.ToString("dd/MM/yyyy");
            statusStrip.Items.Add(toolStripStatusLabelNombreOperador);
            Controls.Add(statusStrip);
            this.usuario = usuario;
            this.sql = new SQL();

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
            try
            {
                FrmTransporte frmTpt = new FrmTransporte();
                frmTpt.StartPosition = FormStartPosition.CenterScreen;
                frmTpt.ShowDialog();
                if (frmTpt.esAuto)
                {
                    if (frmTpt.DialogResult == DialogResult.OK)
                    {
                        if(!ExisteTransporte(frmTpt.nuevoAuto, autos))
                        {
                            sql.AgregarAuto(frmTpt.nuevoAuto, this.autos);
                            ActualizarVisor(this.lstVisorAutos, this.autos);
                        }
                        else
                        {
                            throw new TransporteRepetidoExcepcion("Ya hay un transporte con estas características disponible, regrese mas tarde");
                        }
                    }
                }
                else if (frmTpt.esCaballo)
                {
                    if (frmTpt.DialogResult == DialogResult.OK && !ExisteTransporte(frmTpt.nuevoCaballo, caballos))
                    {
                        sql.AgregarCaballo(frmTpt.nuevoCaballo, this.caballos);
                        ActualizarVisor(this.lstVisorCaballos, this.caballos);
                    }
                    else
                    {
                        throw new TransporteRepetidoExcepcion("Este caballo ya existe");
                    }
                }
                else if (frmTpt.esAvion)
                {
                    if (frmTpt.DialogResult == DialogResult.OK && !ExisteTransporte(frmTpt.nuevoAvion, aviones))
                    {
                        sql.AgregarAvion(frmTpt.nuevoAvion, this.aviones);
                        ActualizarVisor(this.lstVisorAviones, this.aviones);
                    }
                    else
                    {
                        throw new TransporteRepetidoExcepcion("Este avión ya existe"); //SOLUCIONAR ESTOOOOOOOO
                    }
                }
            }
            catch (TransporteRepetidoExcepcion ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        sql.ModificarCaballo(frm1.caballo);
                        ActualizarVisor(this.lstVisorCaballos, this.caballos);
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
                        sql.ModificarAuto(frm2.auto);
                        ActualizarVisor(this.lstVisorAutos, this.autos);
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
                        sql.ModificarAvion(a);
                        ActualizarVisor(this.lstVisorAviones, this.aviones);
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

                if (result == DialogResult.Yes)
                {
                    sql.BorrarAuto((Auto)auto, this.autos);
                    ActualizarVisor(this.lstVisorAutos, this.autos);
                }
            }
            else if (indiceAviones >= 0)
            {
                Transporte avion = this.aviones.ListaTransportes[indiceAviones];
                DialogResult result = MessageBox.Show("¿Deseas eliminar este transporte?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    sql.BorrarAvion((Avion)avion,this.aviones);
                    ActualizarVisor(this.lstVisorAviones, this.aviones);
                }
            }
            else if (indiceCaballos >= 0)
            {
                Transporte caballo = this.caballos.ListaTransportes[indiceCaballos];

                 DialogResult result = MessageBox.Show("¿Deseas eliminar este transporte?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                 if (result == DialogResult.Yes)
                 {
                    sql.BorrarCaballo((Caballo)caballo, this.caballos);
                    ActualizarVisor(this.lstVisorCaballos, this.caballos);
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
            ActualizarVisor(this.lstVisorAviones, this.aviones);
            ActualizarVisor(this.lstVisorAutos, this.autos);
            ActualizarVisor(this.lstVisorCaballos, this.caballos);
        }

        private void btnMenosPasajeros_Click(object sender, EventArgs e)
        {
            this.aviones.OrdenarPorCantidadPasajerosAscendente();
            this.autos.OrdenarPorCantidadPasajerosAscendente();
            this.caballos.OrdenarPorCantidadPasajerosAscendente();
            ActualizarVisor(this.lstVisorAviones, this.aviones);
            ActualizarVisor(this.lstVisorAutos, this.autos);
            ActualizarVisor(this.lstVisorCaballos, this.caballos);

        }

        private void btnMasVeloz_Click(object sender, EventArgs e)
        {
            this.aviones.OrdenarPorVelocidadMaximaDescendente();
            this.autos.OrdenarPorVelocidadMaximaDescendente();
            this.caballos.OrdenarPorVelocidadMaximaDescendente();
            ActualizarVisor(this.lstVisorAviones, this.aviones);
            ActualizarVisor(this.lstVisorAutos, this.autos);
            ActualizarVisor(this.lstVisorCaballos, this.caballos);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.aviones.OrdenarPorVelocidadMaximaAscendente();
            this.autos.OrdenarPorVelocidadMaximaAscendente();
            this.caballos.OrdenarPorVelocidadMaximaAscendente();
            ActualizarVisor(this.lstVisorAviones, this.aviones);
            ActualizarVisor(this.lstVisorAutos, this.autos);
            ActualizarVisor(this.lstVisorCaballos, this.caballos);

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

        private void Serializar(ColeccionTransportes<Transporte> c)
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
                        ser.Serialize(writer, c.ListaTransportes);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al deserializar el archivo XML: " + ex.Message);
            }
        }

        private void Deserializar(ColeccionTransportes<Transporte> c, ListBox listBox)
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
                        c.ListaTransportes = (List<Transporte>)ser.Deserialize(reader);
                    }
                    ActualizarVisor(listBox, c);
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
            Deserializar(this.caballos, lstVisorCaballos);
        }

        private void btnGuardarCaballos_Click(object sender, EventArgs e)
        {
            Serializar(caballos);
        }

        private void btnCargarAutos_Click(object sender, EventArgs e)
        {
            Deserializar(this.autos, lstVisorAutos);
        }

        private void btnGuardarAutos_Click(object sender, EventArgs e)
        {
            Serializar(autos);
        }

        private void btnCargarAviones_Click(object sender, EventArgs e)
        {
            Deserializar(this.aviones,lstVisorAviones);
        }

        private void btnGuardarAviones_Click(object sender, EventArgs e)
        {
            Serializar(aviones);
        }

        private void ActualizarVisor(ListBox listBox, ColeccionTransportes<Transporte> coleccion)
        {
            listBox.Items.Clear();
            foreach (Transporte transporte in coleccion.ListaTransportes)
            {
                listBox.Items.Add(transporte.ToString());
            }
        }

        public bool ExisteTransporte<T>(T nuevoT, ColeccionTransportes<T> c) where T : Transporte
        {
            foreach (Transporte t in c.ListaTransportes)
            {
                if (t is T tExistente && tExistente == nuevoT)
                {
                    return true; 
                }
            }
            return false; 
        }
    }
}

