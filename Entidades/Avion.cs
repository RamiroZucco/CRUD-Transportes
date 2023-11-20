using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Clase derivada de transporte que representa un avión como medio de transporte.
    /// </summary>
    public class Avion:Transporte
    {
        #region Atributos
        private string modelo;
        private int cantidadDeVentanas;

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor de la clase Avion que permite establecer todas las propiedades del avión.
        /// </summary>
        /// <param name="pasajeros">La cantidad de pasajeros del avión.</param>
        /// <param name="velocidad">La velocidad máxima del avión.</param>
        /// <param name="modelo">El modelo del avión.</param>
        /// <param name="cantidadVentanas">La cantidad de ventanas del avión.</param>
        /// <param name="carga">El tipo de carga del avión.</param>

        public Avion() { }

        public Avion(int pasajeros, EVelocidad velocidad, string modelo, int cantidadVentanas, ECarga carga):base(pasajeros,velocidad,carga)
        {
            this.modelo = modelo;
            this.cantidadDeVentanas = cantidadVentanas;
        }
        /// <summary>
        /// Constructor de la clase Avion que tiene un parametro menos que el anterior.
        /// <summary>
        public Avion(int pasajeros, EVelocidad velocidad, string modelo, ECarga carga) : base(pasajeros, velocidad, carga)
        {
            this.modelo = modelo;
        }

        /// <summary>
        /// Constructor de la clase Avion que tiene un parametro menos que el anterior y además se le asigna un valor a velocidad y carga.
        /// <summary>
        public Avion(int pasajeros, string modelo, int cantidadVentanas) : base(pasajeros, EVelocidad.Hiper, ECarga.MuyPesada)
        {
            this.modelo = modelo;
            this.cantidadDeVentanas= cantidadVentanas;
        }

        #endregion

        #region Propiedades
        /// <summary>
        /// Obtiene o establece el modelo del avión.
        /// </summary>
        public string Modelo { get => modelo; set => modelo = value; }

        /// <summary>
        /// Obtiene o establece la cantidad de ventanas del avión.
        /// </summary>
        public int CantidadDeVentanas { get => cantidadDeVentanas; set => cantidadDeVentanas = value; }
        #endregion

        #region Metodos y Sobrecargas

        /// <summary>
        /// Permite que el avión avance. Se sobreescribe el método Avanzar de la clase base.
        /// </summary>
        public override void Avanzar()
        {
            base.Avanzar();
            Console.WriteLine("El avión avanza en velocidad {0} y está disponible", this.VelocidadMaxima);
        }

        /// <summary>
        /// Frena el avión y lo pone fuera de servicio. Se implementa el método abstracto Frenar.
        /// </summary>
        public override void Frenar()
        {
            Console.WriteLine("Se apretó la parte superior de ambos pedales y el avion aterrizó");
        }

        /// <summary>
        /// Convierte la información del avión en una cadena de texto. Se sobreescribe el método ToString de la clase base.
        /// </summary>
        /// <returns>Una cadena que representa la información del avión.</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.Append($" Modelo: {this.modelo} - Cantidad de Ventanas: {this.cantidadDeVentanas}");
            return sb.ToString();
        }
 
        public override bool Equals(object? obj)
        {
            bool retorno = false; 
            if (obj is Avion) 
            {
                retorno = this == (Avion)obj;
            }
            return retorno;
        }

        /// <summary>
        /// Compara dos objetos de tipo Avion para determinar si son iguales.
        /// </summary>
        /// <param name="a">El primer objeto de tipo Avion a comparar.</param>
        /// <param name="a1">El segundo objeto de tipo Avion a comparar.</param>
        /// <returns>True si los objetos son iguales, False en caso contrario.</returns>
        public static bool operator ==(Avion a, Avion a1)
        {
            return a.modelo == a1.modelo && a.cantidadDeVentanas == a1.cantidadDeVentanas;
        }

        /// <summary>
        /// Compara dos objetos de tipo Avion para determinar si son diferentes.
        /// </summary>
        /// <param name="a">El primer objeto de tipo Avion a comparar.</param>
        /// <param name="a1">El segundo objeto de tipo Avion a comparar.</param>
        /// <returns>True si los objetos son diferentes, False en caso contrario.</returns>
        public static bool operator !=(Avion a, Avion a1)
        {
            return !(a == a1);
        }
        #endregion
    }
}
