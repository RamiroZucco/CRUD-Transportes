using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class TransporteRepetidoExcepcion : Exception
    {
        public TransporteRepetidoExcepcion(string msj) : base(msj) { }
    }
}
