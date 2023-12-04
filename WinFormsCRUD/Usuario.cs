using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsCRUD
{
    /// <summary>
    /// Clase que representa a un usuario en el sistema.
    /// </summary>
    public class Usuario
    {
        /// <summary>
        /// Obtiene o establece el correo, la clave, el nombre, el apellido, el legajo y el perfil del usuario.
        /// </summary>
        public string correo { get; set; }
        public string clave { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int legajo { get; set; }
        public string perfil { get; set; }
    }
}
