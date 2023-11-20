using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{

    public class ColeccionTransportes
    {
        #region Propiedades

        private List<Transporte> listaTransportes;

        public List<Transporte> ListaTransportes 
        { 
          get { return this.listaTransportes; }
          set { this.listaTransportes = value; }
        }
        #endregion


        #region Constructores
        public ColeccionTransportes()
        {
            this.listaTransportes = new List<Transporte>();
        }
        #endregion

        #region Metodos y Sobrecargas
        public static bool operator +(ColeccionTransportes coleccion, Transporte transporte)
        {
            bool agregado = true;
            if (coleccion.listaTransportes.Count > 0)
            {
                foreach (Transporte t in coleccion.listaTransportes)
                {
                    if (t.Equals(transporte))
                    {
                        agregado = false;
                        break;
                    }

                }
            }

            if (agregado || coleccion.listaTransportes.Count == 0)
            {
                coleccion.listaTransportes.Add(transporte);

            }
            return agregado;
        }
        public static bool operator -(ColeccionTransportes coleccion, Transporte transporte)
        {
            bool eliminado = false;
            if (coleccion.listaTransportes.Count > 0)
            {
                foreach (Transporte t in coleccion.listaTransportes)
                {
                    if (t.Equals(transporte))
                    {
                        coleccion.listaTransportes.Remove(t);
                        eliminado = true;
                        break;
                    }
                }
            }
            return eliminado;
        }
        public static bool operator ==(Transporte t, ColeccionTransportes coleccion)
        {
            bool retorno = false;
            foreach (Transporte item in coleccion.ListaTransportes)
            {
                if (item == t)
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }
        public static bool operator !=(Transporte t, ColeccionTransportes coleccion)
        {
            return !(t == coleccion);
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
        public override bool Equals(object? obj)
        {
            if (obj is Transporte transporte)
            {
                return ListaTransportes.Contains(transporte);
            }

            return false;
        }
        #endregion
    }

}
