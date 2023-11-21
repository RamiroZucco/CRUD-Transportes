using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Xml.Serialization;


namespace Entidades
{
    public class ColeccionTransportes<T> where T : Transporte
    {
        #region Propiedades

        private List<T> listaTransportes;

        public List<T> ListaTransportes
        {
            get { return this.listaTransportes; }
            set { this.listaTransportes = value; }
        }

        #endregion

        #region Constructores

        public ColeccionTransportes()
        {
            this.listaTransportes = new List<T>();
        }

        #endregion

        #region Metodos y Sobrecargas

        public static ColeccionTransportes<T> operator +(ColeccionTransportes<T> c, T t)
        {
            if (c != t)
            {
                c.listaTransportes.Add(t);
            }
            return c;
        }
        public static ColeccionTransportes<T> operator -(ColeccionTransportes<T> c, T t)
        {
            if (c == t)
            {
                c.listaTransportes.Remove(t);
            }
            return c;
        }

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
        public static bool operator !=(ColeccionTransportes<T> c, T t)
        {
            return !(c == t);
        }

        public override bool Equals(object? obj)
        {
            return this == (T)obj;
        }

        public void OrdenarPorCantidadPasajerosAscendente()
        {
            ListaTransportes.Sort((t1, t2) => t1.CantidadPasajeros.CompareTo(t2.CantidadPasajeros));
        }

        public void OrdenarPorCantidadPasajerosDescendente()
        {
            ListaTransportes.Sort((t1, t2) => t2.CantidadPasajeros.CompareTo(t1.CantidadPasajeros));
        }

        public void OrdenarPorVelocidadMaximaAscendente()
        {
            ListaTransportes.Sort((t1, t2) => t1.VelocidadMaxima.CompareTo(t2.VelocidadMaxima));
        }

        public void OrdenarPorVelocidadMaximaDescendente()
        {
            ListaTransportes.Sort((t1, t2) => t2.VelocidadMaxima.CompareTo(t1.VelocidadMaxima));
        }
        #endregion

    }
}
