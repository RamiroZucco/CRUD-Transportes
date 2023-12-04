using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Interfaz que contiene una función que valida un texto.
    /// </summary>
    public interface IValidadora
    {
        bool ValidarTexto(string texto);

    }
}
