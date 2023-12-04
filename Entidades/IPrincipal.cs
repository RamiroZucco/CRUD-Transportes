using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Interfaz que contiene una función para verificar si existe un transporte con las mismas características.
    /// </summary>
    public interface IPrincipal<T> where T : Transporte
    {
        bool ExisteTransporte<T>(T nuevoPersonal, ColeccionTransportes<T> c) where T : Transporte;
    }
}
