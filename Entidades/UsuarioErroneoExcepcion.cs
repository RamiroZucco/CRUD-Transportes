using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Clase que representa una excepción cuando el usuario es érroneo
    /// </summary>
    public class UsuarioErroneoExcepcion : Exception
    {
        /// <summary>
        /// Informa que el usuario es érroneo
        /// </summary>
        /// <param name="ex">Excepción que se captura</param>
        /// <returns>Retorna un mensaje informando que el usuario no es correcto</returns>
        public static string RetornarInformacionDelError(UsuarioErroneoExcepcion ex)
        {
            return $"Usuario incorrecto. Por favor verifique su correo y su contraseña.\n\nSi el problema persiste, comuniquese con sistemas por este error: {ex.Message}";
        }
    }
}
