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
    public partial class FrmUsuariosRegistrados : Form
    {
        public FrmUsuariosRegistrados()
        {
            InitializeComponent();
        }

        private void FrmUsuariosRegistrados_Load(object sender, EventArgs e)
        {
            string rutaArchivoLog = "usuarios.log";

            if (File.Exists(rutaArchivoLog))
            {
                try
                {
                    string[] registros = File.ReadAllLines(rutaArchivoLog);
                    lstLog.Items.Clear();
                    lstLog.Items.AddRange(registros);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al leer el archivo de registro: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("El archivo de registro no existe o está vacío.");
            }
        }
    }
}
