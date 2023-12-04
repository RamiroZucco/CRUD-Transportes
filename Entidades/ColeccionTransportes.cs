using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Xml.Serialization;


namespace Entidades
{
    /// <summary>
    /// Clase que representa una colección de objetos de tipo transporte.
    /// </summary>
    /// <typeparam name="T">Tipo de transporte contenido en la colección.</typeparam>
    public class ColeccionTransportes<T> where T : Transporte
    {
        #region Propiedades

        private List<T> listaTransportes;

        /// <summary>
        /// Obtiene o establece la lista de transportes en la colección.
        /// </summary>
        public List<T> ListaTransportes
        {
            get { return this.listaTransportes; }
            set { this.listaTransportes = value; }
        }

        #endregion

        #region Constructores

        /// <summary>
        /// Constructor por defecto de la clase ColeccionTransportes. Inicializa la lista de transportes.
        /// </summary>
        public ColeccionTransportes()
        {
            this.listaTransportes = new List<T>();
        }

        #endregion

        #region Metodos y Sobrecargas

        /// <summary>
        /// Sobrecarga del operador +. Agrega un transporte a la colección si no existe.
        /// </summary>
        /// <param name="c">Colección de transportes.</param>
        /// <param name="t">Transporte a agregar.</param>
        /// <returns>La colección con el nuevo transporte, si se agrega.</returns>
        public static ColeccionTransportes<T> operator +(ColeccionTransportes<T> c, T t)
        {
            if (c != t)
            {
                c.listaTransportes.Add(t);
            }
            return c;
        }

        /// <summary>
        /// Sobrecarga del operador -. Remueve un transporte de la colección si existe.
        /// </summary>
        /// <param name="c">Colección de transportes.</param>
        /// <param name="t">Transporte a remover.</param>
        /// <returns>La colección sin el transporte, si se remueve.</returns>
        public static ColeccionTransportes<T> operator -(ColeccionTransportes<T> c, T t)
        {
            if (c == t)
            {
                c.listaTransportes.Remove(t);
            }
            return c;
        }

        /// <summary>
        /// Sobrecarga del operador de igualdad. Compara si un transporte existe en la colección.
        /// </summary>
        /// <param name="c">Colección de transportes.</param>
        /// <param name="t">Transporte a comparar.</param>
        /// <returns>True si el transporte existe en la colección, False en caso contrario.</returns>
        public static bool operator ==(ColeccionTransportes<T> c, T t)
        {
            foreach (T transporte in c.listaTransportes)
            {
                if (t.Equals(transporte))
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Sobrecarga del operador de desigualdad. Compara si un transporte no existe en la colección.
        /// </summary>
        /// <param name="c">Colección de transportes.</param>
        /// <param name="t">Transporte a comparar.</param>
        /// <returns>True si el transporte no existe en la colección, False en caso contrario.</returns>
        public static bool operator !=(ColeccionTransportes<T> c, T t)
        {
            return !(c == t);
        }

        /// <summary>
        /// Sobrescribe el método Equals para comparar si un objeto es igual a la colección.
        /// </summary>
        /// <param name="obj">Objeto a comparar.</param>
        /// <returns>True si el objeto es igual a la colección, False en caso contrario.</returns>
        public override bool Equals(object? obj)
        {
            return this == (T)obj;
        }

        /// <summary>
        /// Ordena la colección por la cantidad de pasajeros de forma ascendente.
        /// </summary>
        public void OrdenarPorCantidadPasajerosAscendente()
        {
            ListaTransportes.Sort((t1, t2) => t1.CantidadPasajeros.CompareTo(t2.CantidadPasajeros));
        }

        /// <summary>
        /// Ordena la colección por la cantidad de pasajeros de forma descendente.
        /// </summary>
        public void OrdenarPorCantidadPasajerosDescendente()
        {
            ListaTransportes.Sort((t1, t2) => t2.CantidadPasajeros.CompareTo(t1.CantidadPasajeros));
        }

        /// <summary>
        /// Ordena la colección por la velocidad máxima de forma ascendente.
        /// </summary>
        public void OrdenarPorVelocidadMaximaAscendente()
        {
            ListaTransportes.Sort((t1, t2) => t1.VelocidadMaxima.CompareTo(t2.VelocidadMaxima));
        }

        /// <summary>
        /// Ordena la colección por la velocidad máxima de forma descendente.
        /// </summary>
        public void OrdenarPorVelocidadMaximaDescendente()
        {
            ListaTransportes.Sort((t1, t2) => t2.VelocidadMaxima.CompareTo(t1.VelocidadMaxima));
        }
        #endregion

    }
}
