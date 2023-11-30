using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public interface IPrincipal<T> where T : Transporte
    {
        bool ExisteTransporte<T>(T nuevoPersonal, ColeccionTransportes<T> c) where T : Transporte;
    }
}
