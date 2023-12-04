using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsCRUD
{
    public class Acciones
    {
        public static void UsuarioIncorrecto(string nombre)
        {
            MessageBox.Show($"{nombre} no está habilitado para realizar esta tarea", "Permiso denegado",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void TransporteRepetido(string nombre)
        {
            MessageBox.Show($"El transporte con esta característica: '{nombre}' debe esperar a que otro transporte con las mismas caracteristicas sea eliminado u ocupado.", "Transporte repetido",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static Color CambiarDeColorBtns(bool permiso)
        {
            if (permiso)
            {
                return Color.LightCoral;
            }
            else
            {
                return Color.Maroon;
            }
        }
    }
}
