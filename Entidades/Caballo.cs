using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Clase derivada de transporte que representa un caballo como medio de transporte.
    /// </summary>
    public class Caballo:Transporte
    {
        #region Atributos
        
        private string nombre;
        private EColor color;

        #endregion

        #region Propiedades
        /// <summary>
        /// Obtiene o establece el nombre del caballo.
        /// </summary>
        public string Nombre { get => nombre; set => nombre = value; }
        
        /// <summary>
        /// Obtiene o establece el color del caballo.
        /// </summary>
        public EColor Color { get => color; set => color = value; }
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor por defecto de la clase Caballo.
        /// Inicializa el nombre del caballo como "Nombre indefinido".
        /// </summary>
        public Caballo()
        {
            //this.nombre = "Nombre indefinido";
        }

        /// <summary>
        /// Constructor con todos los atributos como parametros.
        /// </summary>
        public Caballo(string nombre, int cantPasajeros, EVelocidad miVelocidad, EColor color, ECarga carga):base(cantPasajeros,miVelocidad,carga)
        {
            this.nombre = nombre;
            this.color = color;
        }

        /// <summary>
        /// Constructor con todos los atributos como parametros pero con velocidad y carga ya definidos.
        /// </summary>
        public Caballo(string nombre, int cantPasajeros, EColor color) : base(cantPasajeros, EVelocidad.Media, ECarga.Liviana)
        {
            this.nombre = nombre;
            this.color = color;
        }

        /// <summary>
        /// Constructor con un parametro menos.
        /// </summary>
        public Caballo(int cantPasajeros, EVelocidad miVelocidad, EColor color, ECarga carga) : base(cantPasajeros, miVelocidad, carga)
        {
            this.color = color;
        }
        #endregion

        #region Metodos y Sobrecargas
        /// <summary>
        /// Permite que el caballo avance y este disponible. Se sobreescribe el método Avanzar de la clase base.
        /// </summary>
        public override void Avanzar()
        {
            base.Avanzar();
            Console.WriteLine("El caballo avanza en velocidad {0} y está disponible", this.VelocidadMaxima);
        }

        /// <summary>
        /// Frena el caballo y lo pone fuera de servicio. Se implementa el método abstracto Frenar.
        /// </summary>
        public override void Frenar()
        {
            Console.WriteLine("Se tiró de las riendas, el caballo frenó y no hará mas viajes");
        }

        /// <summary>
        /// Convierte la información del caballo en una cadena de texto. Se sobreescribe el método ToString de la clase base.
        /// </summary>
        /// <returns>Una cadena que representa la información del caballo.</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.Append($" Nombre: {this.nombre} - Color: {this.color}");
            return sb.ToString();
        }

        public override bool Equals(object? obj)
        {
            bool retorno = false; 
            if (obj is Caballo) 
            {
                retorno = this == (Caballo)obj;
            }
            return retorno;
        }

        /// <summary>
        /// Compara dos objetos de tipo Caballo para determinar si son iguales.
        /// </summary>
        /// <param name="c">El primer objeto de tipo Caballo a comparar.</param>
        /// <param name="c1">El segundo objeto de tipo Caballo a comparar.</param>
        /// <returns>True si los objetos son iguales, False en caso contrario.</returns>
        public static bool operator ==(Caballo c, Caballo c1)
        {
            return c.nombre == c1.nombre && c.color == c1.color;
        }

        /// <summary>
        /// Compara dos objetos de tipo Caballo para determinar si son diferentes.
        /// </summary>
        /// <param name="c">El primer objeto de tipo Caballo a comparar.</param>
        /// <param name="c1">El segundo objeto de tipo Caballo a comparar.</param>
        /// <returns>True si los objetos son diferentes, False en caso contrario.</returns>
        public static bool operator !=(Caballo c, Caballo c1)
        {
            return !(c == c1);
        }
        #endregion
    }
}
