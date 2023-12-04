using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Interfaz que contiene la función capitalize para modificar un texto.
    /// </summary>
    public interface IModificadoraDeTexto
    {
        string Capitalize(string input);
    }
}
