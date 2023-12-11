using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Clase derivada de transporte que representa un auto como medio de transporte.
    /// </summary>
    public class Auto:Transporte
    {
        #region Atributos
        private int cantidadDePuertas;
        private string numerosPatente;

        #endregion

        #region Propiedades
        /// <summary>
        /// Obtiene o establece la cantidad de puertas del automóvil.
        /// </summary>
        public int CantidadDePuertas { get => cantidadDePuertas; set => cantidadDePuertas = value; }

        /// <summary>
        /// Obtiene o establece los últimos 2 números de la patente del automóvil.
        /// </summary>
        public string NumerosPatente { get => numerosPatente; set => numerosPatente = value; }
        #endregion

        #region Constructores

        /// <summary>
        /// Constructor por defecto de la clase Auto.
        /// </summary>
        public Auto() 
        { }

        /// <summary>
        /// Constructor de la clase Auto que permite establecer todas las propiedades del automóvil.
        /// </summary>
        /// <param name="pasajeros">La cantidad de pasajeros del automóvil.</param>
        /// <param name="velocidad">La velocidad máxima del automóvil.</param>
        /// <param name="cantidadDePuertas">La cantidad de puertas del automóvil.</param>
        /// <param name="carga">El tipo de carga del automóvil.</param>
        /// <param name="patente">Los últimos 3 números de la patente del automóvil.</param>
        public Auto(int pasajeros, EVelocidad velocidad, int cantidadDePuertas, ECarga carga, string patente)
            : base(pasajeros, carga, velocidad)
        {
            this.cantidadDePuertas = cantidadDePuertas;
            this.numerosPatente = patente;
        }
        #endregion

        #region Metodos y Sobrecargas
        /// <summary>
        /// Permite que el automóvil avance. Se sobreescribe el método Avanzar de la clase base.
        /// </summary>
        public override void Avanzar()
        {
            base.Avanzar();
            Console.WriteLine("El auto avanza en velocidad {0} y está disponible", this.VelocidadMaxima);
        }

        /// <summary>
        /// Frena el automóvil y lo pone fuera de servicio. Se implementa el método abstracto Frenar.
        /// </summary>
        public override void Frenar()
        {
            Console.WriteLine("Se pisó el freno, el auto frenó y no viajará más por hoy");
        }

        /// <summary>
        /// Convierte la información del automóvil en una cadena de texto. Se sobreescribe el método ToString de la clase base.
        /// </summary>
        /// <returns>Una cadena que representa la información del automóvil.</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.Append($" Últimos 2 numeros de patente: {this.numerosPatente} - Cantidad de puertas: {this.cantidadDePuertas}");
            return sb.ToString();
        }
        public override bool Equals(object? obj)
        {
            bool retorno = false;
            if (obj is Auto)
            {
                retorno = this == (Auto)obj;
            }
            return retorno;
        }

        /// <summary>
        /// Compara dos objetos de tipo Auto para determinar si son iguales.
        /// </summary>
        /// <param name="a">El primer objeto de tipo Auto a comparar.</param>
        /// <param name="a1">El segundo objeto de tipo Auto a comparar.</param>
        /// <returns>True si los objetos son iguales, False en caso contrario.</returns>
        public static bool operator ==(Auto a, Auto a1)
        {
            return a.cantidadDePuertas == a1.cantidadDePuertas && a.numerosPatente == a1.numerosPatente;
        }

        /// <summary>
        /// Compara dos objetos de tipo Auto para determinar si son diferentes.
        /// </summary>
        /// <param name="a">El primer objeto de tipo Auto a comparar.</param>
        /// <param name="a1">El segundo objeto de tipo Auto a comparar.</param>
        /// <returns>True si los objetos son diferentes, False en caso contrario.</returns>
        public static bool operator !=(Auto a, Auto a1)
        {
            return !(a == a1);
        }
        #endregion

    }
}
