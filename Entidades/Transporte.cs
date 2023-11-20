using System.Text;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace Entidades
{
    /// <summary>
    /// Clase base abstracta que representa un transporte genérico.
    /// </summary>
    /// 
    [XmlInclude(typeof(Auto))]
    [XmlInclude(typeof(Avion))]
    [XmlInclude(typeof(Caballo))]
    public abstract class Transporte
    {
        #region Atributos
        private int cantidadPasajeros;
        private EVelocidad velocidadMaxima;
        private ECarga carga;
        #endregion

        #region Propiedades
        /// <summary>
        /// Obtiene o establece la cantidad de pasajeros que puede transportar el vehículo.
        /// </summary>
        public int CantidadPasajeros { get => cantidadPasajeros; set => cantidadPasajeros = value; }

        /// <summary>
        /// Obtiene o establece la velocidad máxima del transporte.
        /// </summary>
        public EVelocidad VelocidadMaxima { get => velocidadMaxima; set => velocidadMaxima = value; }
        
        /// <summary>
        /// Obtiene o establece la carga que puede transportar el vehículo.
        /// </summary>
        public ECarga Carga { get => carga; set => carga = value; }
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor por defecto de la clase Transporte.
        /// Inicializa las propiedades con valores predeterminados.
        /// </summary>
        public Transporte()
        {
            
        }
        /// <summary>
        /// Constructor con todos los atributos de la clase.
        /// </summary>
        public Transporte(int pasajeros, EVelocidad velocidad, ECarga carga)
        {
            this.CantidadPasajeros = pasajeros;
            this.VelocidadMaxima = velocidad;
            this.Carga = carga;
        }

        public Transporte(int pasajeros, ECarga carga, EVelocidad velocidad) : this(carga,velocidad)
        {
            this.CantidadPasajeros = pasajeros;
        }
        
        /// <summary>
        /// Constructor con un parametro menos que el anterior.
        /// </summary>
        public Transporte(ECarga carga, EVelocidad velocidad) : this()    
        {
            this.Carga = carga;
            this.VelocidadMaxima = velocidad;
        }
        #endregion

        #region Metodos y Sobrecargas

        /// <summary>
        /// Permite que el transporte avance.
        /// </summary>
        public virtual void Avanzar()
        {
            Console.WriteLine("El transporte está avanzando");
        }

        /// <summary>
        /// Método abstracto para frenar el transporte.
        /// </summary>
        public abstract void Frenar();

        /// <summary>
        /// Convierte la información del transporte en una cadena de texto.
        /// </summary>
        /// <returns>Una cadena que representa la información del transporte.</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Cantidad de pasajeros: {this.cantidadPasajeros} - Tipo de carga: {this.carga} - Velocidad Máxima: {this.velocidadMaxima} -");
            return sb.ToString();
        }


        public override bool Equals(object? obj)
        {
            if (obj is Transporte otro)
            {
                return this.cantidadPasajeros == otro.cantidadPasajeros && this.carga == otro.carga;
            }
            return false;
        }

        /// <summary>
        /// Compara dos objetos de tipo Transporte para determinar si son iguales.
        /// </summary>
        /// <param name="t">El primer objeto de tipo Transporte a comparar.</param>
        /// <param name="t1">El segundo objeto de tipo Transporte a comparar.</param>
        /// <returns>True si los objetos son iguales, False en caso contrario.</returns>
        public static bool operator == (Transporte t, Transporte t1)
        {
            return t.CantidadPasajeros == t1.CantidadPasajeros && t.Carga == t1.Carga;
        }

        /// <summary>
        /// Compara dos objetos de tipo Transporte para determinar si son diferentes.
        /// </summary>
        /// <param name="t">El primer objeto de tipo Transporte a comparar.</param>
        /// <param name="t1">El segundo objeto de tipo Transporte a comparar.</param>
        /// <returns>True si los objetos son diferentes, False en caso contrario.</returns>
        public static bool operator != (Transporte t, Transporte t1)
        {
            return !(t == t1);
        }
        #endregion
    }
}
