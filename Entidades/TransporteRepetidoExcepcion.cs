using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Clase que representa una excepción cuando ya existe un transporte con sus mismas características.
    /// </summary>
    public class TransporteRepetidoExcepcion : Exception
    {
        /// <summary>
        /// Informa que el usuario es érroneo
        /// </summary>
        /// <param name="msj">Cadena de texto que se muestra</param>
        /// <returns>Retorna un mensaje informando que el transporte ya existe</returns>
        public TransporteRepetidoExcepcion(string msj) : base(msj) { }
    }
}
