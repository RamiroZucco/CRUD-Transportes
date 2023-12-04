using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Entidades
{
    /// <summary>
    /// Clase que me permite conectarme a la bdd y realizar un CRUD con la misma
    /// </summary>
    public class SQL
    {
        private SqlConnection conexion;
        private static string cadena_conexion;
        private SqlCommand comando;
        private SqlDataReader lector;

        static SQL()
        {
            SQL.cadena_conexion = Properties.Resources.miConexion;
        }

        /// <summary>
        /// Constructor de la clase SQL
        /// </summary>
        public SQL()
        {
            this.conexion = new SqlConnection(SQL.cadena_conexion);
        }

        /// <summary>
        /// Método para agregar un transporte a la base de datos
        /// </summary>
        public void AgregarAuto(Auto auto, ColeccionTransportes<Transporte> c)
        {
            try
            {
                this.comando = new SqlCommand();

                // Consulta SQL usando MERGE para insertar o actualizar autos.
                this.comando.CommandText = @"
                    MERGE INTO auto AS Target
                    USING (VALUES (@cantidadPasajeros, @velocidadMaxima, @carga, @cantidadDePuertas, @numerosPatente)) AS Source (cantidadPasajeros, velocidadMaxima, carga, cantidadDePuertas, numerosPatente)
                    ON Target.cantidadPasajeros = Source.cantidadPasajeros AND Target.velocidadMaxima = Source.velocidadMaxima AND Target.carga = Source.carga
                    WHEN MATCHED THEN
                        UPDATE SET Target.cantidadDePuertas = Source.cantidadDePuertas, Target.numerosPatente = Source.numerosPatente
                    WHEN NOT MATCHED THEN
                        INSERT (cantidadPasajeros, velocidadMaxima, carga, cantidadDePuertas, numerosPatente) VALUES (Source.cantidadPasajeros, Source.velocidadMaxima, Source.carga, Source.cantidadDePuertas, Source.numerosPatente);
                ";

                this.comando.Parameters.AddWithValue("@cantidadPasajeros", auto.CantidadPasajeros);
                this.comando.Parameters.AddWithValue("@velocidadMaxima", auto.VelocidadMaxima.ToString());
                this.comando.Parameters.AddWithValue("@carga", auto.Carga.ToString());
                this.comando.Parameters.AddWithValue("@cantidadDePuertas", auto.CantidadDePuertas);
                this.comando.Parameters.AddWithValue("@numerosPatente", auto.NumerosPatente);

                this.comando.Connection = this.conexion;
                this.conexion.Open();

                int filasAfectadas = this.comando.ExecuteNonQuery();

                if (filasAfectadas == 1)
                {
                    // se actualizó o insertó un registro
                }

                c += auto;
            }
            catch(Exception e) { }
            finally
            {
                this.conexion.Close();
            }
        }

        /// <summary>
        /// Método para agregar un avión a la base de datos
        /// </summary>
        public void AgregarAvion(Avion avion, ColeccionTransportes<Transporte> c)
        {
            try
            {
                this.comando = new SqlCommand();

                this.comando.CommandText = @"
                    MERGE INTO avion AS Target
                    USING (VALUES (@cantidadPasajeros, @velocidadMaxima, @carga, @modelo, @cantidadDeVentanas)) AS Source (cantidadPasajeros, velocidadMaxima, carga, modelo, cantidadDeVentanas)
                    ON Target.cantidadPasajeros = Source.cantidadPasajeros AND Target.velocidadMaxima = Source.velocidadMaxima AND Target.carga = Source.carga
                    WHEN MATCHED THEN
                        UPDATE SET Target.modelo = Source.modelo, Target.cantidadDeVentanas = Source.cantidadDeVentanas
                    WHEN NOT MATCHED THEN
                        INSERT (cantidadPasajeros, velocidadMaxima, carga, modelo, cantidadDeVentanas) VALUES (Source.cantidadPasajeros, Source.velocidadMaxima, Source.carga, Source.modelo, Source.cantidadDeVentanas);
                ";

                this.comando.Parameters.AddWithValue("@cantidadPasajeros", avion.CantidadPasajeros);
                this.comando.Parameters.AddWithValue("@velocidadMaxima", avion.VelocidadMaxima.ToString());
                this.comando.Parameters.AddWithValue("@carga", avion.Carga.ToString());
                this.comando.Parameters.AddWithValue("@modelo", avion.Modelo);
                this.comando.Parameters.AddWithValue("@cantidadDeVentanas", avion.CantidadDeVentanas);

                this.comando.Connection = this.conexion;
                this.conexion.Open();

                int filasAfectadas = this.comando.ExecuteNonQuery();

                if (filasAfectadas == 1)
                {

                }
                c += avion;
            }
            catch {}
            finally
            {
                this.conexion.Close();
            }
        }

        /// <summary>
        /// Método para agregar un caballo a la base de datos
        /// </summary>
        public void AgregarCaballo(Caballo caballo, ColeccionTransportes<Transporte> c)
        {
            try
            {
                this.comando = new SqlCommand();

                this.comando.CommandText = @"
                    MERGE INTO caballo AS Target
                    USING (VALUES (@cantidadPasajeros, @velocidadMaxima, @carga, @nombre, @color)) AS Source (cantidadPasajeros, velocidadMaxima, carga, nombre, color)
                    ON Target.cantidadPasajeros = Source.cantidadPasajeros AND Target.velocidadMaxima = Source.velocidadMaxima AND Target.carga = Source.carga
                    WHEN MATCHED THEN
                        UPDATE SET Target.nombre = Source.nombre, Target.color = Source.color
                    WHEN NOT MATCHED THEN
                        INSERT (cantidadPasajeros, velocidadMaxima, carga, nombre, color) VALUES (Source.cantidadPasajeros, Source.velocidadMaxima, Source.carga, Source.nombre, Source.color);
                ";

                this.comando.Parameters.AddWithValue("@cantidadPasajeros", caballo.CantidadPasajeros);
                this.comando.Parameters.AddWithValue("@velocidadMaxima", caballo.VelocidadMaxima.ToString());
                this.comando.Parameters.AddWithValue("@carga", caballo.Carga.ToString());
                this.comando.Parameters.AddWithValue("@nombre", caballo.Nombre);
                this.comando.Parameters.AddWithValue("@color", caballo.Color.ToString());

                this.comando.Connection = this.conexion;
                this.conexion.Open();

                int filasAfectadas = this.comando.ExecuteNonQuery();

                if (filasAfectadas == 1)
                {

                }
                c += caballo;
            }
            catch { }
            finally
            {
                this.conexion.Close();
            }
        }

        /// <summary>
        /// Método para modificar datos de un auto en la base de datos
        /// </summary>
        public bool ModificarAuto(Auto auto)
        {
            bool retorno = false;
            try
            {
                this.comando = new SqlCommand();

                this.comando.Parameters.AddWithValue("@cantidadPasajeros", auto.CantidadPasajeros);
                this.comando.Parameters.AddWithValue("@velocidadMaxima", auto.VelocidadMaxima.ToString());
                this.comando.Parameters.AddWithValue("@carga", auto.Carga.ToString());
                this.comando.Parameters.AddWithValue("@cantidadDePuertas", auto.CantidadDePuertas);
                this.comando.Parameters.AddWithValue("@numerosPatente", auto.NumerosPatente);

                this.comando.CommandType = System.Data.CommandType.Text;
                this.comando.CommandText = @"UPDATE auto SET cantidadDePuertas = @cantidadDePuertas, numerosPatente = @numerosPatente, cantidadPasajeros = @cantidadPasajeros, velocidadMaxima = @velocidadMaxima, carga = @carga
                                            WHERE numerosPatente = @numerosPatente";
                this.comando.Connection = this.conexion;

                this.conexion.Open();

                int filasAfectadas = this.comando.ExecuteNonQuery();

                if (filasAfectadas == 1)
                {
                    retorno = true;
                }
            }
            catch { }
            finally
            {
                if (this.conexion.State == System.Data.ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }

            return retorno;
        }

        /// <summary>
        /// Método para modificar datos de un caballo en la base de datos
        /// </summary>
        public bool ModificarCaballo(Caballo caballo)
        {
            bool retorno = false;
            try
            {
                this.comando = new SqlCommand();

                this.comando.Parameters.AddWithValue("@cantidadPasajeros", caballo.CantidadPasajeros);
                this.comando.Parameters.AddWithValue("@velocidadMaxima", caballo.VelocidadMaxima.ToString());
                this.comando.Parameters.AddWithValue("@carga", caballo.Carga.ToString());
                this.comando.Parameters.AddWithValue("@nombre", caballo.Nombre);
                this.comando.Parameters.AddWithValue("@color", caballo.Color.ToString());

                this.comando.CommandType = System.Data.CommandType.Text;
                this.comando.CommandText = @"UPDATE caballo SET nombre = @nombre, color = @color, cantidadPasajeros = @cantidadPasajeros, velocidadMaxima = @velocidadMaxima, carga = @carga
                                            WHERE nombre = @nombre";
                this.comando.Connection = this.conexion;

                this.conexion.Open();

                int filasAfectadas = this.comando.ExecuteNonQuery();

                if (filasAfectadas == 1)
                {
                    retorno = true;
                }
            }
            catch { }
            finally
            {
                if (this.conexion.State == System.Data.ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }

            return retorno;
        }

        /// <summary>
        /// Método para modificar datos de un avión en la base de datos
        /// </summary>
        public bool ModificarAvion(Avion avion)
        {
            bool retorno = false;
            try
            {
                this.comando = new SqlCommand();

                this.comando.Parameters.AddWithValue("@cantidadPasajeros", avion.CantidadPasajeros);
                this.comando.Parameters.AddWithValue("@velocidadMaxima", avion.VelocidadMaxima.ToString());
                this.comando.Parameters.AddWithValue("@carga", avion.Carga.ToString());
                this.comando.Parameters.AddWithValue("@modelo", avion.Modelo);
                this.comando.Parameters.AddWithValue("@cantidadDeVentanas", avion.CantidadDeVentanas);

                this.comando.CommandType = System.Data.CommandType.Text;
                this.comando.CommandText = @"UPDATE avion SET modelo = @modelo, cantidadDeVentanas = @cantidadDeVentanas, cantidadPasajeros = @cantidadPasajeros, velocidadMaxima = @velocidadMaxima, carga = @carga 
                                            WHERE modelo = @modelo";
                this.comando.Connection = this.conexion;

                this.conexion.Open();

                int filasAfectadas = this.comando.ExecuteNonQuery();

                if (filasAfectadas == 1)
                {
                    retorno = true;
                }
            }
            catch{ }
            finally
            {
                if (this.conexion.State == System.Data.ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }

            return retorno;
        }

        /// <summary>
        /// Método para borrar datos de un avion en la base de datos
        /// </summary>
        public bool BorrarAvion(Avion avion, ColeccionTransportes<Transporte> c)
        {
            bool result = false;
            try
            {
                this.comando = new SqlCommand();

                this.comando.Connection = this.conexion;
                this.comando.Parameters.AddWithValue("@modelo", avion.Modelo);
                this.comando.CommandType = System.Data.CommandType.Text;
                this.comando.CommandText = $"DELETE FROM avion WHERE modelo=@modelo";

                this.conexion.Open();

                int filasAfectadas = this.comando.ExecuteNonQuery();
                if (filasAfectadas == 1)
                {
                    result = true;
                }

                c -= avion;
            }
            catch {}
            finally
            {
                if (this.conexion.State == System.Data.ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }

            return result;
        }
        /// <summary>
        /// Método para borrar datos de un auto en la base de datos
        /// </summary>
        public bool BorrarCaballo(Caballo caballo, ColeccionTransportes<Transporte> c)
        {
            bool result = false;
            try
            {
                this.comando = new SqlCommand();

                this.comando.Connection = this.conexion;
                this.comando.Parameters.AddWithValue("@nombre", caballo.Nombre);
                this.comando.CommandType = System.Data.CommandType.Text;
                this.comando.CommandText = $"DELETE FROM caballo WHERE nombre=@nombre";

                this.conexion.Open();

                int filasAfectadas = this.comando.ExecuteNonQuery();
                if (filasAfectadas == 1)
                {
                    result = true;
                }

                c -= caballo;
            }
            catch { }
            finally
            {
                if (this.conexion.State == System.Data.ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }

            return result;
        }

        /// <summary>
        /// Método para borrar datos de un auto en la base de datos
        /// </summary>
        public bool BorrarAuto(Auto auto, ColeccionTransportes<Transporte> c)
        {
            bool result = false;
            try
            {
                this.comando = new SqlCommand();

                this.comando.Connection = this.conexion;
                this.comando.Parameters.AddWithValue("@numerosPatente", auto.NumerosPatente);
                this.comando.CommandType = System.Data.CommandType.Text;
                this.comando.CommandText = $"DELETE FROM auto WHERE numerosPatente=@numerosPatente";

                this.conexion.Open();

                int filasAfectadas = this.comando.ExecuteNonQuery();
                if (filasAfectadas == 1)
                {
                    result = true;
                }

                c -= auto;
            }
            catch { }
            finally
            {
                if (this.conexion.State == System.Data.ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }

            return result;
        }


        /// <summary>
        /// Carga los datos de aviones desde la base de datos y los agrega a la colección
        /// </summary>
        /// <param name="lista">Lista de objetos de tipo transporte.</param>
        public void CargarAvionesBaseDeDatos(List<Transporte> lista)
        {
            try
            {
                this.comando = new SqlCommand();
                this.comando.CommandType = System.Data.CommandType.Text;
                this.comando.CommandText = "SELECT * FROM avion";
                this.comando.Connection = this.conexion;

                this.conexion.Open();

                this.lector = this.comando.ExecuteReader();

                while (this.lector.Read())
                {
                    Avion avion = new Avion();
                    avion.CantidadPasajeros = (int)this.lector["cantidadPasajeros"];
                    avion.Modelo = this.lector["modelo"].ToString();
                    avion.CantidadDeVentanas = (int)this.lector["cantidadDeVentanas"];
                    if (Enum.TryParse(this.lector["velocidadMaxima"].ToString(), out EVelocidad velocidadEnum) && Enum.TryParse(this.lector["carga"].ToString(), out ECarga cargaEnum))
                    {
                        avion.VelocidadMaxima = velocidadEnum;
                        avion.Carga = cargaEnum;
                    }
                    else
                    {
                        Console.WriteLine("Error al convertir el valor de algún enumerado");
                    }

                    lista.Add(avion);
                }

                this.lector.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al cargar datos de aviones desde la base de datos: " + ex.Message);
            }
            finally
            {
                if (this.conexion.State == System.Data.ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }
        }

        /// <summary>
        /// Carga los datos de caballos desde la base de datos y los agrega a la colección
        /// </summary>
        /// <param name="lista">Lista de objetos de tipo transporte.</param>
        public void CargarCaballosBaseDeDatos(List<Transporte> lista)
        {
            try
            {
                this.comando = new SqlCommand();
                this.comando.CommandType = System.Data.CommandType.Text;
                this.comando.CommandText = "SELECT * FROM caballo";
                this.comando.Connection = this.conexion;

                this.conexion.Open();

                this.lector = this.comando.ExecuteReader();

                while (this.lector.Read())
                {
                    Caballo caballo = new Caballo();
                    caballo.CantidadPasajeros = (int)this.lector["cantidadPasajeros"];
                    caballo.Nombre = this.lector["nombre"].ToString();
                    if (Enum.TryParse(this.lector["velocidadMaxima"].ToString(), out EVelocidad velocidadEnum) && Enum.TryParse(this.lector["carga"].ToString(), out ECarga cargaEnum) && Enum.TryParse(this.lector["color"].ToString(), out EColor colorEnum))
                    {
                        caballo.VelocidadMaxima = velocidadEnum;
                        caballo.Carga = cargaEnum;
                        caballo.Color = colorEnum;
                    }
                    else
                    {
                        Console.WriteLine("Error al convertir el valor de algún enumerado");
                    }

                    lista.Add(caballo);
                }

                this.lector.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al cargar datos de caballos desde la base de datos: " + ex.Message);
            }
            finally
            {
                if (this.conexion.State == System.Data.ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }
        }

        /// <summary>
        /// Carga los datos de autos desde la base de datos y los agrega a la colección
        /// </summary>
        /// <param name="lista">Lista de objetos de tipo transporte.</param>
        public void CargarAutosBaseDeDatos(List<Transporte> lista)
        {
            try
            {
                this.comando = new SqlCommand();
                this.comando.CommandType = System.Data.CommandType.Text;
                this.comando.CommandText = "SELECT * FROM auto";
                this.comando.Connection = this.conexion;

                this.conexion.Open();

                this.lector = this.comando.ExecuteReader();

                while (this.lector.Read())
                {
                    Auto auto = new Auto();
                    auto.CantidadPasajeros = (int)this.lector["cantidadPasajeros"];
                    auto.NumerosPatente = this.lector["numerosPatente"].ToString();
                    auto.CantidadDePuertas = (int)this.lector["cantidadDePuertas"];
                    if (Enum.TryParse(this.lector["velocidadMaxima"].ToString(), out EVelocidad velocidadEnum) && Enum.TryParse(this.lector["carga"].ToString(), out ECarga cargaEnum))
                    {
                        auto.VelocidadMaxima = velocidadEnum;
                        auto.Carga = cargaEnum;
                    }
                    else
                    {
                        Console.WriteLine("Error al convertir el valor de algún enumerado");
                    }

                    lista.Add(auto);
                }

                this.lector.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al cargar datos de autos desde la base de datos: " + ex.Message);
            }
            finally
            {
                if (this.conexion.State == System.Data.ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }
        }
    }

}

